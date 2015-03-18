module ConsumerAdapterRepository

open ConsumerAdaptersSQL
open sync.today.Models

let ConsumerAdapters() : ConsumerAdapterDTO list =
    consumerAdapters()

let Insert( consumerAdapter : ConsumerAdapterDTO ) =
    insertConsumerAdapter( consumerAdapter )

let ConsumerAdapter( consumer : ConsumerDTO, adapter : AdapterDTO ) : ConsumerAdapterDTO option =
    consumerAdapter( consumer, adapter)

let ConsumerAdapterById( id : int ) : ConsumerAdapterDTO option =
    consumerAdapterById( id )
