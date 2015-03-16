module TestJson

open NUnit.Framework
open FsUnit
open System.Threading.Tasks
open Common

[<TestFixture>] 
type ``encrypting and decrypting`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    [<TestFixtureSetUp>] 
    member x.``Log Test At the beginning`` ()=         
        logger.Info("Test")

    [<Test>] 
    member x.``when json and unjson string, should be same`` ()=
        let basic = "BASIC"
        ( unjson<string>(json(basic))) |> should equal basic

    [<Test>] 
    member x.``when json and unjson string array, should be same`` ()=
        let basicArray : string array = [| "BASIC"; "Pascal"; "C++" |]
        let jsoned = json(basicArray)
        printfn "%A" jsoned
        let tamZpet = unjson<string array>(jsoned)
        tamZpet.Length |> should equal basicArray.Length
        tamZpet.[0] |> should equal basicArray.[0]
