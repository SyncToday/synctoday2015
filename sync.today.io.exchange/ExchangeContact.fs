namespace sync.today.Models

open System

[<CLIMutable>]
type ExchangeContactDTO =
    {   Id : int
        InternalId : Guid
        ExternalId : string
        LastModifiedTime : DateTime

        JobTitle : string
        CompanyName : string
        EmailAddress1 : string
        EmailAddress2 : string
        EmailAddress3 : string
        GivenName : string
        MiddleName : string
        Surname : string
        Alias : string
        NickName : string
        HomePhone : string
        MobilePhone : string
        BusinessPhone : string
        OtherTelephone : string
        HomeAddressCity : string
        HomeAddressCountryOrRegion : string
        HomeAddressPostalCode : string
        HomeAddressState : string
        HomeAddressStreet : string
        OtherAddressCity : string
        OtherAddressPostalCode : string
        OtherAddressCountryOrRegion : string
        OtherAddressState : string
        OtherAddressStreet : string
        BusinessAddressCity : string
        BusinessAddressCountryOrRegion : string
        BusinessAddressState : string
        BusinessAddressStreet : string
        BusinessAddressPostalCode : string
        
        CategoriesJSON : string
        ServiceAccountId : int
        Tag : int
    }
    override m.ToString() = sprintf "[%A] (%A-%A) %A %A [%A]" m.Id m.InternalId m.ExternalId m.GivenName m.Surname m.ServiceAccountId 
