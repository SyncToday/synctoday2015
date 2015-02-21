module AdapterAppointmentsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let internal adapterAppointments( appointmentId : int ) = 
    query {
        for r in db().AdapterAppointments do
        where ( r.AppointmentId = appointmentId )
        select { Id = r.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; DateTo = r.DateTo; Reminder = r.Reminder; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; 
                    AppointmentId = r.AppointmentId; AdapterId = r.AdapterId; ServiceAccountId = r.ServiceAccountId; Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }
    } |> Seq.toList

let internal adapterAppointmentByInternalId( internalId : Guid ) = 
    query {
        for r in db().AdapterAppointments do
        where ( r.InternalId  = internalId )
        select r
    } |> Seq.tryHead

let internal adapterAppointmentDTOByInternalId( internalId : Guid ) = 
    query {
        for r in db().AdapterAppointments do
        where ( r.InternalId  = internalId )
        select { Id = r.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; DateTo = r.DateTo; Reminder = r.Reminder; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; 
                    AppointmentId = r.AppointmentId; AdapterId = r.AdapterId; ServiceAccountId = r.ServiceAccountId; Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }
    } |> Seq.tryHead

let internal copyToAdapterAppointment(dest : SqlConnection.ServiceTypes.AdapterAppointments, source : AdapterAppointmentDTO ) =
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
    dest.AdapterId <- source.AdapterId
    dest.AppointmentId <- source.AppointmentId
    dest.ServiceAccountId <- source.ServiceAccountId
    dest.Tag <- Nullable(source.Tag)

let insertOrUpdate( app : AdapterAppointmentDTO, upload : bool ) =
    let db = db()
    let possibleApp = adapterAppointmentByInternalId( app.InternalId )
    if ( box possibleApp = null ) then
        let newApp = new SqlConnection.ServiceTypes.AdapterAppointments()
        copyToAdapterAppointment(newApp, app)
        newApp.Upload <- upload
        db.AdapterAppointments.InsertOnSubmit newApp
    else
        copyToAdapterAppointment(possibleApp.Value, app)
        possibleApp.Value.Upload <- upload
    db.DataContext.SubmitChanges()
