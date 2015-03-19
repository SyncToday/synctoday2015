namespace sync.today.Models

open System

[<CLIMutable>]
type ServiceDTO =
    {   Id : int
        Name : string
        Key : string
    }
    override m.ToString() = sprintf "[%A] %A (%A)" m.Id m.Name m.Key