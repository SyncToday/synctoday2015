module WorkflowRunner

open System.Activities.XamlIntegration
open System.Activities
open System.IO
open sync.today.workflow.wf.dyn.Activities

let runFromFile(filename : string) = 
    // http://stackoverflow.com/questions/14229129/workflow-foundation-4-5-expression-activity-type-csharpvalue1-requires-compi
    let settings = ActivityXamlServicesSettings( CompileExpressions = true )
    let xaml = File.ReadAllText(filename)
    let reader = new StringReader(xaml)
    let activity = ActivityXamlServices.Load(reader, settings)
    WorkflowInvoker.Invoke(activity) |> ignore

let runString(xamlWorkflowContent : string) = 
    // http://blogs.msdn.com/b/dglick/archive/2010/01/14/referencing-dynamic-activities-reusing-workflow-activities-without-compilation.aspx
    let schemaContext = new DynamicActivitySchemaContext();
    // http://stackoverflow.com/questions/14229129/workflow-foundation-4-5-expression-activity-type-csharpvalue1-requires-compi
    let settings = ActivityXamlServicesSettings( CompileExpressions = true )
    let reader = new StringReader(xamlWorkflowContent)
    let activity = ActivityXamlServices.Load(reader, settings)
    WorkflowInvoker.Invoke(activity) |> ignore

