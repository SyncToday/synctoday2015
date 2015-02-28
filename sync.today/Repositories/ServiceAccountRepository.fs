module ServiceAccountRepository

open System
open ServiceAccountsSQL
open sync.today.Models

let ServiceAccounts()  = 
    serviceAccounts()

let Download( serviceAccount : ServiceAccountDTO, doDownload : ServiceAccountDTO -> unit ) =
    let serviceAccountPre = { serviceAccount with LastDownloadAttempt = Nullable(DateTime.Now) }
    insertOrUpdate( serviceAccountPre )
    doDownload( serviceAccountPre )
    let serviceAccountPost = { serviceAccount with LastSuccessfulDownload = Nullable(DateTime.Now) }
    insertOrUpdate( serviceAccountPost )


let ServiceAccountsForService( serviceAccount : ServiceDTO )  = 
    serviceAccountsForService( serviceAccount )

let ServiceAccountByAdapter( adapter : AdapterDTO ) =
    serviceAccountByAdapter( adapter )