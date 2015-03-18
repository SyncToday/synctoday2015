module ConsumerAdapterRepository

open ConsumerAdaptersSQL
open sync.today.Models

let ConsumerAdapters() : ConsumerAdapterDTO seq =
    consumerAdapters()

let Insert( consumerAdapter : ConsumerAdapterDTO ) =
    insertOrUpdateConsumerAdapter( consumerAdapter )

let ConsumerAdapter( consumer : ConsumerDTO, adapter : AdapterDTO ) : ConsumerAdapterDTO option =
    consumerAdapter( consumer, adapter)

#if ConsumerAdapterById
let ConsumerAdapterById( id : int ) : ConsumerAdapterDTO option =
    consumerAdapterById( id )
#endif
