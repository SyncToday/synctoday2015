module ConsumerAdaptersSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let internal convert( r : SqlConnection.ServiceTypes.ConsumerAdapters ) : ConsumerAdapterDTO =
    { Id = r.Id; AdapterId = r.AdapterId; ConsumerId = r.ConsumerId; DataJSON = r.DateJSON }

let getConsumerAdapterByAdapterIdAndData( adapterId : int, data : string ) : ConsumerAdapterDTO option =
    let db = db()
    query {
        for r in db.ConsumerAdapters do
        where ( r.AdapterId = adapterId && r.DateJSON = data )
        select ( convert(r) )
    } |> Seq.tryHead

let insertConsumerAdapter( consumerAdapter : ConsumerAdapterDTO ) = 
    let db = db()

    let newConsumerAdapter = new SqlConnection.ServiceTypes.ConsumerAdapters()
    newConsumerAdapter.AdapterId <- consumerAdapter.AdapterId
    newConsumerAdapter.ConsumerId <- consumerAdapter.ConsumerId
    newConsumerAdapter.DateJSON <- consumerAdapter.DataJSON

    db.ConsumerAdapters.InsertOnSubmit newConsumerAdapter
    db.DataContext.SubmitChanges()
    convert(newConsumerAdapter)

let consumerAdapters() : ConsumerAdapterDTO list =
    let db = db()
    query {
        for r in db.ConsumerAdapters do
        select ( convert(r) )
    } |> Seq.toList

let consumerAdapterById( id : int ) : ConsumerAdapterDTO option =
    let db = db()
    query {
        for r in db.ConsumerAdapters do
        where ( r.Id = id )
        select ( convert(r) )
    } |> Seq.tryHead

let consumerAdapterByConsumerAdapter( consumerId : int, adapterId : int ) : ConsumerAdapterDTO option =
    let db = db()
    query {
        for r in db.ConsumerAdapters do
        where ( r.AdapterId = adapterId && r.ConsumerId = consumerId )
        select ( convert(r) )
    } |> Seq.tryHead


let consumerAdapter( consumer : ConsumerDTO, adapter : AdapterDTO ) : ConsumerAdapterDTO option =
    consumerAdapterByConsumerAdapter( consumer.Id, adapter.Id )

let ensureConsumerAdapter( consumerAdapter : ConsumerAdapterDTO ) = 
    let potentialConsumerAdapter = consumerAdapterByConsumerAdapter( consumerAdapter.ConsumerId, consumerAdapter.AdapterId )
    if potentialConsumerAdapter.IsNone then
        insertConsumerAdapter( consumerAdapter )
    else
        potentialConsumerAdapter.Value
