/*
DECLARE @internalIdVal uniqueidentifier
SELECT @internalIdVal = 'B854FE3C-4443-4DD1-A4A4-E05C123F4715'
DECLARE @externalIdVal nvarchar(2048)
SELECT @externalIdVal = 'ccc'
*/

DECLARE @internalId uniqueidentifier
SELECT @internalId = @internalIdVal
DECLARE @externalId nvarchar(2048)
SELECT @externalId = @externalIdVal

-- copy to new deleted row
INSERT INTO [dbo].[ExchangeAppointments]
           ([InternalId]
           ,[ExternalId]
           ,[Body]
           ,[Start]
           ,[End]
           ,[LastModifiedTime]
           ,[Location]
           ,[IsReminderSet]
           ,[AppointmentState]
           ,[Subject]
           ,[RequiredAttendeesJSON]
           ,[ReminderMinutesBeforeStart]
           ,[Sensitivity]
           ,[RecurrenceJSON]
           ,[ModifiedOccurrencesJSON]
           ,[LastOccurrenceJSON]
           ,[IsRecurring]
           ,[IsCancelled]
           ,[ICalRecurrenceId]
           ,[FirstOccurrenceJSON]
           ,[DeletedOccurrencesJSON]
           ,[AppointmentType]
           ,[Duration]
           ,[StartTimeZone]
           ,[EndTimeZone]
           ,[AllowNewTimeProposal]
           ,[CategoriesJSON]
           ,[ServiceAccountId]
           ,[Upload]
           ,[Tag]
           ,[IsNew]
           ,[WasJustUpdated]
           ,[DownloadRound]
           ,[LastDLError]
           ,[LastUPError])
SELECT newid()
           ,[ExternalId]
           ,[Body]
           ,[Start]
           ,[End]
           ,[LastModifiedTime]
           ,[Location]
           ,[IsReminderSet]
           ,255 --[AppointmentState]
           ,[Subject]
           ,[RequiredAttendeesJSON]
           ,[ReminderMinutesBeforeStart]
           ,[Sensitivity]
           ,[RecurrenceJSON]
           ,[ModifiedOccurrencesJSON]
           ,[LastOccurrenceJSON]
           ,[IsRecurring]
           ,[IsCancelled]
           ,[ICalRecurrenceId]
           ,[FirstOccurrenceJSON]
           ,[DeletedOccurrencesJSON]
           ,[AppointmentType]
           ,[Duration]
           ,[StartTimeZone]
           ,[EndTimeZone]
           ,[AllowNewTimeProposal]
           ,[CategoriesJSON]
           ,[ServiceAccountId]
           ,[Upload]
           ,[Tag]
           ,[IsNew]
           ,[WasJustUpdated]
           ,[DownloadRound]
           ,[LastDLError]
           ,[LastUPError]
		   from ExchangeAppointments WHERE InternalId = @internalId AND ExternalId <> @externalId

-- change ExternalId
UPDATE ExchangeAppointments SET ExternalId = @externalId WHERE InternalId = @internalId AND ExternalId <> @externalId