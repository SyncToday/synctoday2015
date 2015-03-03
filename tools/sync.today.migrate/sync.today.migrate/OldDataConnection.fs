module OldDataConnection

open Microsoft.FSharp.Data.TypeProviders

type internal SqlConnection = SqlDataConnection<ConnectionStringName="sync-today-mssql-old">
let internal db() = SqlConnection.GetDataContext()
let internal cnn() = db().DataContext

