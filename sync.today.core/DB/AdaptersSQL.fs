module AdaptersSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

type GetAllAdaptersQuery = SqlCommandProvider<"GetAllAdapters.sql", ConnectionStringName>
type EnsureAdaptersQuery = SqlCommandProvider<"EnsureAdapter.sql", ConnectionStringName>

let internal convert( r : GetAllAdaptersQuery.Record ) : AdapterDTO = 
    { Id = r.Id; Name = r.Name }

let internal convert2( r : EnsureAdaptersQuery.Record ) : AdapterDTO = 
    { Id = r.Id; Name = r.Name }

let internal adapters() : AdapterDTO seq = 
    ( new GetAllAdaptersQuery() ).AsyncExecute(null) |> Async.RunSynchronously |> Seq.map ( fun t -> convert(t) )

let convertOp(c) = 
    convertOption( c, convert )

let internal adapterByName( name : string ) : AdapterDTO option = 
    ( new GetAllAdaptersQuery() ).AsyncExecute(name) |> Async.RunSynchronously |> Seq.tryHead |> convertOp

let internal ensureAdapter( key : string, name : string) : AdapterDTO =
    ( new EnsureAdaptersQuery() ).AsyncExecute(name) |> Async.RunSynchronously |> Seq.head |> convert2
