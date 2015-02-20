// The SqlDataConnection (LINQ to SQL) TypeProvider allows you to write code that uses 
// a live connection to a database. For more information, please go to 
//    http://go.microsoft.com/fwlink/?LinkId=229209

module MainDataConnection

#if INTERACTIVE
#r "System.Data"
#r "System.Data.Linq"
#r "FSharp.Data.TypeProviders"
#endif

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models

type private SqlConnection = SqlDataConnection<ConnectionStringName="sync-today-mssql">
let private db() = SqlConnection.GetDataContext()
let private cnn() = db().DataContext

let internal journals() = 
    query {
        for r in db().Journals do
        select { Id = r.Id; Date = r.Date; Thread = r.Thread; Level = r.Level; Logger = r.Logger; Logger_method = r.Logger_method; Message = r.Message; Exception = r.Exception; Stacktrace = r.Stacktrace }
    } |> Seq.toList

let internal workflows() = 
    query {
        for r in db().Workflows do
        select { Id = r.Id; CreatedOn = r.CreatedOn; Name = r.Name; XamlCode = r.XamlCode }
    } |> Seq.toList

let internal workflowById( id : int ) = 
    query {
        for r in db().Workflows do
        where ( r.Id = id )
        select { Id = r.Id; CreatedOn = r.CreatedOn; Name = r.Name; XamlCode = r.XamlCode }
    } |> Seq.tryHead

let internal processes() = 
    query {
        for r in db().Processes do
        select { Id = r.Id; StartedOn = r.StartedOn; FinishedOn = r.FinishedOn; Name = r.Name; XamlCode = r.XamlCode; Exception = r.Exception; Workflow = workflowById(r.WorkflowId).Value; IsAlive = false }
    } |> Seq.toList

let internal processById( id : int ) = 
    query {
        for r in db().Processes do
        where ( r.Id = id )
        select { Id = r.Id; StartedOn = r.StartedOn; FinishedOn = r.FinishedOn; Name = r.Name; XamlCode = r.XamlCode; Exception = r.Exception; Workflow = workflowById(r.WorkflowId).Value; IsAlive = false }
    } |> Seq.tryHead

let internal appointments() = 
    query {
        for r in db().Appointments do
        select { Id = r.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; DateTo = r.DateTo; Reminder = r.Reminder; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority }
    } |> Seq.toList

let internal insertAppointment( appointment : AppointmentDTO ) =
        let db = db()

        let newAppointment = new SqlConnection.ServiceTypes.Appointments()
        newAppointment.Category <- appointment.Category
        newAppointment.Content <- appointment.Content
        newAppointment.DateFrom <- appointment.DateFrom
        newAppointment.DateTo <- appointment.DateTo
        newAppointment.InternalId <- appointment.InternalId
        newAppointment.IsPrivate <- appointment.IsPrivate
        newAppointment.LastModified <- appointment.LastModified
        newAppointment.Location <- appointment.Location
        newAppointment.Notification <- appointment.Notification
        newAppointment.Priority <- appointment.Priority
        newAppointment.Reminder <- appointment.Reminder
        newAppointment.Title <- appointment.Title

        db.Appointments.InsertOnSubmit newAppointment
        db.DataContext.SubmitChanges()
    
let internal deleteAppointments() =
        let db = db()
        db.Appointments.DeleteAllOnSubmit db.Appointments 
        db.DataContext.SubmitChanges()

(* 
let private ExchangeAppointmentsByExternalId( db : SqlConnection.ServiceTypes.SimpleDataContextTypes.SyncToday2015_New, externalId : string ) = 
    query {
        for r in db.ExchangeAppointments do
        where ( r.ExternalId = externalId )
        select { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; Body = r.Body; Start = r.Start; End = r.End; LastModifiedTime = r.LastModifiedTime; Location = r.Location;
                    IsReminderSet = r.IsReminderSet; ReminderDueBy = r.ReminderDueBy; AppointmentState = r.AppointmentState; Subject = r.Subject; RequiredAttendeesJSON = r.RequiredAttendeesJSON;
                    ReminderMinutesBeforeStart = ( if r.ReminderMinutesBeforeStart.HasValue then r.ReminderMinutesBeforeStart.Value else 0 ); Sensitivity = r.Sensitivity; RecurrenceJSON = r.RecurrenceJSON; ModifiedOccurrencesJSON = r.ModifiedOccurrencesJSON;
                    LastOccurrence = ( if r.LastOccurrence.HasValue then r.LastOccurrence.Value else DateTime.MinValue ); IsRecurring = r.IsRecurring; IsCancelled = r.IsCancelled; ICalRecurrenceId = r.ICalRecurrenceId; 
                    FirstOccurrence = ( if r.FirstOccurrence.HasValue then r.FirstOccurrence.Value else DateTime.MaxValue ); 
                    DeletedOccurrencesJSON = r.DeletedOccurrencesJSON; AppointmentType = r.AppointmentType; Duration = r.Duration; StartTimeZone = r.StartTimeZone; 
                    EndTimeZone = r.EndTimeZone; AllowNewTimeProposal = r.AllowNewTimeProposal; CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; 
                    Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }
    } |> Seq.tryHead
*)

let private ExchangeAppointmentsByExternalId( externalId : string ) = 
    query {
        for r in db().ExchangeAppointments do
        where ( r.ExternalId = externalId )
        select r
    } |> Seq.tryHead

let private ExchangeAppointmentsByInternalId( internalId : Guid ) = 
    query {
        for r in db().ExchangeAppointments do
        where ( r.InternalId = internalId )
        select r
    } |> Seq.tryHead

let private copyToExchangeAppointment(destination : SqlConnection.ServiceTypes.ExchangeAppointments, source : ExchangeAppointmentDTO ) =
    destination.AllowNewTimeProposal <- source.AllowNewTimeProposal
    destination.AppointmentState <- source.AppointmentState
    destination.AppointmentType <- source.AppointmentType
    destination.Body <- source.Body
    destination.CategoriesJSON <- source.CategoriesJSON
    destination.DeletedOccurrencesJSON <- source.DeletedOccurrencesJSON
    destination.Duration <- source.Duration
    destination.End <- source.End
    destination.EndTimeZone <- source.EndTimeZone
    destination.ExternalId <- source.ExternalId
    destination.FirstOccurrenceJSON <- source.FirstOccurrenceJSON
    destination.ICalRecurrenceId <- source.ICalRecurrenceId
    if destination.Id = 0  then
        destination.Id <- source.Id
    destination.InternalId  <- source.InternalId
    destination.IsCancelled <- source.IsCancelled
    destination.IsRecurring <- source.IsRecurring
    destination.IsReminderSet <- source.IsReminderSet
    destination.LastModifiedTime <- source.LastModifiedTime
    destination.LastOccurrenceJSON <- source.LastOccurrenceJSON
    destination.Location <- source.Location
    destination.ModifiedOccurrencesJSON <- source.ModifiedOccurrencesJSON
    destination.RecurrenceJSON <- source.RecurrenceJSON
    destination.ReminderDueBy <- source.ReminderDueBy
    destination.ReminderMinutesBeforeStart <- Nullable<int>(source.ReminderMinutesBeforeStart)
    destination.RequiredAttendeesJSON <- source.RequiredAttendeesJSON
    destination.Sensitivity <- source.Sensitivity
    destination.ServiceAccountId <- source.ServiceAccountId
    destination.Start <- source.Start
    destination.StartTimeZone <- source.StartTimeZone
    destination.Subject <- source.Subject
    destination.Tag <- Nullable<int>(source.Tag)


let saveExchangeAppointment( app : ExchangeAppointmentDTO, upload : bool ) = 
    let db = db()
    let possibleApp = if upload then ExchangeAppointmentsByInternalId( app.InternalId ) else ExchangeAppointmentsByExternalId( app.ExternalId )
    if ( box possibleApp = null ) then
        let newApp = new SqlConnection.ServiceTypes.ExchangeAppointments()
        copyToExchangeAppointment(newApp, app)
        newApp.Upload <- upload
        db.ExchangeAppointments.InsertOnSubmit newApp
    else
        copyToExchangeAppointment(possibleApp.Value, app)
        possibleApp.Value.Upload <- upload
    db.DataContext.SubmitChanges()
        
let ExchangeAppointmentsToUpload( serviceAccountId : int ) = 
    let db = db()
    query {
        for r in db.ExchangeAppointments do
        where ( r.ServiceAccountId = serviceAccountId && r.Upload )
        select { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; Body = r.Body; Start = r.Start; End = r.End; LastModifiedTime = r.LastModifiedTime; Location = r.Location;
                    IsReminderSet = r.IsReminderSet; ReminderDueBy = r.ReminderDueBy; AppointmentState = r.AppointmentState; Subject = r.Subject; RequiredAttendeesJSON = r.RequiredAttendeesJSON;
                    ReminderMinutesBeforeStart = ( if r.ReminderMinutesBeforeStart.HasValue then r.ReminderMinutesBeforeStart.Value else 0 ); Sensitivity = r.Sensitivity; RecurrenceJSON = r.RecurrenceJSON; ModifiedOccurrencesJSON = r.ModifiedOccurrencesJSON;
                    LastOccurrenceJSON = r.LastOccurrenceJSON; IsRecurring = r.IsRecurring; IsCancelled = r.IsCancelled; ICalRecurrenceId = r.ICalRecurrenceId; 
                    FirstOccurrenceJSON = r.FirstOccurrenceJSON; 
                    DeletedOccurrencesJSON = r.DeletedOccurrencesJSON; AppointmentType = r.AppointmentType; Duration = r.Duration; StartTimeZone = r.StartTimeZone; 
                    EndTimeZone = r.EndTimeZone; AllowNewTimeProposal = r.AllowNewTimeProposal; CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; 
                    Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }
    } |> Seq.toList

let changeExchangeAppointmentExternalId(app : ExchangeAppointmentDTO, externalId : string) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeAppointments SET ExternalId = {0} WHERE InternalId = {1}", externalId, app.InternalId ) |> ignore

let setExchangeAppointmentAsUploaded(app : ExchangeAppointmentDTO) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeAppointments SET Upload = 0 WHERE InternalId = {0}", app.InternalId ) |> ignore

/////////////////////////////////////////////////////////////// FLORES

let private FloresActivityByInternalId( internalId : Guid ) = 
    query {
        for r in db().FloresActivities do
        where ( r.InternalId = internalId )
        select r
    } |> Seq.tryHead

let private FloresActivityByExternalId( externalId : string ) = 
    query {
        for r in db().FloresActivities do
        where ( r.ExternalId = externalId )
        select r
    } |> Seq.tryHead

let private copyToFloresActivity(destination : SqlConnection.ServiceTypes.FloresActivities, source : FloresActivityDTO ) =
    if destination.Id = 0  then
        destination.Id <- source.Id
    destination.ActivityType_ID <- source.ActivityType_ID
    destination.CorrectedDATE <- source.CorrectedDATE
    destination.Description <- source.Description
    destination.ExternalId <- source.ExternalId
    destination.InternalId <- source.InternalId
    destination.RealEndDate <- source.RealEndDate
    destination.RealStartDate <- source.RealStartDate
    destination.ResponsibleUser_ID <- source.ResponsibleUser_ID
    destination.SheduledEndDate <- source.SheduledEndDate
    destination.SheduledStartDate <- source.SheduledStartDate
    destination.Subject <- source.Subject
    destination.Tag <- Nullable<int>(source.Tag)
    destination.Period_ID <- source.Period_ID
    destination.Status_ID <- source.Status_ID
    destination.Division_ID <- source.Division_ID
    destination.Firm_ID <- source.Firm_ID
    destination.Person_ID <- source.Person_ID
    destination.OutlookCategory_ID <- source.OutlookCategory_ID



let saveFloresActivity( app : FloresActivityDTO, upload : bool ) = 
    let db = db()
    let possibleApp = if upload then FloresActivityByInternalId( app.InternalId ) else FloresActivityByExternalId( app.ExternalId )
    if ( box possibleApp = null ) then
        let newApp = new SqlConnection.ServiceTypes.FloresActivities()
        copyToFloresActivity(newApp, app)
        newApp.Upload <- upload
        db.FloresActivities.InsertOnSubmit newApp
    else
        copyToFloresActivity(possibleApp.Value, app)
        possibleApp.Value.Upload <- upload
    db.DataContext.SubmitChanges()

let private FloresActivitiesToUpload1() = 
    let db = db()
    query {
        for r in db.FloresActivities do
        where ( r.Upload )
(*        select { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; CorrectedDATE = r.CorrectedDATE; ActivityType_ID = r.ActivityType_ID; Description = r.Description;
                    Subject = r.Subject; SheduledStartDate = r.SheduledStartDate; SheduledEndDate = r.SheduledEndDate; RealStartDate = r.RealStartDate; RealEndDate = r.RealEndDate;
                    ResponsibleUser_ID = r.ResponsibleUser_ID; 
                    Period_ID = r.Period_ID; Status_ID = r.Status_ID; Division_ID = r.Division_ID; Firm_ID = r.Firm_ID; Person_ID = r.Person_ID; OutlookCategory_ID = r.OutlookCategory_ID;
                    Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }*)
        select r
    } |> Seq.toList 

let FloresActivitiesToUpload() : FloresActivityDTO list = 
    let activities = FloresActivitiesToUpload1()
    activities |> Seq.map ( fun r -> { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; CorrectedDATE = r.CorrectedDATE; ActivityType_ID = r.ActivityType_ID; Description = r.Description;
                    Subject = r.Subject; SheduledStartDate = r.SheduledStartDate; SheduledEndDate = r.SheduledEndDate; RealStartDate = r.RealStartDate; RealEndDate = r.RealEndDate;
                    ResponsibleUser_ID = r.ResponsibleUser_ID; 
                    Period_ID = r.Period_ID; Status_ID = r.Status_ID; Division_ID = r.Division_ID; Firm_ID = r.Firm_ID; Person_ID = r.Person_ID; OutlookCategory_ID = r.OutlookCategory_ID;
                    Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) } ) |> Seq.toList
(* 
    for r in activities do
        printfn "%A" r
        printfn "%A" { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; CorrectedDATE = r.CorrectedDATE; ActivityType_ID = r.ActivityType_ID; Description = r.Description;
                    Subject = r.Subject; SheduledStartDate = r.SheduledStartDate; SheduledEndDate = r.SheduledEndDate; RealStartDate = r.RealStartDate; RealEndDate = r.RealEndDate;
                    ResponsibleUser_ID = r.ResponsibleUser_ID; 
                    Period_ID = r.Period_ID; Status_ID = r.Status_ID; Division_ID = r.Division_ID; Firm_ID = r.Firm_ID; Person_ID = r.Person_ID; OutlookCategory_ID = r.OutlookCategory_ID;
                    Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }
    [| |] |> Seq.toList
*)

let changeFloresActivityExternalId(app : FloresActivityDTO, externalId : string) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE FloresActivities SET ExternalId = {0} WHERE InternalId = {1}", externalId, app.InternalId ) |> ignore

let setFloresActivityAsUploaded(app : FloresActivityDTO) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE FloresActivities SET Upload = 0 WHERE InternalId = {0}", app.InternalId ) |> ignore

