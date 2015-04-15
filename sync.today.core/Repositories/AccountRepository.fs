module AccountRepository

open AccountsSQL
open sync.today.Models

let insert( account : AccountDTO ) =
    insertAccount( account )
