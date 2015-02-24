namespace sync.today.Models

open System

[<CLIMutable>]
type AdapterAppointmentDTO =
    {   Id : int
        InternalId : Guid
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
        AppointmentId  : int
        AdapterId : int
        Tag : int
    }
