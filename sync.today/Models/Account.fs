namespace sync.today.Models

open System

[<CLIMutable>]
type AccountDTO =
    {   Id : int
        Name : string
    }
    override m.ToString() = sprintf "[%A] %A" m.Id m.Name