namespace sync.today.Models

open System

[<CLIMutable>]
type AdapterAppointmentChanges =
    {   
        InternalId : Guid
        LastModified : DateTime
        Category : string option
        Location : string option
        Content : string option
        Title : string option
        DateFrom: DateTime option
        DateTo: DateTime option
        ReminderMinutesBeforeStart: int option
        Notification : bool option
        IsPrivate : bool option
        Priority : byte option

    }
    override m.ToString() = sprintf "[%A] %A" m.InternalId m.LastModified
