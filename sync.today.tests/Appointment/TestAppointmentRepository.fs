module TestAppointmentRepository

open System
open NUnit.Framework
open FsUnit
open System.Threading.Tasks
open sync.today.Models
open ConsumersSQL
open MainDataConnection
open ServicesSQL
open AdaptersSQL

[<TestFixture>] 
type ``appointment persistence`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    let emptyAppointment : AppointmentDTO  = 
        { Id = -1; InternalId = Guid.NewGuid(); LastModified = DateTime.Now; Category="";Location="";Content="";Title=""; DateFrom=DateTime.Now; DateTo=DateTime.Now; Reminder=Nullable<DateTime>(); Notification=false; IsPrivate=false; Priority=byte 0; ConsumerId = 1}

    let serviceKey = "Key"
    let serviceId() = 
        serviceByKey( serviceKey ).Value.Id

    let adapterName = "Adapter Name"
    let adapterId() = 
        adapterByName( adapterName ).Value.Id

    [<TestFixtureSetUp>] 
    member x.``Log Test At the beginning`` ()=         
            logger.Info("Test")

    [<SetUp>] 
    member x.``empty and prepare database`` ()=         
            logger.Info("Entered")
            let seed = new Oak.Seed()
            seed.PurgeDb()
            let schema = new CreateDB.Schema(seed)
            for s in schema.Scripts() do 
                let sql = s.Invoke()
                seed.ExecuteNonQuery( sql )
            logger.Info("Structure done ")
            insertService( { Id = 0; Key = serviceKey; Name = "Name" } ) |> ignore
            let adapterId = insertAdapter( { Id = 0; Name = adapterName } )
            let accountId = insertAccount( { Id = 0; Name = "Name" } )
            let serviceAccountId = insertServiceAccount({Id = 0; LoginJSON = ""; ServiceId = serviceId(); AccountId = accountId; LastSuccessfulDownload = Nullable(DateTime.Now); LastDownloadAttempt = Nullable(); LastSuccessfulUpload = Nullable(); LastUploadAttempt = Nullable(); })
            let consumerId = insertConsumer( { Id = 0; Name = "Name" } )
            logger.Info("Sample data done")


    [<Test>] 
    member x.``when I ask for appointments it should not be Null.`` ()=
            AppointmentRepository.Appointments() |> should not' (be Null)

    [<Test>] 
    member x.``when I ask for appointments it should have zero members first.`` ()=
             AppointmentRepository.Appointments().IsEmpty |> should be True

    [<Test>] 
    member x.``when I ask for appointments and insert one it should have more then zero members.`` ()=
             let appointment : AppointmentDTO = emptyAppointment
             AppointmentRepository.InsertAppointment( appointment ) |> ignore
             AppointmentRepository.Appointments().IsEmpty |> should not' (be True)

    [<Test>] 
    member x.``multithreaded appointments saving should work.`` () =
             let appointment : AppointmentDTO = emptyAppointment
             Parallel.ForEach([1;2], fun x-> 
                                        AppointmentRepository.InsertAppointment( appointment ) |> ignore
                                        AppointmentRepository.Appointments().IsEmpty |> should not' (be True)
                                        ) |> ignore            

    [<Test>] 
    member x.``when I create appointment and adapter appointments, they should be connected`` ()=
            let internalId = Guid.NewGuid()
            let appointment : AppointmentDTO = emptyAppointment
            let appId = AppointmentRepository.InsertAppointment( appointment )
            AppointmentRepository.Appointments().IsEmpty |> should not' (be True)
            let appointmentAdapter : AdapterAppointmentDTO = { Id = -1; InternalId = internalId; LastModified = DateTime.Now; Category="";Location="";Content="";Title=""; DateFrom=DateTime.Now; DateTo=DateTime.Now; Reminder=Nullable<DateTime>(); Notification=false; IsPrivate=false; Priority=byte 0; AppointmentId = appId; AdapterId = adapterId(); Tag = 0}
            AdapterAppointmentRepository.InsertOrUpdate(appointmentAdapter)


    [<Test>] 
    member x.``when I create appointment and search among adapter appointments, they should be connected`` ()=
            let serviceId1 = insertService( { Id = 0; Key = "Key1"; Name = "Name1" } )
            let serviceId2 = insertService( { Id = 0; Key = "Key2"; Name = "Name2" } )
            let adapterId1 = insertAdapter( { Id = 0; Name = "Name1" } )
            let adapterId2 = insertAdapter( { Id = 0; Name = "Name2" } )
            let accountId1 = MainDataConnection.insertAccount( { Id = 0; Name = "Name1" } )
            let accountId2 = MainDataConnection.insertAccount( { Id = 0; Name = "Name2" } )
            let serviceAccountId1 = MainDataConnection.insertServiceAccount({Id = 0; LoginJSON = ""; ServiceId = serviceId1; AccountId = accountId1; LastSuccessfulDownload = Nullable(DateTime.Now); LastDownloadAttempt = Nullable(); LastSuccessfulUpload = Nullable(); LastUploadAttempt = Nullable(); })
            let serviceAccountId2 = MainDataConnection.insertServiceAccount({Id = 0; LoginJSON = ""; ServiceId = serviceId2; AccountId = accountId2; LastSuccessfulDownload = Nullable(DateTime.Now); LastDownloadAttempt = Nullable(); LastSuccessfulUpload = Nullable(); LastUploadAttempt = Nullable(); })
            let consumerId = insertConsumer( { Id = 0; Name = "Name" } )

            let internalId = Guid.NewGuid()
            let appointment : AppointmentDTO = emptyAppointment
            let appId = AppointmentRepository.InsertAppointment( appointment )
            AppointmentRepository.Appointments().IsEmpty |> should not' (be True)
            let appointmentAdapter1 : AdapterAppointmentDTO = { Id = -1; InternalId = internalId; LastModified = DateTime.Now; Category="";Location="";Content="";Title=""; 
                                                                DateFrom=DateTime.Now; DateTo=DateTime.Now; Reminder=Nullable<DateTime>(); Notification=false; IsPrivate=false; 
                                                                Priority=byte 0; AppointmentId = appId; AdapterId = adapterId1; Tag = 0}
            AdapterAppointmentRepository.InsertOrUpdate(appointmentAdapter1)
            let appointmentAdapter2 : AdapterAppointmentDTO = { Id = -1; InternalId = internalId; LastModified = DateTime.Now; Category="";Location="";Content="";Title=""; 
                                                                DateFrom=DateTime.Now; DateTo=DateTime.Now; Reminder=Nullable<DateTime>(); Notification=false; IsPrivate=false; 
                                                                Priority=byte 0; AppointmentId = appId; AdapterId = adapterId2; Tag = 0}
            AdapterAppointmentRepository.InsertOrUpdate(appointmentAdapter2)
            let adapterAppointments = AdapterAppointmentRepository.AdapterAppointments(appId) 
            adapterAppointments  |> should not' (be Null)
            adapterAppointments.Length |> should equal 2

