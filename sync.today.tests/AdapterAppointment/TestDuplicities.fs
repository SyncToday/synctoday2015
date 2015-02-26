module TestDuplicities

open NUnit.Framework
open sync.today.Models
open AdapterAppointmentsSQL
open FsUnit
open System
open AdapterAppointmentRepository

[<TestFixture>] 
type ``Adapter Apointment Duplicities`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    let emptyAdapterAppointment : AdapterAppointmentDTO = 
        { Id = 0; InternalId = Guid.Empty; LastModified = DateTime.Now; Category = ""; Location = ""; Content = ""; Title="Title"; DateFrom = DateTime.Parse("2015-01-01");
          DateTo = DateTime.Parse("2015-02-02"); Reminder = Nullable(); Notification = false; IsPrivate = false; Priority = byte 0; AppointmentId = 0; AdapterId = 0; Tag = 0 }

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

    [<Test>] 
    member x.``when I ask for duplicities there should be zero.`` ()=
            findDuplicatedAdapterAppointment(emptyAdapterAppointment) |> should equal None

    [<Test>] 
    member x.``when I create appointment, no duplicities`` ()=
            let consumerId = ConsumerRepository.Insert( { Id = 0; Name = "Consumer" } )
            let adapterId  = AdapterRepository.EnsureAdapter("A", "A").Id
            insertAppointmentAndAdapterAppointments( emptyAdapterAppointment, consumerId  )
            findDuplicatedAdapterAppointment(emptyAdapterAppointment) |> should equal None

    [<Test>] 
    member x.``when I create 2 same appointments, there are no duplicities since same values in one adapter are allowed`` ()=
            let consumerId = ConsumerRepository.Insert( { Id = 0; Name = "Consumer" } )
            let adapter1Id  = AdapterRepository.EnsureAdapter("A", "A").Id
            let adapter2Id  = AdapterRepository.EnsureAdapter("B", "B").Id
            insertAppointmentAndAdapterAppointments( emptyAdapterAppointment, consumerId  )
            let adapterAppointmentInDb = AdapterAppointments(1).[0]
            findDuplicatedAdapterAppointment(adapterAppointmentInDb) |> should equal None
            insertAppointmentAndAdapterAppointments( {emptyAdapterAppointment with InternalId = Guid.NewGuid()} , consumerId  )
            let potentDupl = findDuplicatedAdapterAppointment(adapterAppointmentInDb) 
            potentDupl |> should not' (be Null)
            potentDupl.Value.Title |> should equal adapterAppointmentInDb.Title
            potentDupl.Value.AdapterId |> should not' (equal adapterAppointmentInDb.AdapterId)
