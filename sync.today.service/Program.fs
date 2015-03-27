namespace sync.today.service

open System
open System.Collections.Generic
open System.Linq
open System.ServiceProcess
open System.Text

module Program =
    let appName = "sync.today.service.exe"

    [<EntryPoint>]
    let Main(args) = 
        EnsureConfigFile.FromMasterConfigForApp(appName)
        EnsureConfigFile.FromMasterConfigForLibrary()
        EnsureConfigFile.FromMasterConfigForWeb()
        EnsureConfigFile.FromMasterOrleansClient()

        if args.Length > 0 && args.[0] = "install" then
           Service.InstallService()
        else                 
            // Define your services
            let syncTodayService = new Service.Main()

            // Start the services
            let servicesToRun = [| syncTodayService :> ServiceBase |]
            ServiceBase.Run(servicesToRun)

        // main entry point return
        0

