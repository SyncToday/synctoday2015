module AppointmentLevelRepository


open System
open AppointmentLevelsSQL
open sync.today.Models
open FSharp.Data
open Common

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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

let ensureCategory( categoryName : string ) =
    logger.Debug( sprintf "Called for '%A'" categoryName )
    let appLevels = appointmentLevels()
#if LOG_APP_LEVELS
    for appLevel in appLevels do
        logger.Debug( sprintf "appLevel.Name: '%A'" appLevel.Name )
#endif
    if ( appLevels |> ( Seq.tryFind ( fun p -> p.Name = categoryName ) ) ).IsNone then
        insert( categoryName )

let replaceCategoryInJSON( oldCategoryJSON : string, category : string ) : string =
    devlog.Debug( sprintf "oldCategoryJSON : %A, category : %A" oldCategoryJSON category ) 
    let categories = 
        if ( String.IsNullOrWhiteSpace(oldCategoryJSON) ) then
            [| |]
        else
            SimpleCategories.Parse(oldCategoryJSON)
    let systemCategories = List.map ( fun f -> appLevelName( f ) ) ( AppointmentLevels() )
    let found = intersect systemCategories categories |> Seq.tryHead 
    devlog.Debug( sprintf "found : %A" found ) 
    let result = 
        if ( found.IsNone ) then
            json( Array.append categories [| category |] )
        else
            json( categories |> Array.map ( fun p -> if p = found.Value then category else p ) )
    devlog.Debug( sprintf "result : %A" result ) 
    result
