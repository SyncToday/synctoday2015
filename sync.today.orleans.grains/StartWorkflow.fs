namespace sync.today.orleans.grains

open System
open System.Threading.Tasks
open Orleans
open sync.today.orleans.interfaces

type StartWorkflowGrain() = 
    inherit Orleans.Grain()

    interface IStartWorkflow with
        override this.Start() : Task =
            async {
                WorkflowRunner.runFromDB()
            } |> Async.StartAsTask :> _
