module ServiceAccountsSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

type GetServiceAccountsQuery = SqlCommandProvider<"DB\SQL\GetServiceAccounts.sql", ConnectionStringName>
type MinServiceAccountLastSuccessfulDownloadQuery = SqlCommandProvider<"DB\SQL\MinServiceAccountLastSuccessfulDownload.sql", ConnectionStringName>
type InsertOrUpdateServiceAccountQuery = SqlCommandProvider<"DB\SQL\InsertOrUpdateServiceAccount.sql", ConnectionStringName>

let internal convert( r : GetServiceAccountsQuery.Record ) : ServiceAccountDTO = 
    { Id = r.Id; LoginJSON = r.LoginJSON; ServiceId = r.ServiceId; AccountId = r.AccountId; LastSuccessfulDownload = r.LastSuccessfulDownload; 
      LastSuccessfulUpload = r.LastSuccessfulUpload; LastDownloadAttempt = r.LastDownloadAttempt; LastUploadAttempt = r.LastUploadAttempt }

let internal convert2( r : InsertOrUpdateServiceAccountQuery.Record ) : ServiceAccountDTO = 
    { Id = r.Id; LoginJSON = r.LoginJSON; ServiceId = r.ServiceId; AccountId = r.AccountId; LastSuccessfulDownload = r.LastSuccessfulDownload; 
      LastSuccessfulUpload = r.LastSuccessfulUpload; LastDownloadAttempt = r.LastDownloadAttempt; LastUploadAttempt = r.LastUploadAttempt }

let internal convertOption( ro : GetServiceAccountsQuery.Record option) : ServiceAccountDTO option = 
    match ro with
    | Some r -> Some(convert(r))
    | None -> None


let internal serviceAccounts()  = 
    ( new GetServiceAccountsQuery() ).AsyncExecute(0, 0, 0, 0, null) |> Async.RunSynchronously |> Seq.map ( fun t -> convert(t) )

let internal serviceAccountsForService( service : ServiceDTO )  = 
    ( new GetServiceAccountsQuery() ).AsyncExecute(0, 0, 0, service.Id, null) |> Async.RunSynchronously |> Seq.map ( fun t -> convert(t) )

let serviceAccountById( id : int )  = 
    ( new GetServiceAccountsQuery() ).AsyncExecute(id, 0, 0, 0, null) |> Async.RunSynchronously |> Seq.tryHead |> convertOption

let internal serviceAccountByLoginJSON( loginJSON : string )  = 
    ( new GetServiceAccountsQuery() ).AsyncExecute(0, 0, 0, 0, loginJSON) |> Async.RunSynchronously |> Seq.tryHead |> convertOption

let serviceAccountByAdapterAndConsumer( adapter : AdapterDTO, consumer : ConsumerDTO, service : ServiceDTO ) =
    ( new GetServiceAccountsQuery() ).AsyncExecute(0, adapter.Id, consumer.Id, service.Id, null) |> Async.RunSynchronously |> Seq.tryHead |> convertOption

let internal insertOrUpdate( serviceAccount : ServiceAccountDTO ) =
    ( new InsertOrUpdateServiceAccountQuery() ).AsyncExecute(serviceAccount.Id, 
                                                    serviceAccount.LoginJSON, serviceAccount.ServiceId, serviceAccount.AccountId, serviceAccount.LastSuccessfulDownload.Value, 
                                                    serviceAccount.LastDownloadAttempt.Value, serviceAccount.LastSuccessfulUpload.Value, serviceAccount.LastUploadAttempt.Value) 
                                                        |> Async.RunSynchronously 
                                                        |> Seq.head |> convert2
    
#if ensureServiceAccount
let ensureServiceAccount( serviceAccount : ServiceAccountDTO ) =
    let potentialServiceAccount = serviceAccountByLoginJSON( serviceAccount.LoginJSON )
    if potentialServiceAccount.IsNone then
        insertServiceAccount( serviceAccount )
    else
        convert(potentialServiceAccount.Value)
#endif

let minServiceAccountLastSuccessfulDownload() : DateTime =
    ( ( new MinServiceAccountLastSuccessfulDownloadQuery() ).AsyncExecute() |> Async.RunSynchronously |> Seq.tryHead ).Value.Value
    

