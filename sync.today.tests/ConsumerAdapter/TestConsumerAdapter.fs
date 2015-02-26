module TestConsumerAdapter

open NUnit.Framework
open sync.today.Models
open ConsumerAdaptersSQL
open FsUnit

[<TestFixture>] 
type ``Consumer Adapter persistence`` ()=
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
    member x.``when I ask for ConsumerAdapters it should not be Null.`` ()=
            ConsumerAdapterRepository.ConsumerAdapters() |> should not' (be Null)

    [<Test>] 
    member x.``when I ask for ConsumerAdapters there should be zero.`` ()=
            ConsumerAdapterRepository.ConsumerAdapters().Length |> should equal 0

    [<Test>] 
    member x.``when I Ensure a ConsumerAdapter, it is created but only once.`` ()=
            ConsumerAdapterRepository.ConsumerAdapters().Length |> should equal 0
            let consumerId = ConsumerRepository.Insert( { Id = 0; Name = "Consumer" } )
            let adapterId  = AdapterRepository.EnsureAdapter("A", "A").Id
            let dataJSON = "{ABC}"
            let ConsumerAdapter1 = ConsumerAdapterRepository.Insert( { Id = 0; ConsumerId = consumerId; AdapterId = adapterId; DataJSON = dataJSON } )
            ConsumerAdapterRepository.ConsumerAdapters().Length |> should equal 1
