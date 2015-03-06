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
open AdapterAppointmentRepository
open Common
open ServiceAccountsSQL
open AccountsSQL
open AdapterAppointmentsSQL

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
            insertServiceRetId( { Id = 0; Key = serviceKey; Name = "Name" } ) |> ignore
            let adapterId = insertAdapterRetId( { Id = 0; Name = adapterName } )
            let accountId = insertAccount( { Id = 0; Name = "Name"; ConsumerId = Nullable() } )
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
            let appId = AppointmentRepository.InsertAppointment( appointment ).Id
            AppointmentRepository.Appointments().IsEmpty |> should not' (be True)
            let appointmentAdapter : AdapterAppointmentDTO = { Id = -1; InternalId = internalId; LastModified = DateTime.Now; Category="";Location="";Content="";Title=""; DateFrom=DateTime.Now; DateTo=DateTime.Now; Reminder=Nullable<DateTime>(); Notification=false; IsPrivate=false; Priority=byte 0; AppointmentId = appId; AdapterId = adapterId(); Tag = 0}
            AdapterAppointmentRepository.InsertOrUpdate(appointmentAdapter)

    [<Test>] 
    member x.``when I save an appointment and load it back, they should be same.`` ()=
             let TestTitle = "TestTitle"
             let appointment : AppointmentDTO = { emptyAppointment with Title = TestTitle }
             AppointmentRepository.InsertAppointment( appointment ) |> ignore
             let appointments = AppointmentRepository.Appointments()
             appointments.IsEmpty |> should not' (be True)
             appointments.Length |> should equal 1
             let app = appointments.[0]
             app |> should not' (be Null)
             app.Title |> should equal TestTitle

    [<Test>] 
    member x.``when I save an appointment, load it back , they should be same.`` ()=
             let TestTitle = "TestTitle"
             let appointment : AppointmentDTO = { emptyAppointment with Title = TestTitle }
             AppointmentRepository.InsertOrUpdate(appointment)
             let appointments = AppointmentRepository.Appointments()
             appointments.IsEmpty |> should not' (be True)
             appointments.Length |> should equal 1
             let app = appointments.[0]
             app |> should not' (be Null)
             app.Title |> should equal TestTitle
             let TestTitle2 = "TestTitle2"
             let app2 : AppointmentDTO = { app with Title = TestTitle2 }
             AppointmentRepository.InsertOrUpdate(app2)
             let appointments2 = AppointmentRepository.Appointments()
             appointments2.IsEmpty |> should not' (be True)
             appointments2.Length |> should equal 1
             let app2 = appointments2.[0]
             app2 |> should not' (be Null)
             app2.Title |> should equal TestTitle2

    [<Test>] 
    member x.``when I create appointment, change adapter appointment value and sync, the changes will be propageted`` ()=
            let serviceId1 = insertServiceRetId( { Id = 0; Key = "Key1"; Name = "Name1" } )
            let serviceId2 = insertServiceRetId( { Id = 0; Key = "Key2"; Name = "Name2" } )
            let adapterId1 = insertAdapterRetId( { Id = 0; Name = "Name1" } )
            let adapterId2 = insertAdapterRetId( { Id = 0; Name = "Name2" } )
            let accountId1 = insertAccount( { Id = 0; Name = "Name1"; ConsumerId = Nullable() } )
            let accountId2 = insertAccount( { Id = 0; Name = "Name2"; ConsumerId = Nullable() } )
            let serviceAccountId1 = insertServiceAccount({Id = 0; LoginJSON = ""; ServiceId = serviceId1; AccountId = accountId1; LastSuccessfulDownload = Nullable(DateTime.Now); LastDownloadAttempt = Nullable(); LastSuccessfulUpload = Nullable(); LastUploadAttempt = Nullable(); })
            let serviceAccountId2 = insertServiceAccount({Id = 0; LoginJSON = ""; ServiceId = serviceId2; AccountId = accountId2; LastSuccessfulDownload = Nullable(DateTime.Now); LastDownloadAttempt = Nullable(); LastSuccessfulUpload = Nullable(); LastUploadAttempt = Nullable(); })
            let consumerId = insertConsumer( { Id = 0; Name = "Name" } )

            let internalId = Guid.NewGuid()
            let appointment : AppointmentDTO = { emptyAppointment with InternalId = internalId }
            let app = AppointmentRepository.InsertAppointment( appointment)
            let appId = app.Id
            AppointmentRepository.Appointments().IsEmpty |> should not' (be True)
            AppointmentRepository.Appointments().Length |> should equal 1
            let appointmentAdapter1 : AdapterAppointmentDTO = { Id = -1; InternalId = internalId; LastModified = DateTime.Now.AddDays(-10.0); Category="C1";Location="L1";
                                                                Content="CO1";Title="T1"; 
                                                                DateFrom=DateTime.Now.AddHours(-5.5); DateTo=DateTime.Now.AddHours(-4.5); Reminder=Nullable<DateTime>(); Notification=false; IsPrivate=false; 
                                                                Priority=byte 0; AppointmentId = appId; AdapterId = adapterId1; Tag = 1}
            AdapterAppointmentRepository.InsertOrUpdate(appointmentAdapter1)
            let appointmentAdapter2 : AdapterAppointmentDTO = { Id = -1; InternalId = internalId; LastModified = DateTime.Now; Category="C2";Location="L2";Content="CO2";Title="T2"; 
                                                                DateFrom=DateTime.Now; DateTo=DateTime.Now; Reminder=Nullable<DateTime>(); Notification=true; IsPrivate=true; 
                                                                Priority=byte 0; AppointmentId = appId; AdapterId = adapterId2; Tag = 2}
            AdapterAppointmentRepository.InsertOrUpdate(appointmentAdapter2)
            let adapterAppointments = AdapterAppointmentRepository.AdapterAppointments(appId) 
            adapterAppointments  |> should not' (be Null)
            adapterAppointments.Length |> should equal 2

            appointment.InternalId |> should equal appointmentAdapter1.InternalId 
            appointment.InternalId |> should equal appointmentAdapter2.InternalId 

            let latestModifiedAdapterAppointment = getLatestModified( List.toArray adapterAppointments )
            latestModifiedAdapterAppointment |> should not' (be Null)
            latestModifiedAdapterAppointment.Tag |> should equal appointmentAdapter2.Tag
            appointment.InternalId |> should equal latestModifiedAdapterAppointment.InternalId 

            let lmaa = normalize(latestModifiedAdapterAppointment)
            let aa2 = normalize(appointmentAdapter2)

            fixDateSecs(lmaa.LastModified) |> should equal (fixDateSecs(aa2.LastModified))

            lmaa.Category |> should equal aa2.Category
            lmaa.Location |> should equal aa2.Location
            lmaa.Content |> should equal aa2.Content
            lmaa.Title |> should equal aa2.Title
            fixDateSecs(lmaa.DateFrom) |> should equal (fixDateSecs(aa2.DateFrom))
            fixDateSecs(lmaa.DateTo) |> should equal (fixDateSecs(aa2.DateTo))
            lmaa.Reminder |> should equal aa2.Reminder
            lmaa.Notification |> should equal aa2.Notification
            lmaa.IsPrivate |> should equal aa2.IsPrivate
            lmaa.Priority |> should equal aa2.Priority
            AdapterAppointmentRepository.AreStandardAttrsVisiblyDifferent( latestModifiedAdapterAppointment, appointmentAdapter2 ) |> should not' (be True)

            let newAppointment = copyAdapterAppointmentToAppointment( lmaa, app )
            newAppointment.InternalId |> should equal app.InternalId

            newAppointment.Category |> should equal lmaa.Category
            newAppointment.Location |> should equal lmaa.Location
            newAppointment.Content |> should equal lmaa.Content

            AppointmentRepository.Appointments().Length |> should equal 1

            AdapterAppointmentRepository.CopyAndSaveAllFrom(newAppointment)
            AppointmentRepository.Appointments().Length |> should equal 1

            AppointmentRepository.InsertOrUpdate(newAppointment)
            AppointmentRepository.Appointments().Length |> should equal 1

            let adapterAppointments2 = AdapterAppointmentRepository.AdapterAppointments(appId) 
            adapterAppointments2  |> should not' (be Null)
            adapterAppointments2.Length |> should equal 2
            
            let savedAppointment = AppointmentRepository.Appointment(appId).Value 
            savedAppointment.Category |> should equal lmaa.Category
            savedAppointment.Location |> should equal lmaa.Location
            savedAppointment.Content |> should equal lmaa.Content

            for adaApp in adapterAppointments2 do
                AdapterAppointmentRepository.AreStandardAttrsVisiblyDifferent( latestModifiedAdapterAppointment, adaApp ) |> should not' (be True)
                let aa2 = normalize(adaApp)
                let lmaa2 = savedAppointment
                lmaa2.Category |> should equal aa2.Category
                lmaa2.Location |> should equal aa2.Location
                lmaa2.Content |> should equal aa2.Content
                lmaa2.Title |> should equal aa2.Title
                fixDateSecs(lmaa2.DateFrom) |> should equal (fixDateSecs(aa2.DateFrom))
                fixDateSecs(lmaa2.DateTo) |> should equal (fixDateSecs(aa2.DateTo))
                lmaa2.Reminder |> should equal aa2.Reminder
                lmaa2.Notification |> should equal aa2.Notification
                lmaa2.IsPrivate |> should equal aa2.IsPrivate
                lmaa2.Priority |> should equal aa2.Priority
