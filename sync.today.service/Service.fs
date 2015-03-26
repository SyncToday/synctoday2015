module Service

open Microsoft.Owin.Hosting
open System;
open System.Diagnostics;
open System.Linq;
open System.ServiceProcess;
open System.Text;
open System.Net.Http
open FSharp.Configuration
open System.Configuration.Install
open System.Reflection
open System.Threading

let serviceName = "Sync.Today Main Service"
let mutable server = null
let _stop = new ManualResetEvent(false);
let mutable _registeredWait : RegisteredWaitHandle = null

let IsServiceInstalled() =
    ServiceController.GetServices().Any(fun s -> s.ServiceName = serviceName )

let UninstallService() =
    ManagedInstallerClass.InstallHelper([| "/u"; Assembly.GetExecutingAssembly().Location |] );

let InstallService() =
    if IsServiceInstalled() then
        UninstallService()
    ManagedInstallerClass.InstallHelper([| Assembly.GetExecutingAssembly().Location |] );

type Settings = AppSettings<"app.config">

type public Main() as service =
    inherit ServiceBase()
   
    let eventLog = new EventLog();
    
    let initService = 
        service.ServiceName <- serviceName

        // Define the Event Log
        let eventSource = serviceName
        if not (EventLog.SourceExists(eventSource)) then
            EventLog.CreateEventSource(eventSource, "Application");

        eventLog.Source <- eventSource;
        eventLog.Log <- "Application";

    do
        initService

    override service.OnStart(args:string[]) =
        try 
            eventLog.WriteEntry("Service Starting")
            base.OnStart(args)

            server <- Starter.start("sync.today.service.exe")

            _stop.Reset() |> ignore
            let _registeredWait = 
                ThreadPool.RegisterWaitForSingleObject(_stop, 
                    WaitOrTimerCallback(fun _ timedOut ->   
                        try  
                            if timedOut then
                                // Periodic processing here
                                Starter.startWorkflow()
                            else
                                // Stop any more events coming along
                                _registeredWait.Unregister(null) |> ignore
                        with
                          |  ex -> eventLog.WriteEntry( ( sprintf "Periodic process failed:\n%A" ex), EventLogEntryType.Error)
                     ), null, Settings.RunIntervalInSecs * 1000, false)

            eventLog.WriteEntry("Service Started")
        with
          |  ex -> eventLog.WriteEntry( ( sprintf "Service Start Failed:\n%A" ex), EventLogEntryType.Error)

    override service.OnStop() =
        try 
            eventLog.WriteEntry("Service Stopping")
            base.OnStop()
            _stop.Set() |> ignore
            Starter.stop(server)
            eventLog.WriteEntry("Service Ended")
        with
          |  ex -> eventLog.WriteEntry( ( sprintf "Service Stop Failed:\n%A" ex), EventLogEntryType.Error)
