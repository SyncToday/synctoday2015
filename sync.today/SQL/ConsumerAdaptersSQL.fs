module ConsumerAdaptersSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let internal convert( r : SqlConnection.ServiceTypes.ConsumerAdapters ) : ConsumerAdapterDTO =
    { Id = r.Id; AdapterId = r.AdapterId; ConsumerId = r.ConsumerId; DataJSON = r.DateJSON }

let getConsumerAdapterByAdapterIdAndData( adapterId : int, data : string ) : ConsumerAdapterDTO option =
    let db = db()
    query {
        for r in db.ConsumerAdapters do
        where ( r.AdapterId = adapterId & r.DateJSON = data )
        select ( convert(r) )
    } |> Seq.tryHead
