module Repository

open System
open Microsoft.Exchange.WebServices.Data
open System.Configuration

let connect() =
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
    _service

let download( date : DateTime ) =
    let greaterthanfilter = new SearchFilter.IsGreaterThanOrEqualTo(ItemSchema.LastModifiedTime, date)
    let filter = new SearchFilter.SearchFilterCollection(LogicalOperator.And, greaterthanfilter)
    let _service = connect()
    let folder = Folder.Bind(_service, WellKnownFolderName.Calendar)
    0
