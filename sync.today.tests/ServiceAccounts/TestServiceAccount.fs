module TestServiceAccount

open NUnit.Framework
open sync.today.Models
open ServiceAccountsSQL
open FsUnit

[<TestFixture>] 
type ``service account persistence`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

(* 
    let emptyService : ServiceDTO  = 
        { Id = -1; Key = serviceKey; Name="Name"}
*)

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

(* 
    [<Test>] 
    member x.``when I insert a service account, it is created.`` ()=
            ServiceAccountRepository.ServiceAccounts().Length |> should equal 0
            let service1 = insertServiceAccount(  )
*)
