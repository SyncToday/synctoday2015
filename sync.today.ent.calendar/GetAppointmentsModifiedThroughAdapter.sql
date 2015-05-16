/*
declare @lastModified datetime = '2000-01-01'
declare @consumerIdVal int = 0
*/

declare @consumerId int = @consumerIdVal

select A.* from Appointments A
inner join AdapterAppointments AA ON A.Id = AA.AppointmentId
where
	ConsumerId = ( CASE WHEN @consumerId = 0 THEN ConsumerId ELSE @consumerId END ) AND
	AA.LastModified > @lastModified
