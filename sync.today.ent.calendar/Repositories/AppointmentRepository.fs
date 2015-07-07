module AppointmentRepository

open AppointmentsSQL
open sync.today.Models
open System

let Appointments() =
    appointments()

let Appointment( Id : int ) =
    appointment( Id )

let ModifiedThroughAdapter(forConsumer : ConsumerDTO, lastModified : DateTime)=
    appointmentsModifiedThroughAdapter(forConsumer, lastModified)

let InsertOrUpdate( app : AppointmentDTO ) =
    saveAppointment( app )

let ConsumerAppointments( consumer : ConsumerDTO ) =
    appointmentsByConsumer( consumer.Id )

let printContent( before : bool ) =
    let data_before = log4net.LogManager.GetLogger("appointment_data_before");
    let data_after = log4net.LogManager.GetLogger("appointment_data_after");
    let logger = if before then data_before else data_after
    logger.Debug("started")
    let Appointments = appointments()
    for appointment in Appointments do
        let replacedBody = if appointment.Content.IsSome then appointment.Content.Value.Replace(System.Environment.NewLine, " ") else String.Empty
        logger.Info( sprintf "%A\t%A\t%A\t%A\t%A\t%A" appointment.InternalId appointment.Title appointment.DateFrom appointment.DateTo appointment.LastModified replacedBody )
    logger.Debug("done")

let GetAppointmentByAdapterAppointmentId( adapterAppointmentId : int ) =
    getAppointmentByAdapterAppointmentId( adapterAppointmentId )
