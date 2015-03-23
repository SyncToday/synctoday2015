namespace sync.today.service

open System
open System.Collections.Generic
open System.Linq
open System.ServiceProcess
open System.Text

module Program =

    [<EntryPoint>]
    let Main(args) = 

        if args.Length > 0 then
            if args.[0] = "install" then
                Service.InstallService()

        // Define your services
        let syncTodayService = new Service.Main()

        // Start the services
        let servicesToRun = [| syncTodayService :> ServiceBase |]
        ServiceBase.Run(servicesToRun)

        // main entry point return
        0

