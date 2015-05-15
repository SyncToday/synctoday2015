module AdapterAppointmentsSQL

open Common
open System
open FSharp.Data
open sync.today.Models
open MainDataConnection

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
let standardAttrsVisiblyDifferentLogger = log4net.LogManager.GetLogger( "StandardAttrsVisiblyDifferent" )
let ignlog = log4net.LogManager.GetLogger( "IgnoreLog" )

type private GetAdapterAppointmentsQuery = SqlCommandProvider<"GetAdapterAppointments.sql", ConnectionStringName>
type private FindDuplicatedAdapterAppointmentQuery = SqlCommandProvider<"FindDuplicatedAdapterAppointment.sql", ConnectionStringName>
type private InsertOrUpdateAdapterAppointmentQuery = SqlCommandProvider<"InsertOrUpdateAdapterAppointment.sql", ConnectionStringName>

let internal convert( r  : GetAdapterAppointmentsQuery.Record ) : AdapterAppointmentDTO = 
    { Id = r.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; DateTo = r.DateTo; 
    ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; 
    AppointmentId = r.AppointmentId; AdapterId = r.AdapterId; Tag = r.Tag }

let internal convert2( r  : FindDuplicatedAdapterAppointmentQuery.Record ) : AdapterAppointmentDTO = 
    { Id = r.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; DateTo = r.DateTo; 
    ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; 
    AppointmentId = r.AppointmentId; AdapterId = r.AdapterId; Tag = r.Tag }

let internal convert3( r  : InsertOrUpdateAdapterAppointmentQuery.Record ) : AdapterAppointmentDTO = 
    { Id = r.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; DateTo = r.DateTo; 
    ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; 
    AppointmentId = r.AppointmentId; AdapterId = r.AdapterId; Tag = r.Tag }

let convertOp(c) = 
    convertOption( c, convert )

let convertOp2(c) = 
    convertOption( c, convert2 )

let convertOp3(c) = 
    convertOption( c, convert3 )

let internal adapterAppointments( appointmentId : int ) = 
    ( new GetAdapterAppointmentsQuery() ).AsyncExecute(appointmentId, Guid.Empty, 0, 0, -1) |> Async.RunSynchronously |> Seq.map convert

let internal adapterAppointmentsAll() = 
    ( new GetAdapterAppointmentsQuery() ).AsyncExecute(0, Guid.Empty, 0, 0, -1) |> Async.RunSynchronously |> Seq.map convert

let internal adapterAppointmentDTOByInternalId( internalId : Guid, adapterId : int ) : AdapterAppointmentDTO option = 
    ( new GetAdapterAppointmentsQuery() ).AsyncExecute(0, internalId, adapterId, 0, -1) |> Async.RunSynchronously |> Seq.tryHead |> convertOp


let findDuplicatedAdapterAppointment( adapterAppointment: AdapterAppointmentDTO ): AdapterAppointmentDTO option = 
    ( new FindDuplicatedAdapterAppointmentQuery() ).AsyncExecute(adapterAppointment.Id) |> Async.RunSynchronously |> Seq.tryHead |> convertOp2


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
        devlog.Debug( sprintf "StandardAttrsAREVisiblyDifferent for '%A' '%A'" a1n.Id a2n.Id )
        standardAttrsVisiblyDifferentLogger.Debug( sprintf "StandardAttrsAREVisiblyDifferent for '%A' '%A'" a1n a2n )
    result

let insertOrUpdate( app : AdapterAppointmentDTO, upload : bool ) =
    ( new InsertOrUpdateAdapterAppointmentQuery() ).AsyncExecute( app.InternalId, app.AdapterId, app.LastModified,
                                                                  optionString2String app.Category, 
                                                                  optionString2String app.Location, 
                                                                  optionString2String app.Content, 
                                                                  optionString2String app.Title, app.DateFrom, 
                                                                  app.DateTo, app.ReminderMinutesBeforeStart, app.Notification, 
                                                                  app.IsPrivate,
                                                                  app.Priority, app.AppointmentId, 
                                                                  ( if app.Tag.IsNone then 0 else app.Tag.Value ), 
                                                                  upload 
                                                    ) |> Async.RunSynchronously |> Seq.tryHead |> convertOp3

let findAdapterAppointmentsToUpload( adapterId : int ) = 
    ( new GetAdapterAppointmentsQuery() ).AsyncExecute(0, Guid.Empty, adapterId, 0, 1) |> Async.RunSynchronously |> Seq.map convert

let internal convert3( r : SqlConnection.ServiceTypes.Consumers ) : ConsumerDTO =
    { Id = r.Id; Name = r.Name }

let getConsumerByAdapterAppointment( adapterAppointment : AdapterAppointmentDTO ) =
    //ConsumersSQL.consumer(AppointmentRepository.Appointment(AdapterAppointment.AppointmentId).Value.ConsumerId).Value
    let db = db()
    query {
        for r in db.Consumers do
        join v in db.Appointments on ( r.Id = v.ConsumerId )
        where ( v.Id = adapterAppointment.AppointmentId )
        select ( convert3(r) )
    } |> Seq.tryHead
