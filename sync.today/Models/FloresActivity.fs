namespace sync.today.Models

open System

[<CLIMutable>]
type FloresActivityDTO =
    {   Id : int
        InternalId : Guid
        ExternalId : string
        CorrectedDATE : DateTime
        ActivityType_ID : string
        Description : string
        Subject : string
        SheduledStartDate: DateTime
        SheduledEndDate: DateTime
        RealStartDate: DateTime
        RealEndDate: DateTime
        ResponsibleUser_ID: string
        Tag : int
    }
