namespace sync.today.Models

open System

[<CLIMutable>]
type ConsumerDTO =
    {   Id : int
        Name : string
    }
    override m.ToString() = sprintf "[%A] %A" m.Id m.Name
        