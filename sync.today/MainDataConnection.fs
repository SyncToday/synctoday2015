// The SqlDataConnection (LINQ to SQL) TypeProvider allows you to write code that uses 
// a live connection to a database. For more information, please go to 
//    http://go.microsoft.com/fwlink/?LinkId=229209

module MainDataConnection

#if INTERACTIVE
#r "System.Data"
#r "System.Data.Linq"
#r "FSharp.Data.TypeProviders"
#endif

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models

type internal SqlConnection = SqlDataConnection<ConnectionStringName="sync-today-mssql">
let internal db() = SqlConnection.GetDataContext()
let internal cnn() = db().DataContext

let internal journals() = 
    query {
        for r in db().Journals do
        select { Id = r.Id; Date = r.Date; Thread = r.Thread; Level = r.Level; Logger = r.Logger; Logger_method = r.Logger_method; Message = r.Message; Exception = r.Exception; Stacktrace = r.Stacktrace }
    } |> Seq.toList

let internal workflows() = 
    query {
        for r in db().Workflows do
        select { Id = r.Id; CreatedOn = r.CreatedOn; Name = r.Name; XamlCode = r.XamlCode }
    } |> Seq.toList

let internal workflowById( id : int ) = 
    query {
        for r in db().Workflows do
        where ( r.Id = id )
        select { Id = r.Id; CreatedOn = r.CreatedOn; Name = r.Name; XamlCode = r.XamlCode }
    } |> Seq.tryHead

let internal processes() = 
    query {
        for r in db().Processes do
        select { Id = r.Id; StartedOn = r.StartedOn; FinishedOn = r.FinishedOn; Name = r.Name; XamlCode = r.XamlCode; Exception = r.Exception; Workflow = workflowById(r.WorkflowId).Value; IsAlive = false }
    } |> Seq.toList

let internal processById( id : int ) = 
    query {
        for r in db().Processes do
        where ( r.Id = id )
        select { Id = r.Id; StartedOn = r.StartedOn; FinishedOn = r.FinishedOn; Name = r.Name; XamlCode = r.XamlCode; Exception = r.Exception; Workflow = workflowById(r.WorkflowId).Value; IsAlive = false }
    } |> Seq.tryHead

let internal adapters() = 
    query {
        for r in db().Adapters do
        select { Id = r.Id; Name = r.Name; ServiceId = r.ServiceId }
    } |> Seq.toList

let internal downloadAdapterData( adapter : AdapterDTO ) =
    0 |> ignore

let internal transformAdapterData( adapter : AdapterDTO ) =
    0 |> ignore

let insertAdapter( adapter : AdapterDTO ) =
    let db = db()

    let newAdapter = new SqlConnection.ServiceTypes.Adapters()
    newAdapter.Name <- adapter.Name
    newAdapter.ServiceId <- adapter.ServiceId

    db.Adapters.InsertOnSubmit newAdapter
    db.DataContext.SubmitChanges()
    newAdapter.Id
    
let insertService( service : ServiceDTO ) =
    let db = db()

    let newService = new SqlConnection.ServiceTypes.Services()
    newService.Name <- service.Name
    newService.Key <- service.Key

    db.Services.InsertOnSubmit newService
    db.DataContext.SubmitChanges()
    newService.Id

let insertAccount( account : AccountDTO ) =
    let db = db()

    let newAccount = new SqlConnection.ServiceTypes.Accounts()
    newAccount.Name <- account.Name

    db.Accounts.InsertOnSubmit newAccount
    db.DataContext.SubmitChanges()
    newAccount.Id

let insertServiceAccount( service : ServiceAccountDTO ) =
    let db = db()

    let newService = new SqlConnection.ServiceTypes.ServiceAccounts()
    newService.AccountId <- service.AccountId
    newService.LastDownload <- Nullable(service.LastDownload)
    newService.LoginJSON <- service.LoginJSON
    newService.ServiceId <- service.ServiceId

    db.ServiceAccounts.InsertOnSubmit newService
    db.DataContext.SubmitChanges()
    newService.Id