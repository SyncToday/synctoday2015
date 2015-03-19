namespace sync.today.Models

open System

[<CLIMutable>]
type AppointmentDTO =
    {   Id : int
        InternalId : Guid
        LastModified : DateTime
        Category : string
        Location : string
        Content : string
        Title : string
        DateFrom: DateTime
        DateTo: DateTime
        ReminderMinutesBeforeStart: int
        Notification : bool
        IsPrivate : bool
        Priority : byte
        ConsumerId : int
    }

