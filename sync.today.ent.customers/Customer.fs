namespace sync.today.Models

open System

[<CLIMutable>]
type CustomerDTO =
    {   Id : int
        InternalId : Guid
        LastModified : DateTime
        Category : string
        Name : string
        Description : string
        Code : string
        CustomerCategoryId : int
    }
    override m.ToString() = sprintf "[%A] %A" m.Id m.Name
