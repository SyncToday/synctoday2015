namespace sync.today.Models

open System

[<CLIMutable>]
type AdapterDTO =
    {   Id : int
        Name : string
        ServiceId : int
    }
    override m.ToString() = sprintf "[%A] %A (%A)" m.Id m.Name m.ServiceId