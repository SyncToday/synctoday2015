module AdapterRepository

open MainDataConnection
open sync.today.Models

let Adapters() =
    adapters()

let Download( adapter : AdapterDTO ) =
    downloadAdapterData( adapter )
