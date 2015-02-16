module TestAppointmentRepository

open System
open NUnit.Framework
open FsUnit
open System.Threading.Tasks
open sync.today.Models

[<TestFixture>] 
type ``appointment persistence`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    [<TestFixtureSetUp>] member x.``Log Test At the beginning`` ()=         
            logger.Info("Test")

    [<Test>] member x.``when I ask for appointments it should not be Null.`` ()=
            AppointmentRepository.Appointments() |> should not' (be Null)

    [<Test>] member x.``when I ask for appointments it should have zero members first.`` ()=
             AppointmentRepository.DeleteAppointments()
             AppointmentRepository.Appointments().IsEmpty |> should be True

    [<Test>] member x.``when I ask for appointments and insert one it should have more then zero members.`` ()=
             let appointment = { Id = -1; ExternalId = "externalId"; LastModified = DateTime.Now; Category="";Location="";Content="";Title=""; DateFrom=DateTime.Now; DateTo=DateTime.Now; Reminder=Nullable<DateTime>(); Notification=false; IsPrivate=false; Priority=byte 0}
             AppointmentRepository.InsertAppointment( appointment )
             AppointmentRepository.Appointments().IsEmpty |> should not' (be True)

    [<Test>] member x.``when another Thread is logging, the appointments should be saved as well.`` () =
             let appointment = { Id = -1; ExternalId = "externalId"; LastModified = DateTime.Now; Category="";Location="";Content="";Title=""; DateFrom=DateTime.Now; DateTo=DateTime.Now; Reminder=Nullable<DateTime>(); Notification=false; IsPrivate=false; Priority=byte 0}
            Parallel.ForEach([1;2], fun x-> 
                                        AppointmentRepository.InsertAppointment( appointment )
                                        AppointmentRepository.Appointments().IsEmpty |> should not' (be True)
                                        ) |> ignore            
