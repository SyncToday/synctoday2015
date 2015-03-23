module Starter

open System
open System.Net.Http
open FSharp.Configuration
open Microsoft.Owin.Hosting
open Orleans
open sync.today.orleans.interfaces

type Settings = AppSettings<"app.config">

let start(appName : string) =
    EnsureConfigFile.FromMasterConfigForApp(appName)
    EnsureConfigFile.FromMasterConfigForLibrary()
    EnsureConfigFile.FromMasterConfigForWeb()
    EnsureConfigFile.FromMasterOrleansClient()

    Orleans.GrainClient.Initialize(AppDomain.CurrentDomain.BaseDirectory + "\\SyncTodayClientConfiguration.xml")

    let baseAddress = "http://localhost:" + Settings.ServerPort.ToString()
    let server = WebApp.Start<sync.today.Startup>(baseAddress)
    
    let test = GrainFactory.GetGrain<ILogPageBreak>(int64 0)
    test.Log() |> ignore
            
    server

let stop( server : IDisposable ) =
    server.Dispose()