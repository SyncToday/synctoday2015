module AccountsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let internal convert( r : SqlConnection.ServiceTypes.Accounts ) : AccountDTO =
    { Id = r.Id; Name = r.Name; ConsumerId = r.ConsumerId }

let accounts()  = 
    query {
        for r in db().Accounts do
        select ( convert(r) )
    } |> Seq.toList

let accountByNameConsumer( name : string, consumerId : int )  = 
    query {
        for r in db().Accounts do
        where ( r.Name = name && r.ConsumerId = Nullable(consumerId)  )
        select ( convert(r) )
    } |> Seq.tryHead

let insertAccount( account : AccountDTO ) =
    let db = db()

    let newAccount = new SqlConnection.ServiceTypes.Accounts()
    newAccount.Name <- account.Name
    newAccount.ConsumerId <- account.ConsumerId

    db.Accounts.InsertOnSubmit newAccount
    db.DataContext.SubmitChanges()
    newAccount.Id

let ensureAccount( account : AccountDTO ) =
    let potentialAccount = accountByNameConsumer( account.Name, account.ConsumerId.Value )
    if potentialAccount.IsNone then
        insertAccount( account )
    else
        potentialAccount.Value.Id

