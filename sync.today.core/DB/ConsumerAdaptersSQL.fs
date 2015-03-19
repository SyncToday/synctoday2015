module ConsumerAdaptersSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

type InsertOrUpdateConsumerAdapterQuery = SqlCommandProvider<"DB\SQL\InsertOrUpdateConsumerAdapter.sql", ConnectionStringName>
type GetConsumerAdaptersQuery = SqlCommandProvider<"DB\SQL\GetConsumerAdapters.sql", ConnectionStringName>

let internal convert( r : InsertOrUpdateConsumerAdapterQuery.Record ) : ConsumerAdapterDTO =
    { Id = r.Id; AdapterId = r.AdapterId; ConsumerId = r.ConsumerId; DataJSON = r.DateJSON }
let internal convert2( r : GetConsumerAdaptersQuery.Record ) : ConsumerAdapterDTO =
    { Id = r.Id; AdapterId = r.AdapterId; ConsumerId = r.ConsumerId; DataJSON = r.DateJSON }
let internal convertOption( ro : GetConsumerAdaptersQuery.Record option) : ConsumerAdapterDTO option = 
    match ro with
    | Some r -> Some(convert2(r))
    | None -> None

let insertOrUpdateConsumerAdapter( consumerAdapter : ConsumerAdapterDTO ) = 
    ( new InsertOrUpdateConsumerAdapterQuery() ).AsyncExecute(consumerAdapter.AdapterId, consumerAdapter.ConsumerId, consumerAdapter.DataJSON) 
        |> Async.RunSynchronously |> Seq.head |> convert

let consumerAdapters() : ConsumerAdapterDTO seq =
    ( new GetConsumerAdaptersQuery() ).AsyncExecute(0,0) |> Async.RunSynchronously |> Seq.map ( fun t -> convert2(t) )

#if consumerAdapterById
let consumerAdapterById( id : int ) : ConsumerAdapterDTO option =
    let db = db()
    query {
        for r in db.ConsumerAdapters do
        where ( r.Id = id )
        select ( convert(r) )
    } |> Seq.tryHead
#endif

let consumerAdapterByConsumerAdapter( consumerId : int, adapterId : int ) : ConsumerAdapterDTO option =
    ( new GetConsumerAdaptersQuery() ).AsyncExecute(adapterId,consumerId) |> Async.RunSynchronously |> Seq.tryHead |> convertOption

let consumerAdapter( consumer : ConsumerDTO, adapter : AdapterDTO ) : ConsumerAdapterDTO option =
    consumerAdapterByConsumerAdapter( consumer.Id, adapter.Id )

#if ensureConsumerAdapter
let ensureConsumerAdapter( consumerAdapter : ConsumerAdapterDTO ) = 
    let potentialConsumerAdapter = consumerAdapterByConsumerAdapter( consumerAdapter.ConsumerId, consumerAdapter.AdapterId )
    if potentialConsumerAdapter.IsNone then
        insertConsumerAdapter( consumerAdapter )
    else
        potentialConsumerAdapter.Value
#endif