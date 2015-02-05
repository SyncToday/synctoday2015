namespace sync.today.service

open System
open System.Collections.Generic
open System.Linq
open System.ServiceProcess
open System.Text


module Program =

    [<EntryPoint>]
    let Main(args) = 
        // Define your services
        let syncTodayService = new SyncTodayService()

        // Start the services
        let servicesToRun = [| syncTodayService :> ServiceBase |]
        ServiceBase.Run(servicesToRun)

        // main entry point return
        0

