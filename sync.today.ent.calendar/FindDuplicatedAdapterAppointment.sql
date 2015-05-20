/*
  findDuplicatedAdapterAppointment( adapterAppointment: AdapterAppointmentDTO )
    let appointment : AppointmentDTO = AppointmentsSQL.appointment( adapterAppointment.AppointmentId ).Value

        for r in db.AdapterAppointments do
        join s in db.Appointments on (r.AppointmentId = s.Id)
        where ( r.InternalId <> adapterAppointment.InternalId && r.AdapterId <> adapterAppointment.AdapterId &&
                r.DateFrom = adapterAppointment.DateFrom && r.DateTo = adapterAppointment.DateTo &&
                r.Title = adapterAppointment.Title && ( s.ConsumerId = appointment.ConsumerId )
        )
        select (convert(r))
declare @idVal int = 0
*/


declare @id int
select @id  = @idVal

declare @consumerId int
SELECT @consumerId  = consumerId from Appointments A INNER JOIN AdapterAppointments AA ON A.Id = AA.AppointmentId WHERE AA.Id = @Id

SELECT AA2.* FROM AdapterAppointments AA1, AdapterAppointments AA2 
	INNER JOIN Appointments A ON A.Id = AA2.AppointmentId
WHERE
	AA1.InternalId <> AA2.InternalId AND
	AA1.AdapterId <> AA2.AdapterId AND
	AA1.DateFrom = AA2.DateFrom AND 
	AA1.DateTo = AA2.DateTo AND 
	AA1.Title = AA2.Title AND 
	AA1.Id = @id AND
	A.ConsumerId = @consumerId



