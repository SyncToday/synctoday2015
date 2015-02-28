module TestExchangeAppointment

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
            let adapterId = insertAdapterRetId( { Id = 0; Name = "A" } )
            let accountId = insertAccount( { Id = 0; Name = "Name"; ConsumerId = Nullable() } )
            let serviceId = EnsureService("s", "s").Id
            let serviceAccountId = insertServiceAccount({Id = 0; LoginJSON = ""; ServiceId = serviceId; AccountId = accountId; LastSuccessfulDownload = Nullable(DateTime.Now); LastDownloadAttempt = Nullable(); LastSuccessfulUpload = Nullable(); LastUploadAttempt = Nullable(); })

            ExchangeAppointmentInternalIds().Length |> should equal 0
            insertOrUpdateFrom( Guid.Empty, "", DateTime.Now, DateTime.Now, "", Nullable(), "", 1, 0 )
            ExchangeAppointmentInternalIds().Length |> should equal 1
            ExchangeAppointmentInternalIds().[0] |> should equal Guid.Empty
            let newInternalId = Guid.NewGuid()            
            ChangeInternalIdBecauseOfDuplicitySimple( newInternalId, exchangeAppointmentIds().[0] )
            ExchangeAppointmentInternalIds().[0] |> should equal newInternalId

    [<Test>] 
    member x.``when I convert Exchange Appointment to Adapter Appointments and back, it should be same`` ()=
        let emptyExchangeAppointment = getEmpty(None)
        let serviceAccountId = 1
        let fromTo = ConvertFromDTO( ConvertToDTO(emptyExchangeAppointment, 1), serviceAccountId, emptyExchangeAppointment )
        fromTo.Subject |> should equal emptyExchangeAppointment.Subject
        fromTo.ServiceAccountId |> should equal serviceAccountId

    [<Test>] 
    member x.``when I saveExchange Appointment and load and back, it should be same`` ()=
        let adapterId = insertAdapterRetId( { Id = 0; Name = "A" } )
        let accountId = insertAccount( { Id = 0; Name = "Name"; ConsumerId = Nullable() } )
        let serviceId = EnsureService("s", "s").Id
        let serviceAccountId = insertServiceAccount({Id = 0; LoginJSON = ""; ServiceId = serviceId; AccountId = accountId; LastSuccessfulDownload = Nullable(DateTime.Now); LastDownloadAttempt = Nullable(); LastSuccessfulUpload = Nullable(); LastUploadAttempt = Nullable(); })

        let emptyExchangeAppointment = getEmpty(None)
        let subject = "Test subject"
        let exchangeAppointmentToBeSaved = { emptyExchangeAppointment with Subject = subject; ServiceAccountId = serviceAccountId }
        insertOrUpdate(exchangeAppointmentToBeSaved) 
        let dbExchangeAppointment = exchangeAppointmentByInternalId( exchangeAppointmentToBeSaved.InternalId )
        dbExchangeAppointment |> should not' (be Null)
        dbExchangeAppointment.Value.Subject |> should equal subject
 