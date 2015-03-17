module ServiceAccountsController

open System
open System.Net
open System.Net.Http
open System.Web.Http
open sync.today.Models
open ServiceAccountRepository

/// Retrieves values.
[<RoutePrefix("api")>]
type ServiceAccountsController() =
    inherit ApiController()

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    /// Gets all values.
    [<Route("serviceaccounts")>]
    member x.Get() = 
        logger.Debug("adapter called")
        ServiceAccounts()

    /// Gets a single value at the specified index.
    [<Route("serviceaccounts/{id}")>]
    member x.Get(request: HttpRequestMessage, id: int) =
        let result = ServiceAccountById( id )
        if result.IsSome then
            request.CreateResponse(result.Value)
        else 
            request.CreateResponse(HttpStatusCode.NotFound)

    /// Maps to HTTP PUT.
    [<Route("serviceaccounts")>]
    member x.Put(request : HttpRequestMessage, serviceId : int, accountId : int, loginJSON : string ) = 
        async {
            let lastSuccessfulDownload = DateTime.Now
            return Insert( {Id = 0; LoginJSON = loginJSON; ServiceId = serviceId; AccountId = accountId; LastSuccessfulDownload = Nullable(lastSuccessfulDownload); LastDownloadAttempt = Nullable(); LastSuccessfulUpload = Nullable(); LastUploadAttempt = Nullable(); } )
        } |> Async.StartAsTask
