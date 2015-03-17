module ConsumerRepository

open ConsumersSQL
open sync.today.Models

let Consumers() : ConsumerDTO list =
    consumers()

let Consumer( id : int )  =
    consumer( id : int ) 

let Insert( consumer : ConsumerDTO ) =
    insertConsumer( consumer )

let GetConsumerByServiceAccountId( serviceId : int ) =
    getConsumerByServiceAccountId( serviceId )

let GetConsumerByAdapterAppointment( adapterAppointment : AdapterAppointmentDTO ) =
    getConsumerByAdapterAppointment( adapterAppointment )