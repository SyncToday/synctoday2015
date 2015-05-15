/*
declare @appointmentIdVal int = 0
declare @internalIdVal uniqueidentifier = '00000000-0000-0000-0000-000000000000'
declare @adapterIdVal int = 0
declare @idVal int = 0
declare @uploadVal int = -1
*/

declare @appointmentId int = @appointmentIdVal
declare @internalId uniqueidentifier = @internalIdVal
declare @adapterId int = @adapterIdVal
declare @id int = @idVal
declare @upload int = @uploadVal

select * from AdapterAppointments
where
	AppointmentId = ( CASE WHEN @appointmentId = 0 THEN AppointmentId ELSE @appointmentId END ) AND
	InternalId = ( CASE WHEN @internalId = '00000000-0000-0000-0000-000000000000' THEN InternalId ELSE @internalId END ) AND
	AdapterId = ( CASE WHEN @adapterId = 0 THEN AdapterId ELSE @adapterId END ) AND
	Id = ( CASE WHEN @id = 0 THEN Id ELSE @id END ) AND
	Upload = ( CASE WHEN @upload = -1 THEN Id ELSE @upload END ) 
