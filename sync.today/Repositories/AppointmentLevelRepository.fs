module AppointmentLevelRepository


open System
open AppointmentLevelsSQL
open sync.today.Models

let AppointmentLevels()  = 
    appointmentLevels()