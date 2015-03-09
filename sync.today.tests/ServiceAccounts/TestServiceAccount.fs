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
            ServiceAccountRepository.ServiceAccounts().Length |> should equal 0

    [<Test>] 
    member x.``when I insert a service account, it is created.`` ()=
            ServiceAccountRepository.ServiceAccounts().Length |> should equal 0
            let adapterId = insertAdapterRetId( { Id = 0; Name = "A" } )
            let accountId = insertAccount( { Id = 0; Name = "N0ame"; ConsumerId = Nullable() } )
            let serviceId = EnsureService("s", "s").Id
            let lastSuccessfulDownload = DateTime.Now
            let serviceAccountId = insertServiceAccount({Id = 0; LoginJSON = ""; ServiceId = serviceId; AccountId = accountId; LastSuccessfulDownload = Nullable(lastSuccessfulDownload); LastDownloadAttempt = Nullable(); LastSuccessfulUpload = Nullable(); LastUploadAttempt = Nullable(); })
            ServiceAccountRepository.ServiceAccounts().Length |> should equal 1
            fixDateSecs( minServiceAccountLastSuccessfulDownload() ) |> should equal ( fixDateSecs( lastSuccessfulDownload ) )

    [<Test>] 
    member x.``when search for service account by adapter, I get one.`` ()=
            ServiceAccountRepository.ServiceAccounts().Length |> should equal 0
            insertServiceRetId( { Id = 0; Key = serviceKey; Name = "Name" } ) |> ignore
            let consumerId = insertConsumer( { Id = 0; Name = "Name" } )
            let adapterId = insertAdapterRetId( { Id = 0; Name = adapterName } )
            let accountId = insertAccount( { Id = 0; Name = "Name"; ConsumerId = Nullable(consumerId) } )
            let serviceAccountId = insertServiceAccount({Id = 0; LoginJSON = ""; ServiceId = serviceId(); AccountId = accountId; LastSuccessfulDownload = Nullable(DateTime.Now); LastDownloadAttempt = Nullable(); LastSuccessfulUpload = Nullable(); LastUploadAttempt = Nullable(); })
            let consumerAdapter = insertConsumerAdapter({Id = 0; AdapterId=adapterId;ConsumerId=consumerId;DataJSON=""})
            let serviceAccount = serviceAccountByAdapterAndConsumer(adapter(), consumer(consumerId).Value, service() ) 
            serviceAccount |> should not' (be Null)
            serviceAccount.Value.Id |> should equal serviceAccountId


    [<Test>] 
    member x.``when search for service account by adapter between more customers, I get correct one.`` ()=
            ServiceAccountRepository.ServiceAccounts().Length |> should equal 0
            insertServiceRetId( { Id = 0; Key = serviceKey; Name = "Name" } ) |> ignore
            let consumer1Id = insertConsumer( { Id = 0; Name = "Name1" } )
            let consumer2Id = insertConsumer( { Id = 0; Name = "Name2" } )
            let adapterId = insertAdapterRetId( { Id = 0; Name = adapterName } )
            let account1Id = insertAccount( { Id = 0; Name = "Name"; ConsumerId = Nullable(consumer1Id) } )
            let account2Id = insertAccount( { Id = 0; Name = "Name"; ConsumerId = Nullable(consumer2Id) } )
            let serviceAccount1Id = insertServiceAccount({Id = 0; LoginJSON = ""; ServiceId = serviceId(); AccountId = account1Id; LastSuccessfulDownload = Nullable(DateTime.Now); LastDownloadAttempt = Nullable(); LastSuccessfulUpload = Nullable(); LastUploadAttempt = Nullable(); })
            let serviceAccount2Id = insertServiceAccount({Id = 0; LoginJSON = ""; ServiceId = serviceId(); AccountId = account2Id; LastSuccessfulDownload = Nullable(DateTime.Now); LastDownloadAttempt = Nullable(); LastSuccessfulUpload = Nullable(); LastUploadAttempt = Nullable(); })
            let consumer1Adapter = insertConsumerAdapter({Id = 0; AdapterId=adapterId;ConsumerId=consumer1Id;DataJSON=""})
            let consumer2Adapter = insertConsumerAdapter({Id = 0; AdapterId=adapterId;ConsumerId=consumer2Id;DataJSON=""})
            let serviceAccount = serviceAccountByAdapterAndConsumer(adapter(), consumer(consumer2Id).Value, service() )
            serviceAccount |> should not' (be Null)
            serviceAccount.Value.Id |> should equal serviceAccount2Id
