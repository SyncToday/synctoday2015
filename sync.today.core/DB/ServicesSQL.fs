module ServicesSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

type GetServicesQuery = SqlCommandProvider<"GetServices.sql", ConnectionStringName>
type InsertOrUpdateServiceQuery = SqlCommandProvider<"InsertOrUpdateService.sql", ConnectionStringName>

let internal convert( r : GetServicesQuery.Record ) : ServiceDTO =
    { Id = r.Id; Key = r.Key; Name = r.Name }
let internal convert2( r : InsertOrUpdateServiceQuery.Record ) : ServiceDTO =
    { Id = r.Id; Key = r.Key; Name = r.Name }

let convertOp(c) = 
    convertOption( c, convert )

let services()  = 
    ( new GetServicesQuery() ).AsyncExecute(null) |> Async.RunSynchronously |> Seq.map ( fun t -> convert(t) )

let serviceByKey( key : string )  = 
    ( new GetServicesQuery() ).AsyncExecute(key) |> Async.RunSynchronously |> Seq.tryHead |> convertOp

let ensureService( key : string, name : string ) :  ServiceDTO =
    ( new InsertOrUpdateServiceQuery() ).AsyncExecute(name, key) 
                                                        |> Async.RunSynchronously 
                                                        |> Seq.head |> convert2
