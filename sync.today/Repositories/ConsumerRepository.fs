module ConsumerRepository

open ConsumersSQL
open sync.today.Models

let Consumers() : ConsumerDTO list =
    consumers()

let Insert( consumer : ConsumerDTO ) =
    insertConsumer( consumer )

let GetConsumerByServiceAccountId( serviceId : int ) =
    getConsumerByServiceAccountId( serviceId )