module sync.today.AssemblyInfo
open System.Reflection
open System.Runtime.CompilerServices


[<assembly: AssemblyTitle("Sync.Today Server")>]
[<assembly: AssemblyDescription("")>]
[<assembly: AssemblyCompany("Gassumo Ltd.")>]
[<assembly: AssemblyProduct("")>]
[<assembly: AssemblyCopyright("Copyright ©  2015 Gassumo Ltd.")>]
[<assembly: AssemblyTrademark("")>]

// The assembly version has the format {Major}.{Minor}.{Build}.{Revision}

[<assembly: AssemblyVersion("4.0.*")>]
[<assembly: AssemblyInformationalVersion("4.0.*")>]

//[<assembly: AssemblyDelaySign(false)>]
//[<assembly: AssemblyKeyFile("")>]

#if DEBUG
[<assembly: AssemblyConfiguration("Debug")>]
#else
[<assembly: AssemblyConfiguration("Release")>]
#endif

()

