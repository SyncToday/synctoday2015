module Repository

open System
open Common
open sync.today.Models
open FSharp.Data
open DB

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

let public CALDAV_SERVICE_KEY="CALDAV"

type JsonLogin = JsonProvider<"""{ "userName" : "John", "password" : "UASJXMLXL", "server" : "jidasjidjasi.dasjdasij.com" }""">

[<CLIMutable>]
type Login =
    {   
        userName : string
        password : string
        server : string
        serviceAccountId : int
    }

let getLogin( loginJSON : string, serviceAccountId : int ) : Login = 
    let parsed = 
        if not (loginJSON.StartsWith( "{" )) then 
            JsonLogin.Parse( "{" + loginJSON + "}" )
        else
            JsonLogin.Parse( loginJSON )
    { userName = parsed.UserName;  password = parsed.Password; server = parsed.Server; serviceAccountId  = serviceAccountId }

let copyDTOToEvent( r : CalDav.Event, source : CalDAVEventDTO )  =
    r.Description <- optionString2String source.Description
    r.Start <- Nullable<DateTime>(source.Start)
    r.End <- Nullable<DateTime>(source.End)
    r.Location <- optionString2String source.Location
    r.Summary <- optionString2String source.Summary

let copyEventToDTO( r : CalDav.Event, serviceAccountId : int, tag : int option ) : CalDAVEventDTO =
    try 
        { Id = 0; InternalId = Guid.NewGuid(); ExternalId = Some(r.UID); Description = string2optionString r.Description; Start = r.Start.Value; End = r.End.Value; 
          LastModified = 
            if r.LastModified.HasValue then r.LastModified.Value else 
                if r.Created.HasValue then r.Created.Value 
                    else DateTime.Now;
          Location = string2optionString r.Location; Summary = string2optionString r.Summary; CategoriesJSON = Some(json(r.Categories)); 
          ServiceAccountId = serviceAccountId; 
          Tag = tag }
    with 
        | ex -> raise (System.ArgumentException("copyEventToDTO failed", ex)) 

let getCalendars( login ) =
    let _Server = new CalDav.Client.Server(login.server, login.userName, login.password);
    let _Calendars = _Server.GetCalendars()
    _Calendars

let getCalDAVServerEvents( _from : DateTime, _to : DateTime, login : Login ) =
    let serviceAccountId = login.serviceAccountId
    logger.Debug( sprintf "download started for '%A' from '%A' to '%A'" login.userName _from _to )
    prepareForDownload(login.serviceAccountId) |> ignore
    let _Calendars = getCalendars( login )
    _Calendars |> Seq.map (  
        fun calendar ->  
            calendar.Initialize()
            calendar.Search(CalDav.CalendarQuery.SearchEvents(Nullable<DateTime>(_from), Nullable<DateTime>(_to)))
    ) |> Seq.map (  
        fun events -> 
            [| 
                for item in events do
                    yield item
            |]
    ) |> Seq.concat 
    |> Seq.map (
        fun event -> 
            event.Events
    ) |> Seq.map(
        fun event -> 
            [| 
                for item in event do
                    yield item
            |]
    ) |> Seq.concat 

let processCalDAVServer( _from : DateTime, _to : DateTime, login : Login, processEvent ) =
    getCalDAVServerEvents( _from, _to, login ) |> Seq.map ( fun p -> processEvent p )

let download( _from : DateTime, _to : DateTime, login : Login ) =
    let serviceAccountId = login.serviceAccountId
    processCalDAVServer( _from, _to, login, 
        fun p ->  save( copyEventToDTO(p, serviceAccountId, None), serviceAccountId, false, null, null ) |> ignore
    )

let save( event : CalDAVEventDTO, serviceAccountId : int ) =
    DB.save( event, serviceAccountId, true, String.Empty, String.Empty )

let upload( login : Login ) =
    logger.Debug( "upload started" )
    prepareForUpload( login.serviceAccountId ) |> ignore
    let itemsToUpload = calDAVEventsToUpload(login.serviceAccountId)
    let calendar = getCalendars( login ) |> Seq.tryHead
    if calendar.IsSome then
        for item in itemsToUpload do
            logger.Debug( sprintf "uploading '%A'-'%A'" item.InternalId item.ExternalId )
            let eve = CalDav.Event()
            copyDTOToEvent( eve, item )
            calendar.Value.Save(eve)
            changeExternalId( item.Id, eve.UID )
            setAsUploaded(item.Id)

let UploadForServiceAccount( serviceAccount : ServiceAccountDTO ) =
    upload( getLogin(serviceAccount.LoginJSON, serviceAccount.Id ) )

let Upload( serviceAccount : ServiceAccountDTO ) =
    ServiceAccountRepository.Upload( serviceAccount, UploadForServiceAccount )

let ChangeInternalIdBecauseOfDuplicity( appointment : CalDAVEventDTO, foundDuplicity : AdapterAppointmentDTO ) =
    changeInternalIdBecauseOfDuplicity( appointment , foundDuplicity )
