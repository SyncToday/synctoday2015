module JournalsController

open System.Net
open System.Net.Http
open System.Web.Http
open sync.today.Models
open MainDataConnection

/// Retrieves values.
[<RoutePrefix("api")>]
type JournalsController() =
    inherit ApiController()

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    /// Gets all values.
    [<Route("journals")>]
    member x.Get() = 
        journals()

    (* 
    /// Gets a single value at the specified index.
    [<Route("journals/{id}")>]
    member x.Get(request: HttpRequestMessage, id: int) =
        if id >= 0 && values.Length > id then
            request.CreateResponse(values.[id])
        else 
            request.CreateResponse(HttpStatusCode.NotFound)
    *)