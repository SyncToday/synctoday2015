module ServiceAccountRepository

open System
open ServiceAccountsSQL
open sync.today.Models

let ServiceAccounts()  = 
    serviceAccounts()

let Download( serviceAccount : ServiceAccountDTO ) =
    0 |> ignore

