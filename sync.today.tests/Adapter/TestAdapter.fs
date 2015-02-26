module TestAdapter

open NUnit.Framework
open sync.today.Models
open AdaptersSQL
open FsUnit

[<TestFixture>] 
type ``Adapter persistence`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


    let AdapterName = "__Name__"
    let AdapterId() = 
        adapterByName( AdapterName ).Value.Id

    let emptyAdapter : AdapterDTO  = 
        { Id = -1; Name=AdapterName}

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
    member x.``when I ask for Adapters it should not be Null.`` ()=
            AdapterRepository.Adapters() |> should not' (be Null)

    [<Test>] 
    member x.``when I ask for Adapters there should be zero.`` ()=
            AdapterRepository.Adapters().Length |> should equal 0

    [<Test>] 
    member x.``when I Ensure a Adapter, it is created but only once.`` ()=
            AdapterRepository.Adapters().Length |> should equal 0
            let Adapter1 = AdapterRepository.EnsureAdapter( AdapterName, AdapterName )
            AdapterRepository.Adapters().Length |> should equal 1
            let Adapter2 = AdapterRepository.EnsureAdapter( AdapterName, AdapterName )
            AdapterRepository.Adapters().Length |> should equal 1
            Adapter1.Name |> should equal Adapter2.Name
