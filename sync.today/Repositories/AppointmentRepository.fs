module AppointmentRepository

open MainDataConnection
open sync.today.Models

let Appointments() =
    appointments()

let InsertAppointment( appointment : AppointmentDTO ) =
    insertAppointment( appointment )