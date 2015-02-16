module TestJournalActivity

open NUnit.Framework
open FsUnit
open sync.today.activities
open System.Activities
open sync.today.Models

[<TestFixture>] 
type ``logging a info in workflow`` ()=

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    [<TestFixtureSetUp>] member x.``Log Test At the beginning`` ()=         
            logger.Info("Test")

    [<Test>] member x.``when I ask for journals it should not be Null.`` ()=
            let activity = new GetJournals()
            let result = WorkflowInvoker.Invoke(activity)
            result.["result"] |> should not' (be Null)

    [<Test>] member x.``when I ask for journals it should have more then zero members.`` ()=
            let activity = new GetJournals()
            let result = WorkflowInvoker.Invoke(activity)
            let journalList = result.["result"] :?> (JournalDTO System.Collections.Generic.List)
            journalList.Count |> should be (greaterThanOrEqualTo 1)
