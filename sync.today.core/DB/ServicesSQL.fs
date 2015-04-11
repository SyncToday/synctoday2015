module ServicesSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

#if DEBUG
type GetServicesQuery = SqlCommandProvider<"DB\SQL\GetServices.sql", ConnectionStringName>
#else
type GetServicesQuery = SqlCommandProvider<"""SELECT * FROM [Services] WHERE [Key] = ISNULL(@Key, [Key])""", ConnectionStringName>
#endif
#if DEBUG
type InsertOrUpdateServiceQuery = SqlCommandProvider<"DB\SQL\InsertOrUpdateService.sql", ConnectionStringName>
#else
type InsertOrUpdateServiceQuery = SqlCommandProvider<"""-- uncomment for testing
/* 
declare @idVal int = 7
DECLARE @nameVal nvarchar(255) = 'huhla2'
*/

DECLARE @Name nvarchar(255) = @NameVal
DECLARE @Key nvarchar(255) = @KeyVal

BEGIN TRAN
UPDATE [Services] with (serializable) SET Name=@Name WHERE [Key] = @Key
IF @@ROWCOUNT = 0
BEGIN
  INSERT [Services](Name,[Key]) SELECT @Name, @Key
END
COMMIT

SELECT * FROM [Services] WHERE [Key] = @Key

""", ConnectionStringName>
#endif

let internal convert( r : GetServicesQuery.Record ) : ServiceDTO =
    { Id = r.Id; Key = r.Key; Name = r.Name }
let internal convert2( r : InsertOrUpdateServiceQuery.Record ) : ServiceDTO =
    { Id = r.Id; Key = r.Key; Name = r.Name }

let internal convertOption( ro : GetServicesQuery.Record option) : ServiceDTO option = 
    match ro with
    | Some r -> Some(convert(r))
    | None -> None


let services()  = 
    ( new GetServicesQuery() ).AsyncExecute(null) |> Async.RunSynchronously |> Seq.map ( fun t -> convert(t) )

let serviceByKey( key : string )  = 
    ( new GetServicesQuery() ).AsyncExecute(key) |> Async.RunSynchronously |> Seq.tryHead |> convertOption

let ensureService( key : string, name : string ) :  ServiceDTO =
    ( new InsertOrUpdateServiceQuery() ).AsyncExecute(name, key) 
                                                        |> Async.RunSynchronously 
                                                        |> Seq.head |> convert2
