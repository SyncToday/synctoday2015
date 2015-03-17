module EnsureConfigFile

open System
open System.IO

let finalPath = AppDomain.CurrentDomain.BaseDirectory
let sourcePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles)
let sourceFile = sourcePath + """\sync.today\master.config"""
let finalWebConfigFile = finalPath + "Web.config"
let finalAppConfigFile( appName : string ) = 
    finalPath + appName  + ".config"

let FromMasterConfigForWeb() =
    File.Copy(sourceFile, finalWebConfigFile, true)

let FromMasterConfigForApp( appName : string ) =
    File.Copy(sourceFile, finalAppConfigFile(appName), true)
