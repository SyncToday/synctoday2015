module DB

open Common
open FSharp.Data
open sync.today.Models

type SaveCalDAVEventQuery = SqlCommandProvider<"SaveCalDAVEvent.sql", ConnectionStringName>

(* 
let save( event : CalDAVEventDTO ) =
    ( new SaveCalDAVEventQuery() ).AsyncExecute( (if event.Id.ConsumerId.IsNone then 0 else account.ConsumerId.Value), account.Name ) |> Async.RunSynchronously |> Seq.head |> convert
*)
