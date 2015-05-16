module ConsumersSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

type private GetConsumersQuery = SqlCommandProvider<"GetConsumers.sql", ConnectionStringName>
type private InsertConsumerQuery = SqlCommandProvider<"InsertConsumer.sql", ConnectionStringName>
type private GetConsumerByServiceAccountIdQuery = SqlCommandProvider<"GetConsumerByServiceAccountId.sql", ConnectionStringName>
type private GetConsumerByConsumerAdapterIdQuery = SqlCommandProvider<"GetConsumerByConsumerAdapterId.sql", ConnectionStringName>

let internal convert( r : GetConsumersQuery.Record ) : ConsumerDTO =
    { Id = r.Id; Name = r.Name }
let internal convert2( r : InsertConsumerQuery.Record ) : ConsumerDTO =
    { Id = r.Id; Name = r.Name }
let internal convert3( r : GetConsumerByServiceAccountIdQuery.Record ) : ConsumerDTO =
    { Id = r.Id; Name = r.Name }
let internal convert4( r : GetConsumerByConsumerAdapterIdQuery.Record ) : ConsumerDTO =
    { Id = r.Id; Name = r.Name }

let convertOp(c) = 
    convertOption( c, convert )

let convertOp2(c) = 
    convertOption( c, convert3 )

let convertOp3(c) = 
    convertOption( c, convert4 )

let internal consumers()  = 
    ( new GetConsumersQuery() ).AsyncExecute(0, null) |> Async.RunSynchronously |> Seq.map ( fun t -> convert(t) )

let consumer( id : int )  = 
    ( new GetConsumersQuery() ).AsyncExecute(id, null) |> Async.RunSynchronously |> Seq.tryHead |> convertOp

let consumerByName( name : string )  = 
    ( new GetConsumersQuery() ).AsyncExecute(0, name) |> Async.RunSynchronously |> Seq.tryHead |> convertOp

let insertConsumer( consumer : ConsumerDTO ) = 
    ( new InsertConsumerQuery() ).AsyncExecute(consumer.Name) |> Async.RunSynchronously |> Seq.head |> convert2

let getConsumerByServiceAccountId( serviceAccountId : int ) =
    ( new GetConsumerByServiceAccountIdQuery() ).AsyncExecute(serviceAccountId) |> Async.RunSynchronously |> Seq.tryHead |> convertOp2

let getConsumerByConsumerAdapterId( consumerAdapterId : int ) =
    ( new GetConsumerByConsumerAdapterIdQuery() ).AsyncExecute(consumerAdapterId) |> Async.RunSynchronously |> Seq.tryHead |> convertOp3
