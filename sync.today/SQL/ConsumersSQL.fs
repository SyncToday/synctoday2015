module ConsumersSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let internal convert( r : SqlConnection.ServiceTypes.Consumers ) : ConsumerDTO =
    { Id = r.Id; Name = r.Name }

let internal consumers()  = 
    query {
        for r in db().Consumers do
        select ( convert(r) )
    } |> Seq.toList

let consumer( id : int )  = 
    query {
        for r in db().Consumers do
        where (r.Id = id)
        select ( convert(r) )
    } |> Seq.tryHead

let insertConsumer( consumer : ConsumerDTO ) = 
    let db = db()

    let newConsumer = new SqlConnection.ServiceTypes.Consumers()
    newConsumer.Name <- consumer.Name

    db.Consumers.InsertOnSubmit newConsumer
    db.DataContext.SubmitChanges()
    newConsumer.Id

let getConsumerByServiceAccountId( serviceAccountId : int ) =
    let db = db()
    query {
        for r in db.Consumers do
        join v in db.Accounts on ( r.Id = v.ConsumerId.Value )
        join s in db.ServiceAccounts on ( v.Id = s.AccountId )
        where ( s.Id = serviceAccountId )
        select ( convert(r) )
    } |> Seq.tryHead

let getConsumerByConsumerAdapterId( consumerAdapterId : int ) =
    let db = db()
    query {
        for r in db.Consumers do
        join v in db.ConsumerAdapters on ( r.Id = v.ConsumerId )
        where ( v.Id = consumerAdapterId )
        select ( convert(r) )
    } |> Seq.tryHead
