module Common

open System.IO
open System.Runtime.Serialization.Json
open System.Xml
open System.Text
open Newtonsoft.Json

module Seq =
    let tryHead xs = xs |> Seq.tryPick Some

/// Object to Json 
let public json<'t> (myObj:'t) =   
        JsonConvert.SerializeObject(myObj)
        (* 
        use ms = new MemoryStream() 
        (new DataContractJsonSerializer(typeof<'t>)).WriteObject(ms, myObj) 
        Encoding.Default.GetString(ms.ToArray()) 
        *)

/// Object from Json 
let public unjson<'t> (jsonString:string)  : 't =  
        use ms = new MemoryStream(ASCIIEncoding.Default.GetBytes(jsonString)) 
        let obj = (new DataContractJsonSerializer(typeof<'t>)).ReadObject(ms) 
        obj :?> 't