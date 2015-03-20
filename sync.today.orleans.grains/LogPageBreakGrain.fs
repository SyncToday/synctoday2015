namespace sync.today.orleans.grains

open System
open System.Threading.Tasks
open Orleans
open sync.today.orleans.interfaces

type LogPageBreakGrain() = 
    inherit Orleans.Grain()

    interface ILogPageBreak with
        override this.Log() : Task =
            this.GetLogger().Info( "---SYNC.TODAY-----------------------------------------------------------" )
            async {
                0 |> ignore    
            } |> Async.StartAsTask :> _
