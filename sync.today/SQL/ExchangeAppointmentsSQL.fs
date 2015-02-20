module ExchangeAppointmentsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

(* 
let private ExchangeAppointmentsByExternalId( db : SqlConnection.ServiceTypes.SimpleDataContextTypes.SyncToday2015_New, externalId : string ) = 
    query {
        for r in db.ExchangeAppointments do
        where ( r.ExternalId = externalId )
        select { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; Body = r.Body; Start = r.Start; End = r.End; LastModifiedTime = r.LastModifiedTime; Location = r.Location;
                    IsReminderSet = r.IsReminderSet; ReminderDueBy = r.ReminderDueBy; AppointmentState = r.AppointmentState; Subject = r.Subject; RequiredAttendeesJSON = r.RequiredAttendeesJSON;
                    ReminderMinutesBeforeStart = ( if r.ReminderMinutesBeforeStart.HasValue then r.ReminderMinutesBeforeStart.Value else 0 ); Sensitivity = r.Sensitivity; RecurrenceJSON = r.RecurrenceJSON; ModifiedOccurrencesJSON = r.ModifiedOccurrencesJSON;
                    LastOccurrence = ( if r.LastOccurrence.HasValue then r.LastOccurrence.Value else DateTime.MinValue ); IsRecurring = r.IsRecurring; IsCancelled = r.IsCancelled; ICalRecurrenceId = r.ICalRecurrenceId; 
                    FirstOccurrence = ( if r.FirstOccurrence.HasValue then r.FirstOccurrence.Value else DateTime.MaxValue ); 
                    DeletedOccurrencesJSON = r.DeletedOccurrencesJSON; AppointmentType = r.AppointmentType; Duration = r.Duration; StartTimeZone = r.StartTimeZone; 
                    EndTimeZone = r.EndTimeZone; AllowNewTimeProposal = r.AllowNewTimeProposal; CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; 
                    Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }
    } |> Seq.tryHead
*)

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
    destination.ReminderDueBy <- source.ReminderDueBy
    destination.ReminderMinutesBeforeStart <- Nullable<int>(source.ReminderMinutesBeforeStart)
    destination.RequiredAttendeesJSON <- source.RequiredAttendeesJSON
    destination.Sensitivity <- source.Sensitivity
    destination.ServiceAccountId <- source.ServiceAccountId
    destination.Start <- source.Start
    destination.StartTimeZone <- source.StartTimeZone
    destination.Subject <- source.Subject
    destination.Tag <- Nullable<int>(source.Tag)


let saveExchangeAppointment( app : ExchangeAppointmentDTO, upload : bool ) = 
    let db = db()
    let possibleApp = if upload then ExchangeAppointmentsByInternalId( app.InternalId ) else ExchangeAppointmentsByExternalId( app.ExternalId )
    if ( box possibleApp = null ) then
        let newApp = new SqlConnection.ServiceTypes.ExchangeAppointments()
        copyToExchangeAppointment(newApp, app)
        newApp.Upload <- upload
        db.ExchangeAppointments.InsertOnSubmit newApp
    else
        copyToExchangeAppointment(possibleApp.Value, app)
        possibleApp.Value.Upload <- upload
    db.DataContext.SubmitChanges()
        
let ExchangeAppointmentsToUpload( serviceAccountId : int ) = 
    let db = db()
    query {
        for r in db.ExchangeAppointments do
        where ( r.ServiceAccountId = serviceAccountId && r.Upload )
        select { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; Body = r.Body; Start = r.Start; End = r.End; LastModifiedTime = r.LastModifiedTime; Location = r.Location;
                    IsReminderSet = r.IsReminderSet; ReminderDueBy = r.ReminderDueBy; AppointmentState = r.AppointmentState; Subject = r.Subject; RequiredAttendeesJSON = r.RequiredAttendeesJSON;
                    ReminderMinutesBeforeStart = ( if r.ReminderMinutesBeforeStart.HasValue then r.ReminderMinutesBeforeStart.Value else 0 ); Sensitivity = r.Sensitivity; RecurrenceJSON = r.RecurrenceJSON; ModifiedOccurrencesJSON = r.ModifiedOccurrencesJSON;
                    LastOccurrenceJSON = r.LastOccurrenceJSON; IsRecurring = r.IsRecurring; IsCancelled = r.IsCancelled; ICalRecurrenceId = r.ICalRecurrenceId; 
                    FirstOccurrenceJSON = r.FirstOccurrenceJSON; 
                    DeletedOccurrencesJSON = r.DeletedOccurrencesJSON; AppointmentType = r.AppointmentType; Duration = r.Duration; StartTimeZone = r.StartTimeZone; 
                    EndTimeZone = r.EndTimeZone; AllowNewTimeProposal = r.AllowNewTimeProposal; CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; 
                    Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }
    } |> Seq.toList

let changeExchangeAppointmentExternalId(app : ExchangeAppointmentDTO, externalId : string) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeAppointments SET ExternalId = {0} WHERE InternalId = {1}", externalId, app.InternalId ) |> ignore

let setExchangeAppointmentAsUploaded(app : ExchangeAppointmentDTO) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeAppointments SET Upload = 0 WHERE InternalId = {0}", app.InternalId ) |> ignore

