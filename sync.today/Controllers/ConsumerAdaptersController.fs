module ConsumerAdaptersController

open System.Net
open System.Net.Http
open System.Web.Http
open sync.today.Models
open ConsumerAdapterRepository

/// Retrieves values.
[<RoutePrefix("api")>]
type ConsumerAdaptersController() =
    inherit ApiController()

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    /// Gets all values.
    [<Route("consumeradapters")>]
    member x.Get() = 
        logger.Debug("adapter called")
        ConsumerAdapters()

    /// Gets a single value at the specified index.
    [<Route("consumeradapters/{id}")>]
    member x.Get(request: HttpRequestMessage, id: int) =
        let result = ConsumerAdapterById( id )
        if result.IsSome then
            request.CreateResponse(result.Value)
        else 
            request.CreateResponse(HttpStatusCode.NotFound)

    /// Maps to HTTP PUT.
    [<Route("consumeradapters")>]
    member x.Put(request : HttpRequestMessage, adapterId : int, consumerId : int, dataJSON : string ) = 
        async {
            return Insert( { Id = 0; AdapterId = adapterId; ConsumerId = consumerId; DataJSON = dataJSON } )
        } |> Async.StartAsTask