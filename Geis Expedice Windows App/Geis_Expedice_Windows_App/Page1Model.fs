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

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    let okCommand = 
        self.Factory.CommandSync(
           (fun param -> ( 
                            ( 
                                try
                                    logger.Debug("Export started")
                                    let result = [| GeisExpedice.output.ToString() |]
                                    let now = DateTime.Now
                                    let fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\GEIS-" + now.Year.ToString() + "-" + now.Month.ToString() + "-" + now.Day.ToString() + "-" +  now.Hour.ToString() + "-" + now.Minute.ToString() + "-" + now.Second.ToString() + ".xml"
                                    logger.DebugFormat("FileName:'{0}'", fileName)
                                    File.WriteAllLines( fileName, result, Encoding.UTF8 ) 
                                    GeisExpedice.markAsExported( fileName )
                                    logger.Debug("Export done")
                                with
                                    | ex -> 
                                        logger.Fatal("Export failed", ex)
                                        MessageBox.Show( "Export se nepodařil, více informací najdete v logu" ) |>ignore

                            ) |> ignore 
                          ) )
        )
    

    member x.OkCommand = okCommand
