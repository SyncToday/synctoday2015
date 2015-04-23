namespace sync.today.Models

open System

[<CLIMutable>]
type CalDAVEventDTO =
    {
        Id : int
        InternalId : Guid
        ExternalId : string option
        Description : string option
        Start : DateTime
        End : DateTime
        LastModified : DateTime
        Location : string option
        Summary : string option
            
        CategoriesJSON : string option
        ServiceAccountId : int
        Tag : int option
    }
    override m.ToString() = sprintf "[%A] (%A-%A) %A [%A]" m.Id m.InternalId m.ExternalId m.Summary m.ServiceAccountId 
