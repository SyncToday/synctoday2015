namespace sync.today.Models

open System

[<CLIMutable>]
type WorkflowDTO =
    {   Id : int
        CreatedOn : DateTime
        Name : string
        XamlCode : string
    }

