module AppointmentRepository

open AppointmentsSQL
open sync.today.Models
open System

let Appointments() =
    appointments()

let Appointment( Id : int ) =
    appointment( Id )

let InsertAppointment( appointment : AppointmentDTO ) =
    insertAppointment( appointment )

let ModifiedThroughAdapter(forConsumer : ConsumerDTO, lastModified : DateTime)=
    appointmentsModifiedThroughAdapter(forConsumer, lastModified)

let InsertOrUpdate( app : AppointmentDTO ) =
    saveAppointment( app )

let ConsumerAppointments( consumer : ConsumerDTO ) =
    appointmentsByConsumer( consumer.Id )
