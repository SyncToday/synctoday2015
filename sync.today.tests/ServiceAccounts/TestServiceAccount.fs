module TestServiceAccount

open NUnit.Framework
open sync.today.Models
open ServiceAccountsSQL
open FsUnit
open AdaptersSQL
open MainDataConnection
open ServiceRepository
open System
open ConsumerAdaptersSQL
open ServicesSQL
open ConsumersSQL
open AccountsSQL
open Common

[<TestFixture>] 
type ``service account persistence`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    let serviceKey = "Key"
    let serviceId() = 
        serviceByKey( serviceKey ).Value.Id
    let service() = 
        serviceByKey( serviceKey ).Value

    let adapterName = "Adapter Name"
    let adapterId() = 
        adapterByName( adapterName ).Value.Id
    let adapter() = adapterByName( adapterName ).Value

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
    member x.``when I ask for service accounts it should not be Null.`` ()=
            ServiceAccountRepository.ServiceAccounts() |> should not' (be Null)

    [<Test>] 
    member x.``when I ask for service accounts  there should be zero.`` ()=
            ( Seq.toList (ServiceAccountRepository.ServiceAccounts()) ).Length |> should equal 0

    [<Test>] 
    member x.``when I insert a service account, it is created.`` ()=
            ( Seq.toList (ServiceAccountRepository.ServiceAccounts()) ).Length |> should equal 0
            let adapterId = ensureAdapter( "A", "A" ).Id
            let accountId = insertAccount( { Id = 0; Name = "N0ame"; ConsumerId = None } ).Id
            let serviceId = EnsureService("s", "s").Id
            let lastSuccessfulDownload = DateTime.Now
            let serviceAccountId = ServiceAccountsSQL.insertOrUpdate({Id = 0; LoginJSON = ""; ServiceId = serviceId; AccountId = accountId; LastSuccessfulDownload = Some(lastSuccessfulDownload); LastDownloadAttempt = None; LastSuccessfulUpload = None; LastUploadAttempt = None })
            ( Seq.toList (ServiceAccountRepository.ServiceAccounts()) ).Length |> should equal 1
            fixDateSecs( minServiceAccountLastSuccessfulDownload() ) |> should equal ( fixDateSecs( lastSuccessfulDownload ) )

    [<Test>] 
    member x.``when search for service account by adapter, I get one.`` ()=
            ( Seq.toList (ServiceAccountRepository.ServiceAccounts()) ).Length |> should equal 0
            EnsureService( serviceKey, "Name" ) |> ignore
            let consumerId = insertConsumer( { Id = 0; Name = "Name" } ).Id
            let adapterId = ensureAdapter( adapterName, adapterName ).Id
            let accountId = insertAccount( { Id = 0; Name = "Name"; ConsumerId = Some(consumerId) } ).Id
            let serviceAccountId : int = ServiceAccountsSQL.insertOrUpdate({Id = 0; LoginJSON = ""; ServiceId = serviceId(); AccountId = accountId; LastSuccessfulDownload = Some(DateTime.Now); LastDownloadAttempt = None; LastSuccessfulUpload = None; LastUploadAttempt = None }).Id
            let consumerAdapter = ConsumerAdaptersSQL.insertOrUpdateConsumerAdapter({Id = 0; AdapterId=adapterId;ConsumerId=consumerId;DataJSON=""})
            let serviceAccount = serviceAccountByAdapterAndConsumer(adapter(), consumer(consumerId).Value, service() ) 
            serviceAccount |> should not' (be Null)
            serviceAccount.Value.Id |> should equal serviceAccountId


    [<Test>] 
    member x.``when search for service account by adapter between more customers, I get correct one.`` ()=
            ( Seq.toList (ServiceAccountRepository.ServiceAccounts()) ).Length |> should equal 0
            EnsureService( serviceKey, "Name" ) |> ignore
            let consumer1Id = insertConsumer( { Id = 0; Name = "Name1" } ).Id
            let consumer2Id = insertConsumer( { Id = 0; Name = "Name2" } ).Id
            let adapterId =  ensureAdapter( adapterName, adapterName ).Id
            let account1Id = insertAccount( { Id = 0; Name = "Name"; ConsumerId = Some(consumer1Id) } ).Id
            let account2Id = insertAccount( { Id = 0; Name = "Name"; ConsumerId = Some(consumer2Id) } ).Id
            let serviceAccount1Id : int = ServiceAccountsSQL.insertOrUpdate({Id = 0; LoginJSON = ""; ServiceId = serviceId(); AccountId = account1Id; LastSuccessfulDownload = Some(DateTime.Now); LastDownloadAttempt = None; LastSuccessfulUpload = None; LastUploadAttempt = None }).Id
            let serviceAccount2Id : int = ServiceAccountsSQL.insertOrUpdate({Id = 0; LoginJSON = ""; ServiceId = serviceId(); AccountId = account2Id; LastSuccessfulDownload = Some(DateTime.Now); LastDownloadAttempt = None; LastSuccessfulUpload = None; LastUploadAttempt = None }).Id
            let consumer1Adapter = ConsumerAdaptersSQL.insertOrUpdateConsumerAdapter({Id = 0; AdapterId=adapterId;ConsumerId=consumer1Id;DataJSON=""})
            let consumer2Adapter = ConsumerAdaptersSQL.insertOrUpdateConsumerAdapter({Id = 0; AdapterId=adapterId;ConsumerId=consumer2Id;DataJSON=""})
            let serviceAccount = serviceAccountByAdapterAndConsumer(adapter(), consumer(consumer2Id).Value, service() )
            serviceAccount |> should not' (be Null)
            serviceAccount.Value.Id |> should equal serviceAccount2Id
