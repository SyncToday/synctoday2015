module ServiceAccountRepository

open System
open ServiceAccountsSQL
open sync.today.Models

let ServiceAccounts()  = 
    serviceAccounts()

let ServiceAccountById( id : int ) =
    serviceAccountById( id )

let Download( serviceAccount : ServiceAccountDTO, doDownload : ServiceAccountDTO -> unit ) =
    let serviceAccountPre = { serviceAccount with LastDownloadAttempt = Some(DateTime.Now) }
    insertOrUpdate( serviceAccountPre ) |> ignore
    doDownload( serviceAccountPre )
    let serviceAccountPost = { serviceAccount with LastSuccessfulDownload = Some(DateTime.Now) }
    insertOrUpdate( serviceAccountPost )

let Upload( serviceAccount : ServiceAccountDTO, doUpload : ServiceAccountDTO -> unit ) =
    let serviceAccountPre = { serviceAccount with LastUploadAttempt = Some(DateTime.Now) }
    insertOrUpdate( serviceAccountPre ) |> ignore
    doUpload( serviceAccountPre )
    let serviceAccountPost = { serviceAccount with LastSuccessfulUpload = Some(DateTime.Now) }
    insertOrUpdate( serviceAccountPost )

let ServiceAccountsForService( serviceAccount : ServiceDTO )  = 
    serviceAccountsForService( serviceAccount )

let ServiceAccountBAdapterAndConsumer( adapter : AdapterDTO, consumer : ConsumerDTO, service : ServiceDTO ) =
    serviceAccountByAdapterAndConsumer( adapter, consumer, service )

let Insert( serviceAccount : ServiceAccountDTO ) =
    insertOrUpdate( serviceAccount )