module ConsumerAdaptersSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

#if DEBUG
type InsertOrUpdateConsumerAdapterQuery = SqlCommandProvider<"DB\SQL\InsertOrUpdateConsumerAdapter.sql", ConnectionStringName>
#else
type InsertOrUpdateConsumerAdapterQuery = SqlCommandProvider<"""-- uncomment for testings
/* 
DECLARE @AdapterIdVal int = 1
DECLARE @ConsumerIdVal int = 2
DECLARE @DataJSONVal nvarchar(max) = 'AAA\b'
*/

DECLARE @AdapterId int = @AdapterIdVal
DECLARE @ConsumerId int = @ConsumerIdVal
DECLARE @DataJSON nvarchar(max) = @DataJSONVal

BEGIN TRAN
UPDATE [ConsumerAdapters] with (serializable) SET DateJSON=@DataJSON WHERE AdapterId = @AdapterId AND ConsumerId = @ConsumerId
IF @@ROWCOUNT = 0
BEGIN
  INSERT [ConsumerAdapters](AdapterId,ConsumerId,DateJSON) SELECT @AdapterId, @ConsumerId, @DataJSON
END
COMMIT

SELECT * FROM [ConsumerAdapters] WHERE AdapterId = @AdapterId AND ConsumerId = @ConsumerId """, ConnectionStringName>
#endif
#if DEBUG
type GetConsumerAdaptersQuery = SqlCommandProvider<"DB\SQL\GetConsumerAdapters.sql", ConnectionStringName>
#else
type GetConsumerAdaptersQuery = SqlCommandProvider<"""/* 
declare @adapterIdVal int = 1
declare @consumerIdVal int = 3
*/

declare @adapterId int = @adapterIdVal
declare @consumerId int = @consumerIdVal

SELECT * FROM ConsumerAdapters WHERE 
	AdapterId = ( CASE WHEN @adapterId = 0 THEN AdapterId ELSE @adapterId END ) AND
	ConsumerId = ( CASE WHEN @consumerId = 0 THEN ConsumerId ELSE @consumerId END )
 """, ConnectionStringName>
#endif

let internal convert( r : InsertOrUpdateConsumerAdapterQuery.Record ) : ConsumerAdapterDTO =
    { Id = r.Id; AdapterId = r.AdapterId; ConsumerId = r.ConsumerId; DataJSON = r.DateJSON }
let internal convert2( r : GetConsumerAdaptersQuery.Record ) : ConsumerAdapterDTO =
    { Id = r.Id; AdapterId = r.AdapterId; ConsumerId = r.ConsumerId; DataJSON = r.DateJSON }
let internal convertOption( ro : GetConsumerAdaptersQuery.Record option) : ConsumerAdapterDTO option = 
    match ro with
    | Some r -> Some(convert2(r))
    | None -> None

let insertOrUpdateConsumerAdapter( consumerAdapter : ConsumerAdapterDTO ) = 
    ( new InsertOrUpdateConsumerAdapterQuery() ).AsyncExecute(consumerAdapter.AdapterId, consumerAdapter.ConsumerId, consumerAdapter.DataJSON) 
        |> Async.RunSynchronously |> Seq.head |> convert

let consumerAdapters() : ConsumerAdapterDTO seq =
    ( new GetConsumerAdaptersQuery() ).AsyncExecute(0,0, null) |> Async.RunSynchronously |> Seq.map ( fun t -> convert2(t) )

#if consumerAdapterById
let consumerAdapterById( id : int ) : ConsumerAdapterDTO option =
    let db = db()
    query {
        for r in db.ConsumerAdapters do
        where ( r.Id = id )
        select ( convert(r) )
    } |> Seq.tryHead
#endif

let consumerAdapterByConsumerAdapter( consumerId : int, adapterId : int ) : ConsumerAdapterDTO option =
    ( new GetConsumerAdaptersQuery() ).AsyncExecute(adapterId,consumerId, null) |> Async.RunSynchronously |> Seq.tryHead |> convertOption

let consumerAdapter( consumer : ConsumerDTO, adapter : AdapterDTO ) : ConsumerAdapterDTO option =
    consumerAdapterByConsumerAdapter( consumer.Id, adapter.Id )

#if ensureConsumerAdapter
let ensureConsumerAdapter( consumerAdapter : ConsumerAdapterDTO ) = 
    let potentialConsumerAdapter = consumerAdapterByConsumerAdapter( consumerAdapter.ConsumerId, consumerAdapter.AdapterId )
    if potentialConsumerAdapter.IsNone then
        insertConsumerAdapter( consumerAdapter )
    else
        potentialConsumerAdapter.Value
#endif

let getConsumerAdapterByAdapterIdAndData( adapterId : int, data : string ) : ConsumerAdapterDTO option =
    ( new GetConsumerAdaptersQuery() ).AsyncExecute(adapterId,0, data) |> Async.RunSynchronously |> Seq.tryHead |> convertOption
