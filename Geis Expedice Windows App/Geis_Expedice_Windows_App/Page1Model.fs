namespace Views

open System
open System.Windows
open System.Windows.Input

open System.IO
open System.Text

open FsXaml
open FSharp.ViewModule
open FSharp.ViewModule.Validation

type Page1ViewModel() as self = 
    inherit ViewModelBase()

    let okCommand = 
        self.Factory.CommandSync(
           (fun param -> ( 
                            ( 
                                let result = [| GeisExpedice.output.ToString() |]
                                let now = DateTime.Now
                                let fileName = "GEIS-" + now.Year.ToString() + "-" + now.Month.ToString() + "-" + now.Day.ToString() + "-" +  now.Hour.ToString() + "-" + now.Minute.ToString() + "-" + now.Second.ToString() + ".xml"
                                File.WriteAllLines( fileName, result, Encoding.UTF8 ) 

                            ) |> ignore 
                          ) )
        )
    

    member x.OkCommand = okCommand
