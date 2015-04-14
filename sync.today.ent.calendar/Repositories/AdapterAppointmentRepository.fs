module AdapterAppointmentRepository

open Common
open System
open AdapterAppointmentsSQL
open sync.today.Models

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
let winlog = log4net.LogManager.GetLogger("WinnerLog");

let AdapterAppointments( appointmentId : int ) =
    adapterAppointments( appointmentId )

let InsertOrUpdate( adapterAppointment : AdapterAppointmentDTO ) =
    insertOrUpdate( adapterAppointment, true )

let Get( id : Guid, adapterId : int ) =
    adapterAppointmentDTOByInternalId( id, adapterId )

let Update( id : Guid,  r : AdapterAppointmentDTO ) = 
    let db = adapterAppointmentDTOByInternalId( id, r.AdapterId ).Value
    let updatedAdapterAppointment = 
        { Id = db.Id; InternalId = db.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; 
        DateFrom = fixDateSecs(r.DateFrom); DateTo = fixDateSecs(r.DateTo); ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; 
        Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; 
        AppointmentId = db.AppointmentId; AdapterId = db.AdapterId; Tag = r.Tag }
    insertOrUpdate(updatedAdapterAppointment, false)

let copyAdapterAppointmentToAppointment( r : AdapterAppointmentDTO, orig:AppointmentDTO ) : AppointmentDTO =
    { Id = orig.Id; InternalId = orig.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; 
    DateTo = r.DateTo; ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; ConsumerId = orig.ConsumerId }

let copyAdapterAppointmentToNewAppointment( r : AdapterAppointmentDTO, consumerId:int ) : AppointmentDTO =
    { Id = 0; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; 
    DateTo = r.DateTo; ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; ConsumerId = consumerId }

let copyAppointmentToAdapterAppointment( r : AppointmentDTO, orig:AdapterAppointmentDTO ) : AdapterAppointmentDTO =
    { Id = orig.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; 
    DateFrom = r.DateFrom; 
    DateTo = r.DateTo; ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; AppointmentId = orig.AppointmentId; 
    AdapterId = orig.AdapterId; Tag = orig.Tag }


let insertAppointmentAndAdapterAppointments( app : AdapterAppointmentDTO, consumerId :int ) =
    let appointement = copyAdapterAppointmentToNewAppointment( app, consumerId )
    let appId = AppointmentRepository.InsertAppointment( appointement ).Id
    let adapters = AdapterRepository.Adapters()
    for adapter in adapters do
        let adApp = {app with AppointmentId=appId; AdapterId = adapter.Id  }
        InsertOrUpdate( adApp )

let getLatestModified( adaApps : AdapterAppointmentDTO[] ) : AdapterAppointmentDTO =
    let latestModifiedDate = adaApps |> Array.map ( fun p -> p.LastModified ) |> Array.max
    let result = adaApps |> Array.find( fun p -> p.LastModified = latestModifiedDate )
    winlog.Debug( sprintf "Winner choosen is %A" result )
    result

let CopyAndSaveAllFrom( appointment : AppointmentDTO ) =
    let adapterAppointments = adapterAppointments( appointment.Id )
    for adaApp in adapterAppointments do
        let updatedAdaApp = copyAppointmentToAdapterAppointment( appointment, adaApp )
        InsertOrUpdate( updatedAdaApp )
    
let FindDuplicatedAdapterAppointment( appointment : AdapterAppointmentDTO ) : AdapterAppointmentDTO option =
    let potentials = findDuplicatedAdapterAppointment( appointment )
    logger.Debug( sprintf "Searching for %A %A %A %A %A found %A"  appointment.InternalId appointment.AdapterId  appointment.DateFrom appointment.DateTo appointment.Title potentials )
    potentials

let FindAdapterAppointmentsToUpload( adapterId : int ) = 
    findAdapterAppointmentsToUpload( adapterId )

let AreStandardAttrsVisiblyDifferent( a1 : AdapterAppointmentDTO, a2 : AdapterAppointmentDTO ) : bool =
    areStandardAttrsVisiblyDifferent( a1, a2 )

let GetConsumerByAdapterAppointment( adapterAppointment : AdapterAppointmentDTO ) =
    getConsumerByAdapterAppointment( adapterAppointment )

let printContent( before : bool ) =
    let data_before = log4net.LogManager.GetLogger("adapterappointment_data_before");
    let data_after = log4net.LogManager.GetLogger("adapterappointment_data_after");
    let logger = if before then data_before else data_after
    logger.Debug("started")
    let Appointments = adapterAppointmentsAll()
    for appointment in Appointments do
        let replacedBody = if appointment.Content <> null then appointment.Content.Replace(System.Environment.NewLine, " ") else String.Empty
        logger.Info( sprintf "%A\t%A\t%A\t%A\t%A\t%A" appointment.InternalId appointment.Title appointment.DateFrom appointment.DateTo appointment.LastModified replacedBody )
    logger.Debug("done")
