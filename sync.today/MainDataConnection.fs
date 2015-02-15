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

type private SqlConnection = SqlDataConnection<ConnectionStringName="sync-today-mssql">
let private db() = SqlConnection.GetDataContext()
let private cnn() = db().DataContext

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

