namespace sync.today.Models

open System

[<CLIMutable>]
type CustomerCategoryDTO =
    {   Id : int
        InternalId : Guid
        LastModified : DateTime
        Category : string
        Name : string
        Description : string
        Code : string
    }
    override m.ToString() = sprintf "[%A] %A" m.Id m.Name
