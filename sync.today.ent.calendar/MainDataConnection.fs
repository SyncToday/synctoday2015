// The SqlDataConnection (LINQ to SQL) TypeProvider allows you to write code that uses 
// a live connection to a database. For more information, please go to 
//    http://go.microsoft.com/fwlink/?LinkId=229209

module MainDataConnection

#if INTERACTIVE
#r "System.Data"
#r "System.Data.Linq"
#r "FSharp.Data.TypeProviders"
#endif

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open sync.today.Models
open Microsoft.FSharp.Data.TypeProviders

type internal SqlConnection = SqlDataConnection<ConnectionStringName="sync-today-mssql">
let internal db() = SqlConnection.GetDataContext()
let internal cnn() = db().DataContext

#if OLD
let internal journals() = 
    query {
        for r in db().Journals do
        select { Id = r.Id; Date = r.Date; Thread = r.Thread; Level = r.Level; Logger = r.Logger; Logger_method = r.Logger_method; Message = r.Message; Exception = r.Exception; Stacktrace = r.Stacktrace }
    } |> Seq.toList

let internal workflows() = 
    query {
        for r in db().Workflows do
        select { Id = r.Id; CreatedOn = r.CreatedOn; Name = r.Name; XamlCode = r.XamlCode }
    } |> Seq.toList

let internal workflowById( id : int ) = 
    query {
        for r in db().Workflows do
        where ( r.Id = id )
        select { Id = r.Id; CreatedOn = r.CreatedOn; Name = r.Name; XamlCode = r.XamlCode }
    } |> Seq.tryHead

let internal convertToProcessDTO( r : SqlConnection.ServiceTypes.Processes ) : ProcessDTO = 
    { Id = r.Id; StartedOn = r.StartedOn; FinishedOn = r.FinishedOn; Name = r.Name; XamlCode = r.XamlCode; Exception = r.Exception; Workflow = workflowById(r.WorkflowId).Value; IsAlive = false }

let internal processes() = 
    query {
        for r in db().Processes do
        select ( convertToProcessDTO(r) )
    } |> Seq.toList

let internal processById( id : int ) = 
    query {
        for r in db().Processes do
        where ( r.Id = id )
        select ( convertToProcessDTO(r) )
    } |> Seq.tryHead

let internal transformDownloadedAdapterData( adapter : AdapterDTO ) =
    0 |> ignore

let internal transformUploadedAdapterData( adapter : AdapterDTO ) =
    0 |> ignore
#endif


let public getLastSuccessfulDate( date : Nullable<DateTime> ) : DateTime = 
    if date.HasValue then date.Value else DateTime.Now.AddDays(-1.0)

let public getLastSuccessfulDate2( date : Option<DateTime> ) : DateTime = 
    if date.IsSome then date.Value else DateTime.Now.AddDays(-1.0)


let internal convert( r : SqlConnection.ServiceTypes.ConsumerAdapters ) : ConsumerAdapterDTO =
    { Id = r.Id; AdapterId = r.AdapterId; ConsumerId = r.ConsumerId; DataJSON = r.DateJSON }

let getConsumerAdapterByAdapterIdAndData( adapterId : int, data : string ) : ConsumerAdapterDTO option =
    let db = db()
    query {
        for r in db.ConsumerAdapters do
        where ( r.AdapterId = adapterId && r.DateJSON = data )
        select ( convert(r) )
    } |> Seq.tryHead
