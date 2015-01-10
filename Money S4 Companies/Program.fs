module Program

open System.IO
open System.Text

[<EntryPoint>]
let main argv = 
    (* Export companies
    let result = [| MoneyS4.output.ToString() |]
    File.WriteAllLines( argv.[0], result, Encoding.UTF8 )     
       // Export companies *)
    (* Export contact persons *)
    let result = [| MoneyS4.outputContacts.ToString() |]
    File.WriteAllLines( argv.[0], result, Encoding.UTF8 )     
    (* //Export contact persons *)
    0 
