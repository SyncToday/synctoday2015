module DB

open Common
open FSharp.Data
open sync.today.Models

type GetCalDAVEventQuery = SqlCommandProvider<"GetCalDAVEvent.sql", ConnectionStringName>

type GetCalDAVEventsToUploadQuery = SqlCommandProvider<"GetCalDAVEventsToUpload.sql", ConnectionStringName>

let internal convert( r : GetCalDAVEventQuery.Record ) : CalDAVEventDTO = 
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; Description = r.Description; Start = r.Start; End = r.End; LastModified = r.LastModified; 
      Location = r.Location; Summary = r.Summary; CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; Tag = r.Tag; }

type SaveCalDAVEventQuery = SqlCommandProvider<"SaveCalDAVEvent.sql", ConnectionStringName>

let internal convert2( r : SaveCalDAVEventQuery.Record ) : CalDAVEventDTO = 
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; Description = r.Description; Start = r.Start; End = r.End; LastModified = r.LastModified; 
      Location = r.Location; Summary = r.Summary; CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; Tag = r.Tag; }

let internal convert3( r : GetCalDAVEventsToUploadQuery.Record ) : CalDAVEventDTO = 
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; Description = r.Description; Start = r.Start; End = r.End; LastModified = r.LastModified; 
      Location = r.Location; Summary = r.Summary; CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; Tag = r.Tag; }

let save( event : CalDAVEventDTO, serviceAccountId : int, upload : bool, lastDLError : string, lastUPError : string ) =
    try
        ( new SaveCalDAVEventQuery() ).AsyncExecute( 
                event.Id, event.InternalId, optionString2String event.ExternalId, 
                optionString2String event.Description, event.Start, event.End, event.LastModified, 
                optionString2String event.Location, optionString2String event.Summary,
                optionString2String event.CategoriesJSON, serviceAccountId, upload, 
                ( if event.Tag.IsNone then 0 else event.Tag.Value), lastDLError, lastUPError
        ) |> Async.RunSynchronously |> Seq.head |> convert2
    with 
        | ex -> raise (System.ArgumentException("save failed", ex)) 

type PrepareForDownloadQuery = SqlCommandProvider<"PrepareForDownload.sql", ConnectionStringName>

type PrepareForUploadQuery = SqlCommandProvider<"PrepareForUpload.sql", ConnectionStringName>

let internal convertOption( ro : GetCalDAVEventQuery.Record option) : CalDAVEventDTO option = 
    match ro with
    | Some r -> Some(convert(r))
    | None -> None

let calDAVEvent( id: int, externalId: string ) : CalDAVEventDTO option =
    ( new GetCalDAVEventQuery() ).AsyncExecute(id,externalId) |> Async.RunSynchronously |> Seq.tryHead |> convertOption

let prepareForDownload( serviceAccountId : int ) =
    ( new PrepareForDownloadQuery() ).AsyncExecute(serviceAccountId) |> Async.RunSynchronously

let prepareForUpload( serviceAccountId : int ) =
    ( new PrepareForUploadQuery() ).AsyncExecute(serviceAccountId) |> Async.RunSynchronously

let calDAVEventsToUpload( serviceAccountId : int  ) : CalDAVEventDTO seq =
    ( new GetCalDAVEventsToUploadQuery() ).AsyncExecute(serviceAccountId) |> Async.RunSynchronously |> Seq.map convert3

let changeExternalId( id : int, externalId : string ) =
    0 |> ignore

let setAsUploaded( id : int ) =
    0 |> ignore

type ChangeInternalIdBecauseOfDuplicityQuery = SqlCommandProvider<"ChangeInternalIdBecauseOfDuplicity.sql", ConnectionStringName>

let changeInternalIdBecauseOfDuplicity( appointment : CalDAVEventDTO, foundDuplicity : AdapterAppointmentDTO ) =
    ( new ChangeInternalIdBecauseOfDuplicityQuery() ).AsyncExecute(foundDuplicity.InternalId, appointment.Id) |> Async.RunSynchronously
