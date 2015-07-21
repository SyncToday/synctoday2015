module ExchangeCommon

open Microsoft.Exchange.WebServices.Data
open sync.today.cipher
open System.Configuration
open System
open FSharp.Data
open Microsoft.FSharp.Data.TypeProviders
open Common
open sync.today.Models
open MainDataConnection

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

type internal SqlConnection = SqlDataConnection<ConnectionStringName="sync-today-mssql">
let internal db() = SqlConnection.GetDataContext()
let internal cnn() = db().DataContext

type ExchangeJsonLogin = JsonProvider<"""{ "loginName" : "John", "password" : "UASJXMLXL", "server" : "jidasjidjasi.dasjdasij.com", "impersonate" : "true", "email" : "john.doe@hotmail.com" , "folder" : "SyncToday" }""">
 
let ExchangeVersionInSettings = ConfigurationManager.AppSettings.["ExchangeVersion"]
let exchangeVersion = 
    match ExchangeVersionInSettings with
        | "Exchange2007" -> ExchangeVersion.Exchange2007_SP1
        | "Exchange2010_SP2" -> ExchangeVersion.Exchange2010_SP2
        | "Exchange2013" -> ExchangeVersion.Exchange2013
        | _ -> ExchangeVersion.Exchange2013

let ExchangeTraceInSettings = ConfigurationManager.AppSettings.["ExchangeTrace"]
let exchangeTrace = 
    match ExchangeTraceInSettings with
        | "true" -> true
        | "false" -> false
        | _ -> false

let ExchangeUseTimeZoneInSettings = ConfigurationManager.AppSettings.["ExchangeUseTimeZone"]
let exchangeUseTimeZone = 
    match ExchangeUseTimeZoneInSettings with
        | "true" -> true
        | "false" -> false
        | _ -> false

let timezone( debugLog : bool ) =
    let _TIMEZONEInSettings = ConfigurationManager.AppSettings.["ExchangeTimeZone"]
    if debugLog then logger.Debug( sprintf "_TIMEZONEInSettings '%A'" _TIMEZONEInSettings )
    let _TIMEZONE = ( if String.IsNullOrWhiteSpace( _TIMEZONEInSettings ) then TimeZone.CurrentTimeZone.StandardName else _TIMEZONEInSettings )
    if debugLog then logger.Debug( sprintf "_TIMEZONE '%A'" _TIMEZONE )
    TimeZoneInfo.FindSystemTimeZoneById(_TIMEZONE)

[<CLIMutable>]
type Login =
    {   
        userName : string
        password : string
        server : string
        email : string
        serviceAccountId : int
        impersonate : bool
        folder : string option
        maintenance : bool
    }

let getLogin loginJSON  serviceAccountId maintenance = 
    let parsed = 
        if not ( (loginJSON : string ).StartsWith( "{" )) then 
            ExchangeJsonLogin.Parse( "{" + loginJSON + "}" )
        else
            ExchangeJsonLogin.Parse( loginJSON )
    let result : Login = 
        { userName = parsed.LoginName;  password = parsed.Password; server = parsed.Server; email = parsed.Email; serviceAccountId  = serviceAccountId; impersonate = parsed.Impersonate; folder = string2optionString parsed.Folder; maintenance = maintenance }
    result

let connect( login : Login ) =
    logger.Debug( sprintf "Login started for '%A' on %A with trace %A" login.userName login.server exchangeTrace)

    System.Net.ServicePointManager.ServerCertificateValidationCallback <- 
        (fun _ _ _ _ -> true)

    let _service = 
        if exchangeUseTimeZone then new ExchangeService(exchangeVersion, timezone(true)) else new ExchangeService(exchangeVersion)

    _service.EnableScpLookup <- true    
    let decryptedPassword = StringCipher.Decrypt(login.password, login.userName)
#if LOG_DECRYPTED_PASSWORD
    logger.Debug( sprintf "Password '%A'" decryptedPassword )
#endif
    _service.Credentials <- new WebCredentials(login.userName, decryptedPassword) 
    _service.TraceEnabled <- true //exchangeTrace
    _service.TraceFlags <- TraceFlags.All
    if String.IsNullOrWhiteSpace(login.server) then
        logger.Debug( sprintf "Trying auto discover for '%A'" login.email )
        _service.AutodiscoverUrl(login.email, (fun _ -> true) )
    else
        _service.Url <- new Uri(login.server)

    if login.impersonate && not( String.IsNullOrWhiteSpace( login.email ) ) && login.email <> login.userName then
        logger.Debug( sprintf "Impersonating for '%A'" login.email )
        _service.ImpersonatedUserId <- new ImpersonatedUserId(ConnectingIdType.SmtpAddress, login.email)    

    logger.Debug( "Login successfully finished" )
    _service

let ExchangeForceTreatAsDiffInSettings = ConfigurationManager.AppSettings.["ExchangeForceTreatAsDiff"]
let exchangeForceTreatAsDiff = 
    match ExchangeForceTreatAsDiffInSettings with
        | "true" -> true
        | "false" -> false
        | _ -> false

let findFolderByName( _service : ExchangeService, name : string option, login : Login, wellKnownFolderName ) : Folder option =         
    let folder = 
        if not (login.impersonate) && not( String.IsNullOrWhiteSpace( login.email ) ) && login.email <> login.userName then
            devlog.Debug( sprintf "Impersonating for %A" login.email)
            Folder.Bind(_service, new FolderId(wellKnownFolderName, new Mailbox(login.email)))
        else
            devlog.Debug( sprintf "Opening %A" wellKnownFolderName)
            Folder.Bind(_service, wellKnownFolderName)

    if name.IsSome then
        let folderView = new FolderView(10)
        folderView.PropertySet <- PropertySet(BasePropertySet.IdOnly)
        folderView.PropertySet.Add(FolderSchema.DisplayName)
        let nameSearchFilter = new SearchFilter.ContainsSubstring( FolderSchema.DisplayName, name.Value )
        folderView.Traversal <- FolderTraversal.Deep   
        let findFolderResults = _service.FindFolders(folder.Id, nameSearchFilter, folderView)    
        for findFolderResult in findFolderResults do
            logger.Debug( sprintf "found folder %A (%A)" findFolderResult.DisplayName findFolderResult.Id )
        let found = Seq.tryHead findFolderResults
        found
    else
        Some(folder)


let uploadForServiceAccount upload serviceAccount  =
    let lastSuccessUpload = getLastSuccessfulDate2 ( serviceAccount : ServiceAccountDTO ).LastSuccessfulUpload
    let maintenance = ( DateTime.Now.Date - lastSuccessUpload.Date ) > TimeSpan.FromHours( float 1 )
    upload( getLogin serviceAccount.LoginJSON serviceAccount.Id maintenance ) |> ignore
