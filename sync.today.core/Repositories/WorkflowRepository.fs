module WorkflowRepository

open System
open WorkflowsSQL
open sync.today.Models

(* 
let public EnsureWorkflow( key : string, name : string ) : WorkflowDTO =
    ensureWorkflow( key, name )
*)

let public Workflows() : WorkflowDTO seq =
    Workflows()