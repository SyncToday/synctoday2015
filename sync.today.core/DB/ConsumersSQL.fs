module ConsumersSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

#if DEBUG
type GetConsumersQuery = SqlCommandProvider<"DB\SQL\GetConsumers.sql", ConnectionStringName>
#else
type GetConsumersQuery = SqlCommandProvider<"""/*
DECLARE @id int = 0
DECLARE @Name nvarchar(max) = 'ahoj'
*/
DECLARE @idVal int = @Id
SELECT * FROM Consumers WHERE Id = ( CASE WHEN @idVal = 0 THEN Id ELSE @idVal END ) AND Name = ISNULL(@Name, Name) ORDER BY Name ASC""", ConnectionStringName>
#endif
#if DEBUG
type InsertConsumerQuery = SqlCommandProvider<"DB\SQL\InsertConsumer.sql", ConnectionStringName>
#else
type InsertConsumerQuery = SqlCommandProvider<"""--DECLARE @Name nvarchar(255) = 'joe doe'
INSERT INTO [dbo].[Consumers]
           ([Name])
     VALUES
           (@Name)
DECLARE @id int = SCOPE_IDENTITY()
SELECT * FROM [Consumers] WHERE Id = @id
""", ConnectionStringName>
#endif
#if DEBUG
type GetConsumerByServiceAccountIdQuery = SqlCommandProvider<"DB\SQL\GetConsumerByServiceAccountId.sql", ConnectionStringName>
#else
type GetConsumerByServiceAccountIdQuery = SqlCommandProvider<"""--declare @serviceAccountId int = 1

select r.* from Consumers r
inner join Accounts v on r.Id = v.ConsumerId
inner join ServiceAccounts s on v.Id = s.AccountId
where s.Id = @serviceAccountId
""", ConnectionStringName>
#endif
#if DEBUG
type GetConsumerByConsumerAdapterIdQuery = SqlCommandProvider<"DB\SQL\GetConsumerByConsumerAdapterId.sql", ConnectionStringName>
#else
type GetConsumerByConsumerAdapterIdQuery = SqlCommandProvider<"""--declare @consumerAdapterId int = 1

select r.* from Consumers r 
inner join ConsumerAdapters v on r.Id = v.ConsumerId
where v.Id = @consumerAdapterId
""", ConnectionStringName>
#endif

let internal convert( r : GetConsumersQuery.Record ) : ConsumerDTO =
    { Id = r.Id; Name = r.Name }
let internal convert2( r : InsertConsumerQuery.Record ) : ConsumerDTO =
    { Id = r.Id; Name = r.Name }
let internal convert3( r : GetConsumerByServiceAccountIdQuery.Record ) : ConsumerDTO =
    { Id = r.Id; Name = r.Name }
let internal convert4( r : GetConsumerByConsumerAdapterIdQuery.Record ) : ConsumerDTO =
    { Id = r.Id; Name = r.Name }

let internal convertOption( ro : GetConsumersQuery.Record option) : ConsumerDTO option = 
    match ro with
    | Some r -> Some(convert(r))
    | None -> None

let internal convertOption2( ro : GetConsumerByServiceAccountIdQuery.Record option) : ConsumerDTO option = 
    match ro with
    | Some r -> Some(convert3(r))
    | None -> None

let internal convertOption3( ro : GetConsumerByConsumerAdapterIdQuery.Record option) : ConsumerDTO option = 
    match ro with
    | Some r -> Some(convert4(r))
    | None -> None

let internal consumers()  = 
    ( new GetConsumersQuery() ).AsyncExecute(0, null) |> Async.RunSynchronously |> Seq.map ( fun t -> convert(t) )

let consumer( id : int )  = 
    ( new GetConsumersQuery() ).AsyncExecute(id, null) |> Async.RunSynchronously |> Seq.tryHead |> convertOption

let consumerByName( name : string )  = 
    ( new GetConsumersQuery() ).AsyncExecute(0, name) |> Async.RunSynchronously |> Seq.tryHead |> convertOption

let insertConsumer( consumer : ConsumerDTO ) = 
    ( new InsertConsumerQuery() ).AsyncExecute(consumer.Name) |> Async.RunSynchronously |> Seq.head |> convert2

let getConsumerByServiceAccountId( serviceAccountId : int ) =
    ( new GetConsumerByServiceAccountIdQuery() ).AsyncExecute(serviceAccountId) |> Async.RunSynchronously |> Seq.tryHead |> convertOption2

let getConsumerByConsumerAdapterId( consumerAdapterId : int ) =
    ( new GetConsumerByConsumerAdapterIdQuery() ).AsyncExecute(consumerAdapterId) |> Async.RunSynchronously |> Seq.tryHead |> convertOption3
