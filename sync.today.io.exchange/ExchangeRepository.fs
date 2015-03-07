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

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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


let propertySet = 
    if exchangeVersion <> ExchangeVersion.Exchange2007_SP1 then
        let result = PropertySet( Array.append Properties [| AppointmentSchemaStartTimeZone; AppointmentSchemaEndTimeZone  |] )
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
    logger.Debug( "Login started" )

    System.Net.ServicePointManager.ServerCertificateValidationCallback <- 
        (fun _ _ _ _ -> true)

    let _service = new ExchangeService(exchangeVersion, timezone(true))
    _service.EnableScpLookup <- true    
    let decryptedPassword = StringCipher.Decrypt(login.password, login.userName)
    _service.Credentials <- new WebCredentials(login.userName, decryptedPassword) 
    if String.IsNullOrWhiteSpace(login.server) then
        logger.Debug( sprintf "Trying auto discover for '%A'" login.email )
        _service.AutodiscoverUrl(login.email, (fun _ -> true) )
    else
        _service.Url <- new Uri(login.server)
    logger.Debug( "Login successfully finished" )
    _service

let copyDTOToAppointment( r : Appointment, source : ExchangeAppointmentDTO )  =
        r.Body <- MessageBody(BodyType.Text, ( if String.IsNullOrWhiteSpace(source.Body) then String.Empty else source.Body  ) )
        r.StartTimeZone <- timezone(false)
        r.Start <- source.Start
        r.End <- source.End 
        if exchangeVersion <> ExchangeVersion.Exchange2007_SP1 then
            r.EndTimeZone <- timezone(false)
        r.Location <- source.Location 
        r.ReminderDueBy <- source.ReminderDueBy
        r.Subject <- source.Subject 
        r.IsReminderSet <- source.IsReminderSet 
        r.Categories.AddRange( unjson<string array>( source.CategoriesJSON ) )

let copyAppointmentToDTO( r : Appointment, serviceAccountId : int, tag : int ) : ExchangeAppointmentDTO =
    try
        { Id = 0; InternalId = Guid.NewGuid(); ExternalId = r.Id.ToString();     
        Body = r.Body.Text; Start = r.Start; End = r.End; LastModifiedTime = r.LastModifiedTime; Location = r.Location;
                        IsReminderSet = r.IsReminderSet; ReminderDueBy = r.ReminderDueBy; AppointmentState = byte r.AppointmentState; Subject = r.Subject; RequiredAttendeesJSON = json(r.RequiredAttendees);
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

let download( date : DateTime, login : Login ) =
    logger.Debug( "download started" )
    prepareForDownload()
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
            if ( item :? Appointment ) then
                try
                    let app = item :?> Appointment
                    //logger.Debug( sprintf "processing '%A' " app.Id )
                    app.Load( propertySet )
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
            if ( item :? Appointment ) then
                let app = item :?> Appointment
                app.Delete( DeleteMode.HardDelete, SendCancellationsMode.SendToNone )

let private createAppointment( item : ExchangeAppointmentDTO, _service : ExchangeService ) : Appointment =
    let app = new Appointment(_service)
    copyDTOToAppointment( app, item )
    app

let upload( login : Login ) =
    logger.Debug( "upload started" )
    let _service = connect(login)
    let itemsToUpload = ExchangeAppointmentsToUpload(login.serviceAccountId)
    for item in itemsToUpload do
        logger.Debug( sprintf "uploading '%A'" item )
        if String.IsNullOrWhiteSpace(item.ExternalId) then
            let app = createAppointment( item, _service )
            app.Save(SendInvitationsMode.SendToNone)
            logger.Debug( sprintf "'%A' saved" app.Id )
            changeExternalId( item, app.Id.ToString() )

        else
            try 
                let possibleApp = Appointment.Bind(_service, new ItemId(item.ExternalId))
                copyDTOToAppointment( possibleApp, item )
                possibleApp.Update(ConflictResolutionMode.AutoResolve, SendInvitationsOrCancellationsMode.SendToNone)
                logger.Debug( sprintf "'%A' saved" possibleApp.Id )
            with 
                | ex -> 
                        saveDLUPIssues(item.ExternalId, null, ex.ToString() ) 
                        //reraise()
                        (* 
                        try 
                            logger.Debug( sprintf "Save '%A' failed '%A'" item ex )
                            let app = createAppointment( item, _service )
                            app.Save(SendInvitationsMode.SendToNone)
                            changeExternalId( item, app.Id.ToString() )
                        with
                            | ex ->
                                saveDLUPIssues(item.ExternalId, null, ex.ToString() ) 
                                reraise()
                        *)
        setExchangeAppointmentAsUploaded(item)

let Updated() =
    getUpdatedExchangeAppointments()

let New() =
    getNewExchangeAppointments()

type ExchangeLogin = JsonProvider<"""{ "loginName" : "John", "password" : "UASJXMLXL", "server" : "jidasjidjasi.dasjdasij.com"  }""">

let ConvertToDTO( r : ExchangeAppointmentDTO, adapterId ) : AdapterAppointmentDTO =
   { Id = 0; InternalId = r.InternalId; LastModified = r.LastModifiedTime; Category = findCategory( r.CategoriesJSON ); Location = r.Location; Content = r.Body; Title = r.Subject; 
   DateFrom = r.Start; DateTo = r.End; Reminder = Nullable(r.ReminderDueBy); Notification = r.IsReminderSet; IsPrivate = r.Sensitivity <> byte 0; Priority = byte 0; 
   AppointmentId = 0; AdapterId = adapterId; Tag = r.Tag }

let getEmpty(old : ExchangeAppointmentDTO option): ExchangeAppointmentDTO =
    if ( old.IsSome ) then
        old.Value
    else 
        { Id = 0; InternalId = Guid.Empty; ExternalId = ""; Body = ""; Start = DateTime.Now;
            End = DateTime.Now; LastModifiedTime = DateTime.Now; Location = "";
            IsReminderSet = true; ReminderDueBy = DateTime.Now; 
            AppointmentState = byte 0; Subject = ""; RequiredAttendeesJSON = "";
            ReminderMinutesBeforeStart = 0; 
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
    { Id = original.Id; InternalId = r.InternalId; ExternalId = original.ExternalId; Body = r.Content; Start = r.DateFrom; 
    End = r.DateTo; LastModifiedTime = r.LastModified; Location = r.Location;
        IsReminderSet = r.Notification; ReminderDueBy = ( if r.Reminder.HasValue then r.Reminder.Value else r.DateFrom ); 
        AppointmentState = original.AppointmentState; Subject = r.Title; RequiredAttendeesJSON = original.RequiredAttendeesJSON;
        ReminderMinutesBeforeStart = ( if r.Reminder.HasValue then int (r.DateFrom.Subtract( r.Reminder.Value ).TotalMinutes ) else 0 ); 
        Sensitivity = original.Sensitivity; RecurrenceJSON = original.RecurrenceJSON; 
        ModifiedOccurrencesJSON = original.ModifiedOccurrencesJSON;
        LastOccurrenceJSON = original.LastOccurrenceJSON; IsRecurring = original.IsRecurring; 
        IsCancelled = original.IsCancelled; ICalRecurrenceId = original.ICalRecurrenceId; 
        FirstOccurrenceJSON = original.FirstOccurrenceJSON; 
        DeletedOccurrencesJSON = original.DeletedOccurrencesJSON; AppointmentType = original.AppointmentType; 
        Duration = int (r.DateTo.Subtract( r.DateTo ).TotalMinutes ); StartTimeZone = original.StartTimeZone; 
        EndTimeZone = original.EndTimeZone; AllowNewTimeProposal = original.AllowNewTimeProposal; 
        CategoriesJSON = "[\"" + r.Category + "\"]"; ServiceAccountId = serviceAccountId; 
        Tag = r.Tag }

let private getLogin( loginJSON : string, serviceAccountId : int ) : Login = 
    let parsed = ExchangeLogin.Parse( loginJSON )
    { userName = parsed.LoginName;  password = parsed.Password; server = parsed.Server; email = parsed.LoginName; serviceAccountId  = serviceAccountId }

let DownloadForServiceAccount( serviceAccount : ServiceAccountDTO ) =
    download( getLastSuccessfulDate( serviceAccount.LastSuccessfulDownload ), getLogin(serviceAccount.LoginJSON, serviceAccount.Id ) )

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

let UploadForServiceAccount( serviceAccount : ServiceAccountDTO ) =
    upload( getLogin(serviceAccount.LoginJSON, serviceAccount.Id ) )

let Upload( serviceAccount : ServiceAccountDTO ) =
    ServiceAccountRepository.Upload( serviceAccount, UploadForServiceAccount )

