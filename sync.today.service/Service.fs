namespace sync.today.service

open Microsoft.Owin.Hosting
open System;
open System.Diagnostics;
open System.Linq;
open System.ServiceProcess;
open System.Text;
open System.Net.Http
open FSharp.Configuration

type Settings = AppSettings<"app.config">

type public Main() as service =
    inherit ServiceBase()
   
    let eventLog = new EventLog();

    let mutable server = null
    
    let initService = 
        service.ServiceName <- "sync.today.service" 

        // Define the Event Log
        let eventSource = "sync.today.service"
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

