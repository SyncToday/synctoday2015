module Program

open System
open System.IO
open System.Text

[<EntryPoint>]
let main argv = 
    try
        //printfn "%A" (System.DateTime(2015, 1, 6).AddDays(-42010.0).ToString())
        //printfn "%A" (System.DateTime(1899, 12, 30).AddDays(42010.0).ToString())
        
        (* *) 
        GeisExpedice.importFaktura()
        (* *)
        
        (* 
        let result = [| GeisExpedice.output.ToString() |
        let now = DateTime.Now
        let fileName = "GEIS-" + now.Year.ToString() + "-" + now.Month.ToString() + "-" + now.Day.ToString() + "-" +  now.Hour.ToString() + "-" + now.Minute.ToString() + "-" + now.Second.ToString() + ".xml"
        File.WriteAllLines( fileName, result, Encoding.UTF8 )    
        *)
        //GeisExpedice.markAsExported( fileName )
        //System.Console.ReadLine() |> ignore 
        0 // return an integer exit code
    with
        | ex -> raise (System.ArgumentException("main failed", ex))
