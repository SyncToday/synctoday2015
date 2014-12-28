// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    try
        for address in Repository.getAddresses do
            printfn "%A" address
            Repository.saveAdress(address)
    with
        | ex -> raise (System.ArgumentException("hikashop sync failed", ex))

    0 // return an integer exit code
