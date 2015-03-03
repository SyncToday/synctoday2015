namespace sync.today.Models

open System

[<CLIMutable>]
type ProcessDTO =
    {   Id : int
        StartedOn : DateTime
        FinishedOn : Nullable<DateTime>
        Name : string
        XamlCode : string
        Exception : string
        Workflow : WorkflowDTO
        IsAlive : bool
    }
