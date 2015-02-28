module ServiceAccountsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let internal convert( r : SqlConnection.ServiceTypes.ServiceAccounts ) : ServiceAccountDTO = 
    { Id = r.Id; LoginJSON = r.LoginJSON; ServiceId = r.ServiceId; AccountId = r.AccountId; LastSuccessfulDownload = r.LastSuccessfulDownload; 
      LastSuccessfulUpload = r.LastSuccessfulUpload; LastDownloadAttempt = r.LastDownloadAttempt; LastUploadAttempt = r.LastUploadAttempt }

let internal serviceAccounts()  = 
    query {
        for r in db().ServiceAccounts do
        select ( convert( r ) )
    } |> Seq.toList

let internal serviceAccountsForService( serviceAccount : ServiceDTO )  = 
    query {
        for r in db().ServiceAccounts do
        where ( r.ServiceId = serviceAccount.Id )
        select ( convert( r ) )
    } |> Seq.toList

let internal serviceAccountById( id : int )  = 
    query {
        for r in db().ServiceAccounts do
        where ( r.Id = id ) 
        select r
    } |> Seq.tryHead

let internal copyToServiceAccount(newServiceAccount : SqlConnection.ServiceTypes.ServiceAccounts, serviceAccount : ServiceAccountDTO) =
    newServiceAccount.AccountId <- serviceAccount.AccountId
    newServiceAccount.LastDownloadAttempt <- serviceAccount.LastDownloadAttempt
    newServiceAccount.LastSuccessfulDownload <- serviceAccount.LastSuccessfulDownload
    newServiceAccount.LastSuccessfulUpload <- serviceAccount.LastSuccessfulUpload
    newServiceAccount.LastUploadAttempt <- serviceAccount.LastUploadAttempt
    newServiceAccount.LoginJSON <- serviceAccount.LoginJSON
    newServiceAccount.ServiceId <- serviceAccount.ServiceId

let internal insertOrUpdate( serviceAccount : ServiceAccountDTO ) =
    let db = db()
    let possibleServiceAccount = 
        query {
            for r in db.ServiceAccounts do
            where ( r.Id = serviceAccount.Id ) 
            select r
        } |> Seq.tryHead
    if ( box possibleServiceAccount = null ) then
        let newServiceAccount = new SqlConnection.ServiceTypes.ServiceAccounts()
        copyToServiceAccount(newServiceAccount, serviceAccount)

        db.ServiceAccounts.InsertOnSubmit newServiceAccount
    else
        copyToServiceAccount(possibleServiceAccount.Value, serviceAccount)
    db.DataContext.SubmitChanges()
    
let insertServiceAccount( serviceAccount : ServiceAccountDTO ) =
    let db = db()

    let newServiceAccount = new SqlConnection.ServiceTypes.ServiceAccounts()
    copyToServiceAccount( newServiceAccount, serviceAccount )

    db.ServiceAccounts.InsertOnSubmit newServiceAccount
    db.DataContext.SubmitChanges()
    newServiceAccount.Id

let serviceAccountByAdapterAndConsumer( adapter : AdapterDTO, consumer : ConsumerDTO ) =
    let db = db()
    query {
        for r in db.ServiceAccounts do
        join s in db.Accounts on ( r.AccountId = s.Id )
        join t in db.ConsumerAdapters on (s.ConsumerId = Nullable(t.ConsumerId))
        where ( t.AdapterId = adapter.Id && s.ConsumerId = Nullable(consumer.Id) )
        select ( convert( r ) )
    } |> Seq.tryHead
    