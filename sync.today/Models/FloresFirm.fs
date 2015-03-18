namespace sync.today.Models

open System

[<CLIMutable>]
type FloresFirmDTO =
    {   Id : int
        InternalId : Guid
        ExternalId : string
        CorrectedDATE : DateTime
        Tag : int

        Name : string
        VATIdentNumber : string
        WWWAddress : string
        ReceivedInvoicesSum : decimal
        IssuedInvoicesSum : decimal
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
