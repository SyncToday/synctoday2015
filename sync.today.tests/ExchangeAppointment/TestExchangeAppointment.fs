module TestExchangeAppointment

open Common
open System
open NUnit.Framework
open sync.today.Models
open ExchangeAppointmentsSQL
open ExchangeRepository
open FsUnit
open AdaptersSQL
open MainDataConnection
open ServiceAccountsSQL
open ServiceRepository
open AdapterAppointmentRepository
open sync.today.cipher
open AppointmentLevelRepository
open AccountsSQL

[<TestFixture>] 
type ``service persistence`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
    member x.``when I ask for Exchange Appointments it should not be Null.`` ()=
            ExchangeAppointmentInternalIds() |> should not' (be Null)

    [<Test>] 
    member x.``when I ask for Exchange Appointments there should be zero.`` ()=
            ExchangeAppointmentInternalIds().Length |> should equal 0

    [<Test>] 
    member x.``when I change internal Id for Exchange Appointment, it will propagate.`` ()=
            let adapterId = ensureAdapter( "A", "A" ).Id
            let accountId = insertAccount( { Id = 0; Name = "Name"; ConsumerId = None } ).Id
            let serviceId = EnsureService("s", "s").Id
            let serviceAccountId = insertOrUpdate({Id = 0; LoginJSON = ""; ServiceId = serviceId; AccountId = accountId; LastSuccessfulDownload = None; LastDownloadAttempt = None; LastSuccessfulUpload = None; LastUploadAttempt = None }).Id

            ExchangeAppointmentInternalIds().Length |> should equal 0
            ExchangeRepository.insertOrUpdate( { ExchangeRepository.getEmpty(None) with ServiceAccountId = serviceAccountId } ) |> ignore
            ExchangeAppointmentInternalIds().Length |> should equal 1
            ExchangeAppointmentInternalIds().[0] |> should equal Guid.Empty
            let newInternalId = Guid.NewGuid()            
            ChangeInternalIdBecauseOfDuplicitySimple( newInternalId, exchangeAppointmentIds().[0] )
            ExchangeAppointmentInternalIds().[0] |> should equal newInternalId

    [<Test>] 
    member x.``when I convert Exchange Appointment to Adapter Appointments and back, it should be same`` ()=
        let emptyExchangeAppointment = { getEmpty(None) with InternalId = Guid.NewGuid() }
        let serviceAccountId = 1
        let fromTo = ConvertFromDTO( ConvertToDTO(emptyExchangeAppointment, 1), serviceAccountId, emptyExchangeAppointment )
        fromTo.Subject |> should equal emptyExchangeAppointment.Subject
        fromTo.ServiceAccountId |> should equal serviceAccountId
        fromTo.InternalId |> should equal emptyExchangeAppointment.InternalId

    [<Test>] 
    member x.``when I save Exchange Appointment and load and back, it should be same`` ()=
        let adapterId = ensureAdapter( "A", "A" ).Id
        let accountId = insertAccount( { Id = 0; Name = "Name"; ConsumerId = None } ).Id
        let serviceId = EnsureService("s", "s").Id
        let serviceAccountId = ServiceAccountsSQL.insertOrUpdate({Id = 0; LoginJSON = ""; ServiceId = serviceId; AccountId = accountId; LastSuccessfulDownload = Some(DateTime.Now); LastDownloadAttempt = None; LastSuccessfulUpload = None; LastUploadAttempt = None; }).Id

        let emptyExchangeAppointment = getEmpty(None)
        let subject = "Test subject"
        let exchangeAppointmentToBeSaved = { emptyExchangeAppointment with Subject = subject; ServiceAccountId = serviceAccountId; InternalId = Guid.NewGuid()  }
        ExchangeRepository.insertOrUpdate(exchangeAppointmentToBeSaved) 
        let dbExchangeAppointment = exchangeAppointmentByInternalId( exchangeAppointmentToBeSaved.InternalId )
        dbExchangeAppointment |> should not' (be Null)
        dbExchangeAppointment.Value.Subject |> should equal subject

    [<Test>] 
    member x.``when I convert Exchange Appointment and load and back, it should be same`` ()=
        let consumerId = ConsumerRepository.Insert( { Id = 0; Name = "Consumer" } ).Id
        let adapterId = ensureAdapter( "A", "A" ).Id
        let accountId = insertAccount( { Id = 0; Name = "Name"; ConsumerId = Some(consumerId) } ).Id
        let serviceId = EnsureService("s", "s").Id
        let serviceAccountId = ServiceAccountsSQL.insertOrUpdate({Id = 0; LoginJSON = ""; ServiceId = serviceId; AccountId = accountId; LastSuccessfulDownload = Some(DateTime.Now); LastDownloadAttempt = None; LastSuccessfulUpload = None; LastUploadAttempt = None; }).Id

        let emptyExchangeAppointment = getEmpty(None)
        let subject = "Test subject"
        let exchangeAppointmentToBeSaved = { emptyExchangeAppointment with Subject = subject; ServiceAccountId = serviceAccountId; InternalId = Guid.NewGuid()  }
        ExchangeRepository.insertOrUpdate(exchangeAppointmentToBeSaved) 
        let dbExchangeAppointment = exchangeAppointmentByInternalId( exchangeAppointmentToBeSaved.InternalId )
        dbExchangeAppointment |> should not' (be Null)
        dbExchangeAppointment.Value.Subject |> should equal subject
        dbExchangeAppointment.Value.InternalId |> should equal exchangeAppointmentToBeSaved.InternalId
        let adaApp = ConvertToDTO( dbExchangeAppointment.Value, adapterId )
        adaApp |> should not' (be Null)
        adaApp.InternalId |> should equal exchangeAppointmentToBeSaved.InternalId
        adaApp.Title |> should equal subject
        insertAppointmentAndAdapterAppointments( adaApp, consumerId  )
        let adaApps = AdapterAppointments( 1 )
        adaApps |> should not' (be Null)
        adaApps.Length |> should equal 1
        let dbAdaApp = adaApps.[0]
        dbAdaApp |> should not' (be Null)
        dbAdaApp.InternalId |> should equal exchangeAppointmentToBeSaved.InternalId
        dbAdaApp.Title |> should equal subject
