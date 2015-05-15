module AppointmentsSQL

open Common
open System
open FSharp.Data
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

type private GetAppointmentsQuery = SqlCommandProvider<"GetAppointments.sql", ConnectionStringName>
type private GetAppointmentsModifiedThroughAdapterQuery = SqlCommandProvider<"GetAppointmentsModifiedThroughAdapter.sql", ConnectionStringName>

let internal convert( r : GetAppointmentsQuery.Record ) : AppointmentDTO =
    { Id = r.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; 
    DateTo = r.DateTo; ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; ConsumerId = r.ConsumerId }

let internal convert2( r : GetAppointmentsModifiedThroughAdapterQuery.Record ) : AppointmentDTO =
    { Id = r.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; 
    DateTo = r.DateTo; ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; ConsumerId = r.ConsumerId }

let convertOp(c) = 
    convertOption( c, convert )

let internal appointments()  = 
    ( new GetAppointmentsQuery() ).AsyncExecute(0, Guid.Empty, 0) |> Async.RunSynchronously |> Seq.map convert

let internal appointmentsByConsumer( consumerId ) =
    ( new GetAppointmentsQuery() ).AsyncExecute(consumerId, Guid.Empty, 0) |> Async.RunSynchronously |> Seq.tryHead |> convertOp

let internal appointmentsByInternalId( internalid : Guid ) =
    ( new GetAppointmentsQuery() ).AsyncExecute(0, internalid, 0) |> Async.RunSynchronously |> Seq.tryHead |> convertOp

let appointment( Id : int ) : AppointmentDTO option =
    ( new GetAppointmentsQuery() ).AsyncExecute(0, Guid.Empty, Id) |> Async.RunSynchronously |> Seq.tryHead |> convertOp
    
#if copyToAppointment
let internal copyToAppointment(dest : SqlConnection.ServiceTypes.Appointments, source : AppointmentDTO ) =
    dest.Category <- source.Category
    dest.Content <- source.Content
    dest.DateFrom <- source.DateFrom
    dest.DateTo <- source.DateTo
    dest.IsPrivate <- source.IsPrivate
    dest.LastModified <- source.LastModified
    dest.Location <- source.Location
    dest.Notification <- source.Notification
    dest.Priority <- source.Priority
    dest.ReminderMinutesBeforeStart <- source.ReminderMinutesBeforeStart
    dest.Title <- source.Title 
    dest.ConsumerId <- source.ConsumerId

let internal insertAppointment( appointment : AppointmentDTO ) =
        let db = db()

        let newAppointment = new SqlConnection.ServiceTypes.Appointments()
        copyToAppointment( newAppointment, appointment )
        newAppointment.InternalId <- appointment.InternalId
        newAppointment.LastModified <- DateTime.Now

        db.Appointments.InsertOnSubmit newAppointment
        db.DataContext.SubmitChanges()
        convert(newAppointment)
    
let saveAppointment( app : AppointmentDTO ) = 
    let db = db()
    // unable to refactor query to a method, do not know how to pass db - the type is generated dynamically
    let possibleApp= 
        query {
            for r in db.Appointments do
            where ( r.InternalId = app.InternalId )
            select r
        } |> Seq.tryHead
    if ( box possibleApp = null ) then
        let newApp = new SqlConnection.ServiceTypes.Appointments()
        copyToAppointment(newApp, app)
        newApp.InternalId <- app.InternalId

        db.Appointments.InsertOnSubmit newApp
    else
        copyToAppointment(possibleApp.Value, app)
    db.DataContext.SubmitChanges()
#endif

let internal appointmentsModifiedThroughAdapter(forConsumer : ConsumerDTO, lastModified : DateTime) =
    ( new GetAppointmentsModifiedThroughAdapterQuery() ).AsyncExecute(forConsumer.Id, lastModified) |> Async.RunSynchronously |> Seq.map convert2
