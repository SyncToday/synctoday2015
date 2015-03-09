module ExchangeAppointmentsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

let internal convert( r :SqlConnection.ServiceTypes.ExchangeAppointments ) : ExchangeAppointmentDTO =
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; Body = r.Body; Start = r.Start; End = r.End; LastModifiedTime = r.LastModifiedTime; Location = r.Location;
                    IsReminderSet = r.IsReminderSet; AppointmentState = r.AppointmentState; Subject = r.Subject; RequiredAttendeesJSON = r.RequiredAttendeesJSON;
                    ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Sensitivity = r.Sensitivity; RecurrenceJSON = r.RecurrenceJSON; ModifiedOccurrencesJSON = r.ModifiedOccurrencesJSON;
                    LastOccurrenceJSON = r.LastOccurrenceJSON; IsRecurring = r.IsRecurring; IsCancelled = r.IsCancelled; ICalRecurrenceId = r.ICalRecurrenceId; 
                    FirstOccurrenceJSON = r.FirstOccurrenceJSON; 
                    DeletedOccurrencesJSON = r.DeletedOccurrencesJSON; AppointmentType = r.AppointmentType; Duration = r.Duration; StartTimeZone = r.StartTimeZone; 
                    EndTimeZone = r.EndTimeZone; AllowNewTimeProposal = r.AllowNewTimeProposal; CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; 
                    Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }

let exchangeAppointmentInternalIds() = 
    query {
        for r in db().ExchangeAppointments do
        select r.InternalId
    } |> Seq.toList

let exchangeAppointmentIds() = 
    query {
        for r in db().ExchangeAppointments do
        select r.Id
    } |> Seq.toList

let private ExchangeAppointmentsByExternalId( externalId : string ) = 
    query {
        for r in db().ExchangeAppointments do
        where ( r.ExternalId = externalId )
        select r
    } |> Seq.tryHead

let private ExchangeAppointmentsByInternalId( internalId : Guid ) = 
    query {
        for r in db().ExchangeAppointments do
        where ( r.InternalId = internalId )
        select r
    } |> Seq.tryHead

let exchangeAppointmentByInternalId( internalId : Guid ) = 
    query {
        for r in db().ExchangeAppointments do
        where ( r.InternalId = internalId )
        select ( convert(r) )
    } |> Seq.tryHead

let private copyToExchangeAppointment(destination : SqlConnection.ServiceTypes.ExchangeAppointments, source : ExchangeAppointmentDTO ) =
    destination.AllowNewTimeProposal <- source.AllowNewTimeProposal
    destination.AppointmentState <- source.AppointmentState
    destination.AppointmentType <- source.AppointmentType
    destination.Body <- source.Body
    destination.CategoriesJSON <- source.CategoriesJSON
    destination.DeletedOccurrencesJSON <- source.DeletedOccurrencesJSON
    destination.Duration <- source.Duration
    destination.End <- source.End
    destination.EndTimeZone <- source.EndTimeZone
    destination.ExternalId <- source.ExternalId
    destination.FirstOccurrenceJSON <- source.FirstOccurrenceJSON
    destination.ICalRecurrenceId <- source.ICalRecurrenceId
    if destination.Id = 0  then
        destination.Id <- source.Id
    destination.InternalId  <- source.InternalId
    destination.IsCancelled <- source.IsCancelled
    destination.IsRecurring <- source.IsRecurring
    destination.IsReminderSet <- source.IsReminderSet
    destination.LastModifiedTime <- source.LastModifiedTime
    destination.LastOccurrenceJSON <- source.LastOccurrenceJSON
    destination.Location <- source.Location
    destination.ModifiedOccurrencesJSON <- source.ModifiedOccurrencesJSON
    destination.RecurrenceJSON <- source.RecurrenceJSON
    destination.ReminderMinutesBeforeStart <- source.ReminderMinutesBeforeStart
    destination.RequiredAttendeesJSON <- source.RequiredAttendeesJSON
    destination.Sensitivity <- source.Sensitivity
    destination.ServiceAccountId <- source.ServiceAccountId
    destination.Start <- source.Start
    destination.StartTimeZone <- source.StartTimeZone
    destination.Subject <- source.Subject
    destination.Tag <- Nullable<int>(source.Tag)

let saveDLUPIssues( externalId : string, lastDLError : string, lastUPError : string  ) = 
    logger.Debug( ( sprintf "externalId:'%A', LastDLError:'%A', LastUPError:'%A'" externalId, lastDLError, lastUPError  ) )
    let db = db()
    let possibleApp = 
        query {
            for r in db.ExchangeAppointments do
            where ( r.ExternalId = externalId )
            select r
        } |> Seq.tryHead
    if ( possibleApp.IsNone ) then
        let newApp = new SqlConnection.ServiceTypes.ExchangeAppointments()
        newApp.ExternalId <- externalId
        newApp.LastDLError <- lastDLError
        newApp.LastUPError <- lastUPError
        db.ExchangeAppointments.InsertOnSubmit newApp
    else
        if ( not ( String.IsNullOrWhiteSpace(lastDLError) ) ) then possibleApp.Value.LastDLError <- lastDLError
        if ( not ( String.IsNullOrWhiteSpace(lastUPError) ) ) then possibleApp.Value.LastUPError <- lastUPError
    db.DataContext.SubmitChanges()
    
let normalize( r : ExchangeAppointmentDTO ) : ExchangeAppointmentDTO =
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; Body = (String.Empty + r.Body); Start = fixDateSecs(r.Start); End = fixDateSecs(r.End); LastModifiedTime = fixDateSecs(r.LastModifiedTime); 
        Location = r.Location;
        IsReminderSet = r.IsReminderSet; AppointmentState = r.AppointmentState; Subject = r.Subject; RequiredAttendeesJSON = r.RequiredAttendeesJSON;
        ReminderMinutesBeforeStart = r.ReminderMinutesBeforeStart; Sensitivity = r.Sensitivity; RecurrenceJSON = r.RecurrenceJSON; ModifiedOccurrencesJSON = r.ModifiedOccurrencesJSON;
        LastOccurrenceJSON = r.LastOccurrenceJSON; IsRecurring = r.IsRecurring; IsCancelled = r.IsCancelled; ICalRecurrenceId = r.ICalRecurrenceId; 
        FirstOccurrenceJSON = r.FirstOccurrenceJSON; 
        DeletedOccurrencesJSON = r.DeletedOccurrencesJSON; AppointmentType = r.AppointmentType; Duration = r.Duration; StartTimeZone = r.StartTimeZone; 
        EndTimeZone = r.EndTimeZone; AllowNewTimeProposal = r.AllowNewTimeProposal; CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; 
        Tag = r.Tag }

let areStandardAttrsVisiblyDifferent( a1 : ExchangeAppointmentDTO, a2 : ExchangeAppointmentDTO ) : bool =
    let a1n = normalize( a1 )
    let a2n = normalize( a2 )
    let result = not (( a1n.CategoriesJSON = a2n.CategoriesJSON ) && ( a1n.Location = a2n.Location ) && ( a1n.Body = a2n.Body ) && ( a1n.Subject = a2n.Subject )
    && ( a1n.Start = a2n.Start ) && ( a1n.End = a2n.End ) && ( a1n.ReminderMinutesBeforeStart = a2n.ReminderMinutesBeforeStart ) && ( a1n.IsReminderSet = a2n.IsReminderSet )
    && ( a1n.Sensitivity = a2n.Sensitivity ))
    logger.Debug( sprintf "'%A' <>? for '%A' '%A'" result a1n a2n )
    result

let saveExchangeAppointment( app : ExchangeAppointmentDTO, upload : bool, downloadRound : int ) = 
    let db = db()
    let possibleApp = 
        if upload then 
            query {
                for r in db.ExchangeAppointments do
                where ( r.InternalId = app.InternalId )
                select r
            } |> Seq.tryHead
        else 
            query {
                for r in db.ExchangeAppointments do
                where ( r.ExternalId = app.ExternalId )
                select r
            } |> Seq.tryHead

    logger.Debug( sprintf "upload:'%A', app.InternalId:'%A', app.ExternalId:'%A', possibleApp:'%A' serviceAccountId: '%A' app.LastModifiedTime:'%A'" upload app.InternalId app.ExternalId possibleApp app.ServiceAccountId app.LastModifiedTime )
    if ( possibleApp.IsNone ) then
        let newApp = new SqlConnection.ServiceTypes.ExchangeAppointments()
        copyToExchangeAppointment(newApp, app)
        newApp.Upload <- upload
        newApp.IsNew <- true
        newApp.DownloadRound <- downloadRound
        db.ExchangeAppointments.InsertOnSubmit newApp
    else
        if ( possibleApp.Value.DownloadRound <> downloadRound) then // ignore duplicities received from EWS
            if areStandardAttrsVisiblyDifferent(app, convert(possibleApp.Value)) then
                let originalInternalId = possibleApp.Value.InternalId
                copyToExchangeAppointment(possibleApp.Value, app)
                possibleApp.Value.InternalId <- originalInternalId
                possibleApp.Value.Upload <- upload
                possibleApp.Value.WasJustUpdated <- true
                possibleApp.Value.DownloadRound <- downloadRound
            else
                logger.Debug ( sprintf "ignoring:'%A', have same values as '%A'" app possibleApp.Value )
        else
            logger.Debug ( sprintf "ignoring:'%A', have same downloadRound '%A'" app downloadRound )
    db.DataContext.SubmitChanges()
        
let ExchangeAppointmentsToUpload( serviceAccountId : int ) = 
    let db = db()
    query {
        for r in db.ExchangeAppointments do
        where ( r.ServiceAccountId = serviceAccountId && r.Upload )
        select (convert(r))
    } |> Seq.toList

let changeExchangeAppointmentExternalId(app : ExchangeAppointmentDTO, externalId : string) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeAppointments SET ExternalId = {0} WHERE InternalId = {1}", externalId, app.InternalId ) |> ignore

let setExchangeAppointmentAsUploaded(app : ExchangeAppointmentDTO) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeAppointments SET Upload = 0 WHERE InternalId = {0}", app.InternalId ) |> ignore

let prepareForDownload( serviceAccountId : int ) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeAppointments SET IsNew=0, WasJustUpdated=0 WHERE ServiceAccountId = {0}", serviceAccountId ) |> ignore

let prepareForUpload() =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeAppointments SET Upload=1 WHERE Upload=0 and (ExternalID IS NULL OR LEN(ExternalID)=0)" ) |> ignore

let exchangeAppointments() =
    let db = db()
    query {
        for r in db.ExchangeAppointments do
        select (convert(r))
    } |> Seq.toList

let getUpdatedExchangeAppointments() =
    let db = db()
    query {
        for r in db.ExchangeAppointments do
        where ( r.WasJustUpdated )
        select (convert(r))
    } |> Seq.toList

let getNewExchangeAppointments() =
    let db = db()
    query {
        for r in db.ExchangeAppointments do
        where ( r.IsNew )
        select (convert(r))
    } |> Seq.toList
    
let changeInternalIdBecauseOfDuplicitySimple( internalId : Guid, exchangeAppointmentId : int ) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeAppointments SET InternalId = {0} WHERE Id = {1}", internalId, exchangeAppointmentId ) |> ignore

let changeInternalIdBecauseOfDuplicity( exchangeAppointment : ExchangeAppointmentDTO, foundDuplicity : AdapterAppointmentDTO ) =
    let cnn = cnn()
    changeInternalIdBecauseOfDuplicitySimple( foundDuplicity.InternalId, exchangeAppointment.Id )

