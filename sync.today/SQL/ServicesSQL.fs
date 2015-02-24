module ServicesSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let internal convert( r : SqlConnection.ServiceTypes.Services ) : ServiceDTO =
    { Id = r.Id; Key = r.Key; Name = r.Name }

let services()  = 
    query {
        for r in db().Services do
        select ( convert(r) )
    } |> Seq.toList

let insertService( service : ServiceDTO ) =
    let db = db()

    let newService = new SqlConnection.ServiceTypes.Services()
    newService.Name <- service.Name
    newService.Key <- service.Key

    db.Services.InsertOnSubmit newService
    db.DataContext.SubmitChanges()
    newService.Id

let serviceByKey( key : string )  = 
    query {
        for r in db().Services do
        where ( r.Key = key )
        select ( convert(r) )
    } |> Seq.tryHead
