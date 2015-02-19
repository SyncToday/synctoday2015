module ExchangeRepository

open System
open Microsoft.Exchange.WebServices.Data
open System.Configuration

[<CLIMutable>]
type Login =
    {   
        userName : string
        password : string
        server : string
        email : string
    }

let connect( login : Login ) =
    System.Net.ServicePointManager.ServerCertificateValidationCallback <- 
        (fun _ _ _ _ -> true)

    let _TIMEZONEInSettings = ConfigurationManager.AppSettings.["ExchangeTimeZone"]
    let _TIMEZONE = ( if String.IsNullOrWhiteSpace( _TIMEZONEInSettings ) then TimeZone.CurrentTimeZone.StandardName else _TIMEZONEInSettings )
    let ExchangeVersionInSettings = ConfigurationManager.AppSettings.["ExchangeVersion"]
    let exchangeVersion = 
            match ExchangeVersionInSettings with
                | "Exchange2007" -> ExchangeVersion.Exchange2007_SP1
                | "Exchange2010_SP2" -> ExchangeVersion.Exchange2010_SP2
                | "Exchange2013" -> ExchangeVersion.Exchange2013
                | _ -> ExchangeVersion.Exchange2013

    let _service = new ExchangeService(exchangeVersion, TimeZoneInfo.FindSystemTimeZoneById(_TIMEZONE))
    _service.EnableScpLookup <- true    
    _service.Credentials <- new WebCredentials(login.userName, login.password) 
    if String.IsNullOrWhiteSpace(login.server) then
        _service.AutodiscoverUrl(login.email, (fun _ -> true) )
    else
        _service.Url <- new Uri(login.server)
    _service

let save( app : Appointment ) =
    0

let download( date : DateTime, login : Login ) =
    let greaterthanfilter = new SearchFilter.IsGreaterThanOrEqualTo(ItemSchema.LastModifiedTime, date)
    let filter = new SearchFilter.SearchFilterCollection(LogicalOperator.And, greaterthanfilter)
    let _service = connect(login)
    let folder = Folder.Bind(_service, WellKnownFolderName.Calendar)
    let view = new ItemView(1000)
    view.Offset <- 0
    let mutable search = true
    while search do
        let found = folder.FindItems(filter, view)
        search <- found.Items.Count = view.PageSize
        view.Offset <- view.Offset + view.PageSize
        for item in found do
            if ( item :? Appointment ) then
                let app = item :?> Appointment
                save(app) |> ignore
    0
