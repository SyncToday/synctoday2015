/* 
declare @consumerIdVal int = 0
declare @internalIdVal uniqueidentifier = '00000000-0000-0000-0000-000000000000'
declare @idVal int = 0
*/

declare @consumerId int = @consumerIdVal
declare @internalId uniqueidentifier = @internalIdVal
declare @id int = @idVal

select [Id]
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
      ,[ConsumerId]
      ,cast( [ReminderMinutesBeforeStart] as int ) ReminderMinutesBeforeStart
from Appointments
where
	ConsumerId = ( CASE WHEN @consumerId = 0 THEN ConsumerId ELSE @consumerId END ) AND
	InternalId = ( CASE WHEN @internalId = '00000000-0000-0000-0000-000000000000' THEN InternalId ELSE @internalId END ) AND
	Id = ( CASE WHEN @id = 0 THEN Id ELSE @id END )
