namespace sync.today.Models

open System

[<CLIMutable>]
type AdapterAppointmentChanges =
    {   Id : int
        InternalId : Guid
        LastModified : DateTime
        CategoryChanged : bool
        LocationChanged : bool
        ContentChanged : bool
        TitleChanged : bool
        DateFromChanged : bool
        DateToChanged : bool
        ReminderMinutesBeforeStartChanged : bool
        NotificationChanged : bool
        IsPrivateChanged : bool
        PriorityChanged : bool
        AppointmentId  : int
        AdapterId : int
        Tag : int
    }
    override m.ToString() = sprintf "[%A] (%A) [%A-%A] %A" m.Id m.InternalId m.AppointmentId m.AdapterId m.LastModified
