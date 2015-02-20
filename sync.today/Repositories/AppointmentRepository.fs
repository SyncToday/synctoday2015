module AppointmentRepository

open AppointmentsSQL
open sync.today.Models

let Appointments() =
    appointments()

let InsertAppointment( appointment : AppointmentDTO ) =
    insertAppointment( appointment )

let DeleteAppointments() =
    deleteAppointments()

let ModifiedThroughAdapter()=
    appointmentsModifiedThroughAdapter()

let InsertOrUpdate( app : AppointmentDTO ) =
    saveAppointment( app )
