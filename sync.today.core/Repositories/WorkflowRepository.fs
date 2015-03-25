module WorkflowRepository

open System
open WorkflowsSQL
open sync.today.Models

let public EnsureWorkflow( name : string, xaml : string ) : WorkflowDTO =
    ensureWorkflow( name, xaml )

let public Workflows() : WorkflowDTO seq =
    Workflows()