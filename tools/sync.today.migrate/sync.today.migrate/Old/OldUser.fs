namespace sync.today.Old

open System

[<CLIMutable>]
type OldUserDTO =
    {   Id : int
        InternalId : Guid
        UserId : int
        FirstName : string
        LastName : string
        Email : string
    }
    override m.ToString() = sprintf "[%A] %A %A (%A-%A)" m.Id m.FirstName m.LastName  m.InternalId m.Email
        