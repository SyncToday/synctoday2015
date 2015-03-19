module AdaptersSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

type GetAllAdaptersQuery = SqlCommandProvider<"DB\SQL\GetAllAdapters.sql", ConnectionStringName>
type EnsureAdaptersQuery = SqlCommandProvider<"DB\SQL\EnsureAdapter.sql", ConnectionStringName>

let internal convert( r : GetAllAdaptersQuery.Record ) : AdapterDTO = 
    { Id = r.Id; Name = r.Name }

let internal convert2( r : EnsureAdaptersQuery.Record ) : AdapterDTO = 
    { Id = r.Id; Name = r.Name }

let internal convertOption( ro : GetAllAdaptersQuery.Record option) : AdapterDTO option = 
    match ro with
    | Some r -> Some(convert(r))
    | None -> None

let internal adapters() : AdapterDTO seq = 
    ( new GetAllAdaptersQuery() ).AsyncExecute(null) |> Async.RunSynchronously |> Seq.map ( fun t -> convert(t) )

let internal adapterByName( name : string ) : AdapterDTO option = 
    ( new GetAllAdaptersQuery() ).AsyncExecute(name) |> Async.RunSynchronously |> Seq.tryHead |> convertOption

let internal ensureAdapter( key : string, name : string) : AdapterDTO =
    ( new EnsureAdaptersQuery() ).AsyncExecute(name) |> Async.RunSynchronously |> Seq.head |> convert2
