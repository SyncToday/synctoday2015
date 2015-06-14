/*
  getConsumerByAdapterAppointment( adapterAppointment : AdapterAppointmentDTO )
        for r in db.Consumers do
        join v in db.Appointments on ( r.Id = v.ConsumerId )
        where ( v.Id = adapterAppointment.AppointmentId )
        select ( convert3(r) )

		declare @idVal int = 0		
*/


declare @id int
select @id  = @idVal

SELECT C.Id,C.Name FROM Consumers C
INNER JOIN Appointments A ON C.Id = A.ConsumerId
WHERE A.Id = @id
