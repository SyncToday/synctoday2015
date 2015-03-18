// The SqlDataConnection (LINQ to SQL) TypeProvider allows you to write code that uses 
// a live connection to a database. For more information, please go to 
//    http://go.microsoft.com/fwlink/?LinkId=229209

module JournalsSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open FSharp.Data
open sync.today.Models

[<Literal>]
let query = "SELECT TOP 100 * FROM Journals ORDER BY 1 DESC" 

type JournalQuery = SqlCommandProvider<query, ConnectionStringName>

let convert( r : JournalQuery.Record ) : JournalDTO =
    { Id = r.Id; Date = r.Date; Thread = r.Thread; Level = r.Level; Logger = r.Logger; Logger_method = r.Logger_method; Message = r.Message; Exception = r.Exception; 
    Stacktrace = r.Stacktrace }

let internal journals() = 
    ( new JournalQuery() ).AsyncExecute() |> Async.RunSynchronously |> Seq.map ( fun t -> convert(t) )