/*
declare @lastModified datetime = '2000-01-01'
declare @consumerIdVal int = 0
*/

declare @consumerId int = @consumerIdVal

select A.[Id]
      ,A.[InternalId]
      ,A.[LastModified]
      ,A.[Category]
      ,A.[Location]
      ,A.[Content]
      ,A.[Title]
      ,A.[DateFrom]
      ,A.[DateTo]
      ,A.[Notification]
      ,cast( A.[IsPrivate] as bit ) IsPrivate
      ,A.[Priority]
      ,A.[ConsumerId]
      ,cast( A.[ReminderMinutesBeforeStart] as int ) ReminderMinutesBeforeStart 

from Appointments A
inner join AdapterAppointments AA ON A.Id = AA.AppointmentId
where
	ConsumerId = ( CASE WHEN @consumerId = 0 THEN ConsumerId ELSE @consumerId END ) AND
	AA.LastModified > @lastModified
