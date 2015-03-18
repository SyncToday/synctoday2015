module AdapterAppointmentsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
let standardAttrsVisiblyDifferentLogger = log4net.LogManager.GetLogger( "StandardAttrsVisiblyDifferent" )

let internal convert( r  : SqlConnection.ServiceTypes.AdapterAppointments ) : AdapterAppointmentDTO = 
    { Id = r.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; DateTo = r.DateTo; 
    ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; 
    AppointmentId = r.AppointmentId; AdapterId = r.AdapterId; Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }

let internal adapterAppointments( appointmentId : int ) : AdapterAppointmentDTO list = 
    query {
        for r in db().AdapterAppointments do
        where ( r.AppointmentId = appointmentId )
        select (convert(r))
    } |> Seq.toList

let findDuplicatedAdapterAppointment( adapterAppointment: AdapterAppointmentDTO ): AdapterAppointmentDTO option = 
    let db = db()
    let appointment : AppointmentDTO = AppointmentsSQL.appointment( adapterAppointment.AppointmentId ).Value
    query {
        for r in db.AdapterAppointments do
        join s in db.Appointments on (r.AppointmentId = s.Id)
        where ( r.InternalId <> adapterAppointment.InternalId && r.AdapterId <> adapterAppointment.AdapterId &&
                r.DateFrom = adapterAppointment.DateFrom && r.DateTo = adapterAppointment.DateTo &&
                r.Title = adapterAppointment.Title && ( s.ConsumerId = appointment.ConsumerId )
        )
        select (convert(r))
    } |> Seq.tryHead

let internal adapterAppointmentByInternalIdAndAdapterId( internalId : Guid, adapterId : int ) : SqlConnection.ServiceTypes.AdapterAppointments option = 
    query {
        for r in db().AdapterAppointments do
        where ( r.InternalId  = internalId && r.AdapterId = adapterId )
        select r
    } |> Seq.tryHead

let internal adapterAppointmentDTOByInternalId( internalId : Guid, adapterId : int ) : AdapterAppointmentDTO option = 
    let res = adapterAppointmentByInternalIdAndAdapterId(internalId, adapterId)
    if res.IsNone then
        None
    else
        Some(convert(res.Value))

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
    dest.ReminderMinutesBeforeStart <- source.ReminderMinutesBeforeStart
    dest.Title <- source.Title 
    dest.AdapterId <- source.AdapterId
    dest.AppointmentId <- source.AppointmentId
    dest.Tag <- Nullable(source.Tag)

let normalize( r : AdapterAppointmentDTO ) : AdapterAppointmentDTO =
    { Id = r.Id; InternalId = r.InternalId; LastModified = fixDateSecs(r.LastModified); Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; 
    DateFrom = fixDateSecs(r.DateFrom); DateTo = fixDateSecs(r.DateTo); ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart;
    Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; 
    AppointmentId = r.AppointmentId; AdapterId = r.AdapterId; Tag = r.Tag }

let areStandardAttrsVisiblyDifferent( a1 : AdapterAppointmentDTO, a2 : AdapterAppointmentDTO ) : bool =
    let a1n = normalize( a1 )
    let a2n = normalize( a2 )
    let result = not (( a1n.Category = a2n.Category ) && ( a1n.Location = a2n.Location ) && ( a1n.Content = a2n.Content ) && ( a1n.Title = a2n.Title )
                    && ( a1n.DateFrom = a2n.DateFrom ) && ( a1n.DateTo = a2n.DateTo ) && ( a1n.ReminderMinutesBeforeStart = a2n.ReminderMinutesBeforeStart ) && ( a1n.Notification = a2n.Notification )
                    && ( a1n.IsPrivate = a2n.IsPrivate ) && ( a1n.Priority = a2n.Priority ))
    if result then
        logger.Debug( sprintf "StandardAttrsAREVisiblyDifferent for '%A' '%A'" a1n.Id a2n.Id )
        standardAttrsVisiblyDifferentLogger.Debug( sprintf "StandardAttrsAREVisiblyDifferent for '%A' '%A'" a1n a2n )
    result

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
        if areStandardAttrsVisiblyDifferent(app, convert(possibleApp.Value)) then
            copyToAdapterAppointment(possibleApp.Value, app)
            possibleApp.Value.Upload <- upload 
            let m = possibleApp.Value
            logger.Debug( sprintf "saved [%A] (%A) %A %A -> %A [%A-%A] '%A'" m.Id m.InternalId m.Title m.DateFrom m.DateTo m.AppointmentId m.AdapterId m.LastModified )
        else
            logger.Debug( sprintf "Not saving '%A' and '%A' are the same" app.Id possibleApp.Value.InternalId )
    db.DataContext.SubmitChanges()

let findAdapterAppointmentsToUpload( adapterId : int ) = 
    let db = db()
    query {
        for r in db.AdapterAppointments do
        where ( r.AdapterId = adapterId && r.Upload )
        select (convert(r))
    } |> Seq.toList
