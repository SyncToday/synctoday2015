namespace sync.today.Models

open System

[<CLIMutable>]
type GoogleContactDTO =
    {   Id : int
        InternalId : Guid
        ExternalId : string
        ChangedOn : DateTime

        Content : string
        Title : string
        Email : string

        GivenName : string
        FamilyName : string
        OrgDepartment : string
        OrgJobDescription : string
        OrgName : string
        OrgTitle : string
        PrimaryPhonenumber : string
        postalAddressCity : string
        postalAddressStreet : string
        postalAddressRegion : string
        postalAddressPostcode : string
        postalAddressCountry : string
        postalAddressFormattedAddress : string
    }
    override m.ToString() = sprintf "[%A] %A (%A)" m.Id m.Title m.Email
