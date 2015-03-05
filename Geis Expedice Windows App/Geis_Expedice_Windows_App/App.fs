module main

open System
open FsXaml

type App = XAML<"App.xaml">


[<STAThread>]
[<EntryPoint>]
let main argv =
    log4net.Config.XmlConfigurator.Configure() |> ignore
    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    logger.Info("Application started")    
    App().Root.Run()