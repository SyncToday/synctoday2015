module Schemas

open Microsoft.Exchange.WebServices.Data

let AppointmentSchemaId : PropertyDefinitionBase = 
    upcast AppointmentSchema.Id

let AppointmentSchemaBody : PropertyDefinitionBase = 
    upcast AppointmentSchema.Body

let AppointmentSchemaStart : PropertyDefinitionBase = 
    upcast AppointmentSchema.Start

let AppointmentSchemaEnd : PropertyDefinitionBase = 
    upcast AppointmentSchema.End

let AppointmentSchemaLastModifiedTime : PropertyDefinitionBase = 
    upcast AppointmentSchema.LastModifiedTime

let AppointmentSchemaLocation : PropertyDefinitionBase = 
    upcast AppointmentSchema.Location

let AppointmentSchemaIsReminderSet : PropertyDefinitionBase = 
    upcast AppointmentSchema.IsReminderSet

let AppointmentSchemaReminderDueBy : PropertyDefinitionBase = 
    upcast AppointmentSchema.ReminderDueBy

let AppointmentSchemaAppointmentState : PropertyDefinitionBase = 
    upcast AppointmentSchema.AppointmentState

let AppointmentSchemaSubject : PropertyDefinitionBase = 
    upcast AppointmentSchema.Subject

let AppointmentSchemaRequiredAttendees : PropertyDefinitionBase = 
    upcast AppointmentSchema.RequiredAttendees

let AppointmentSchemaReminderMinutesBeforeStart : PropertyDefinitionBase = 
    upcast AppointmentSchema.ReminderMinutesBeforeStart

let AppointmentSchemaSensitivity : PropertyDefinitionBase = 
    upcast AppointmentSchema.Sensitivity

let ContactSchemaId : PropertyDefinitionBase = 
    upcast ContactSchema.Id

let AppointmentSchemaRecurrence : PropertyDefinitionBase = 
    upcast AppointmentSchema.Recurrence

let AppointmentSchemaModifiedOccurrences : PropertyDefinitionBase = 
    upcast AppointmentSchema.ModifiedOccurrences

let AppointmentSchemaLastOccurrence : PropertyDefinitionBase = 
    upcast AppointmentSchema.LastOccurrence

let AppointmentSchemaIsRecurring : PropertyDefinitionBase = 
    upcast AppointmentSchema.IsRecurring

let AppointmentSchemaIsCancelled : PropertyDefinitionBase = 
    upcast AppointmentSchema.IsCancelled

let AppointmentSchemaICalRecurrenceId : PropertyDefinitionBase = 
    upcast AppointmentSchema.ICalRecurrenceId

let AppointmentSchemaFirstOccurrence : PropertyDefinitionBase = 
    upcast AppointmentSchema.FirstOccurrence

let AppointmentSchemaDeletedOccurrences : PropertyDefinitionBase = 
    upcast AppointmentSchema.DeletedOccurrences

let AppointmentSchemaAppointmentType : PropertyDefinitionBase = 
    upcast AppointmentSchema.AppointmentType

let AppointmentSchemaDuration : PropertyDefinitionBase = 
    upcast AppointmentSchema.Duration

let AppointmentSchemaStartTimeZone : PropertyDefinitionBase = 
    upcast AppointmentSchema.StartTimeZone

let AppointmentSchemaEndTimeZone : PropertyDefinitionBase = 
    upcast AppointmentSchema.EndTimeZone

let AppointmentSchemaAllowNewTimeProposal : PropertyDefinitionBase = 
    upcast AppointmentSchema.AllowNewTimeProposal

let AppointmentSchemaCategories : PropertyDefinitionBase = 
    upcast AppointmentSchema.Categories

let Properties = 
    [|
        AppointmentSchemaId; AppointmentSchemaBody;
        AppointmentSchemaBody;
        AppointmentSchemaStart;
        AppointmentSchemaEnd;
        AppointmentSchemaLastModifiedTime;
        AppointmentSchemaLocation;
        AppointmentSchemaIsReminderSet;
        AppointmentSchemaReminderDueBy;
        AppointmentSchemaAppointmentState;
        AppointmentSchemaSubject;
        AppointmentSchemaRequiredAttendees;
        AppointmentSchemaReminderMinutesBeforeStart;
        AppointmentSchemaSensitivity;
        ContactSchemaId;
        AppointmentSchemaRecurrence;
        AppointmentSchemaModifiedOccurrences;
        AppointmentSchemaLastOccurrence;
        AppointmentSchemaIsRecurring;
        AppointmentSchemaIsCancelled;
        AppointmentSchemaICalRecurrenceId;
        AppointmentSchemaFirstOccurrence;
        AppointmentSchemaDeletedOccurrences;
        AppointmentSchemaAppointmentType;
        AppointmentSchemaDuration;
        AppointmentSchemaAllowNewTimeProposal;
        AppointmentSchemaCategories
    |]

