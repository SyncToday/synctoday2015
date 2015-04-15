namespace sync.today.Models

open System

[<CLIMutable>]
type ProductSoldToCustomerDTO =
    {   Id : int
        InternalId : Guid
        LastModified : DateTime
        Category : string option
        ProductId : int
        CustomerId : int
        SoldWhen : DateTime
        UnitPrice : decimal
        Units : decimal
        UsageId : int option
        UsageComment : string option
        UsageSuccessLevel : decimal option
    }
    override m.ToString() = sprintf "[%A] %A" m.Id m.CustomerId
