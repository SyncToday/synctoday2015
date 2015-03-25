module ExchangeEmailMessagesRepository

open System
open Microsoft.Exchange.WebServices.Data
open System.Configuration
open sync.today.Models
open Common
open ExchangeEmailMessagesSQL
open FSharp.Data
open MainDataConnection
open sync.today.cipher
open Schemas

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
let devlog = log4net.LogManager.GetLogger( "DevLog" )

let public EXCHANGE_SERVICE_KEY="EXCHANGE"

[<CLIMutable>]
type Login =
    {   
        userName : string
        password : string
        server : string
        email : string
        serviceAccountId : int
    }

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

let propertySet = 
    let result = PropertySet( BasePropertySet.FirstClassProperties )
    result.RequestedBodyType <- Nullable(BodyType.Text)
    result.AddRange( [| EmailMessageSchema.Subject; EmailMessageSchema.Body; EmailMessageSchema.BccRecipients;
        EmailMessageSchema.CcRecipients;
        EmailMessageSchema.From;
        EmailMessageSchema.InternetMessageId;
        EmailMessageSchema.ReceivedBy;
        EmailMessageSchema.ReceivedRepresenting;
        EmailMessageSchema.References;
        EmailMessageSchema.ReplyTo;
        EmailMessageSchema.Sender;
        EmailMessageSchema.ToRecipients;
    |] )
    result

let timezone( debugLog : bool ) =
    let _TIMEZONEInSettings = ConfigurationManager.AppSettings.["ExchangeTimeZone"]
    if debugLog then logger.Debug( sprintf "_TIMEZONEInSettings '%A'" _TIMEZONEInSettings )
    let _TIMEZONE = ( if String.IsNullOrWhiteSpace( _TIMEZONEInSettings ) then TimeZone.CurrentTimeZone.StandardName else _TIMEZONEInSettings )
    if debugLog then logger.Debug( sprintf "_TIMEZONE '%A'" _TIMEZONE )
    TimeZoneInfo.FindSystemTimeZoneById(_TIMEZONE)

let connect( login : Login ) =
    logger.Debug( sprintf "Login started for '%A' on %A with trace %A" login.userName login.server exchangeTrace)

    System.Net.ServicePointManager.ServerCertificateValidationCallback <- 
        (fun _ _ _ _ -> true)

    let _service = new ExchangeService(exchangeVersion, timezone(true))
    _service.EnableScpLookup <- true    
    let decryptedPassword = StringCipher.Decrypt(login.password, login.userName)
//#if LOG_DECRYPTED_PASSWORD
    logger.Debug( sprintf "Password '%A'" decryptedPassword )
//#endif
    _service.Credentials <- new WebCredentials(login.userName, decryptedPassword) 
    _service.TraceEnabled <- true //exchangeTrace
    _service.TraceFlags <- TraceFlags.All
    if String.IsNullOrWhiteSpace(login.server) then
        logger.Debug( sprintf "Trying auto discover for '%A'" login.email )
        _service.AutodiscoverUrl(login.email, (fun _ -> true) )
    else
        _service.Url <- new Uri(login.server)
    logger.Debug( "Login successfully finished" )
    _service

#if copyDTOToEmailMessage
let copyDTOToEmailMessage( r : EmailMessage, source : ExchangeEmailMessageDTO )  =
        

        // Categories
        let oldCategories = json(r.Categories)
        devlog.Debug( sprintf "oldCategories:'%A' source.CategoriesJSON:''%A " oldCategories source.CategoriesJSON )
        if oldCategories <> source.CategoriesJSON then 
            let categories = if String.IsNullOrWhiteSpace(source.CategoriesJSON) then [| |] else unjson<string array>( source.CategoriesJSON )
            let categoriesNotEmpty = Array.FindAll(categories, ( fun p -> not(String.IsNullOrWhiteSpace(p) ) ) )
            r.Categories.Clear()
            devlog.Debug( sprintf "categoriesNotEmpty:'%A'" categoriesNotEmpty )
            r.Categories.AddRange( categoriesNotEmpty )
#endif


let copyEmailMessageToDTO( r : EmailMessage, serviceAccountId : int, tag : int ) : ExchangeEmailMessageDTO =
    try
        { Id = 0; InternalId = Guid.NewGuid(); ExternalId = r.Id.ToString(); LastModifiedTime = r.LastModifiedTime;     
            Subject = r.Subject; Body = r.Body.Text; 
    
            BccRecipientsJSON = json(r.BccRecipients); 
            CcRecipientsJSON = json(r.CcRecipients);
            From = r.From.Address; InternetMessageId = r.InternetMessageId; 
            ReceivedByJSON = json(r.ReceivedBy); ReceivedRepresentingJSON = json(r.ReceivedRepresenting);
            References = r.References; ReplyToJSON = json(r.ReplyTo); SenderJSON = json(r.Sender); ToRecipientsJSON = json(r.ToRecipients);

            CategoriesJSON = json(r.Categories); ServiceAccountId = serviceAccountId; 
            Tag = tag }
    with
        | ex -> raise (System.ArgumentException("copyEmailMessageToDTO failed", ex)) 

let save( app : EmailMessage, serviceAccountId : int, downloadRound : int ) =
    saveExchangeEmailMessage(copyEmailMessageToDTO(app, serviceAccountId, -1), false, downloadRound)

let insertOrUpdate( app : ExchangeEmailMessageDTO ) =
    let downloadRound = int DateTime.Now.Ticks
    saveExchangeEmailMessage(app, true, downloadRound)


let changeExternalId( app : ExchangeEmailMessageDTO, externalId : string ) =
    changeExchangeEmailMessageExternalId(app, externalId)

let findFolderByName( _service : ExchangeService, name : string ) : Folder option = 
    let folderView = new FolderView(10)
    folderView.PropertySet <- PropertySet(BasePropertySet.IdOnly)
    folderView.PropertySet.Add(FolderSchema.DisplayName)
    let nameSearchFilter = new SearchFilter.ContainsSubstring( FolderSchema.DisplayName, name )
    folderView.Traversal <- FolderTraversal.Deep
    let findFolderResults = _service.FindFolders(WellKnownFolderName.Root, nameSearchFilter, folderView)
    for findFolderResult in findFolderResults do
        logger.Debug( sprintf "found folder %A (%A)" findFolderResult.DisplayName findFolderResult.Id )
    let found = Seq.tryHead findFolderResults
    found


let download( date : DateTime, login : Login ) =
    logger.Debug( sprintf "download started for '%A' from '%A'" login.userName date )
    prepareForDownload(login.serviceAccountId)
    let greaterthanfilter = new SearchFilter.IsGreaterThanOrEqualTo(ItemSchema.LastModifiedTime, date)
    let filter = new SearchFilter.SearchFilterCollection(LogicalOperator.And, greaterthanfilter)
    let _service = connect(login)

    let syncTodayFolder = findFolderByName( _service, "SyncToday" ) 
    let folder = 
        if syncTodayFolder.IsSome then 
            syncTodayFolder.Value 
        else
            Folder.Bind(_service, WellKnownFolderName.Inbox)
    let view = new ItemView(1000)
    view.Offset <- 0
    let mutable search = true
    let downloadRound = int DateTime.Now.Ticks
    while search do
        let found = folder.FindItems(filter, view)
        search <- found.Items.Count = view.PageSize
        view.Offset <- view.Offset + view.PageSize
        logger.DebugFormat( "got {0} items", found.Items.Count )
        for item in found do
            if ( item :? EmailMessage ) then
                try
                    let app = item :?> EmailMessage
                    //logger.Debug( sprintf "processing '%A' " app.Id )
                    app.Load( propertySet )
                    if ( app.LastModifiedTime > date ) then
                        save(app, login.serviceAccountId, downloadRound ) |> ignore
                with
                    | ex ->
                        saveDLUPIssues(Guid.NewGuid(), item.Id.ToString(), ex.ToString(), null ) 
                        reraise()
                        
                        
    logger.Debug( "download successfully finished" )

let deleteAll(login : Login) =
    let _service = connect(login)
    let folder = Folder.Bind(_service, WellKnownFolderName.Inbox)
    let view = new ItemView(1000)
    view.Offset <- 0
    let mutable search = true
    while search do
        let found = folder.FindItems(view)
        search <- found.Items.Count = view.PageSize
        view.Offset <- view.Offset + view.PageSize
        logger.DebugFormat( "got {0} items", found.Items.Count )
        for item in found do
            if ( item :? EmailMessage ) then
                let app = item :?> EmailMessage
                app.Delete( DeleteMode.HardDelete )

let Updated() =
    getUpdatedExchangeEmailMessages()

let New() =
    getNewExchangeEmailMessages()

type ExchangeLogin = JsonProvider<"""{ "loginName" : "John", "password" : "UASJXMLXL", "server" : "jidasjidjasi.dasjdasij.com"  }""">

#if AdapterEmailMessageDTO
let ConvertToDTO( r : ExchangeEmailMessageDTO, adapterId ) : AdapterEmailMessageDTO =
   { Id = 0; InternalId = r.InternalId; LastModified = r.LastModifiedTime; Category = findCategory( r.CategoriesJSON ); Location = r.Location; Content = r.Body; Title = r.Subject; 
   DateFrom = r.Start; DateTo = r.End; Notification = r.IsReminderSet; IsPrivate = r.Sensitivity <> byte 0; Priority = byte 0; 
   EmailMessageId = 0; AdapterId = adapterId; Tag = r.Tag; ReminderMinutesBeforeStart=r.ReminderMinutesBeforeStart }

let getEmpty(old : ExchangeEmailMessageDTO option): ExchangeEmailMessageDTO =
    if ( old.IsSome ) then
        old.Value
    else 
        { Id = 0; InternalId = Guid.Empty; ExternalId = ""; Body = ""; Start = DateTime.Now;
            End = DateTime.Now; LastModifiedTime = DateTime.Now; Location = "";
            IsReminderSet = true; 
            EmailMessageState = byte 0; Subject = ""; RequiredAttendeesJSON = "";
            ReminderMinutesBeforeStart = 15; 
            Sensitivity = byte 0; RecurrenceJSON = ""; 
            ModifiedOccurrencesJSON = "";
            LastOccurrenceJSON = ""; IsRecurring = false; 
            IsCancelled = false; ICalRecurrenceId = ""; 
            FirstOccurrenceJSON = ""; 
            DeletedOccurrencesJSON = ""; EmailMessageType = byte 0; 
            Duration = 0; StartTimeZone = ""; 
            EndTimeZone = ""; AllowNewTimeProposal = false; 
            CategoriesJSON = ""; ServiceAccountId = 0; 
            Tag = 0 }
        

let ConvertFromDTO( r : AdapterEmailMessageDTO, serviceAccountId, original : ExchangeEmailMessageDTO ) : ExchangeEmailMessageDTO =
    { Id = original.Id; InternalId = r.InternalId; ExternalId = original.ExternalId; Body = r.Content; Start = r.DateFrom; 
    End = r.DateTo; LastModifiedTime = r.LastModified; Location = r.Location;
        IsReminderSet = r.Notification; 
        EmailMessageState = original.EmailMessageState; Subject = r.Title; RequiredAttendeesJSON = original.RequiredAttendeesJSON;
        ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; 
        Sensitivity = original.Sensitivity; RecurrenceJSON = original.RecurrenceJSON; 
        ModifiedOccurrencesJSON = original.ModifiedOccurrencesJSON;
        LastOccurrenceJSON = original.LastOccurrenceJSON; IsRecurring = original.IsRecurring; 
        IsCancelled = original.IsCancelled; ICalRecurrenceId = original.ICalRecurrenceId; 
        FirstOccurrenceJSON = original.FirstOccurrenceJSON; 
        DeletedOccurrencesJSON = original.DeletedOccurrencesJSON; EmailMessageType = original.EmailMessageType; 
        Duration = int (r.DateTo.Subtract( r.DateTo ).TotalMinutes ); StartTimeZone = original.StartTimeZone; 
        EndTimeZone = original.EndTimeZone; AllowNewTimeProposal = original.AllowNewTimeProposal; 
        CategoriesJSON = EmailMessageLevelRepository.replaceCategoryInJSON( original.CategoriesJSON, r.Category ); 
        ServiceAccountId = serviceAccountId; 
        Tag = r.Tag }
#endif

let private getLogin( loginJSON : string, serviceAccountId : int ) : Login = 
    if not (loginJSON.StartsWith( "{" )) then 
        let parsed = ExchangeLogin.Parse( "{" + loginJSON + "}" )
        { userName = parsed.LoginName;  password = parsed.Password; server = parsed.Server; email = parsed.LoginName; serviceAccountId  = serviceAccountId }
    else
        let parsed = ExchangeLogin.Parse( loginJSON )
        { userName = parsed.LoginName;  password = parsed.Password; server = parsed.Server; email = parsed.LoginName; serviceAccountId  = serviceAccountId }

let DownloadForServiceAccount( serviceAccount : ServiceAccountDTO ) =
    download( getLastSuccessfulDate2( serviceAccount.LastSuccessfulDownload ), getLogin(serviceAccount.LoginJSON, serviceAccount.Id ) )

let Download( serviceAccount : ServiceAccountDTO ) =
    ServiceAccountRepository.Download( serviceAccount, DownloadForServiceAccount )

#if ChangeInternalIdBecauseOfDuplicity
let ChangeInternalIdBecauseOfDuplicity( exchangeEmailMessage : ExchangeEmailMessageDTO, foundDuplicity : AdapterEmailMessageDTO ) =
    changeInternalIdBecauseOfDuplicity( exchangeEmailMessage , foundDuplicity )
#endif

let ChangeInternalIdBecauseOfDuplicitySimple( internalId : Guid, exchangeEmailMessageId : int ) =
    changeInternalIdBecauseOfDuplicitySimple( internalId , exchangeEmailMessageId )

let ExchangeEmailMessageInternalIds() =
    exchangeEmailMessageInternalIds()

let ExchangeEmailMessageByInternalId( internalId : Guid ) =
    exchangeEmailMessageByInternalId( internalId )

