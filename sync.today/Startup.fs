namespace sync.today

open Owin
open Microsoft.Owin
open System
open System.Net.Http
open System.Web
open System.Web.Http
open System.Web.Http.Owin
open log4net

[<Sealed>]
type Startup() =
    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    static member RegisterWebApi(config: HttpConfiguration) =
        // Configure routing
        config.MapHttpAttributeRoutes()

        // Configure serialization
        config.Formatters.XmlFormatter.UseXmlSerializer <- true
        config.Formatters.JsonFormatter.SerializerSettings.ContractResolver <- Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()

        // Additional Web API settings

    member __.Configuration(builder: IAppBuilder) =
        log4net.Config.XmlConfigurator.Configure() |> ignore
        logger.Info("Sync.Today Server started")
        let config = new HttpConfiguration()
        Startup.RegisterWebApi(config)
        builder.UseWebApi(config) |> ignore

