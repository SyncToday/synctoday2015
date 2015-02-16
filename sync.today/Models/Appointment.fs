namespace sync.today.Models

open System

[<CLIMutable>]
type AppointmentDTO =
    {   Id : int
        ExternalId : string
        LastModified : DateTime
        Category : string
        Location : string
        Content : string
        Title : string
        DateFrom: DateTime
        DateTo: DateTime
        Reminder: Nullable<DateTime>
        Notification : bool
        IsPrivate : bool
        Priority : byte
    }

