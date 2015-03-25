module WorkflowRunner

open System.Activities.XamlIntegration
open System.Activities
open System.IO
open sync.today.workflow.wf.dyn.Activities
open System
open System.Xaml

let exportAllFromDB( dir : string ) =
    Directory.CreateDirectory(dir) |> ignore
    let workflows = WorkflowRepository.Workflows()
    for workflow in workflows do
        let workflowFile = dir + workflow.Name + ".xaml" 
        File.WriteAllText( workflowFile, workflow.XamlCode )        

let runFromFile(dir : string, filename : string, namespaceToReplace : string (* "http://WorkflowConsoleApplication1/" *) ) = 
    // http://blogs.msdn.com/b/dglick/archive/2010/01/14/referencing-dynamic-activities-reusing-workflow-activities-without-compilation.aspx
    let schemaContext = new DynamicActivitySchemaContext();
    schemaContext.RegisterNamespace(new Uri(namespaceToReplace), dir)
    // http://stackoverflow.com/questions/14229129/workflow-foundation-4-5-expression-activity-type-csharpvalue1-requires-compi
    let settings = ActivityXamlServicesSettings( CompileExpressions = true )
    let reader = new XamlXmlReader(filename, schemaContext)
    let activity = ActivityXamlServices.Load(reader, settings)
    WorkflowInvoker.Invoke(activity) |> ignore

let runString(xamlWorkflowContent : string) = 
    // http://stackoverflow.com/questions/14229129/workflow-foundation-4-5-expression-activity-type-csharpvalue1-requires-compi
    let settings = ActivityXamlServicesSettings( CompileExpressions = true )
    let reader = new StringReader(xamlWorkflowContent)
    let activity = ActivityXamlServices.Load(reader, settings)
    WorkflowInvoker.Invoke(activity) |> ignore

let runFromDB() =
    let tempDir = Path.GetTempPath() + @"sync.today\workflow.wf\" + Guid.NewGuid().ToString() + @"\"
    exportAllFromDB( tempDir )
    let startupFile = tempDir + "startup.xaml"
    if File.Exists( startupFile ) then
        runFromFile( tempDir, startupFile, "http://local/" )
