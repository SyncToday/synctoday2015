module Program

open System.IO
open System.Text

[<EntryPoint>]
let main argv = 
    let result = [| MoneyS4.output.ToString() |]
    File.WriteAllLines( argv.[0], result, Encoding.UTF8 )     
    0 // return an integer exit code
