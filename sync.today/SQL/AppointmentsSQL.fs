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
    { Id = r.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; DateTo = r.DateTo; Reminder = r.Reminder; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority }

let internal appointments()  = 
    query {
        for r in db().Appointments do
        select ( convert( r ) )
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

let internal appointmentsModifiedThroughAdapter() =
        appointments()