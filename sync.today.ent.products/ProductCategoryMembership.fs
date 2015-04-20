namespace sync.today.Models

open System

[<CLIMutable>]
type ProductCategoryMembershipDTO =
    {   Id : int
        InternalId : Guid
        LastModified : DateTime
        Category : string option
        ProductId : int
        ProductCategoryId : int
    }
    override m.ToString() = sprintf "[%A] %A" m.Id m.InternalId
