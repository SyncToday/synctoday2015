module AdapterRepository

open sync.today.Models
open AdaptersSQL

let Adapters() : AdapterDTO seq =
    adapters()

let EnsureAdapter( key : string, name : string) : AdapterDTO =
    ensureAdapter(key, name)
