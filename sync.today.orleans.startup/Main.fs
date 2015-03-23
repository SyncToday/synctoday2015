module Main

open System
open System.Net.Http
open FSharp.Configuration
open Microsoft.Owin.Hosting

type Settings = AppSettings<"app.config">

let start(appName : string) =
    EnsureConfigFile.FromMasterConfigForApp(appName)
    EnsureConfigFile.FromMasterConfigForLibrary()
    EnsureConfigFile.FromMasterConfigForWeb()

    Orleans.GrainClient.Initialize("SyncTodayClientConfiguration.xml")

    let baseAddress = "http://localhost:" + Settings.ServerPort.ToString()
    let server = WebApp.Start<sync.today.Startup>(baseAddress)
    server

