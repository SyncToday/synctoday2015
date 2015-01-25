namespace sync.today.Controllers

open System.Net
open System.Net.Http
open System.Web.Http
open sync.today.Models

/// Retrieves values.
[<RoutePrefix("api")>]
type CarsController() =
    inherit ApiController()

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    let values = [| { Make = "Ford"; Model = "Mustang" }; { Make = "Nissan"; Model = "Titan" } |]

    /// Gets all values.
    [<Route("cars")>]
    member x.Get() = 
        logger.Info("Get called")
        values

    /// Gets a single value at the specified index.
    [<Route("cars/{id}")>]
    member x.Get(request: HttpRequestMessage, id: int) =
        if id >= 0 && values.Length > id then
            request.CreateResponse(values.[id])
        else 
            request.CreateResponse(HttpStatusCode.NotFound)

