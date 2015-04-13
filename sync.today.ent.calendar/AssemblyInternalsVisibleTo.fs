module sync.today.AssemblyInternalsVisibleTo
open System.Reflection
open System.Runtime.CompilerServices


[<assembly: InternalsVisibleTo("sync.today.io.google")>]
[<assembly: InternalsVisibleTo("sync.today.io.exchange")>]
[<assembly: InternalsVisibleTo("sync.today.io.flores")>]
()

