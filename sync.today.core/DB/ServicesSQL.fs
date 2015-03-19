module ServicesSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

type GetServicesQuery = SqlCommandProvider<"DB\SQL\GetServices.sql", ConnectionStringName>
type InsertOrUpdateServiceQuery = SqlCommandProvider<"DB\SQL\InsertOrUpdateService.sql", ConnectionStringName>

let internal convert( r : GetServicesQuery.Record ) : ServiceDTO =
    { Id = r.Id; Key = r.Key; Name = r.Name }
let internal convert2( r : InsertOrUpdateServiceQuery.Record ) : ServiceDTO =
    { Id = r.Id; Key = r.Key; Name = r.Name }

let internal convertOption( ro : GetServicesQuery.Record option) : ServiceDTO option = 
    match ro with
    | Some r -> Some(convert(r))
    | None -> None


let services()  = 
    ( new GetServicesQuery() ).AsyncExecute(null) |> Async.RunSynchronously |> Seq.map ( fun t -> convert(t) )

let serviceByKey( key : string )  = 
    ( new GetServicesQuery() ).AsyncExecute(key) |> Async.RunSynchronously |> Seq.tryHead |> convertOption

let ensureService( key : string, name : string ) :  ServiceDTO =
    ( new InsertOrUpdateServiceQuery() ).AsyncExecute(name, key) 
                                                        |> Async.RunSynchronously 
                                                        |> Seq.head |> convert2
