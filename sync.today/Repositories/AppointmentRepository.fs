module AppointmentRepository

open AppointmentsSQL
open sync.today.Models

let Appointments() =
    appointments()

let Appointment( Id : int ) =
    appointment( Id )

let InsertAppointment( appointment : AppointmentDTO ) =
    insertAppointment( appointment )

let ModifiedThroughAdapter(forConsumer : ConsumerDTO)=
    appointmentsModifiedThroughAdapter(forConsumer)

let InsertOrUpdate( app : AppointmentDTO ) =
    saveAppointment( app )

let ConsumerAppointments( consumer : ConsumerDTO ) =
    appointmentsByConsumer( consumer.Id )
