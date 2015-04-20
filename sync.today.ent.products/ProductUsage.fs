namespace sync.today.Models

open System

[<CLIMutable>]
type ProductUsageDTO =
    {   Id : int
        InternalId : Guid
        LastModified : DateTime
        Category : string option
        Name : string
        Description : string option
        Code : string option
    }
    override m.ToString() = sprintf "[%A] %A" m.Id m.Name
