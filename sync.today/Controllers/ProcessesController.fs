module ProcessesController

open System.Net
open System.Net.Http
open System.Web.Http
open sync.today.Models
open MainDataConnection

/// Retrieves values.
[<RoutePrefix("api")>]
type ProcessesController() =
    inherit ApiController()

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    
    let values = [| |]

    let isAlive( e : ProcessDTO ) =
        true

    /// Gets all values.
    [<Route("processes")>]
    member x.Get() = 
        logger.Debug("processes called")
        processes() |> Seq.iter (fun e -> ( e.IsAlive = isAlive(e) ) |> ignore )

    /// Gets a single value at the specified index.
    [<Route("processes/{id}")>]
    member x.Get(request: HttpRequestMessage, id: int) =
        let result = processById( id )       
        if result.IsSome then
            result.Value.IsAlive = isAlive(result.Value) |> ignore 
            request.CreateResponse(result.Value)
        else 
            request.CreateResponse(HttpStatusCode.NotFound)
