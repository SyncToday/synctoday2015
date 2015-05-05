module TestCalDAV

open NUnit.Framework
open FsUnit
open System.Threading.Tasks
open sync.today.cipher
open FSharp.Configuration
open System
open AdapterRepository
open AccountRepository
open sync.today.Models

type Settings = AppSettings<"app.config">

[<TestFixture>] 
type ``working with CalDAV`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
    let _userName = Settings.CalDavUserName
    let _password = Settings.CalDavPassword
    let _server = Settings.CalDavServer

    let _from = DateTime.Now.AddDays(float -14)
    let _to = _from.AddDays(float -30)

    let mutable _serviceAccountId : int = 0

    let ensureServiceAccountId() : int = 
        let adapterId = EnsureAdapter( "A", "A" ).Id
        let accountId = AccountRepository.insert( { Id = 0; Name = "N0ame"; ConsumerId = None } ).Id
        let serviceId = ServiceRepository.EnsureService("s", "s").Id
        let lastSuccessfulDownload = DateTime.Now
        let _serviceAccountId = ServiceAccountsSQL.insertOrUpdate({Id = 0; LoginJSON = ""; ServiceId = serviceId; AccountId = accountId; LastSuccessfulDownload = Some(lastSuccessfulDownload); LastDownloadAttempt = None; LastSuccessfulUpload = None; LastUploadAttempt = None }).Id
        _serviceAccountId
    

    let login() : Repository.Login = { userName = _userName; password = _password; server = _server.ToString(); serviceAccountId = _serviceAccountId }

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
            _serviceAccountId <- ensureServiceAccountId() 

    [<TestFixtureSetUp>] 
    member x.``Log Test At the beginning`` ()=         
        logger.Info("Test")
        Repository.ignoreSslCertificateErrors()

    [<Test>] 
    member x.``when I upload CalDAV events they should be accessible from the CalDAV server`` ()=
        if String.IsNullOrWhiteSpace(_userName) then
            Assert.Ignore()

        ( Repository.AllEvents() |> Seq.toList ).Length |> should equal 0

        let _now = DateTime.Now
        Repository.deleteAll( (  _from, _to ), login() ) |> ignore

        Repository.download( (_from, _to), login()) |> ignore
        ( Repository.AllEvents() |> Seq.toList ).Length |> should equal 0

        let internalId = Guid.NewGuid()

        let _title = "Title" + _now.Ticks.ToString()
        let newEvent : CalDAVEventDTO = { Id = 0; InternalId = internalId; ExternalId = None; Description = Some "Our event description"; Start = _now; End = _now.AddMinutes(float 1); LastModified = _now; 
                                          Location = Some "Here"; Summary = Some _title; CategoriesJSON = None; ServiceAccountId = _serviceAccountId; Tag = None; }

        let dbObject = Repository.save(newEvent, _serviceAccountId) 
        ( Repository.AllEvents() |> Seq.toList ).Length |> should equal 1

        let newEvent : CalDAVEventDTO = { Id = 0; InternalId = internalId; ExternalId = None; Description = Some "Our event description"; Start = _now; End = _now.AddMinutes(float 1); LastModified = _now; 
                                          Location = Some "Here"; Summary = Some _title; CategoriesJSON = None; ServiceAccountId = _serviceAccountId; Tag = None; }

        let dbObject = Repository.save(newEvent, _serviceAccountId) 
        ( Repository.AllEvents() |> Seq.toList ).Length |> should equal 1

        Repository.upload(login())       

        let allEvents = ( Repository.AllEvents() |> Seq.toList )
        allEvents.Length |> should equal 1
        let uid = allEvents.[0].ExternalId
        uid.IsSome |> Assert.IsTrue
        String.IsNullOrWhiteSpace( uid.Value ) |> Assert.IsFalse

        let newEvent2 = { allEvents.[0] with Description = Some "Our desc 2" } 
        Repository.save(newEvent2, _serviceAccountId) |> ignore

        ( Repository.AllEvents() |> Seq.toList ).Length |> should equal 1

        Repository.upload(login())       

        let allEvents = ( Repository.AllEvents() |> Seq.toList )
        allEvents.Length |> should equal 1
        let uid2 = allEvents.[0].ExternalId
        uid2.IsSome |> Assert.IsTrue
        String.IsNullOrWhiteSpace( uid2.Value ) |> Assert.IsFalse
        uid2.Value |> should equal uid.Value

        Repository.processCalDAVServer( _now.Date, _now.Date.AddDays(float 1), login(), 
            fun p -> p.Summary.Equals( _title )
        ) |> Seq.exists( fun p -> p ) |>  Assert.IsTrue

        ( Repository.AllEvents() |> Seq.toList ).Length |> should equal 1

        Repository.download( (_from, _to), login()) |> ignore

        ( Repository.NewEvents() |> Seq.toList ).Length |> should equal 0
        ( Repository.UpdatedEvents() |> Seq.toList ).Length |> should equal 0
        ( Repository.AllEvents() |> Seq.toList ).Length |> should equal 1
