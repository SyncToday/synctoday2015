module AccountsSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

#if DEBUG
type InsertAccountQuery = SqlCommandProvider<"DB\SQL\InsertAccount.sql", ConnectionStringName>
#else
type InsertAccountQuery = SqlCommandProvider<"""/*  
DECLARE @Name nvarchar(255) = 'Alfons'
DECLARE @ConsumerIdVal int = 1
*/

DECLARE @ConsumerId int = @ConsumerIdVal

INSERT INTO [Accounts] ([Name],[ConsumerId])
     SELECT @Name, ( CASE WHEN @ConsumerId = 0 THEN NULL ELSE @ConsumerId END )
DECLARE @id int = SCOPE_IDENTITY()
SELECT * FROM [Accounts] where Id = @id



""", ConnectionStringName>
#endif

let internal convert( r : InsertAccountQuery.Record ) : AccountDTO =
    { Id = r.Id; Name = r.Name; ConsumerId = r.ConsumerId }

#if ACCOUNTS
let accounts()  = 
    query {
        for r in db().Accounts do
        select ( convert(r) )
    } |> Seq.toList
#endif

let insertAccount( account : AccountDTO ) =
    ( new InsertAccountQuery() ).AsyncExecute((if account.ConsumerId.IsNone then 0 else account.ConsumerId.Value), account.Name ) |> Async.RunSynchronously |> Seq.head |> convert


#if ENSUREACCOUNT
let ensureAccount( account : AccountDTO ) =
    let potentialAccount = accountByNameConsumer( account.Name, account.ConsumerId.Value )
    if potentialAccount.IsNone then
        insertAccount( account )
    else
        potentialAccount.Value.Id
#endif
