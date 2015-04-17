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
open ExchangeCommon

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

let public EXCHANGE_SERVICE_KEY="EXCHANGE"

let propertySet = 
    let result = PropertySet( BasePropertySet.FirstClassProperties )
    result.RequestedBodyType <- Nullable(BodyType.Text)
    result.AddRange( [| ContactSchema.EmailAddress1; ContactSchema.EmailAddress2; ContactSchema.EmailAddress3;
        ContactSchema.HomePhone;
        ContactSchema.MobilePhone;
        ContactSchema.BusinessPhone;
        ContactSchema.HomeAddressCountryOrRegion;
        ContactSchema.HomeAddressPostalCode;
        ContactSchema.HomeAddressState;
        ContactSchema.HomeAddressStreet;
        ContactSchema.OtherAddressCity;
        ContactSchema.OtherAddressPostalCode;
        ContactSchema.OtherAddressCountryOrRegion;
        ContactSchema.OtherAddressState;
        ContactSchema.OtherAddressStreet;
        ContactSchema.BusinessAddressCity;
        ContactSchema.BusinessAddressCountryOrRegion;
        ContactSchema.BusinessAddressState;
        ContactSchema.BusinessAddressStreet;
        ContactSchema.BusinessAddressPostalCode;
    |] )
    result

let getEmail( r : Contact, key : EmailAddressKey ) =     
    let mutable oldEmailAddress : EmailAddress = null
    if r.EmailAddresses.TryGetValue(key, &oldEmailAddress ) then
        oldEmailAddress.Address
    else
        null

let setEmail( r : Contact, emailAddress : string, key : EmailAddressKey ) =     
    let mutable oldEmailAddress : EmailAddress = null
    if r.EmailAddresses.TryGetValue(key, &oldEmailAddress ) then
        r.EmailAddresses.[key] <- null
    if not ( String.IsNullOrWhiteSpace(emailAddress) ) then
        r.EmailAddresses.[key] <- EmailAddress(emailAddress)

let getPhone( r : Contact, key : PhoneNumberKey ) =     
    let mutable oldNumber : string = null
    if r.PhoneNumbers.TryGetValue(key, &oldNumber ) then
        oldNumber
    else
        null

let setPhone( r : Contact, number : string, key : PhoneNumberKey ) =     
    let mutable oldNumber : string = null
    if r.PhoneNumbers.TryGetValue(key, &oldNumber ) then
        r.PhoneNumbers.[key] <- null
    if not ( String.IsNullOrWhiteSpace(number) ) then
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
        (* 
        r.DisplayName <- 
            ( if String.IsNullOrWhiteSpace(source.GivenName) then "" else source.GivenName + " " ) + ( if String.IsNullOrWhiteSpace(source.MiddleName) then "" else source.MiddleName + " " ) + source.Surname
        *)
        r.FileAs <-
            (( if String.IsNullOrWhiteSpace(source.Surname) then "" else source.Surname + " " ) + ( if String.IsNullOrWhiteSpace(source.GivenName) then "" else source.GivenName + " " ) + ( if String.IsNullOrWhiteSpace(source.MiddleName) then "" else source.MiddleName + " " )).TrimEnd(' ')
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

let getAddressPart(r : Contact, key : PhysicalAddressKey) =
    let mutable addressEntry : PhysicalAddressEntry = null
    if r.PhysicalAddresses.TryGetValue(key, &addressEntry) then
        Some(addressEntry)
    else 
        None

let copyContactToDTO( r : Contact, serviceAccountId : int, tag : int ) : ExchangeContactDTO =
    try
        let home = getAddressPart(r , PhysicalAddressKey.Home )
        let business = getAddressPart(r , PhysicalAddressKey.Business )
        let other = getAddressPart(r , PhysicalAddressKey.Other )
        { Id = 0; InternalId = Guid.NewGuid(); ExternalId = r.Id.ToString();     
        JobTitle = r.JobTitle; CompanyName = r.CompanyName; 
        EmailAddress1 = getEmail(r,EmailAddressKey.EmailAddress1); 
        LastModifiedTime = r.LastModifiedTime; EmailAddress2 =  getEmail(r,EmailAddressKey.EmailAddress2);
        EmailAddress3 = getEmail(r,EmailAddressKey.EmailAddress3); GivenName = r.GivenName; MiddleName = r.MiddleName; Surname = r.Surname;
#if ALIAS
        Alias = r.Alias; 
#endif
        NickName = r.NickName; HomePhone = getPhone( r,PhoneNumberKey.HomePhone); MobilePhone = getPhone( r,PhoneNumberKey.MobilePhone);
        BusinessPhone = getPhone( r,PhoneNumberKey.BusinessPhone); OtherTelephone = getPhone( r,PhoneNumberKey.OtherTelephone); 
        HomeAddressCity = ( if home.IsNone then null else home.Value.City);
        HomeAddressCountryOrRegion = ( if home.IsNone then null else home.Value.CountryOrRegion ); 
        HomeAddressPostalCode = ( if home.IsNone then null else home.Value.PostalCode ); 
        HomeAddressState = ( if home.IsNone then null else home.Value.State ); 
        HomeAddressStreet = ( if home.IsNone then null else home.Value.Street ); 
        BusinessAddressCity = ( if business.IsNone then null else business.Value.City);
        BusinessAddressCountryOrRegion = ( if business.IsNone then null else business.Value.CountryOrRegion ); 
        BusinessAddressPostalCode = ( if business.IsNone then null else business.Value.PostalCode ); 
        BusinessAddressState = ( if business.IsNone then null else business.Value.State ); 
        BusinessAddressStreet = ( if business.IsNone then null else business.Value.Street ); 
        OtherAddressCity = ( if other.IsNone then null else other.Value.City);
        OtherAddressCountryOrRegion = ( if other.IsNone then null else other.Value.CountryOrRegion ); 
        OtherAddressPostalCode = ( if other.IsNone then null else other.Value.PostalCode ); 
        OtherAddressState = ( if other.IsNone then null else other.Value.State ); 
        OtherAddressStreet = ( if other.IsNone then null else other.Value.Street ); 

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
            Folder.Bind(_service, WellKnownFolderName.Contacts)
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
                        saveDLUPIssues(Guid.NewGuid(), item.Id.ToString(), ex.ToString(), null ) 
                        reraise()
                        
                        
    logger.Debug( "download successfully finished" )

let deleteAll(login : Login) =
    let _service = connect(login)
    let folder = Folder.Bind(_service, WellKnownFolderName.Contacts)
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

let private createContact( item : ExchangeContactDTO, _service : ExchangeService, folder : FolderId ) : Contact =
    let app = new Contact(_service)
    copyDTOToContact( app, item )
    app

let upload( login : Login ) =
    logger.Debug( sprintf "upload started for %A" login.userName )
    prepareForUpload()
    let _service = connect(login)

    let syncTodayFolder = findFolderByName( _service, "SyncToday" ) 
    let folder = 
        if syncTodayFolder.IsSome then 
            syncTodayFolder.Value 
        else
            Folder.Bind(_service, WellKnownFolderName.Contacts)

    let itemsToUpload = ExchangeContactsToUpload(login.serviceAccountId)
    for item in itemsToUpload do
        logger.Debug( sprintf "uploading '%A'-'%A'" item.InternalId item.ExternalId )
        if String.IsNullOrWhiteSpace(item.ExternalId) then
            try 
                let app = createContact( item, _service, folder.Id )
                app.Save(folder.Id)
                logger.Debug( sprintf "'%A' saved" app.Id )
                changeExternalId( item, app.Id.ToString() )
                setExchangeContactAsUploaded(item)
            with 
                | ex -> 
                        saveDLUPIssues(item.InternalId, Guid.NewGuid().ToString(), null, ex.ToString() ) 
        else
            try 
                let possibleApp = Contact.Bind(_service, new ItemId(item.ExternalId))
                copyDTOToContact( possibleApp, item )
                possibleApp.Update(ConflictResolutionMode.AutoResolve)
                logger.Debug( sprintf "'%A' saved" possibleApp.Id )
                setExchangeContactAsUploaded(item)
            with 
                | ex -> 
                        saveDLUPIssues(item.InternalId, item.ExternalId, null, ex.ToString() ) 
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

let getLogin( loginJSON : string, serviceAccountId : int ) : Login = 
    if not (loginJSON.StartsWith( "{" )) then 
        let parsed = ExchangeLogin.Parse( "{" + loginJSON + "}" )
        { userName = parsed.LoginName;  password = parsed.Password; server = parsed.Server; email = parsed.LoginName; serviceAccountId  = serviceAccountId; impersonate = parsed.Impersonate }
    else
        let parsed = ExchangeLogin.Parse( loginJSON )
        { userName = parsed.LoginName;  password = parsed.Password; server = parsed.Server; email = parsed.LoginName; serviceAccountId  = serviceAccountId; impersonate = parsed.Impersonate }

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

