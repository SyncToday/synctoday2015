module TestService

open NUnit.Framework
open sync.today.Models
open ServicesSQL
open FsUnit

[<TestFixture>] 
type ``service persistence`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


    let serviceKey = "__Key__"
    let serviceName = "__Name__"
    let serviceId() = 
        serviceByKey( serviceKey ).Value.Id

    let emptyService : ServiceDTO  = 
        { Id = -1; Key = serviceKey; Name="Name"}

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
    member x.``when I ask for services it should not be Null.`` ()=
            ServiceRepository.Services() |> should not' (be Null)

    [<Test>] 
    member x.``when I ask for services there should be zero.`` ()=
            ServiceRepository.Services().Length |> should equal 0

    [<Test>] 
    member x.``when I Ensure a service, it is created but only once.`` ()=
            ServiceRepository.Services().Length |> should equal 0
            let service1 = ServiceRepository.EnsureService( serviceKey, serviceName )
            ServiceRepository.Services().Length |> should equal 1
            let service2 = ServiceRepository.EnsureService( serviceKey, serviceName )
            ServiceRepository.Services().Length |> should equal 1
            service1.Name |> should equal service2.Name
