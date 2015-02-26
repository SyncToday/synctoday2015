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

let internal insertAdapter( adapter : AdapterDTO ) =
    let db = db()

    let newAdapter = new SqlConnection.ServiceTypes.Adapters()
    newAdapter.Name <- adapter.Name

    db.Adapters.InsertOnSubmit newAdapter
    db.DataContext.SubmitChanges()
    newAdapter

let insertAdapterRetId( adapter : AdapterDTO ) =
    insertAdapter( adapter ).Id
    
let adapterByName( name : string ) : AdapterDTO option = 
    query {
        for r in db().Adapters do
        where ( r.Name = name )
        select (convert(r))
    } |> Seq.tryHead

let ensureAdapter( key : string, name : string) : AdapterDTO =
    let adapter = adapterByName( name )
    if adapter.IsSome then
        adapter.Value
    else
        convert(insertAdapter( { Id = 0; Name = name } ) )
