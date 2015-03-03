module OldDataConnection

open Microsoft.FSharp.Data.TypeProviders
open sync.today.Old
open System

type internal SqlConnection = SqlDataConnection<ConnectionStringName="sync-today-mssql-old">
let internal db() = SqlConnection.GetDataContext()
let internal cnn() = db().DataContext

let internal users() : OldUserDTO list = 
    query {
        for r in db().NuRelations do
        where ( r.TypeDescriptor = Nullable(7) ) 
        select { Id = r.Id; InternalId = r.InternalId.Value; UserId = r.UserId.Value; FirstName = r.FirstName; LastName = r.LastName; Email = r.Email }
    } |> Seq.toList
