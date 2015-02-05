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
   
    // TODO define your service variables
    let eventLog = new EventLog();

    let mutable server = null
    
    // TODO initialize your service
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

    // TODO define your service operations
    override service.OnStart(args:string[]) =
        try 
            eventLog.WriteEntry("Service Starting")
            base.OnStart(args)
            let baseAddress = "http://localhost:" + Settings.ServerPort.ToString()
            server <- WebApp.Start<sync.today.Startup>(baseAddress)

            eventLog.WriteEntry("Service Started")
        with
          |  ex -> eventLog.WriteEntry( ( sprintf "Service Start Failed %s %s" ex.Message ex.StackTrace), EventLogEntryType.Error)

    override service.OnStop() =
        try 
            eventLog.WriteEntry("Service Stopping")
            base.OnStop()
            server.Dispose()
            eventLog.WriteEntry("Service Ended")
        with
          |  ex -> eventLog.WriteEntry( ( sprintf "Service Stop Failed %s %s" ex.Message ex.StackTrace), EventLogEntryType.Error)

