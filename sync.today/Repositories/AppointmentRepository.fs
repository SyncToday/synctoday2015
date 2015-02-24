module AppointmentRepository

open AppointmentsSQL
open sync.today.Models

let Appointments() =
    appointments()

let InsertAppointment( appointment : AppointmentDTO ) =
    insertAppointment( appointment )

let ModifiedThroughAdapter()=
    appointmentsModifiedThroughAdapter()

let InsertOrUpdate( app : AppointmentDTO ) =
    saveAppointment( app )

let ConsumerAppointments( consumer : ConsumerDTO ) =
    appointmentsByConsumer( consumer.Id )
