namespace sync.today.Models

open System

[<CLIMutable>]
type FloresPersonDTO =
    {   Id : int
        InternalId : Guid
        ExternalId : string
        CorrectedDATE : DateTime
        Tag : int

        LastName : string
        FirstName : string
        Title : string
        Grade : string
        ExternalText : string
        InternalText : string
        Category : string
        ResponsibleUser_ID : string
        ResponsibleRole_ID : string
        Status_ID : string
        Suffix : string
        CRMMenuItem_ID : string
        Recipient : string
        City : string
        Street : string
        PostCode : string
        ZIP : string
        Country : string
        PhoneNumber1 : string
        PhoneNumber2 : string
        FaxNumber : string
        EMail : string
        Location : string
        CountryCode : string
    }
