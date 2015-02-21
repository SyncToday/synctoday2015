module AppointmentLevelsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let internal appointmentLevels()  = 
    query {
        for r in db().AppointmentLevels do
        select ( { Id = r.Id; Name = r.Name } )
    } |> Seq.toList
