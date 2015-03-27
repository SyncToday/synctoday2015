module WorkflowRepository

open System
open WorkflowsSQL
open sync.today.Models

let public EnsureWorkflow( name : string, xaml : string ) : WorkflowDTO =
    ensureWorkflow( name, xaml )

let public Workflows() : WorkflowDTO seq =
    workflows()

let public WorkflowByName( name : string ) : WorkflowDTO  =
    workflowByName( name )

let public DeleteWorkflow( name : string ) =
    deleteWorkflow( name )