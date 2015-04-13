module ServiceAccountsSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

#if DEBUG
type GetServiceAccountsQuery = SqlCommandProvider<"DB\SQL\GetServiceAccounts.sql", ConnectionStringName>
#else
type GetServiceAccountsQuery = SqlCommandProvider<"""/* 
declare @idVal int = 0
declare @LoginJSON nvarchar(max) = '' 
declare @adapterIdVal int = 0
declare @consumerIdVal int = 0
declare @serviceIdVal int = 1
*/

declare @id int = @idVal
declare @adapterId int = @adapterIdVal
declare @consumerId int = @consumerIdVal
declare @serviceId int = @serviceIdVal

print @adapterId

IF @adapterId = 0 AND @consumerId = 0 AND @serviceId = 0
	select * from ServiceAccounts where 
		Id = ( CASE WHEN @id = 0 THEN Id ELSE @id END ) AND
		LoginJSON = ISNULL( @LoginJSON, LoginJSON )
ELSE
        select distinct r.* from ServiceAccounts r
        left join Accounts s  on ( r.AccountId = s.Id )
        left join ConsumerAdapters t on (s.ConsumerId = t.ConsumerId)
        where 
		ISNULL(t.AdapterId, 0) = ( CASE WHEN @adapterId = 0 THEN ISNULL(t.AdapterId, 0) ELSE @adapterId END )  AND 
		ISNULL(s.ConsumerId, 0) = ( CASE WHEN @consumerId = 0 THEN ISNULL(s.ConsumerId, 0) ELSE @consumerId END )  AND 
		ISNULL(r.ServiceId, 0) = @serviceId 
	""", ConnectionStringName>
#endif
#if DEBUG
type MinServiceAccountLastSuccessfulDownloadQuery = SqlCommandProvider<"DB\SQL\MinServiceAccountLastSuccessfulDownload.sql", ConnectionStringName>
#else
type MinServiceAccountLastSuccessfulDownloadQuery = SqlCommandProvider<"""select ISNULL(min(LastSuccessfulDownload), getdate() - 30 ) FROM ServiceAccounts
""", ConnectionStringName>
#endif
#if DEBUG
type InsertOrUpdateServiceAccountQuery = SqlCommandProvider<"DB\SQL\InsertOrUpdateServiceAccount.sql", ConnectionStringName>
#else
type InsertOrUpdateServiceAccountQuery = SqlCommandProvider<"""-- uncomment for testing
/* 
declare @idVal int = 7
DECLARE @nameVal nvarchar(255) = 'huhla2'
*/

DECLARE @id int = @idVal
DECLARE @LoginJSON nvarchar(max) = @LoginJSONVal
DECLARE @ServiceId int = @ServiceIdVal
DECLARE @AccountId int = @AccountIdVal
DECLARE @LastSuccessfulDownload datetime = @LastSuccessfulDownloadVal
DECLARE @LastDownloadAttempt datetime = @LastDownloadAttemptVal
DECLARE @LastSuccessfulUpload datetime = @LastSuccessfulUploadVal
DECLARE @LastUploadAttempt datetime = @LastUploadAttemptVal

BEGIN TRAN
UPDATE ServiceAccounts with (serializable) SET 
	LoginJSON=@LoginJSON,ServiceId=@ServiceId,AccountId=@AccountId,
	LastSuccessfulDownload=@LastSuccessfulDownload,
	LastDownloadAttempt=@LastDownloadAttempt,
	LastSuccessfulUpload=@LastSuccessfulUpload,
	LastUploadAttempt=@LastUploadAttempt
	WHERE Id = @id;
IF @@ROWCOUNT = 0
BEGIN
  INSERT ServiceAccounts(LoginJSON
           ,ServiceId
           ,AccountId
           ,LastSuccessfulDownload
           ,LastDownloadAttempt
           ,LastSuccessfulUpload
           ,LastUploadAttempt) SELECT @LoginJSON
           ,@ServiceId
           ,@AccountId
           ,@LastSuccessfulDownload
           ,@LastDownloadAttempt
           ,@LastSuccessfulUpload
           ,@LastUploadAttempt
;
  SELECT @id = SCOPE_IDENTITY()
END
COMMIT

SELECT * FROM ServiceAccounts WHERE Id = @id
""", ConnectionStringName>
#endif

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
                                                    serviceAccount.LoginJSON, serviceAccount.ServiceId, serviceAccount.AccountId, 
                                                    ( if serviceAccount.LastSuccessfulDownload.IsNone then DateTime.Today else serviceAccount.LastSuccessfulDownload.Value ), 
                                                    ( if serviceAccount.LastDownloadAttempt.IsNone then DateTime.Today else serviceAccount.LastDownloadAttempt.Value ), 
                                                    ( if serviceAccount.LastSuccessfulUpload.IsNone then DateTime.Today else serviceAccount.LastSuccessfulUpload.Value ), 
                                                    ( if serviceAccount.LastUploadAttempt.IsNone then DateTime.Today else serviceAccount.LastUploadAttempt.Value) ) 
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
    

