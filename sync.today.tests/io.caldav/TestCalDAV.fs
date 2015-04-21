module TestCalDAV

open NUnit.Framework
open FsUnit
open System.Threading.Tasks
open sync.today.cipher
open FSharp.Configuration
open System

type Settings = AppSettings<"app.config">

[<TestFixture>] 
type ``working with CalDAV`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    [<TestFixtureSetUp>] 
    member x.``Log Test At the beginning`` ()=         
        logger.Info("Test")

    [<Test>] 
    member x.``when I download CalDAV events, should not throw exceptions`` ()=
        let _userName = Settings.CalDavUserName
        if String.IsNullOrWhiteSpace(_userName) then
            Assert.Ignore()
        let _password = Settings.CalDavPassword
        let _server = Settings.CalDavServer

        let _from = Settings.CalDavFrom
        let _to = Settings.CalDavTo

        let _serviceAccountId = 1

        let login : Repository.Login = { userName = _userName; password = _password; server = _server.ToString(); serviceAccountId = _serviceAccountId }
        Repository.download(_from, _to, login)

