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

let download( _from : DateTime, _to : DateTime, login : Login ) =
    let serviceAccountId = login.serviceAccountId
    logger.Debug( sprintf "download started for '%A' from '%A' to '%A'" login.userName _from _to )
    prepareForDownload(login.serviceAccountId) |> ignore
    let _Server = new CalDav.Client.Server(login.server, login.userName, login.password);
    let _Calendars = _Server.GetCalendars()
    for calendar in _Calendars do
        calendar.Initialize()
        let events = calendar.Search(CalDav.CalendarQuery.SearchEvents(Nullable<DateTime>(_from), Nullable<DateTime>(_to)))
        for item in events do
            for event in item.Events do
                save( copyEventToDTO(event, serviceAccountId, None), serviceAccountId, false, null, null ) |> ignore

let upload( login : Login ) =
    logger.Debug( "upload started" )
    prepareForUpload()
    let _service = connect(login)
    let itemsToUpload = ExchangeAppointmentsToUpload(login.serviceAccountId)

    let folder = 
        if not (login.impersonate) && not( String.IsNullOrWhiteSpace( login.email ) ) && login.email <> login.userName then
            Folder.Bind(_service, new FolderId(WellKnownFolderName.Calendar, new Mailbox(login.email)))
        else
            Folder.Bind(_service, WellKnownFolderName.Calendar)

    for item in itemsToUpload do
        logger.Debug( sprintf "uploading '%A'-'%A'" item.InternalId item.ExternalId )
        if String.IsNullOrWhiteSpace(item.ExternalId) then
            let app = createAppointment( item, _service )
            app.Save(folder.Id, SendInvitationsMode.SendToNone)
            logger.Debug( sprintf "'%A' saved" app.Id )
            changeExternalId( item, app.Id.ToString() )
            setExchangeAppointmentAsUploaded(item)
        else
            try 
                let possibleApp = Appointment.Bind(_service, new ItemId(item.ExternalId))
                copyDTOToAppointment( possibleApp, item )
                possibleApp.Update(ConflictResolutionMode.AutoResolve, SendInvitationsOrCancellationsMode.SendToNone)
                logger.Debug( sprintf "'%A' saved" possibleApp.Id )
                setExchangeAppointmentAsUploaded(item)
            with 
                | ex -> 
                        saveDLUPIssues(item.ExternalId, null, ex.ToString() ) 
                        //reraise()
                        (* 
                        try 
                            logger.Debug( sprintf "Save '%A' failed '%A'" item ex )
                            if  ex.Message <> "Set action is invalid for property" then
                                let app = createAppointment( item, _service )
                                app.Save(SendInvitationsMode.SendToNone)
                                changeExternalId( item, app.Id.ToString() )
                        with
                            | ex ->
                                saveDLUPIssues(item.ExternalId, null, ex.ToString() ) 
                                reraise()
                        *)
