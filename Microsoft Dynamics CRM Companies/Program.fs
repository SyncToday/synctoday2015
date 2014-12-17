module Program

open System
open FSharpx.TypeProviders.XrmProvider

let xrm = XrmDataProvider<"https://", Username="", Password="">.GetDataContext("https://.../XRMServices/2011/Organization.svc", "username", "password", "server")

[<EntryPoint>]
let main argv = 
    let accounts = xrm.accountSet |> Seq.toList
    let activeAccounts = query {
                            for account in accounts do
                            where ( ( int account.statecode )  = 0 )
                            select account
                        }                        
    for account in activeAccounts do
        printfn "%A" account.name

    Console.ReadLine() |> ignore
    0 // return an integer exit code
