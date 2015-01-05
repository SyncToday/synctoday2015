module Program

open System.IO
open System.Text

[<EntryPoint>]
let main argv = 
    //printfn "%A" (System.DateTime(2015, 1, 6).AddDays(-42010.0).ToString())
    //printfn "%A" (System.DateTime(1899, 12, 30).AddDays(42010.0).ToString())
    let result = [| GeisExpedice.output.ToString() |]
    File.WriteAllLines( argv.[0], result, Encoding.UTF8 )    
    //System.Console.ReadLine() |> ignore 
    0 // return an integer exit code
