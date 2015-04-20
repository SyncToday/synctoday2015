module sync.today.AssemblyInternalsVisibleTo
open System.Reflection
open System.Runtime.CompilerServices


[<assembly: InternalsVisibleTo("sync.today.tests")>]
[<assembly: InternalsVisibleTo("sync.today.tests.private")>]
()

