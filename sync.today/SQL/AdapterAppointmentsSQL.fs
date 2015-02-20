module AdapterAppointmentsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let internal adapterAppointments( appointmentId : int ) = 
    query {
        for r in db().AdapterAppointments do
        where ( r.AppointmentId = appointmentId )
        select { Id = r.Id; InternalId = r.InternalId; LastModified = r.LastModified; Category = r.Category; Location = r.Location; Content = r.Content; Title = r.Title; DateFrom = r.DateFrom; DateTo = r.DateTo; Reminder = r.Reminder; Notification = r.Notification; IsPrivate = r.IsPrivate; Priority = r.Priority; 
                    AppointmentId = r.AppointmentId; AdapterId = r.AdapterId; ServiceAccountId = r.ServiceAccountId; Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }
    } |> Seq.toList