module ConsumersController

open System.Net
open System.Net.Http
open System.Web.Http
open sync.today.Models
open ConsumerRepository

/// Retrieves values.
[<RoutePrefix("api")>]
type ConsumersController() =
    inherit ApiController()

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    /// Gets all values.
    [<Route("Consumers")>]
    member x.Get() = 
        logger.Debug("adapter called")
        ConsumerRepository.Consumers()

    /// Gets a single value at the specified index.
    [<Route("Consumers/{id}")>]
    member x.Get(request: HttpRequestMessage, id: int) =
        let result = ConsumerRepository.Consumer( id )
        if result.IsSome then
            request.CreateResponse(result.Value)
        else 
            request.CreateResponse(HttpStatusCode.NotFound)

    /// Maps to HTTP PUT.
    [<Route("Consumers")>]
    member x.Put(request : HttpRequestMessage, name : string ) = 
        async {
            return ConsumerRepository.Insert( { Id = 0; Name = name } )
        } |> Async.StartAsTask

