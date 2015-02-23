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