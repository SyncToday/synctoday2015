module EnsureConfigFile

open System
open System.IO

let finalPath = AppDomain.CurrentDomain.BaseDirectory
let sourcePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles)
let sourceFile = sourcePath + """\sync.today\master.config"""
let sourceOrleansClient = sourcePath + """\sync.today\ClientConfiguration.xml"""
let finalWebConfigFile = finalPath + "Web.config"
let finalLibraryAppConfigFile = finalPath + "App.config"
let finalAppConfigFile( appName : string ) = 
    finalPath + appName  + ".config"
let finalOrleansClient = finalPath + "SyncTodayClientConfiguration.xml"

let FromMasterConfigForWeb() =
    File.Copy(sourceFile, finalWebConfigFile, true)

let FromMasterConfigForApp( appName : string ) =
    File.Copy(sourceFile, finalAppConfigFile(appName), true)

let FromMasterConfigForLibrary() =
    File.Copy(sourceFile, finalLibraryAppConfigFile, true)

let FromMasterOrleansClient() =
    File.Copy(sourceOrleansClient, finalOrleansClient, true)