namespace sync.today.Models

open System

[<CLIMutable>]
type ProductSoldToCustomerDTO =
    {   Id : int
        InternalId : Guid
        LastModified : DateTime
        Category : string
        ProductId : int
        CustomerId : string
        SoldWhen : DateTime
        UnitPrice : decimal
        Units : decimal
        UsageId : int
        UsageComment : string
        UsageSuccessLevel : decimal
    }
    override m.ToString() = sprintf "[%A] %A" m.Id m.CustomerId
