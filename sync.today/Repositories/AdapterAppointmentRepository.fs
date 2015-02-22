module AdapterAppointmentRepository

open Common
open System
open AdapterAppointmentsSQL
open sync.today.Models

let AdapterAppointments( appointmentId : int ) =
    adapterAppointments( appointmentId )

let InsertOrUpdate( adapterAppointment : AdapterAppointmentDTO ) =
    insertOrUpdate( adapterAppointment, true )

let Get( id : Guid ) =
    adapterAppointmentDTOByInternalId( id )

let normalize( r : AdapterAppointmentDTO ) : AdapterAppointmentDTO =
    { Id = r.Id; InternalId = r.InternalId; LastModified = fixDateSecs(r.LastModified); Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; 
    DateFrom = fixDateSecs(r.DateFrom); DateTo = fixDateSecs(r.DateTo); Reminder = ( if r.Reminder.HasValue then Nullable(fixDateSecs(r.Reminder.Value)) else Nullable() ); 
    Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; 
    AppointmentId = r.AppointmentId; AdapterId = r.AdapterId; ServiceAccountId = r.ServiceAccountId; Tag = r.Tag }

let areStandardAttrsVisiblyDifferent( a1 : AdapterAppointmentDTO, a2 : AdapterAppointmentDTO ) : bool =
    let a1n = normalize( a1 )
    let a2n = normalize( a2 )
    ( a1n.Category = a2n.Category ) && ( a1n.Location = a1n.Location ) && ( a1n.Content = a1n.Content ) && ( a1n.Title = a1n.Title )
    && ( a1n.DateFrom = a2n.DateFrom ) && ( a1n.DateTo = a2n.DateTo ) && ( a1n.Reminder = a2n.Reminder ) && ( a1n.Notification = a2n.Notification )
    && ( a1n.IsPrivate = a2n.IsPrivate ) && ( a1n.Priority = a2n.Priority )

let Update( id : Guid,  r : AdapterAppointmentDTO ) = 
    let db = adapterAppointmentDTOByInternalId( id ).Value
    let updatedAdapterAppointment = 
        { Id = db.Id; InternalId = db.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; 
        DateFrom = fixDateSecs(r.DateFrom); DateTo = fixDateSecs(r.DateTo); Reminder = ( if r.Reminder.HasValue then Nullable(fixDateSecs(r.Reminder.Value)) else Nullable() ); 
        Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; 
        AppointmentId = db.AppointmentId; AdapterId = db.AdapterId; ServiceAccountId = db.ServiceAccountId; Tag = r.Tag }
    insertOrUpdate(updatedAdapterAppointment, false)