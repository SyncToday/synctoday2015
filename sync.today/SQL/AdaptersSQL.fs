module AdaptersSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let internal convert( r : SqlConnection.ServiceTypes.Adapters ) : AdapterDTO = 
    { Id = r.Id; Name = r.Name }

let internal adapters() : AdapterDTO list = 
    query {
        for r in db().Adapters do
        select (convert(r))
    } |> Seq.toList

let insertAdapter( adapter : AdapterDTO ) =
    let db = db()

    let newAdapter = new SqlConnection.ServiceTypes.Adapters()
    newAdapter.Name <- adapter.Name

    db.Adapters.InsertOnSubmit newAdapter
    db.DataContext.SubmitChanges()
    newAdapter.Id
    
let adapterByName( name : string ) : AdapterDTO option = 
    query {
        for r in db().Adapters do
        where ( r.Name = name )
        select (convert(r))
    } |> Seq.tryHead
