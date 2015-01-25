namespace sync.today.Models

open System

[<CLIMutable>]
type JournalDTO =
    {   Id : int
        Date : DateTime
        Thread : int
        Level : string
        Logger : string
        Logger_method : string
        Message : string
        Exception: string
        Stacktrace: string
    }

