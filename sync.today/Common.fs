module Common

open System
open System.IO
open System.Xml
open System.Text
open Newtonsoft.Json

module Seq =
    let tryHead xs = xs |> Seq.tryPick Some

/// Object to Json 
let public json<'t> (myObj:'t) =   
        JsonConvert.SerializeObject(myObj)

        (* 
/// Object from Json 
let public unjson<'t> (jsonString:string)  : 't =  
        use ms = new MemoryStream(ASCIIEncoding.Default.GetBytes(jsonString)) 
        let obj = (new DataContractJsonSerializer(typeof<'t>)).ReadObject(ms) 
        obj :?> 't
        *)
let fixDateTime( a : DateTime ) : DateTime =
    a.AddTicks( -(a.Ticks % TimeSpan.TicksPerSecond) )

let fixDateSecs( a : DateTime ) : DateTime =
    fixDateTime( a.AddSeconds( float -a.Second ) )
