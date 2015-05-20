/*
declare @appointmentIdVal int = 0
declare @internalIdVal uniqueidentifier = '00000000-0000-0000-0000-000000000000'
declare @adapterIdVal int = 0
declare @idVal int = 0
declare @uploadVal int = -1
*/

declare @appointmentId int
select @appointmentId  = @appointmentIdVal
declare @internalId uniqueidentifier
select @internalId  = @internalIdVal
declare @adapterId int
select @adapterId  = @adapterIdVal
declare @id int
select @id  = @idVal
declare @upload int
select @upload  = @uploadVal

SELECT [Id]
      ,[InternalId]
      ,[LastModified]
      ,[Category]
      ,[Location]
      ,[Content]
      ,[Title]
      ,[DateFrom]
      ,[DateTo]
      ,[Notification]
      ,cast( [IsPrivate] as bit ) IsPrivate
      ,[Priority]
      ,[AppointmentId]
      ,[AdapterId]
      ,[Tag]
      ,[Upload]
      ,cast( [ReminderMinutesBeforeStart] as int )  ReminderMinutesBeforeStart
  FROM AdapterAppointments
where
	AppointmentId = ( CASE WHEN @appointmentId = 0 THEN AppointmentId ELSE @appointmentId END ) AND
	InternalId = ( CASE WHEN @internalId = '00000000-0000-0000-0000-000000000000' THEN InternalId ELSE @internalId END ) AND
	AdapterId = ( CASE WHEN @adapterId = 0 THEN AdapterId ELSE @adapterId END ) AND
	Id = ( CASE WHEN @id = 0 THEN Id ELSE @id END ) AND
	Upload = ( CASE WHEN @upload = -1 THEN Upload ELSE @upload END ) 
order by id
