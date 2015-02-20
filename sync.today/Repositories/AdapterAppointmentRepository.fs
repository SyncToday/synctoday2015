module AdapterAppointmentRepository

open AdapterAppointmentsSQL
open sync.today.Models

let AdapterAppointments( appointmentId : int ) =
    adapterAppointments( appointmentId )