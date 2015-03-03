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
        where ( r.TypeDescriptor = Nullable(1) ) 
        select { Id = r.Id; InternalId = r.InternalId.Value; UserId = r.UserId.Value; FirstName = r.FirstName; LastName = r.LastName; Email = r.Email }
    } |> Seq.toList

let internal convertToOldAccountDTO( r: SqlConnection.ServiceTypes.NuObjects ) : OldAccountDTO =
    { Id = r.Id; InternalId = r.InternalId; UserId = r.NuRelationId.Value; UserName = r.ConnectInfo_Username; Password = r.ConnectInfo_Password; Server = r.ConnectInfo_Server }

let internal oldAccounts( userId : int ) : OldAccountDTO list = 
    query {
        for r in db().NuObjects do
        where ( ( r.TypeDescriptor = Nullable(7) ) && ( r.NuRelationId = Nullable(userId) ) ) 
        select (  convertToOldAccountDTO( r ) )
    } |> Seq.toList

