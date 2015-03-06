module AdapterAppointmentsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let internal convert( r  : SqlConnection.ServiceTypes.AdapterAppointments ) : AdapterAppointmentDTO = 
    { Id = r.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; DateTo = r.DateTo; Reminder = r.Reminder; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; 
    AppointmentId = r.AppointmentId; AdapterId = r.AdapterId; Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }

let internal adapterAppointments( appointmentId : int ) : AdapterAppointmentDTO list = 
    query {
        for r in db().AdapterAppointments do
        where ( r.AppointmentId = appointmentId )
        select (convert(r))
    } |> Seq.toList

let findDuplicatedAdapterAppointment( appointment: AdapterAppointmentDTO ): AdapterAppointmentDTO option = 
    query {
        for r in db().AdapterAppointments do
        where ( r.InternalId <> appointment.InternalId && r.AdapterId <> appointment.AdapterId &&
                r.DateFrom = appointment.DateFrom && r.DateTo = appointment.DateTo &&
                r.Title = appointment.Title
        )
        select (convert(r))
    } |> Seq.tryHead

let internal adapterAppointmentByInternalIdAndAdapterId( internalId : Guid, adapterId : int ) : SqlConnection.ServiceTypes.AdapterAppointments option = 
    query {
        for r in db().AdapterAppointments do
        where ( r.InternalId  = internalId && r.AdapterId = adapterId )
        select r
    } |> Seq.tryHead

let internal adapterAppointmentDTOByInternalId( internalId : Guid ) : AdapterAppointmentDTO option = 
    query {
        for r in db().AdapterAppointments do
        where ( r.InternalId  = internalId )
        select (convert(r))
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
    dest.Tag <- Nullable(source.Tag)

let normalize( r : AdapterAppointmentDTO ) : AdapterAppointmentDTO =
    { Id = r.Id; InternalId = r.InternalId; LastModified = fixDateSecs(r.LastModified); Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; 
    DateFrom = fixDateSecs(r.DateFrom); DateTo = fixDateSecs(r.DateTo); Reminder = ( if r.Reminder.HasValue then Nullable(fixDateSecs(r.Reminder.Value)) else r.Reminder ); 
    Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; 
    AppointmentId = r.AppointmentId; AdapterId = r.AdapterId; Tag = r.Tag }

let areStandardAttrsVisiblyDifferent( a1 : AdapterAppointmentDTO, a2 : AdapterAppointmentDTO ) : bool =
    let a1n = normalize( a1 )
    let a2n = normalize( a2 )
    not (( a1n.Category = a2n.Category ) && ( a1n.Location = a1n.Location ) && ( a1n.Content = a1n.Content ) && ( a1n.Title = a1n.Title )
    && ( a1n.DateFrom = a2n.DateFrom ) && ( a1n.DateTo = a2n.DateTo ) && ( a1n.Reminder = a2n.Reminder ) && ( a1n.Notification = a2n.Notification )
    && ( a1n.IsPrivate = a2n.IsPrivate ) && ( a1n.Priority = a2n.Priority ))

let insertOrUpdate( app : AdapterAppointmentDTO, upload : bool ) =
    let db = db()
    let possibleApp = 
        query {
            for r in db.AdapterAppointments do
            where ( r.InternalId  = app.InternalId && r.AdapterId = app.AdapterId )
            select r
        } |> Seq.tryHead

    if ( box possibleApp = null ) then
        let newApp = new SqlConnection.ServiceTypes.AdapterAppointments()
        copyToAdapterAppointment(newApp, app)
        newApp.InternalId <- app.InternalId
        newApp.LastModified <- DateTime.Now
        newApp.Upload <- upload
        db.AdapterAppointments.InsertOnSubmit newApp
    else
        if areStandardAttrsVisiblyDifferent(normalize(app), normalize(convert(possibleApp.Value))) then
            copyToAdapterAppointment(possibleApp.Value, app)
            possibleApp.Value.Upload <- upload 
    db.DataContext.SubmitChanges()

let findAdapterAppointmentsToUpload( adapterId : int ) = 
    let db = db()
    query {
        for r in db.AdapterAppointments do
        where ( r.AdapterId = adapterId && r.Upload )
        select (convert(r))
    } |> Seq.toList
