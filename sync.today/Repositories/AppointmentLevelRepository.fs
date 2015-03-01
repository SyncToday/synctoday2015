module AppointmentLevelRepository


open System
open AppointmentLevelsSQL
open sync.today.Models
open FSharp.Data
open Common

let AppointmentLevels() : AppointmentLevelDTO list = 
    appointmentLevels()

type SimpleCategories = JsonProvider<"""["Yellow category","Green category","Blue category"]""">

let appLevelName( aln : AppointmentLevelDTO ) =
    aln.Name

let findCategory( categoryJSON : string ) : string =
    if ( String.IsNullOrWhiteSpace(categoryJSON) ) then
        String.Empty 
    else
    let categories = SimpleCategories.Parse(categoryJSON)
    let systemCategories = List.map ( fun f -> appLevelName( f ) ) ( AppointmentLevels() )
    let result = intersect systemCategories categories |> Seq.tryHead 
    if ( result.IsNone ) then
            String.Empty 
    else
        result.Value

