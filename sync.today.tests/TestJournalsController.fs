module TestJournalsController

open NUnit.Framework
open FsUnit
open JournalsController
open System.Threading.Tasks

[<TestFixture>] 
type ``logging a info`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    let JournalsController = 
        new JournalsController()

    [<TestFixtureSetUp>] member x.``Log Test At the beginning`` ()=         
            logger.Info("Test")

    [<Test>] member x.``when I ask for journals it should not be Null.`` ()=
            JournalsController.Get |> should not' (be Null)

    [<Test>] member x.``when I ask for journals it should have more then zero members.`` ()=
            JournalsController.Get().IsEmpty |> should not' (be True)

    [<Test>] member x.``when another Thread is logging, the journal should contain the logged data as well.`` () =
            Parallel.ForEach([1;2], fun x-> 
                                        logger.Info(x+1) 
                                        JournalsController.Get().IsEmpty |> should not' (be True)                                        
                                        ) |> ignore            
