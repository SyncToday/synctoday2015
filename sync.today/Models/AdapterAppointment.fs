﻿namespace sync.today.Models

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
        ReminderMinutesBeforeStart: int
        Notification : bool
        IsPrivate : bool
        Priority : byte
        AppointmentId  : int
        AdapterId : int
        Tag : int
    }
    override m.ToString() = sprintf "[%A] (%A) %A %A -> %A [%A-%A] %A" m.Id m.InternalId m.Title m.DateFrom m.DateTo m.AppointmentId m.AdapterId m.LastModified
