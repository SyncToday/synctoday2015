module TestAppointmentLevel

open NUnit.Framework
open FsUnit
open System.Threading.Tasks
open Common
open AppointmentLevelRepository

[<TestFixture>] 
type ``working with categories`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    [<TestFixtureSetUp>] 
    member x.``Log Test At the beginning`` ()=         
        logger.Info("Test")

    [<Test>] 
    member x.``when category that is not present is added, it should be added`` ()=
        ensureCategory( "A" )
        ensureCategory( "B" )
        ensureCategory( "C" )
        let ada = "ADA"
        let basicArray : string array = [| "BASIC"; "Pascal"; "C++" |]
        let resultArray : string array = [| "BASIC"; "Pascal"; "C++"; ada |]
        let jsoned = json(basicArray)
        printfn "%A" jsoned
        replaceCategoryInJSON( jsoned, ada ) |> should equal (json(resultArray))

    [<Test>] 
    member x.``when category that is present is added, it should be replaced`` ()=
        ensureCategory( "A" )
        ensureCategory( "B" )
        ensureCategory( "C" )
        let basicArray : string array = [| "A"; "Pascal"; "C++" |]
        let resultArray : string array = [| "B"; "Pascal"; "C++"|]
        let jsoned = json(basicArray)
        printfn "%A" jsoned
        replaceCategoryInJSON( jsoned, "B" ) |> should equal (json(resultArray))
