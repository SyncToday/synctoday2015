module Common

open System
open System.IO
open System.Xml
open System.Text
open Newtonsoft.Json
open Newtonsoft.Json.Linq
open System.Collections

[<Literal>]
let ConnectionStringName="name=sync-today-mssql"

module Seq =
    let tryHead xs = xs |> Seq.tryPick Some

/// Object to Json 
let public json<'t> (myObj:'t) =   
        JsonConvert.SerializeObject(myObj)

/// Object from Json 
let public unjson<'t> (jsonString:string)  : 't =  
        let obj = JsonConvert.DeserializeObject(jsonString)
        if obj :? 't then 
            obj :?> 't
        else
            let jToken = obj :?> JToken
            jToken.ToObject<'t>()

let fixDateTime( a : DateTime ) : DateTime =
    a.AddTicks( -(a.Ticks % TimeSpan.TicksPerSecond) )

let fixDateSecs( a : DateTime ) : DateTime =
    fixDateTime( a.AddSeconds( float -a.Second ) )

let intersect x y = Set.intersect (Set.ofSeq x) (Set.ofArray y)

let optionString2String( optionString : String option ) =
    if optionString.IsNone then null else optionString.Value 

let devlog = log4net.LogManager.GetLogger("DevLog");
let ignlog = log4net.LogManager.GetLogger( "IgnoreLog" )

let string2optionString( s : string ) : string option =
    match s with
    | null -> None
    | some -> Some(some)

type IEqualityComparer<'T> = Generic.IEqualityComparer<'T>

let equalIf f (x:'T) (y:obj) =
  if obj.ReferenceEquals(x, y) then true
  else
    match box x, y with
    | null, _ | _, null -> false
    | _, (:? 'T as y) -> f x y
    | _ -> false

let equalByWithComparer (comparer:IEqualityComparer<_>) f (x:'T) (y:obj) = 
  (x, y) ||> equalIf (fun x y -> comparer.Equals(f x, f y))

let equalByProjection proj (comparer:IEqualityComparer<_>) f (x:'T) (y:obj) = 
  (x, y) ||> equalIf (fun x y -> 
    Seq.zip (proj x) (proj y)
    |> Seq.forall obj.Equals && comparer.Equals(f x, f y))

let equalByString f (x:'T) (y:obj) = 
  (x, y) ||> equalIf (fun x y -> StringComparer.InvariantCulture.Equals(f x, f y))

let convertOption(a, convert) =
    match a with
    | Some r -> Some(convert(r))
    | None -> None

let stringsAreEqual a b =
    if String.IsNullOrEmpty a then
        String.IsNullOrEmpty b 
    else
        String.Equals( a, b )

let optionstringsAreEqual a b =
    let a_s = optionString2String a
    let b_s = optionString2String b
    stringsAreEqual a_s b_s

let optionstringIsEmpty a =
    match a with
    | Some r -> String.IsNullOrEmpty( r )
    | None -> true
