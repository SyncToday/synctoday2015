module Repository

open System
open Common
open sync.today.Models
open FSharp.Data
open DB
open sync.today.cipher
open System.Collections.Specialized

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

let public CalDAV_SERVICE_KEY="CALDAV"

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
    let decryptedPassword = StringCipher.Decrypt(parsed.Password, parsed.UserName)
#if LOG_DECRYPTED_PASSWORD
    logger.Debug( sprintf "Password '%A'" decryptedPassword )
#endif
    { userName = parsed.UserName;  password = decryptedPassword; server = parsed.Server; serviceAccountId  = serviceAccountId }

let setXLabel( r : CalDav.Event, source : CalDAVEventDTO ) =
    if source.CategoriesJSON.IsSome then
        //r.Properties.Clear()
        r.Properties.Add( "X-LABEL", unjson<string array>(source.CategoriesJSON.Value).[0], NameValueCollection() )

let copyDTOToEvent( r : CalDav.Event, source : CalDAVEventDTO )  =
    r.Description <- optionString2String source.Description
    r.Start <- Nullable<DateTime>(source.Start.ToUniversalTime())
    r.End <- Nullable<DateTime>(source.End.ToUniversalTime())
    r.Location <- optionString2String source.Location
    r.Summary <- optionString2String source.Summary
    r.UID <- optionString2String source.ExternalId 
    setXLabel( r, source )

let getXLabel( r : CalDav.Event ) =
    let result = 
        r.Properties |> 
        Seq.map (  
            fun item -> 
                let (key, value, _) = item
                devlog.Debug( sprintf "%A" item )
                if key = "X-LABEL" then
                    Some value
                else 
                    None
        ) |> Seq.reduce (
            fun item1 item2 -> if item1.IsSome then item1 else if item2.IsSome then item2 else None
        )
    result
     
let treatUnspecifiedAsLocal ( d : DateTime ) =
    match d.Kind with
    | DateTimeKind.Local -> d
    | DateTimeKind.Utc -> d
    | DateTimeKind.Unspecified -> DateTime.SpecifyKind( d, DateTimeKind.Local )
    | _ -> d

let copyEventToDTO( r : CalDav.Event, serviceAccountId : int, tag : int option ) : CalDAVEventDTO =
    try 
        let xLabel = getXLabel( r );
        { Id = 0; InternalId = Guid.NewGuid(); ExternalId = Some(r.UID); Description = string2optionString r.Description; 
          Start = ( treatUnspecifiedAsLocal r.Start.Value ).ToLocalTime(); 
          End = ( treatUnspecifiedAsLocal r.End.Value ).ToLocalTime(); 
          LastModified = 
            if r.LastModified.HasValue then r.LastModified.Value.ToLocalTime() else 
                if r.Created.HasValue then r.Created.Value.ToLocalTime() 
                    else r.DtStamp.ToLocalTime()
          Location = string2optionString r.Location; Summary = string2optionString r.Summary;
#if CATEGORIES
          CategoriesJSON = Some(json(r.Categories)); 
#else
          CategoriesJSON = if xLabel.IsSome then Some("[\"" + xLabel.Value + "\"]") else None;
#endif
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
    let found  =
        _Calendars |> Seq.map (  
            fun calendar ->  
                calendar.Initialize()
                calendar.Search(CalDav.CalendarQuery.SearchEvents(Nullable<DateTime>(_from), Nullable<DateTime>(_to)))
            ) 
    devlog.Debug( sprintf "found %A" found )                
    found |> Seq.map (  
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
    let events = getCalDAVServerEvents( _from, _to, login ) 
    events |> Seq.filter ( fun p -> p.Start.HasValue && p.End.HasValue ) |> Seq.map processEvent

let download( ( _from : DateTime, _to : DateTime ), login : Login ) =
    let serviceAccountId = login.serviceAccountId
    let res = 
        processCalDAVServer( _from, _to, login, 
            fun p ->  save( copyEventToDTO(p, serviceAccountId, None), serviceAccountId, false, null, null )
        )
    res |> Seq.iter ( fun p -> devlog.Debug( sprintf "Got %A (%A)" p.ExternalId p.Id ) )
    res

let delete( p : CalDav.Event, login : Login ) = 
    let _Calendars = getCalendars( login )
    _Calendars |> Seq.iter (  
            fun calendar ->  
                calendar.Initialize()
                calendar.Delete( p )
            ) |> ignore
    p

let deleteAll( ( _from : DateTime, _to : DateTime ), login : Login ) =
    let serviceAccountId = login.serviceAccountId
    let res = 
        processCalDAVServer( _from, _to, login, 
            fun p ->  delete( p, login )
        )
    res |> Seq.iter ( fun p -> devlog.Debug( sprintf "Deleted %A" p.UID ) )
    res


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
            changeExternalId( item.Id, eve.UID ) |> ignore
            setAsUploaded(item.Id) |> ignore

let UploadForServiceAccount( serviceAccount : ServiceAccountDTO ) =
    upload( getLogin(serviceAccount.LoginJSON, serviceAccount.Id ) )

let Upload( serviceAccount : ServiceAccountDTO ) =
    ServiceAccountRepository.Upload( serviceAccount, UploadForServiceAccount )

let ChangeInternalIdBecauseOfDuplicity( appointment : CalDAVEventDTO, foundDuplicity : AdapterAppointmentDTO ) =
    devlog.Debug( sprintf "ChangeInternalIdBecauseOfDuplicity %A %A" appointment foundDuplicity )
    changeInternalIdBecauseOfDuplicity( appointment , foundDuplicity )

let ConvertFromDTO( r : AdapterAppointmentDTO, serviceAccountId, original : CalDAVEventDTO ) : CalDAVEventDTO =
    let result = 
        { Id = original.Id; InternalId = r.InternalId; ExternalId = original.ExternalId; 
          Description = r.Content; Start = r.DateFrom; 
          End = r.DateTo; LastModified = r.LastModified; 
          Location = r.Location; Summary = r.Title; 
          CategoriesJSON = string2optionString (AppointmentLevelRepository.replaceCategoryInJSON(optionString2String original.CategoriesJSON, optionString2String r.Category) ); 
          ServiceAccountId = serviceAccountId; Tag = r.Tag; }
    result
    
let ConvertToDTO( r : CalDAVEventDTO, adapterId ) : AdapterAppointmentDTO =
    let result = 
        { Id = 0; InternalId = r.InternalId; LastModified = r.LastModified;
          Category = AppointmentLevelRepository.findCategory( optionString2String r.CategoriesJSON ); 
          Location = r.Location; Content = r.Description; 
          Title = r.Summary;
          DateFrom = r.Start; DateTo = r.End; Notification = true; IsPrivate = false; Priority = byte 0; 
          AppointmentId = 0; AdapterId = adapterId; Tag = r.Tag; 
          ReminderMinutesBeforeStart = 0 }
    result

let DownloadForServiceAccount( serviceAccount : ServiceAccountDTO ) =
    download( MainDataConnection.getDateRange( serviceAccount.LastSuccessfulDownload ), getLogin(serviceAccount.LoginJSON, serviceAccount.Id ) ) |> ignore

let Download( serviceAccount : ServiceAccountDTO ) =
    ServiceAccountRepository.Download( serviceAccount, DownloadForServiceAccount )

let EventByInternalId( internalId : Guid ) : CalDAVEventDTO option = 
    DB.calDAVEvent( 0, null, internalId )

let NewEvents() : CalDAVEventDTO seq =
    DB.calDAVEvents( "1", null )

let UpdatedEvents() : CalDAVEventDTO seq =
    DB.calDAVEvents( null, "1" )

let AllEvents() : CalDAVEventDTO seq =
    DB.calDAVEvents( null, null )

let printContent( before : bool ) =
    0 |> ignore

let getEmpty(old : CalDAVEventDTO option): CalDAVEventDTO =
    if ( old.IsSome ) then
        old.Value
    else 
        { Id = 0; InternalId = Guid.Empty; ExternalId = None; Description = None; Start = DateTime.Now; End = DateTime.Now; 
          LastModified = DateTime.Now; 
          Location = None; Summary = None; CategoriesJSON = None; ServiceAccountId = 0; Tag = None; }
        
let ignoreSslCertificateErrors() =
    System.Net.ServicePointManager.ServerCertificateValidationCallback <- 
        (fun _ _ _ _ -> true)
