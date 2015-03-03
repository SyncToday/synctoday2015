namespace sync.today.Old

open System

[<CLIMutable>]
type OldAccountDTO =
    {   Id : int
        InternalId : Guid
        UserId : int
        UserName : string
        Password : string
        Server : string
    }
    override m.ToString() = sprintf "[%A] %A %A (%A-%A)" m.Id m.UserName m.Password  m.InternalId m.Server
        