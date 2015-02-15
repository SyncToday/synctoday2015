module Setup

open NUnit.Framework

[<SetUpFixture>] 
type Setup() = 
    
    [<SetUp>] 
    member x.RunBeforeAnyTests() =
        log4net.Config.XmlConfigurator.Configure() |> ignore