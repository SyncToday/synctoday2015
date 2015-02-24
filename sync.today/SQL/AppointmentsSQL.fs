module AppointmentsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let internal convert( r : SqlConnection.ServiceTypes.Appointments ) : AppointmentDTO =
    { Id = r.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; 
    DateTo = r.DateTo; Reminder = r.Reminder; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; ConsumerId = r.ConsumerId }

let internal appointments()  = 
    query {
        for r in db().Appointments do
        select ( convert( r ) )
    } |> Seq.toList

let internal appointmentsByConsumer( consumerId ) =
    query {
        for r in db().Appointments do
        where ( r.ConsumerId = consumerId ) 
        select ( convert( r ) )
    } |> Seq.toList

let internal appointmentsByInternalId( internalid : Guid ) =
    query {
        for r in db().Appointments do
        where ( r.InternalId = internalid )
        select r
    } |> Seq.tryHead
    
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
    dest.Reminder <- source.Reminder
    dest.Title <- source.Title 
    dest.ConsumerId <- source.ConsumerId

let internal insertAppointment( appointment : AppointmentDTO ) =
        let db = db()

        let newAppointment = new SqlConnection.ServiceTypes.Appointments()
        copyToAppointment( newAppointment, appointment )
        newAppointment.InternalId <- appointment.InternalId

        db.Appointments.InsertOnSubmit newAppointment
        db.DataContext.SubmitChanges()
        newAppointment.Id
    
let internal appointmentsModifiedThroughAdapter() =
        appointments()

let saveAppointment( app : AppointmentDTO ) = 
    let db = db()
    let possibleApp = appointmentsByInternalId( app.InternalId ) 
    if ( box possibleApp = null ) then
        let newApp = new SqlConnection.ServiceTypes.Appointments()
        copyToAppointment(newApp, app)
        newApp.InternalId <- app.InternalId

        db.Appointments.InsertOnSubmit newApp
    else
        copyToAppointment(possibleApp.Value, app)
    db.DataContext.SubmitChanges()
