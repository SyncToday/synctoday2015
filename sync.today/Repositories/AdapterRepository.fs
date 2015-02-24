module AdapterRepository

open MainDataConnection
open sync.today.Models
open AdaptersSQL

let Adapters() : AdapterDTO list =
    adapters()

let TransformDownloaded( adapter : AdapterDTO ) =
    transformDownloadedAdapterData( adapter )

let Insert( adapter : AdapterDTO ) =
    insertAdapter( adapter )

let TransformUploaded( adapter : AdapterDTO ) =
    transformUploadedAdapterData( adapter )
