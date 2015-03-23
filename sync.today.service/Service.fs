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

let serviceName = "sync.today.service"
let mutable server = null

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

            eventLog.WriteEntry("Service Started")
        with
          |  ex -> eventLog.WriteEntry( ( sprintf "Service Start Failed:\n%A" ex), EventLogEntryType.Error)

    override service.OnStop() =
        try 
            eventLog.WriteEntry("Service Stopping")
            base.OnStop()
            Starter.stop(server)
            eventLog.WriteEntry("Service Ended")
        with
          |  ex -> eventLog.WriteEntry( ( sprintf "Service Stop Failed:\n%A" ex), EventLogEntryType.Error)
