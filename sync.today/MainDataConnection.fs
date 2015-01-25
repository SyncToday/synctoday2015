// The SqlDataConnection (LINQ to SQL) TypeProvider allows you to write code that uses 
// a live connection to a database. For more information, please go to 
//    http://go.microsoft.com/fwlink/?LinkId=229209

module MainDataConnection

#if INTERACTIVE
#r "System.Data"
#r "System.Data.Linq"
#r "FSharp.Data.TypeProviders"
#endif

open System
open System.Data
open System.Data.Linq
open System.Data.Entity
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models

type private SqlConnection = SqlDataConnection<ConnectionStringName="sync-today-mssql">
let private db = SqlConnection.GetDataContext()
let private cnn = db.DataContext

let internal journals() = 
    query {
        for r in db.Journals do
        select { Id = r.Id; Date = r.Date; Thread = Int32.Parse( r.Thread ); Level = r.Level; Logger = r.Logger; Logger_method = r.Logger_method; Message = r.Message; Exception = r.Exception; Stacktrace = r.Stacktrace }
    } |> Seq.toList
