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

let AppointmentSchemaId : PropertyDefinitionBase = 
    upcast AppointmentSchema.Id

let AppointmentSchemaBody : PropertyDefinitionBase = 
    upcast AppointmentSchema.Body

let AppointmentSchemaStart : PropertyDefinitionBase = 
    upcast AppointmentSchema.Start

let AppointmentSchemaEnd : PropertyDefinitionBase = 
    upcast AppointmentSchema.End

let AppointmentSchemaLastModifiedTime : PropertyDefinitionBase = 
    upcast AppointmentSchema.LastModifiedTime

let AppointmentSchemaLocation : PropertyDefinitionBase = 
    upcast AppointmentSchema.Location

let AppointmentSchemaIsReminderSet : PropertyDefinitionBase = 
    upcast AppointmentSchema.IsReminderSet

let AppointmentSchemaReminderDueBy : PropertyDefinitionBase = 
    upcast AppointmentSchema.ReminderDueBy

let AppointmentSchemaAppointmentState : PropertyDefinitionBase = 
    upcast AppointmentSchema.AppointmentState

let AppointmentSchemaSubject : PropertyDefinitionBase = 
    upcast AppointmentSchema.Subject

let AppointmentSchemaRequiredAttendees : PropertyDefinitionBase = 
    upcast AppointmentSchema.RequiredAttendees

let AppointmentSchemaReminderMinutesBeforeStart : PropertyDefinitionBase = 
    upcast AppointmentSchema.ReminderMinutesBeforeStart

let AppointmentSchemaSensitivity : PropertyDefinitionBase = 
    upcast AppointmentSchema.Sensitivity

let ContactSchemaId : PropertyDefinitionBase = 
    upcast ContactSchema.Id

let AppointmentSchemaRecurrence : PropertyDefinitionBase = 
    upcast AppointmentSchema.Recurrence

let AppointmentSchemaModifiedOccurrences : PropertyDefinitionBase = 
    upcast AppointmentSchema.ModifiedOccurrences

let AppointmentSchemaLastOccurrence : PropertyDefinitionBase = 
    upcast AppointmentSchema.LastOccurrence

let AppointmentSchemaIsRecurring : PropertyDefinitionBase = 
    upcast AppointmentSchema.IsRecurring

let AppointmentSchemaIsCancelled : PropertyDefinitionBase = 
    upcast AppointmentSchema.IsCancelled

let AppointmentSchemaICalRecurrenceId : PropertyDefinitionBase = 
    upcast AppointmentSchema.ICalRecurrenceId

let AppointmentSchemaFirstOccurrence : PropertyDefinitionBase = 
    upcast AppointmentSchema.FirstOccurrence

let AppointmentSchemaDeletedOccurrences : PropertyDefinitionBase = 
    upcast AppointmentSchema.DeletedOccurrences

let AppointmentSchemaAppointmentType : PropertyDefinitionBase = 
    upcast AppointmentSchema.AppointmentType

let AppointmentSchemaDuration : PropertyDefinitionBase = 
    upcast AppointmentSchema.Duration

let AppointmentSchemaStartTimeZone : PropertyDefinitionBase = 
    upcast AppointmentSchema.StartTimeZone

let AppointmentSchemaEndTimeZone : PropertyDefinitionBase = 
    upcast AppointmentSchema.EndTimeZone

let AppointmentSchemaAllowNewTimeProposal : PropertyDefinitionBase = 
    upcast AppointmentSchema.AllowNewTimeProposal

let AppointmentSchemaCategories : PropertyDefinitionBase = 
    upcast AppointmentSchema.Categories

let Properties = 
    [|
        AppointmentSchemaId; AppointmentSchemaBody;
        AppointmentSchemaBody;
        AppointmentSchemaStart;
        AppointmentSchemaEnd;
        AppointmentSchemaLastModifiedTime;
        AppointmentSchemaLocation;
        AppointmentSchemaIsReminderSet;
        AppointmentSchemaReminderDueBy;
        AppointmentSchemaAppointmentState;
        AppointmentSchemaSubject;
        AppointmentSchemaRequiredAttendees;
        AppointmentSchemaReminderMinutesBeforeStart;
        AppointmentSchemaSensitivity;
        ContactSchemaId;
        AppointmentSchemaRecurrence;
        AppointmentSchemaModifiedOccurrences;
        AppointmentSchemaLastOccurrence;
        AppointmentSchemaIsRecurring;
        AppointmentSchemaIsCancelled;
        AppointmentSchemaICalRecurrenceId;
        AppointmentSchemaFirstOccurrence;
        AppointmentSchemaDeletedOccurrences;
        AppointmentSchemaAppointmentType;
        AppointmentSchemaDuration;
        AppointmentSchemaAllowNewTimeProposal;
        AppointmentSchemaCategories
    |]

let propertySet = 
    if exchangeVersion <> ExchangeVersion.Exchange2007_SP1 then
        let result = PropertySet( Array.append Properties [| AppointmentSchemaStartTimeZone; AppointmentSchemaEndTimeZone  |] )
        result.RequestedBodyType <- Nullable(BodyType.Text)
        result
    else
        let result = PropertySet( Properties )
        result.RequestedBodyType <- Nullable(BodyType.Text)
        result

let connect( login : Login ) =
    logger.Debug( "Login started" )

    System.Net.ServicePointManager.ServerCertificateValidationCallback <- 
        (fun _ _ _ _ -> true)

    let _TIMEZONEInSettings = ConfigurationManager.AppSettings.["ExchangeTimeZone"]
    let _TIMEZONE = ( if String.IsNullOrWhiteSpace( _TIMEZONEInSettings ) then TimeZone.CurrentTimeZone.StandardName else _TIMEZONEInSettings )

    let _service = new ExchangeService(exchangeVersion, TimeZoneInfo.FindSystemTimeZoneById(_TIMEZONE))
    _service.EnableScpLookup <- true    
    let decryptedPassword = StringCipher.Decrypt(login.password, login.userName)
    _service.Credentials <- new WebCredentials(login.userName, decryptedPassword) 
    if String.IsNullOrWhiteSpace(login.server) then
        _service.AutodiscoverUrl(login.email, (fun _ -> true) )
    else
        _service.Url <- new Uri(login.server)
    logger.Debug( "Login successfully finished" )
    _service

let copyDTOToAppointment( r : Appointment, source : ExchangeAppointmentDTO )  =
        r.Body <- MessageBody(BodyType.Text, source.Body)
        r.Start <- source.Start
        r.End <- source.End 
        r.Location <- source.Location 
        r.ReminderDueBy <- source.ReminderDueBy
        r.Subject <- source.Subject 
        r.IsReminderSet <- source.IsReminderSet 

let copyAppointmentToDTO( r : Appointment, serviceAccountId : int, tag : int ) : ExchangeAppointmentDTO =
    try
        { Id = 0; InternalId = Guid.NewGuid(); ExternalId = r.Id.ToString();     
        Body = r.Body.Text; Start = r.Start; End = r.End; LastModifiedTime = r.LastModifiedTime; Location = r.Location;
                        IsReminderSet = r.IsReminderSet; ReminderDueBy = r.ReminderDueBy; AppointmentState = byte r.AppointmentState; Subject = r.Subject; RequiredAttendeesJSON = json(r.RequiredAttendees);
                        ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Sensitivity = byte r.Sensitivity; RecurrenceJSON = json(r.Recurrence); 
                        ModifiedOccurrencesJSON = json(r.ModifiedOccurrences);
                        LastOccurrenceJSON = json(r.LastOccurrence); IsRecurring = r.IsRecurring; IsCancelled = r.IsCancelled; ICalRecurrenceId = ""; 
                        FirstOccurrenceJSON = json(r.FirstOccurrence); 
                        DeletedOccurrencesJSON = json(r.DeletedOccurrences); AppointmentType = byte r.AppointmentType; Duration = int r.Duration.TotalMinutes; 
                        StartTimeZone = ( if exchangeVersion <> ExchangeVersion.Exchange2007_SP1  then r.StartTimeZone.StandardName else String.Empty ); 
                        EndTimeZone = ( if exchangeVersion <> ExchangeVersion.Exchange2007_SP1  then r.EndTimeZone.StandardName else String.Empty );  
                        AllowNewTimeProposal = false; CategoriesJSON = json(r.Categories); 
                        ServiceAccountId = serviceAccountId; 
                        Tag = tag }
    with
        | ex -> raise (System.ArgumentException("copyAppointmentToDTO failed", ex)) 

let save( app : Appointment, serviceAccountId : int ) =
    saveExchangeAppointment(copyAppointmentToDTO(app, serviceAccountId, -1), false)

let insertOrUpdate( app : ExchangeAppointmentDTO ) =
    saveExchangeAppointment(app, true)

let changeExternalId( app : ExchangeAppointmentDTO, externalId : string ) =
    changeExchangeAppointmentExternalId(app, externalId)

let insertOrUpdateFrom( internalId : Guid, body : string, startDT : DateTime, endDT : DateTime, location : string, reminderDueBy : Nullable<DateTime>, subject : string, serviceAccountId : int, tag : int  ) =
    let app = { Id = 0; InternalId = internalId; ExternalId = String.Empty;     
                        Body = body; Start = startDT; End = endDT; LastModifiedTime = DateTime.Now; Location = location;
                        IsReminderSet = reminderDueBy.HasValue; ReminderDueBy = ( if reminderDueBy.HasValue then reminderDueBy.Value else DateTime.Now ); 
                        AppointmentState = byte 0; Subject = subject; RequiredAttendeesJSON = String.Empty;
                        ReminderMinutesBeforeStart = 0; Sensitivity = byte 0; RecurrenceJSON = String.Empty; 
                        ModifiedOccurrencesJSON = String.Empty;
                        LastOccurrenceJSON = String.Empty; IsRecurring = false; IsCancelled = false; ICalRecurrenceId = ""; 
                        FirstOccurrenceJSON = String.Empty; 
                        DeletedOccurrencesJSON = String.Empty; AppointmentType = byte 0; Duration = int (endDT - startDT).TotalMinutes; 
                        StartTimeZone = String.Empty; 
                        EndTimeZone = String.Empty;  
                        AllowNewTimeProposal = false; CategoriesJSON = String.Empty; 
                        ServiceAccountId = serviceAccountId; 
                        Tag = tag }
    saveExchangeAppointment(app, true)


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
    while search do
        let found = folder.FindItems(filter, view)
        search <- found.Items.Count = view.PageSize
        view.Offset <- view.Offset + view.PageSize
        logger.DebugFormat( "got {0} items", found.Items.Count )
        for item in found do
            if ( item :? Appointment ) then
                let app = item :?> Appointment
                app.Load( propertySet )
                save(app, login.serviceAccountId ) |> ignore
    logger.Debug( "download successfully finished" )

let private createAppointment( item : ExchangeAppointmentDTO, _service : ExchangeService ) : Appointment =
    let app = new Appointment(_service)
    copyDTOToAppointment( app, item )
    app

let upload( login : Login ) =
    logger.Debug( "upload started" )
    let _service = connect(login)
    let itemsToUpload = ExchangeAppointmentsToUpload(login.serviceAccountId)
    for item in itemsToUpload do
        if String.IsNullOrWhiteSpace(item.ExternalId) then
            let app = createAppointment( item, _service )
            app.Save(SendInvitationsMode.SendToNone)
            changeExternalId( item, app.Id.ToString() )

        else
            try 
                let possibleApp = Appointment.Bind(_service, new ItemId(item.ExternalId))
                copyDTOToAppointment( possibleApp, item )
                possibleApp.Save(SendInvitationsMode.SendToNone)
            with 
                | ex -> let app = createAppointment( item, _service )
                        app.Save(SendInvitationsMode.SendToNone)
                        changeExternalId( item, app.Id.ToString() )
        setExchangeAppointmentAsUploaded(item)

let Updated() =
    getUpdatedExchangeAppointments()

let New() =
    getNewExchangeAppointments()

type ExchangeLogin = JsonProvider<"""{ "loginName" : "Franta", "password" : "UASJXMLXL", "server" : "jidasjidjasi.dasjdasij.com"  }""">

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
            IsReminderSet = false; ReminderDueBy = DateTime.Now; 
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
        CategoriesJSON = original.CategoriesJSON; ServiceAccountId = original.ServiceAccountId; 
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