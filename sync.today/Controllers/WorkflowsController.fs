module WorkflowsController

open System.Net
open System.Net.Http
open System.Web.Http
open sync.today.Models
open MainDataConnection

/// Retrieves values.
[<RoutePrefix("api")>]
type WorkflowsController() =
    inherit ApiController()

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    /// Gets all values.
    [<Route("workflows")>]
    member x.Get() = 
        logger.Debug("workflows called")
        workflows()

    /// Gets a single value at the specified index.
    [<Route("workflows/{id}")>]
    member x.Get(request: HttpRequestMessage, id: int) =
        let  result = workflowById( id )
        if result.IsSome then
            request.CreateResponse(result.Value)
        else 
            request.CreateResponse(HttpStatusCode.NotFound)
