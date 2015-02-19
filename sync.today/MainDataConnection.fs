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

let saveExchangeAppointment( app : ExchangeAppointmentDTO ) = 
    let db = db()
    let possibleApp = ExchangeAppointmentsByExternalId( db, app.ExternalId )
    if ( box possibleApp = null ) then
        0 |> ignore
    else
        0 |> ignore
    db.DataContext.SubmitChanges()
        