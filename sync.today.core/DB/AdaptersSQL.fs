module AdaptersSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

#if DEBUG
type GetAllAdaptersQuery = SqlCommandProvider<"DB\SQL\GetAllAdapters.sql", ConnectionStringName>
#else
type GetAllAdaptersQuery = SqlCommandProvider<"SELECT * FROM Adapters WHERE Name = ISNULL(@Name, Name) ORDER BY Name ASC", ConnectionStringName>
#endif
#if DEBUG
type EnsureAdaptersQuery = SqlCommandProvider<"DB\SQL\EnsureAdapter.sql", ConnectionStringName>
#else
type EnsureAdaptersQuery = SqlCommandProvider<"""-- uncomment for testing
/*  
DECLARE @nameVal nvarchar(255) = 'huhla555'
*/

DECLARE @name nvarchar(255) = @nameVal

BEGIN TRAN
if not exists (select * from Adapters with (updlock,serializable) where Name = @name)
BEGIN
  INSERT Adapters(Name) SELECT @name;
END
COMMIT

SELECT * FROM Adapters WHERE Name = @name

""", ConnectionStringName>
#endif

let internal convert( r : GetAllAdaptersQuery.Record ) : AdapterDTO = 
    { Id = r.Id; Name = r.Name }

let internal convert2( r : EnsureAdaptersQuery.Record ) : AdapterDTO = 
    { Id = r.Id; Name = r.Name }

let internal convertOption( ro : GetAllAdaptersQuery.Record option) : AdapterDTO option = 
    match ro with
    | Some r -> Some(convert(r))
    | None -> None

let internal adapters() : AdapterDTO seq = 
    ( new GetAllAdaptersQuery() ).AsyncExecute(null) |> Async.RunSynchronously |> Seq.map ( fun t -> convert(t) )

let internal adapterByName( name : string ) : AdapterDTO option = 
    ( new GetAllAdaptersQuery() ).AsyncExecute(name) |> Async.RunSynchronously |> Seq.tryHead |> convertOption

let internal ensureAdapter( key : string, name : string) : AdapterDTO =
    ( new EnsureAdaptersQuery() ).AsyncExecute(name) |> Async.RunSynchronously |> Seq.head |> convert2
