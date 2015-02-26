module Program

open System.IO
open System.Text

[<EntryPoint>]
let main argv = 
    try 
        if ( argv.[0] = "import" ) then
            DB.import_do_money()
        if ( argv.[0] = "exportcompanies" ) then
        (* Export companies *)
            let result = [| MoneyS4.output.ToString() |]
            File.WriteAllLines( argv.[1], result, Encoding.UTF8 )     
           // Export companies *)
        (* Export contact persons 
        let result = [| MoneyS4.outputContacts.ToString() |]
        File.WriteAllLines( argv.[0], result, Encoding.UTF8 )     
         //Export contact persons *)
        if ( argv.[0] = "exportorders" ) then
        (* Export orders *)
            let result = [| ObjednavkyPrijate.output.ToString() |]
            File.WriteAllLines( argv.[1], result, Encoding.UTF8 )     
         //Export orders *)
        0
    with
      |  ex -> raise (System.ArgumentException("main failed", ex))
               1
