module WorkflowsSQL

open Common
open System
open System.Data
open System.Data.SqlClient
open sync.today.Models
open FSharp.Data

type GetWorkflowsQuery = SqlCommandProvider<"DB\SQL\GetAllWorkflows.sql", ConnectionStringName>
type InsertOrUpdateWorkflowQuery = SqlCommandProvider<"DB\SQL\InsertOrUpdateWorkflow.sql", ConnectionStringName>

let internal convert( r : GetWorkflowsQuery.Record ) : WorkflowDTO =
    { Id = r.Id; CreatedOn = r.CreatedOn; Name = r.Name; XamlCode = r.XamlCode }
let internal convert2( r : InsertOrUpdateWorkflowQuery.Record ) : WorkflowDTO =
    { Id = r.Id; CreatedOn = r.CreatedOn; Name = r.Name; XamlCode = r.XamlCode }

let internal convertOption( ro : GetWorkflowsQuery.Record option) : WorkflowDTO option = 
    match ro with
    | Some r -> Some(convert(r))
    | None -> None


let Workflows()  = 
    ( new GetWorkflowsQuery() ).AsyncExecute() |> Async.RunSynchronously |> Seq.map ( fun t -> convert(t) )

(* 
let WorkflowByKey( key : string )  = 
    ( new GetWorkflowsQuery() ).AsyncExecute(key) |> Async.RunSynchronously |> Seq.tryHead |> convertOption
*)

let ensureWorkflow( name : string, xaml : string ) :  WorkflowDTO =
    ( new InsertOrUpdateWorkflowQuery() ).AsyncExecute(xaml, name) 
                                                        |> Async.RunSynchronously 
                                                        |> Seq.head |> convert2
