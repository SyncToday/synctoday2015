module ServiceRepository

open System
open ServicesSQL
open sync.today.Models

let public EnsureService( key : string, name : string ) : ServiceDTO =
    ensureService( key, name )

let public Services() : ServiceDTO seq =
    services()