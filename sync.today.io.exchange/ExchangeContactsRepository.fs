module ExchangeContactsRepository

open System
open Microsoft.Exchange.WebServices.Data
open System.Configuration
open sync.today.Models
open Common
open ExchangeContactsSQL
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
    if exchangeVersion <> ExchangeVersion.Exchange2007_SP1 then
        let result = PropertySet( Array.append Properties [|  |] )
        result.RequestedBodyType <- Nullable(BodyType.Text)
        result
    else
        let result = PropertySet( Properties )
        result.RequestedBodyType <- Nullable(BodyType.Text)
        result

let timezone( debugLog : bool ) =
    let _TIMEZONEInSettings = ConfigurationManager.AppSettings.["ExchangeTimeZone"]
    if debugLog then logger.Debug( sprintf "_TIMEZONEInSettings '%A'" _TIMEZONEInSettings )
    let _TIMEZONE = ( if String.IsNullOrWhiteSpace( _TIMEZONEInSettings ) then TimeZone.CurrentTimeZone.StandardName else _TIMEZONEInSettings )
    if debugLog then logger.Debug( sprintf "_TIMEZONE '%A'" _TIMEZONE )
    TimeZoneInfo.FindSystemTimeZoneById(_TIMEZONE)

let connect( login : Login ) =
    logger.Debug( sprintf "Login started for '%A'" login.userName )

    System.Net.ServicePointManager.ServerCertificateValidationCallback <- 
        (fun _ _ _ _ -> true)

    let _service = new ExchangeService(exchangeVersion, timezone(true))
    _service.EnableScpLookup <- true    
    let decryptedPassword = StringCipher.Decrypt(login.password, login.userName)
#if LOG_DECRYPTED_PASSWORD
    logger.Debug( sprintf "Password '%A'" decryptedPassword )
#endif
    _service.Credentials <- new WebCredentials(login.userName, decryptedPassword) 
    _service.TraceEnabled <- exchangeTrace
    _service.TraceFlags <- TraceFlags.All
    if String.IsNullOrWhiteSpace(login.server) then
        logger.Debug( sprintf "Trying auto discover for '%A'" login.email )
        _service.AutodiscoverUrl(login.email, (fun _ -> true) )
    else
        _service.Url <- new Uri(login.server)
    logger.Debug( "Login successfully finished" )
    _service

let setEmail( r : Contact, emailAddress : string, key : EmailAddressKey ) =     
    let mutable oldEmailAddress : EmailAddress = null
    if r.EmailAddresses.TryGetValue(key, &oldEmailAddress ) then
        r.EmailAddresses.[key] <- null
    if not ( String.IsNullOrWhiteSpace(emailAddress) ) && r.EmailAddresses.Contains( key) then
        r.EmailAddresses.[key] <- EmailAddress(emailAddress)

let setPhone( r : Contact, number : string, key : PhoneNumberKey ) =     
    let mutable oldNumber : string = null
    if r.PhoneNumbers.TryGetValue(key, &oldNumber ) then
        r.PhoneNumbers.[key] <- null
    if not ( String.IsNullOrWhiteSpace(number) ) && r.PhoneNumbers.Contains( key) then
        r.PhoneNumbers.[key] <- number


let copyDTOToContact( r : Contact, source : ExchangeContactDTO )  =
        r.JobTitle <- source.JobTitle
        r.CompanyName <- source.CompanyName
        setEmail( r, source.EmailAddress1, EmailAddressKey.EmailAddress1 )
        setEmail( r, source.EmailAddress2, EmailAddressKey.EmailAddress2 )
        setEmail( r, source.EmailAddress3, EmailAddressKey.EmailAddress3 )
        r.GivenName <- source.GivenName 
        r.MiddleName <- source.MiddleName 
        r.Surname <- source.Surname
        //r.Alias <- source.Alias 
        r.NickName <- source.NickName 
        setPhone( r, source.HomePhone,  PhoneNumberKey.HomePhone )
        setPhone( r, source.MobilePhone,  PhoneNumberKey.MobilePhone )
        setPhone( r, source.BusinessPhone,  PhoneNumberKey.BusinessPhone )
        r.PhysicalAddresses.[PhysicalAddressKey.Business] <- PhysicalAddressEntry()
        r.PhysicalAddresses.[PhysicalAddressKey.Business].City <- source.BusinessAddressCity 
        r.PhysicalAddresses.[PhysicalAddressKey.Business].Street <- source.BusinessAddressStreet 
        r.PhysicalAddresses.[PhysicalAddressKey.Business].PostalCode <- source.BusinessAddressPostalCode 

        // Categories
        let oldCategories = json(r.Categories)
        devlog.Debug( sprintf "oldCategories:'%A' source.CategoriesJSON:''%A " oldCategories source.CategoriesJSON )
        if oldCategories <> source.CategoriesJSON then 
            let categories = if String.IsNullOrWhiteSpace(source.CategoriesJSON) then [| |] else unjson<string array>( source.CategoriesJSON )
            let categoriesNotEmpty = Array.FindAll(categories, ( fun p -> not(String.IsNullOrWhiteSpace(p) ) ) )
            r.Categories.Clear()
            devlog.Debug( sprintf "categoriesNotEmpty:'%A'" categoriesNotEmpty )
            r.Categories.AddRange( categoriesNotEmpty )

let copyContactToDTO( r : Contact, serviceAccountId : int, tag : int ) : ExchangeContactDTO =
    try
        { Id = 0; InternalId = Guid.NewGuid(); ExternalId = r.Id.ToString();     
        JobTitle = r.JobTitle; CompanyName = r.CompanyName; EmailAddress1 = r.EmailAddresses.[EmailAddressKey.EmailAddress1].Address; 
        LastModifiedTime = r.LastModifiedTime; EmailAddress2 = r.EmailAddresses.[EmailAddressKey.EmailAddress2].Address;
        EmailAddress3 = r.EmailAddresses.[EmailAddressKey.EmailAddress3].Address; GivenName = r.GivenName; MiddleName = r.MiddleName; Surname = r.Surname;
        Alias = r.Alias; NickName = r.NickName; HomePhone = r.PhoneNumbers.[PhoneNumberKey.HomePhone]; MobilePhone = r.PhoneNumbers.[PhoneNumberKey.MobilePhone];
        BusinessPhone = r.PhoneNumbers.[PhoneNumberKey.BusinessPhone]; OtherTelephone = r.PhoneNumbers.[PhoneNumberKey.OtherTelephone]; 
        HomeAddressCity = r.PhysicalAddresses.[PhysicalAddressKey.Home].City; 
        HomeAddressCountryOrRegion = r.PhysicalAddresses.[PhysicalAddressKey.Home].CountryOrRegion; 
        HomeAddressPostalCode = r.PhysicalAddresses.[PhysicalAddressKey.Home].PostalCode; 
        HomeAddressState = r.PhysicalAddresses.[PhysicalAddressKey.Home].State; 
        HomeAddressStreet = r.PhysicalAddresses.[PhysicalAddressKey.Home].Street; 
        BusinessAddressCity = r.PhysicalAddresses.[PhysicalAddressKey.Business].City; 
        BusinessAddressCountryOrRegion = r.PhysicalAddresses.[PhysicalAddressKey.Business].CountryOrRegion; 
        BusinessAddressPostalCode = r.PhysicalAddresses.[PhysicalAddressKey.Business].PostalCode; 
        BusinessAddressState = r.PhysicalAddresses.[PhysicalAddressKey.Business].State; 
        BusinessAddressStreet = r.PhysicalAddresses.[PhysicalAddressKey.Business].Street; 
        OtherAddressCity = r.PhysicalAddresses.[PhysicalAddressKey.Other].City; 
        OtherAddressCountryOrRegion = r.PhysicalAddresses.[PhysicalAddressKey.Other].CountryOrRegion; 
        OtherAddressPostalCode = r.PhysicalAddresses.[PhysicalAddressKey.Other].PostalCode; 
        OtherAddressState = r.PhysicalAddresses.[PhysicalAddressKey.Other].State; 
        OtherAddressStreet = r.PhysicalAddresses.[PhysicalAddressKey.Other].Street; 

        CategoriesJSON = json(r.Categories); 
        ServiceAccountId = serviceAccountId; 
        Tag = tag }
    with
        | ex -> raise (System.ArgumentException("copyContactToDTO failed", ex)) 

let save( app : Contact, serviceAccountId : int, downloadRound : int ) =
    saveExchangeContact(copyContactToDTO(app, serviceAccountId, -1), false, downloadRound)

let insertOrUpdate( app : ExchangeContactDTO ) =
    let downloadRound = int DateTime.Now.Ticks
    saveExchangeContact(app, true, downloadRound)


let changeExternalId( app : ExchangeContactDTO, externalId : string ) =
    changeExchangeContactExternalId(app, externalId)

let download( date : DateTime, login : Login ) =
    logger.Debug( sprintf "download started for '%A' from '%A'" login.userName date )
    prepareForDownload(login.serviceAccountId)
    let greaterthanfilter = new SearchFilter.IsGreaterThanOrEqualTo(ItemSchema.LastModifiedTime, date)
    let filter = new SearchFilter.SearchFilterCollection(LogicalOperator.And, greaterthanfilter)
    let _service = connect(login)
    let folder = Folder.Bind(_service, WellKnownFolderName.Calendar)
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
            if ( item :? Contact ) then
                try
                    let app = item :?> Contact
                    //logger.Debug( sprintf "processing '%A' " app.Id )
                    app.Load( propertySet )
                    if ( app.LastModifiedTime > date ) then
                        save(app, login.serviceAccountId, downloadRound ) |> ignore
                with
                    | ex ->
                        saveDLUPIssues(item.Id.ToString(), ex.ToString(), null ) 
                        reraise()
                        
                        
    logger.Debug( "download successfully finished" )

let deleteAll(login : Login) =
    let _service = connect(login)
    let folder = Folder.Bind(_service, WellKnownFolderName.Calendar)
    let view = new ItemView(1000)
    view.Offset <- 0
    let mutable search = true
    while search do
        let found = folder.FindItems(view)
        search <- found.Items.Count = view.PageSize
        view.Offset <- view.Offset + view.PageSize
        logger.DebugFormat( "got {0} items", found.Items.Count )
        for item in found do
            if ( item :? Contact ) then
                let app = item :?> Contact
                app.Delete( DeleteMode.HardDelete )

let private createContact( item : ExchangeContactDTO, _service : ExchangeService ) : Contact =
    let app = new Contact(_service)
    copyDTOToContact( app, item )
    app

let upload( login : Login ) =
    logger.Debug( "upload started" )
    prepareForUpload()
    let _service = connect(login)
    let itemsToUpload = ExchangeContactsToUpload(login.serviceAccountId)
    for item in itemsToUpload do
        logger.Debug( sprintf "uploading '%A'-'%A'" item.InternalId item.ExternalId )
        if String.IsNullOrWhiteSpace(item.ExternalId) then
            let app = createContact( item, _service )
            app.Save()
            logger.Debug( sprintf "'%A' saved" app.Id )
            changeExternalId( item, app.Id.ToString() )
            setExchangeContactAsUploaded(item)
        else
            try 
                let possibleApp = Contact.Bind(_service, new ItemId(item.ExternalId))
                copyDTOToContact( possibleApp, item )
                possibleApp.Update(ConflictResolutionMode.AutoResolve)
                logger.Debug( sprintf "'%A' saved" possibleApp.Id )
                setExchangeContactAsUploaded(item)
            with 
                | ex -> 
                        saveDLUPIssues(item.ExternalId, null, ex.ToString() ) 
                        //reraise()
                        (* 
                        try 
                            logger.Debug( sprintf "Save '%A' failed '%A'" item ex )
                            if  ex.Message <> "Set action is invalid for property" then
                                let app = createContact( item, _service )
                                app.Save(SendInvitationsMode.SendToNone)
                                changeExternalId( item, app.Id.ToString() )
                        with
                            | ex ->
                                saveDLUPIssues(item.ExternalId, null, ex.ToString() ) 
                                reraise()
                        *)

let Updated() =
    getUpdatedExchangeContacts()

let New() =
    getNewExchangeContacts()

type ExchangeLogin = JsonProvider<"""{ "loginName" : "John", "password" : "UASJXMLXL", "server" : "jidasjidjasi.dasjdasij.com"  }""">

#if AdapterContactDTO
let ConvertToDTO( r : ExchangeContactDTO, adapterId ) : AdapterContactDTO =
   { Id = 0; InternalId = r.InternalId; LastModified = r.LastModifiedTime; Category = findCategory( r.CategoriesJSON ); Location = r.Location; Content = r.Body; Title = r.Subject; 
   DateFrom = r.Start; DateTo = r.End; Notification = r.IsReminderSet; IsPrivate = r.Sensitivity <> byte 0; Priority = byte 0; 
   ContactId = 0; AdapterId = adapterId; Tag = r.Tag; ReminderMinutesBeforeStart=r.ReminderMinutesBeforeStart }

let getEmpty(old : ExchangeContactDTO option): ExchangeContactDTO =
    if ( old.IsSome ) then
        old.Value
    else 
        { Id = 0; InternalId = Guid.Empty; ExternalId = ""; Body = ""; Start = DateTime.Now;
            End = DateTime.Now; LastModifiedTime = DateTime.Now; Location = "";
            IsReminderSet = true; 
            ContactState = byte 0; Subject = ""; RequiredAttendeesJSON = "";
            ReminderMinutesBeforeStart = 15; 
            Sensitivity = byte 0; RecurrenceJSON = ""; 
            ModifiedOccurrencesJSON = "";
            LastOccurrenceJSON = ""; IsRecurring = false; 
            IsCancelled = false; ICalRecurrenceId = ""; 
            FirstOccurrenceJSON = ""; 
            DeletedOccurrencesJSON = ""; ContactType = byte 0; 
            Duration = 0; StartTimeZone = ""; 
            EndTimeZone = ""; AllowNewTimeProposal = false; 
            CategoriesJSON = ""; ServiceAccountId = 0; 
            Tag = 0 }
        

let ConvertFromDTO( r : AdapterContactDTO, serviceAccountId, original : ExchangeContactDTO ) : ExchangeContactDTO =
    { Id = original.Id; InternalId = r.InternalId; ExternalId = original.ExternalId; Body = r.Content; Start = r.DateFrom; 
    End = r.DateTo; LastModifiedTime = r.LastModified; Location = r.Location;
        IsReminderSet = r.Notification; 
        ContactState = original.ContactState; Subject = r.Title; RequiredAttendeesJSON = original.RequiredAttendeesJSON;
        ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; 
        Sensitivity = original.Sensitivity; RecurrenceJSON = original.RecurrenceJSON; 
        ModifiedOccurrencesJSON = original.ModifiedOccurrencesJSON;
        LastOccurrenceJSON = original.LastOccurrenceJSON; IsRecurring = original.IsRecurring; 
        IsCancelled = original.IsCancelled; ICalRecurrenceId = original.ICalRecurrenceId; 
        FirstOccurrenceJSON = original.FirstOccurrenceJSON; 
        DeletedOccurrencesJSON = original.DeletedOccurrencesJSON; ContactType = original.ContactType; 
        Duration = int (r.DateTo.Subtract( r.DateTo ).TotalMinutes ); StartTimeZone = original.StartTimeZone; 
        EndTimeZone = original.EndTimeZone; AllowNewTimeProposal = original.AllowNewTimeProposal; 
        CategoriesJSON = ContactLevelRepository.replaceCategoryInJSON( original.CategoriesJSON, r.Category ); 
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
let ChangeInternalIdBecauseOfDuplicity( exchangeContact : ExchangeContactDTO, foundDuplicity : AdapterContactDTO ) =
    changeInternalIdBecauseOfDuplicity( exchangeContact , foundDuplicity )
#endif

let ChangeInternalIdBecauseOfDuplicitySimple( internalId : Guid, exchangeContactId : int ) =
    changeInternalIdBecauseOfDuplicitySimple( internalId , exchangeContactId )

let ExchangeContactInternalIds() =
    exchangeContactInternalIds()

let ExchangeContactByInternalId( internalId : Guid ) =
    exchangeContactByInternalId( internalId )

let UploadForServiceAccount( serviceAccount : ServiceAccountDTO ) =
    upload( getLogin(serviceAccount.LoginJSON, serviceAccount.Id ) )

let Upload( serviceAccount : ServiceAccountDTO ) =
    ServiceAccountRepository.Upload( serviceAccount, UploadForServiceAccount )

