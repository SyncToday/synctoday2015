module DB

open Common
open FSharp.Data
open sync.today.Models

type SaveCalDAVEventQuery = SqlCommandProvider<"SaveCalDAVEvent.sql", ConnectionStringName>

(* 
let save( event : CalDAVEventDTO ) =
    ( new SaveCalDAVEventQuery() ).AsyncExecute( (if event.Id.ConsumerId.IsNone then 0 else account.ConsumerId.Value), account.Name ) |> Async.RunSynchronously |> Seq.head |> convert
*)

type GetCalDAVEventQuery = SqlCommandProvider<"GetCalDAVEvent.sql", ConnectionStringName>
type PrepareForDownloadQuery = SqlCommandProvider<"PrepareForDownload.sql", ConnectionStringName>

let internal convert( r : GetCalDAVEventQuery.Record ) : CalDAVEventDTO = 
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; Description = r.Description; Start = r.Start; End = r.End; LastModified = r.LastModified; 
      Location = r.Location; Summary = r.Summary; CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; Tag = r.Tag; }


let internal convertOption( ro : GetCalDAVEventQuery.Record option) : CalDAVEventDTO option = 
    match ro with
    | Some r -> Some(convert(r))
    | None -> None

let calDAVEvent( id: int, externalId: string ) : CalDAVEventDTO option =
    ( new GetCalDAVEventQuery() ).AsyncExecute(id,externalId) |> Async.RunSynchronously |> Seq.tryHead |> convertOption

let prepareForDownload( serviceAccountId : int ) =
    ( new PrepareForDownloadQuery() ).AsyncExecute(serviceAccountId) |> Async.RunSynchronously
