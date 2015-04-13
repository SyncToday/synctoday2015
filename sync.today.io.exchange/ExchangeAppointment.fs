namespace sync.today.Models

open System

[<CLIMutable>]
type ExchangeAppointmentDTO =
    {   Id : int
        InternalId : Guid
        ExternalId : string
        Body : string
        Start : DateTime
        End : DateTime
        LastModifiedTime : DateTime
        Location : string
        IsReminderSet : bool
        AppointmentState : byte
        Subject : string
        RequiredAttendeesJSON : string
        ReminderMinutesBeforeStart : int
        Sensitivity : byte
        RecurrenceJSON : string
        ModifiedOccurrencesJSON : string
        LastOccurrenceJSON : string
        IsRecurring : bool
        IsCancelled : bool
        ICalRecurrenceId : string
        FirstOccurrenceJSON : string
        DeletedOccurrencesJSON : string
        AppointmentType : byte
        Duration : int
        StartTimeZone : string
        EndTimeZone : string
        AllowNewTimeProposal : bool
        CategoriesJSON : string
        ServiceAccountId : int
        Tag : int
    }
    override m.ToString() = sprintf "[%A] (%A-%A) %A [%A]" m.Id m.InternalId m.ExternalId m.Subject m.ServiceAccountId 
