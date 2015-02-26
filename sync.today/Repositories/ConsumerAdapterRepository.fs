module ConsumerAdapterRepository

open ConsumerAdaptersSQL
open sync.today.Models

let ConsumerAdapters() : ConsumerAdapterDTO list =
    consumerAdapters()

let Insert( consumerAdapter : ConsumerAdapterDTO ) =
    insertConsumerAdapter( consumerAdapter )
