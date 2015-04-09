module ExchangeCommon

open Microsoft.Exchange.WebServices.Data
open sync.today.cipher
open System.Configuration
open System
open FSharp.Data

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

type ExchangeLogin = JsonProvider<"""{ "loginName" : "John", "password" : "UASJXMLXL", "server" : "jidasjidjasi.dasjdasij.com", "impersonate" : "true"   }""">

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
    }

let connect( login : Login ) =
    logger.Debug( sprintf "Login started for '%A' on %A with trace %A" login.userName login.server exchangeTrace)

    System.Net.ServicePointManager.ServerCertificateValidationCallback <- 
        (fun _ _ _ _ -> true)

    let _service = new ExchangeService(exchangeVersion, timezone(true))
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
