module DB

open System
open FSharp.Data
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders

type internal EntityConnection = SqlEntityConnection<ConnectionStringName="sync-today-mssql",
                                                        Pluralize = true>


let internal context = EntityConnection.GetDataContext()

let internal fullContext = context.DataContext
