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
        ReminderDueBy : DateTime
        AppointmentState : byte
        Subject : string
        RequiredAttendeesJSON : string
        ReminderMinutesBeforeStart : int
        Sensitivity : byte
        RecurrenceJSON : string
        ModifiedOccurrencesJSON : string
        LastOccurrence : DateTime
        IsRecurring : bool
        IsCancelled : bool
        ICalRecurrenceId : string
        FirstOccurrence : DateTime
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
