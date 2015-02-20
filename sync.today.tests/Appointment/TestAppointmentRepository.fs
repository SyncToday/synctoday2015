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

    [<SetUp>] member x.``empty and prepare database`` ()=         
            logger.Info("Entered")
            let seed = new Oak.Seed()
            seed.PurgeDb()
            let schema = new CreateDB.Schema(seed)
            for s in schema.Scripts() do 
                let sql = s.Invoke()
                seed.ExecuteNonQuery( sql )
            logger.Info("Done")

    [<Test>] member x.``when I ask for appointments it should not be Null.`` ()=
            AppointmentRepository.Appointments() |> should not' (be Null)

    [<Test>] member x.``when I ask for appointments it should have zero members first.`` ()=
             AppointmentRepository.Appointments().IsEmpty |> should be True

    [<Test>] member x.``when I ask for appointments and insert one it should have more then zero members.`` ()=
             let appointment : AppointmentDTO = { Id = -1; InternalId = Guid.NewGuid(); LastModified = DateTime.Now; Category="";Location="";Content="";Title=""; DateFrom=DateTime.Now; DateTo=DateTime.Now; Reminder=Nullable<DateTime>(); Notification=false; IsPrivate=false; Priority=byte 0}
             AppointmentRepository.InsertAppointment( appointment )
             AppointmentRepository.Appointments().IsEmpty |> should not' (be True)

    [<Test>] member x.``multithreaded appointments saving should work.`` () =
             let appointment : AppointmentDTO = { Id = -1; InternalId = Guid.NewGuid(); LastModified = DateTime.Now; Category="";Location="";Content="";Title=""; DateFrom=DateTime.Now; DateTo=DateTime.Now; Reminder=Nullable<DateTime>(); Notification=false; IsPrivate=false; Priority=byte 0}
             Parallel.ForEach([1;2], fun x-> 
                                        AppointmentRepository.InsertAppointment( appointment )
                                        AppointmentRepository.Appointments().IsEmpty |> should not' (be True)
                                        ) |> ignore            
