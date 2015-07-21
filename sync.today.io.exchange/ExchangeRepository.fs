module ExchangeRepository

open System
open Microsoft.Exchange.WebServices.Data
open System.Configuration
open sync.today.Models
open Common
open ExchangeAppointmentsSQL
open FSharp.Data
open AppointmentLevelRepository
open MainDataConnection
open sync.today.cipher
open Schemas
open ExchangeCommon

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

let public EXCHANGE_SERVICE_KEY="EXCHANGE"


let propertySet = 
    if exchangeVersion <> ExchangeVersion.Exchange2007_SP1 then
        let result = PropertySet( Array.append Properties [| AppointmentSchemaStartTimeZone; AppointmentSchemaEndTimeZone  |] )
        result.RequestedBodyType <- Nullable(BodyType.Text)
        result
    else
        let result = PropertySet( Properties )
        result.RequestedBodyType <- Nullable(BodyType.Text)
        result

let shouldBeReminderSet =
    let posVal = ConfigurationManager.AppSettings.[ "Exchange.shouldBeReminderSet" ]
    let result = ref false
    if Boolean.TryParse( posVal, result ) then
        result.Value
    else
        true

let copyDTOToAppointment( r : Appointment, source : ExchangeAppointmentDTO )  =
        r.Body <- MessageBody(BodyType.Text, ( if String.IsNullOrWhiteSpace(source.Body) then String.Empty else source.Body  ) )

        if exchangeUseTimeZone && (exchangeVersion <> ExchangeVersion.Exchange2007_SP1) then
            r.StartTimeZone <- timezone(false)
        r.Start <- source.Start
        r.End <- source.End 

        if exchangeUseTimeZone && (exchangeVersion <> ExchangeVersion.Exchange2007_SP1) then
            r.EndTimeZone <- timezone(false)

        r.Location <- source.Location 
        r.ReminderMinutesBeforeStart <- source.ReminderMinutesBeforeStart
        r.Subject <- source.Subject 
        if shouldBeReminderSet then
            r.IsReminderSet <- source.IsReminderSet 
        else 
            r.IsReminderSet <- false

        // Categories
        let oldCategories = json(r.Categories)
        devlog.Debug( sprintf "InternalId: %A Subject: %A oldCategories:'%A' source.CategoriesJSON:''%A " source.InternalId r.Subject oldCategories source.CategoriesJSON )
        if oldCategories <> source.CategoriesJSON then 
            let categories = if String.IsNullOrWhiteSpace(source.CategoriesJSON) then [| |] else unjson<string array>( source.CategoriesJSON )
            let categoriesNotEmpty = Array.FindAll(categories, ( fun p -> not(String.IsNullOrWhiteSpace(p) ) ) )
            r.Categories.Clear()
            devlog.Debug( sprintf "categoriesNotEmpty:'%A'" categoriesNotEmpty )
            r.Categories.AddRange( categoriesNotEmpty )

let copyAppointmentToDTO( r : Appointment, serviceAccountId : int, tag : int ) : ExchangeAppointmentDTO =
    try
        { Id = 0; InternalId = Guid.NewGuid(); ExternalId = r.Id.ToString();     
        Body = r.Body.Text; Start = r.Start; End = r.End; LastModifiedTime = r.LastModifiedTime; Location = r.Location;
                        IsReminderSet = r.IsReminderSet; AppointmentState = byte r.AppointmentState; Subject = r.Subject; RequiredAttendeesJSON = json(r.RequiredAttendees);
                        ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Sensitivity = byte r.Sensitivity; RecurrenceJSON = ( if exchangeVersion <> ExchangeVersion.Exchange2007_SP1 then json(r.Recurrence) else String.Empty ); 
                        ModifiedOccurrencesJSON = ( if exchangeVersion <> ExchangeVersion.Exchange2007_SP1 then json(r.ModifiedOccurrences) else String.Empty );
                        LastOccurrenceJSON = ( if exchangeVersion <> ExchangeVersion.Exchange2007_SP1  then json(r.LastOccurrence) else String.Empty ); IsRecurring = ( if exchangeVersion <> ExchangeVersion.Exchange2007_SP1 then r.IsRecurring else false); IsCancelled = r.IsCancelled; ICalRecurrenceId = ""; 
                        FirstOccurrenceJSON = ( if exchangeVersion <> ExchangeVersion.Exchange2007_SP1  then json(r.FirstOccurrence) else String.Empty ); 
                        DeletedOccurrencesJSON = ( if exchangeVersion <> ExchangeVersion.Exchange2007_SP1  then json(r.DeletedOccurrences) else String.Empty ); AppointmentType = byte r.AppointmentType; Duration = int r.Duration.TotalMinutes; 
                        StartTimeZone = ( if exchangeVersion <> ExchangeVersion.Exchange2007_SP1  then r.StartTimeZone.StandardName else String.Empty ); 
                        EndTimeZone = ( if exchangeVersion <> ExchangeVersion.Exchange2007_SP1  then r.EndTimeZone.StandardName else String.Empty );  
                        AllowNewTimeProposal = false; CategoriesJSON = json(r.Categories); 
                        ServiceAccountId = serviceAccountId; 
                        Tag = tag }
    with
        | ex -> raise (System.ArgumentException("copyAppointmentToDTO failed", ex)) 

let save( app : Appointment, serviceAccountId : int, downloadRound : int ) =
    saveExchangeAppointment(copyAppointmentToDTO(app, serviceAccountId, -1), false, downloadRound)

let insertOrUpdate( app : ExchangeAppointmentDTO ) =
    let downloadRound = int DateTime.Now.Ticks
    saveExchangeAppointment(app, true, downloadRound)


let changeExternalId( app : ExchangeAppointmentDTO, externalId : string ) =
    changeExchangeAppointmentExternalId(app, externalId)

let findFolderByName( _service : ExchangeService, name, login : Login ) : Folder option = 
    ExchangeCommon.findFolderByName( _service, name, login, WellKnownFolderName.Calendar )

let download fromDate login =
    let date : DateTime = fromDate
    logger.Debug( sprintf "download started for '%A' from '%A'" login.userName date )
    prepareForDownload(login.serviceAccountId)
    let greaterthanfilter = new SearchFilter.IsGreaterThanOrEqualTo(ItemSchema.LastModifiedTime, date)
    let filter = new SearchFilter.SearchFilterCollection(LogicalOperator.And, greaterthanfilter)
    let _service = connect(login)

    let syncTodayFolder = findFolderByName( _service, login.folder, login ) 
    if syncTodayFolder.IsSome then 
        let folder = 
            if not (login.impersonate) && not( String.IsNullOrWhiteSpace( login.email ) ) && login.email <> login.userName then
                Folder.Bind(_service, new FolderId(WellKnownFolderName.Calendar, new Mailbox(login.email)))
            else
                Folder.Bind(_service, WellKnownFolderName.Calendar)
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
                if ( item :? Appointment ) then
                    try
                        let app = item :?> Appointment
                        //logger.Debug( sprintf "processing '%A' " app.Id )
                        app.Load( propertySet )
                        if ( app.LastModifiedTime > date ) then
                            save(app, login.serviceAccountId, downloadRound ) |> ignore
                    with
                        | ex ->
                            saveDLUPIssues(item.Id.ToString(), ex.ToString(), null ) 
                            reraise()                        
    else 
        logger.Warn( sprintf "folder %A not found" login.folder )
                        
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
            if ( item :? Appointment ) then
                let app = item :?> Appointment
                app.Delete( DeleteMode.HardDelete, SendCancellationsMode.SendToNone )

let private createAppointment( item : ExchangeAppointmentDTO, _service : ExchangeService ) : Appointment =
    let app = new Appointment(_service)
    copyDTOToAppointment( app, item )
    app


let get login externalId =
    logger.Debug( "get started" )
    let _service = connect(login)

    let folder = 
        if not (login.impersonate) && not( String.IsNullOrWhiteSpace( login.email ) ) && login.email <> login.userName then
            Folder.Bind(_service, new FolderId(WellKnownFolderName.Calendar, new Mailbox(login.email)))
        else
            Folder.Bind(_service, WellKnownFolderName.Calendar)

    try 
        let possibleApp = Appointment.Bind(_service, new ItemId(externalId))

        // check if the parent is my folder
        if possibleApp.ParentFolderId.UniqueId <> folder.Id.UniqueId then
            // if not, nothing
            None
        else
            Some( possibleApp )
    with 
        | ex -> None               


let upload( login : Login ) =
    logger.Debug( "upload started" )
    prepareForUpload login.maintenance
    let _service = connect(login)
    let itemsToUpload = ExchangeAppointmentsToUpload(login.serviceAccountId)

    let folder = 
        if not (login.impersonate) && not( String.IsNullOrWhiteSpace( login.email ) ) && login.email <> login.userName then
            Folder.Bind(_service, new FolderId(WellKnownFolderName.Calendar, new Mailbox(login.email)))
        else
            Folder.Bind(_service, WellKnownFolderName.Calendar)

    for item in itemsToUpload do
        logger.Debug( sprintf "uploading '%A'-'%A'" item.InternalId item.ExternalId )
        if String.IsNullOrWhiteSpace(item.ExternalId) then
            let app = createAppointment( item, _service )
            app.Save(folder.Id, SendInvitationsMode.SendToNone)
            logger.Debug( sprintf "'%A' saved" app.Id )
            changeExternalId( item, app.Id.ToString() )
            setExchangeAppointmentAsUploaded(item)
        else
            try 
                let possibleApp = Appointment.Bind(_service, new ItemId(item.ExternalId))
                copyDTOToAppointment( possibleApp, item )
                possibleApp.Update(ConflictResolutionMode.AutoResolve, SendInvitationsOrCancellationsMode.SendToNone)

                // check if the parent is my folder
                if possibleApp.ParentFolderId.UniqueId <> folder.Id.UniqueId then
                  // if not, move
                  devlog.Debug( sprintf "Moving %A from %A to %A" possibleApp possibleApp.ParentFolderId folder )
                  changeExternalId( item, possibleApp.Move( folder.Id ).Id.ToString() )
                  devlog.Debug( "Moved" )

                logger.Debug( sprintf "'%A' saved" possibleApp.Id )
                setExchangeAppointmentAsUploaded(item)
            with 
                | ex -> 
                        saveDLUPIssues(item.ExternalId, null, ex.ToString() ) 
                        try 
                            logger.Debug( sprintf "Save '%A' failed '%A'" item ex )
                            if  ex.Message <> "Set action is invalid for property" then
                                // create new item
                                let app = createAppointment( item, _service )
                                app.Save(folder.Id, SendInvitationsMode.SendToNone)
                                changeExternalId( item, app.Id.ToString() )
                                // we are not able to delete old item, since we were not able to update it
                        with
                            | ex ->
                                saveDLUPIssues(item.ExternalId, null, ex.ToString() ) 
                                reraise()

let Updated() =
    getUpdatedExchangeAppointments()

let New() =
    getNewExchangeAppointments()

let ConvertToDTO( r : ExchangeAppointmentDTO, adapterId ) : AdapterAppointmentDTO =
   { Id = 0; InternalId = r.InternalId; LastModified = r.LastModifiedTime; Category = findCategory( r.CategoriesJSON ); 
   Location = string2optionString r.Location; Content = string2optionString r.Body; Title = string2optionString r.Subject; 
   DateFrom = r.Start; DateTo = r.End; Notification = r.IsReminderSet; IsPrivate = r.Sensitivity <> byte 0; Priority = byte 0; 
   AppointmentId = 0; AdapterId = adapterId; Tag = Some(r.Tag); ReminderMinutesBeforeStart=r.ReminderMinutesBeforeStart }

let getEmpty(old : ExchangeAppointmentDTO option): ExchangeAppointmentDTO =
    if ( old.IsSome ) then
        old.Value
    else 
        { Id = 0; InternalId = Guid.Empty; ExternalId = ""; Body = ""; Start = DateTime.Now;
            End = DateTime.Now; LastModifiedTime = DateTime.Now; Location = "";
            IsReminderSet = true; 
            AppointmentState = byte 0; Subject = ""; RequiredAttendeesJSON = "";
            ReminderMinutesBeforeStart = 15; 
            Sensitivity = byte 0; RecurrenceJSON = ""; 
            ModifiedOccurrencesJSON = "";
            LastOccurrenceJSON = ""; IsRecurring = false; 
            IsCancelled = false; ICalRecurrenceId = ""; 
            FirstOccurrenceJSON = ""; 
            DeletedOccurrencesJSON = ""; AppointmentType = byte 0; 
            Duration = 0; StartTimeZone = ""; 
            EndTimeZone = ""; AllowNewTimeProposal = false; 
            CategoriesJSON = ""; ServiceAccountId = 0; 
            Tag = 0 }
        

let ConvertFromDTO( r : AdapterAppointmentDTO, serviceAccountId, original : ExchangeAppointmentDTO ) : ExchangeAppointmentDTO =
    { Id = original.Id; InternalId = r.InternalId; ExternalId = original.ExternalId; Body = optionString2String r.Content; 
    Start = r.DateFrom; 
    End = r.DateTo; LastModifiedTime = r.LastModified; Location = optionString2String r.Location;
        IsReminderSet = r.Notification; 
        AppointmentState = original.AppointmentState; Subject = optionString2String r.Title; 
        RequiredAttendeesJSON = original.RequiredAttendeesJSON;
        ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; 
        Sensitivity = original.Sensitivity; RecurrenceJSON = original.RecurrenceJSON; 
        ModifiedOccurrencesJSON = original.ModifiedOccurrencesJSON;
        LastOccurrenceJSON = original.LastOccurrenceJSON; IsRecurring = original.IsRecurring; 
        IsCancelled = original.IsCancelled; ICalRecurrenceId = original.ICalRecurrenceId; 
        FirstOccurrenceJSON = original.FirstOccurrenceJSON; 
        DeletedOccurrencesJSON = original.DeletedOccurrencesJSON; AppointmentType = original.AppointmentType; 
        Duration = int (r.DateTo.Subtract( r.DateTo ).TotalMinutes ); StartTimeZone = original.StartTimeZone; 
        EndTimeZone = original.EndTimeZone; AllowNewTimeProposal = original.AllowNewTimeProposal; 
        CategoriesJSON = AppointmentLevelRepository.replaceCategoryInJSON( original.CategoriesJSON, optionString2String r.Category ); 
        ServiceAccountId = serviceAccountId; 
        Tag = if r.Tag.IsSome then r.Tag.Value else 0 }

let DownloadForServiceAccount( serviceAccount : ServiceAccountDTO ) =
    let lastSuccessfulDownload = getLastSuccessfulDate2 serviceAccount.LastSuccessfulDownload
    let maintenance = ( DateTime.Now.Date - lastSuccessfulDownload.Date ) > TimeSpan.FromHours( float 1 )
    download lastSuccessfulDownload  ( getLogin serviceAccount.LoginJSON serviceAccount.Id maintenance )

let Download( serviceAccount : ServiceAccountDTO ) =
    ServiceAccountRepository.Download( serviceAccount, DownloadForServiceAccount )

let ChangeInternalIdBecauseOfDuplicity( exchangeAppointment : ExchangeAppointmentDTO, foundDuplicity : AdapterAppointmentDTO ) =
    changeInternalIdBecauseOfDuplicity( exchangeAppointment , foundDuplicity )

let ChangeInternalIdBecauseOfDuplicitySimple( internalId : Guid, exchangeAppointmentId : int ) =
    changeInternalIdBecauseOfDuplicitySimple( internalId , exchangeAppointmentId )

let ExchangeAppointmentInternalIds() =
    exchangeAppointmentInternalIds()

let ExchangeAppointmentByInternalId( internalId : Guid ) =
    exchangeAppointmentByInternalId( internalId )

let Upload( serviceAccount : ServiceAccountDTO ) =
    ServiceAccountRepository.Upload( serviceAccount, ( uploadForServiceAccount upload ) )

let printContent( before : bool ) =
    let data_before = log4net.LogManager.GetLogger("exchange_data_before");
    let data_after = log4net.LogManager.GetLogger("exchange_data_after");
    let logger = if before then data_before else data_after
    logger.Debug("started")
    let exchangeAppointments = exchangeAppointments()
    for exchangeAppointment in exchangeAppointments do
        let replacedBody = if exchangeAppointment.Body <> null then exchangeAppointment.Body.Replace(System.Environment.NewLine, " ") else String.Empty
        logger.Info( sprintf "%A\t%A\t%A\t%A\t%A\t%A" exchangeAppointment.InternalId exchangeAppointment.Subject exchangeAppointment.Start exchangeAppointment.End exchangeAppointment.LastModifiedTime replacedBody )
    logger.Debug("done")

let AllEvents() =
    exchangeAppointments()

let getExchangeServerAppointments login processEvent =
    logger.Debug( sprintf "getExchangeServerAppointments started for '%A'" login.userName )
    prepareForDownload(login.serviceAccountId)
    let _service = connect(login)
    let folder = 
        if not (login.impersonate) && not( String.IsNullOrWhiteSpace( login.email ) ) && login.email <> login.userName then
            Folder.Bind(_service, new FolderId(WellKnownFolderName.Calendar, new Mailbox(login.email)))
        else
            Folder.Bind(_service, WellKnownFolderName.Calendar)
    let view = new ItemView(1000)
    view.Offset <- 0
    let downloadRound = int DateTime.Now.Ticks
    seq {
        let search = ref true
        while search.Value do
            let found = folder.FindItems(view)
            search := found.Items.Count = view.PageSize
            view.Offset <- view.Offset + view.PageSize
            logger.DebugFormat( "got {0} items", found.Items.Count )
            for item in found do
                if ( item :? Appointment ) then
                        let app = item :?> Appointment
                        //logger.Debug( sprintf "processing '%A' " app.Id )
                        app.Load( propertySet )
                        yield processEvent app
    }
    

let processExchangeServer login processEvent =
    getExchangeServerAppointments login processEvent
