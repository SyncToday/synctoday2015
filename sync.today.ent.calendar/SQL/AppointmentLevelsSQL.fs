module AppointmentLevelsSQL

open Common
open System
open FSharp.Data
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

type private GetAppointmentLevelsQuery = SqlCommandProvider<"GetAppointmentLevels.sql", ConnectionStringName>
type private InsertAppointmentLevelQuery = SqlCommandProvider<"InsertAppointmentLevel.sql", ConnectionStringName>

let internal convert( r : GetAppointmentLevelsQuery.Record  ) : AppointmentLevelDTO =
    { Id = r.Id; Name = r.Name }

let internal convert2( r : InsertAppointmentLevelQuery.Record  ) : AppointmentLevelDTO =
    { Id = r.Id; Name = r.Name }

let convertOp2( p ) = convertOption( p, convert2 )

let internal appointmentLevels()  = 
    ( new GetAppointmentLevelsQuery() ).AsyncExecute() |> Async.RunSynchronously |> Seq.map convert

let insert( name : string) = 
    ( new InsertAppointmentLevelQuery() ).AsyncExecute( name ) |> Async.RunSynchronously |> Seq.tryHead |> convertOp2
