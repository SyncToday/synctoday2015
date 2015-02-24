module TestJournalRepository

open NUnit.Framework
open FsUnit
open System.Threading.Tasks

[<TestFixture>] 
type ``logging a info in repository`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    [<TestFixtureSetUp>] member x.``Log Test At the beginning`` ()=         
                                                                        logger.Info("Test")

    [<Test>] member x.``when I ask for journals it should not be Null.`` ()=
                                                                                JournalRepository.Journals() |> should not' (be Null)

    [<Test>] member x.``when I ask for journals it should have more then zero members.`` ()=
                                                                                             JournalRepository.Journals().IsEmpty |> should not' (be True)

    [<Test>] member x.``when another Thread is logging, the journal should contain the logged data as well.`` () =
                                    Parallel.ForEach([1;2], fun x-> 
                                        logger.Info(x+1) 
                                        JournalRepository.Journals().IsEmpty |> should not' (be True)                                        
                                        ) |> ignore            
