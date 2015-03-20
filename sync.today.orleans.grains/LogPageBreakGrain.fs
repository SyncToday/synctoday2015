namespace sync.today.orleans.grains

open System
open System.Threading.Tasks
open Orleans
open sync.today.orleans.interfaces

type LogPageBreakGrain() = 
    inherit Orleans.Grain()

    interface ILogPageBreak with
        override this.Log() =
            this.GetLogger().Info( "---SYNC.TODAY-----------------------------------------------------------" )

