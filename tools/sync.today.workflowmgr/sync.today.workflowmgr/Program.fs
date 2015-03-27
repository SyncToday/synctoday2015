open System
open System.IO
open System.Xml
open System.Xaml

let printusage() =
    printfn  "Usage: sync.today.workflowmgr <command> <filename if needed>"
    printfn  "------------------------------------------------------------"
    printfn  "sync.today.workflowmgr list - list all workflows"
    printfn  "sync.today.workflowmgr import filename.xaml - import filename.xaml as filename workflow"
    printfn  "sync.today.workflowmgr export filename - export filename workflow as filename.xaml"
    printfn  "sync.today.workflowmgr delete filename - delete filename workflow"

let listWorkflows() =
    printfn "Listing workflows:"
    for workflow in WorkflowRepository.Workflows() do
        printfn "%A" workflow.Name
    printfn "Done"

let importWorkflow(fileName : string ) =
    if File.Exists(fileName) then 
        try
            let workflowName = Path.GetFileNameWithoutExtension(fileName)
            let xamlContent = File.ReadAllText(fileName)
            let stringReader = new StringReader(xamlContent)
            let xmlReader = XmlReader.Create(stringReader)
            xmlReader.ReadStartElement()
            printfn "File %A imported as workflow %A" fileName (WorkflowRepository.EnsureWorkflow(workflowName, xamlContent))
        with
            | ex -> printfn "Loading %A failed with %A" fileName ex
    else
       printfn "File %A not found" fileName

let exportWorkflow( workflowName : string ) =
    0 |> ignore

let deleteWorkflow( workflowName : string ) =
    0 |> ignore

[<EntryPoint>]
let main argv = 
    EnsureConfigFile.FromMasterConfigForApp("sync.today.workflowmgr.exe")

    if argv.Length = 0 then
        printusage()
    else
        let command = argv.[0]
        match command with
        | "list" -> listWorkflows()
        | "import" -> 
            if argv.Length = 2 then importWorkflow(argv.[1]) else printusage()
        | "export" ->
            if argv.Length = 2 then exportWorkflow(argv.[1]) else printusage()
        | "delete" ->
            if argv.Length = 2 then deleteWorkflow(argv.[1]) else printusage()
        | _ -> printusage()

    0 // return an integer exit code
