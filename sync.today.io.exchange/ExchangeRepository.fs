module ExchangeRepository

open System
open Microsoft.Exchange.WebServices.Data
open System.Configuration
open sync.today.Models
open Common

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
    _service.Credentials <- new WebCredentials(login.userName, login.password) 
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
    MainDataConnection.saveExchangeAppointment(copyAppointmentToDTO(app, serviceAccountId, -1), false)

let insertOrUpdate( app : ExchangeAppointmentDTO ) =
    MainDataConnection.saveExchangeAppointment(app, true)

let changeExternalId( app : ExchangeAppointmentDTO, externalId : string ) =
    MainDataConnection.changeExchangeAppointmentExternalId(app, externalId)

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
    MainDataConnection.saveExchangeAppointment(app, true)


let download( date : DateTime, login : Login ) =
    logger.Debug( "download started" )
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
    let itemsToUpload = MainDataConnection.ExchangeAppointmentsToUpload(login.serviceAccountId)
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
        MainDataConnection.setExchangeAppointmentAsUploaded(item)
