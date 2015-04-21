namespace sync.today.Models

open System

[<CLIMutable>]
type CalDAVEventDTO =
    {
        Id : int
        InternalId : Guid
        ExternalId : string
        Description : string
        Start : DateTime
        End : DateTime
        LastModified : DateTime
        Location : string
        Summary : string
            
        CategoriesJSON : string
        ServiceAccountId : int
        Tag : int
    }
    override m.ToString() = sprintf "[%A] (%A-%A) %A [%A]" m.Id m.InternalId m.ExternalId m.Summary m.ServiceAccountId 
