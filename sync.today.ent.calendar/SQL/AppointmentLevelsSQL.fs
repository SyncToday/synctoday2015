module AppointmentLevelsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

let internal convert( r : SqlConnection.ServiceTypes.AppointmentLevels ) : AppointmentLevelDTO =
    { Id = r.Id; Name = r.Name }

let internal appointmentLevels()  = 
    query {
        for r in db().AppointmentLevels do
        select ( convert(r) )
    } |> Seq.toList

let insert( name : string) = 
    let db = db()

    let newAppointmentLevel = new SqlConnection.ServiceTypes.AppointmentLevels()
    newAppointmentLevel.Name <- name

    db.AppointmentLevels.InsertOnSubmit newAppointmentLevel
    db.DataContext.SubmitChanges()

