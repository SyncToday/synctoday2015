open System
open System.IO
open System.Linq
open System.Activities
open System.Activities.Statements
open System.Activities.XamlIntegration

[<EntryPoint>]
let main argv = 
    let settings = ActivityXamlServicesSettings( CompileExpressions = true )
    let xaml = File.ReadAllText("Workflow1.xaml")
    let reader = new StringReader(xaml)
    let activity = ActivityXamlServices.Load(reader, settings)
    WorkflowInvoker.Invoke(activity) |> ignore
    0 // return an integer exit code
