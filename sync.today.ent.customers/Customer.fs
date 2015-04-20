namespace sync.today.Models

open System

[<CLIMutable>]
type CustomerDTO =
    {   Id : int
        InternalId : Guid
        LastModified : DateTime
        Category : string option
        Name : string
        Code : string option
        CustomerCategoryId : int
    }
    override m.ToString() = sprintf "[%A] %A" m.Id m.Name
