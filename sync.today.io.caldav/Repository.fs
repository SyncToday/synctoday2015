module Repository

open System
open Common
open sync.today.Models

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

let public CALDAV_SERVICE_KEY="CALDAV"

let copyDTOToEvent( r : CalDav.Event, source : CalDAVEventDTO )  =
    r.Description <- source.Description
    r.Start <- Nullable<DateTime>(source.Start)
    r.End <- Nullable<DateTime>(source.End)
    r.Location <- source.Location
    r.Summary <- source.Summary

let copyEventToDTO( r : CalDav.Event, serviceAccountId : int, tag : int ) : CalDAVEventDTO =
    try 
        { Id = 0; InternalId = Guid.NewGuid(); ExternalId = r.UID; Description = r.Description; Start = r.Start.Value; End = r.End.Value; LastModified = r.LastModified.Value; 
          Location = r.Location; Summary = r.Summary; CategoriesJSON = json(r.Categories); ServiceAccountId = serviceAccountId; Tag = tag }
    with 
        | ex -> raise (System.ArgumentException("copyEventToDTO failed", ex)) 
