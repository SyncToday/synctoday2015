-- SELECT * FROM [OldAdapterAppointments]

DELETE [OldAdapterAppointments]

SET IDENTITY_INSERT [OldAdapterAppointments] ON

INSERT INTO [OldAdapterAppointments]
           (ID,[InternalId]
           ,[LastModified]
           ,[Category]
           ,[Location]
           ,[Content]
           ,[Title]
           ,[DateFrom]
           ,[DateTo]
           ,[ReminderMinutesBeforeStart]
           ,[Notification]
           ,[IsPrivate]
           ,[Priority]
           ,[AppointmentId]
           ,[AdapterId]
           ,[Tag]
           ,[Upload])

SELECT 
			ID,[InternalId]
           ,[LastModified]
           ,[Category]
           ,[Location]
           ,[Content]
           ,[Title]
           ,[DateFrom]
           ,[DateTo]
           ,[ReminderMinutesBeforeStart]
           ,[Notification]
           ,[IsPrivate]
           ,[Priority]
           ,[AppointmentId]
           ,[AdapterId]
           ,[Tag]
           ,[Upload]
	FROM [dbo].[AdapterAppointments]

SELECT COUNT(*) FROM [dbo].[AdapterAppointments]