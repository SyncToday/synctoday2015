module AdapterAppointmentRepository

open Common
open System
open AdapterAppointmentsSQL
open sync.today.Models
open FSharp.Data

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
    let appId = AppointmentRepository.InsertOrUpdate( appointement ).Value.Id
    let adapters = AdapterRepository.Adapters()
    for adapter in adapters do
        let adApp = {app with AppointmentId=appId; AdapterId = adapter.Id  }
        InsertOrUpdate( adApp ) |> ignore

let getLatestModified( adaApps : AdapterAppointmentDTO[] ) : AdapterAppointmentDTO =
    let latestModifiedDate = adaApps |> Array.map ( fun p -> p.LastModified ) |> Array.max
    let result = adaApps |> Array.find( fun p -> p.LastModified = latestModifiedDate )
    winlog.Debug( sprintf "Winner choosen is %A" result )
    result

let CopyAndSaveAllFrom( appointment : AppointmentDTO ) =
    let adapterAppointments = adapterAppointments( appointment.Id )
    for adaApp in adapterAppointments do
        let updatedAdaApp = copyAppointmentToAdapterAppointment( appointment, adaApp )
        InsertOrUpdate( updatedAdaApp ) |> ignore
    
let FindDuplicatedAdapterAppointment( appointment : AdapterAppointmentDTO ) : AdapterAppointmentDTO option =
    let potentials = findDuplicatedAdapterAppointment( appointment )
    devlog.Debug( sprintf "Searching for %A %A %A %A %A found %A"  appointment.InternalId appointment.AdapterId  appointment.DateFrom appointment.DateTo appointment.Title potentials )
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
        let replacedBody = if appointment.Content.IsSome then appointment.Content.Value.Replace(System.Environment.NewLine, " ") else String.Empty
        logger.Info( sprintf "%A\t%A\t%A\t%A\t%A\t%A" appointment.InternalId appointment.Title appointment.DateFrom appointment.DateTo appointment.LastModified replacedBody )
    logger.Debug("done")


type private getAdapterAppointmentChangesQuery = SqlCommandProvider<"GetAdapterAppointmentChanges.sql", ConnectionStringName>

let internal convert( r : getAdapterAppointmentChangesQuery.Record ) : AdapterAppointmentChanges = 
    { InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom;
      DateTo = r.DateTo; ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Notification = r.Notification;  IsPrivate = r.IsPrivate; Priority = r.Priority;   }


let convertOp(c) = 
    convertOption( c, convert )


let getAdapterAppointmentChanges( adaApps : AdapterAppointmentDTO ) =
    ( new getAdapterAppointmentChangesQuery() ).AsyncExecute(adaApps.Id) |> Async.RunSynchronously |> Seq.tryHead |> convertOp

let mergeAttribute( a1, a1modified : DateTime, a2, a2modified : DateTime ) =
    match (a1, a2) with
    | ( None, None ) -> None
    | Some(a1s), None -> Some(a1s)
    | None, Some(a1s) -> Some(a1s)
    | Some(a1s), Some(a2s) -> if a1modified > a2modified then Some(a1s) else Some(a2s)

let intMerge(accVal : AdapterAppointmentDTO, elemVal : AdapterAppointmentChanges) : AdapterAppointmentDTO =
    {  Id = accVal.Id; InternalId = elemVal.InternalId; LastModified = if accVal.LastModified > elemVal.LastModified then accVal.LastModified else elemVal.LastModified;
       Category =  mergeAttribute( accVal.Category, accVal.LastModified, elemVal.Category, elemVal.LastModified );
       Location =  mergeAttribute( accVal.Location, accVal.LastModified, elemVal.Location, elemVal.LastModified );
       Content =  mergeAttribute( accVal.Content, accVal.LastModified, elemVal.Content, elemVal.LastModified );
       Title =  mergeAttribute( accVal.Title, accVal.LastModified, elemVal.Title, elemVal.LastModified );
       DateFrom =  mergeAttribute( Some(accVal.DateFrom), accVal.LastModified, elemVal.DateFrom, elemVal.LastModified ).Value;
       DateTo =  mergeAttribute( Some(accVal.DateTo), accVal.LastModified, elemVal.DateTo, elemVal.LastModified ).Value;
       ReminderMinutesBeforeStart =  mergeAttribute( Some(accVal.ReminderMinutesBeforeStart), accVal.LastModified, elemVal.ReminderMinutesBeforeStart, elemVal.LastModified ).Value;
       Notification =  mergeAttribute( Some(accVal.Notification), accVal.LastModified, elemVal.Notification, elemVal.LastModified ).Value;
       IsPrivate =  mergeAttribute( Some(accVal.IsPrivate), accVal.LastModified, elemVal.IsPrivate, elemVal.LastModified ).Value;
       Priority =  mergeAttribute( Some(accVal.Priority), accVal.LastModified, elemVal.Priority, elemVal.LastModified ).Value;
       AppointmentId = accVal.AppointmentId; AdapterId = accVal.AdapterId; Tag = accVal.Tag; 
    }


let merge( adaApps : AdapterAppointmentDTO[] ) : AdapterAppointmentDTO =
    let changes = adaApps |> Seq.map ( fun p -> getAdapterAppointmentChanges( p ) )
    let mergedChanges = 
        changes |> 
        Seq.reduce( 
            fun acc elem -> 
                let accVal = acc.Value
                let elemVal = elem.Value
                Some( {  InternalId = elemVal.InternalId; LastModified = if accVal.LastModified > elemVal.LastModified then accVal.LastModified else elemVal.LastModified;
                         Category =  mergeAttribute( accVal.Category, accVal.LastModified, elemVal.Category, elemVal.LastModified );
                         Location =  mergeAttribute( accVal.Location, accVal.LastModified, elemVal.Location, elemVal.LastModified );
                         Content =  mergeAttribute( accVal.Content, accVal.LastModified, elemVal.Content, elemVal.LastModified );
                         Title =  mergeAttribute( accVal.Title, accVal.LastModified, elemVal.Title, elemVal.LastModified );
                         DateFrom =  mergeAttribute( accVal.DateFrom, accVal.LastModified, elemVal.DateFrom, elemVal.LastModified );
                         DateTo =  mergeAttribute( accVal.DateTo, accVal.LastModified, elemVal.DateTo, elemVal.LastModified );
                         ReminderMinutesBeforeStart =  mergeAttribute( accVal.ReminderMinutesBeforeStart, accVal.LastModified, elemVal.ReminderMinutesBeforeStart, elemVal.LastModified );
                         Notification =  mergeAttribute( accVal.Notification, accVal.LastModified, elemVal.Notification, elemVal.LastModified );
                         IsPrivate =  mergeAttribute( accVal.IsPrivate, accVal.LastModified, elemVal.IsPrivate, elemVal.LastModified );
                         Priority =  mergeAttribute( accVal.Priority, accVal.LastModified, elemVal.Priority, elemVal.LastModified );
                } )
        )
    let latestModifiedDate = adaApps |> Array.map ( fun p -> p.LastModified ) |> Array.max
    let latestResult = adaApps |> Array.find( fun p -> p.LastModified = latestModifiedDate )
    let result = intMerge( latestResult, mergedChanges.Value )

    winlog.Debug( sprintf "winner choosen is %A" result )
    result

type private save2OldAdapterAppointmentsQuery = SqlCommandProvider<"Save2OldAdapterAppointments.sql", ConnectionStringName>

let save2OldAdapterAppointments() =
    ( new save2OldAdapterAppointmentsQuery() ).AsyncExecute() |> Async.RunSynchronously


