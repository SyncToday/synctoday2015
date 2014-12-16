module Repository

open System
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders

// for technical see http://msdn.microsoft.com/en-us/library/hh361035.aspx
// note as this is a sample we do not follow recommendations from http://fsharpforfunandprofit.com/posts/recipe-part3/
[<Literal>]
let connectionString = "Data Source=(localdb)\ProjectsV12; Initial Catalog=SyncToday2015; Integrated Security=True;"

type internal EntityConnection = SqlEntityConnection<ConnectionString=connectionString,
                                                        Pluralize = true>

let private context = EntityConnection.GetDataContext()

let private fullContext = context.DataContext

// this should got to Common.fs
module Seq =
    let tryHead xs = xs |> Seq.tryPick Some

let internal getGroupById( id ) =
    query {
        for qroup in context.Google_Contacts_Group do
        where ( qroup.id = id )        
    } |> Seq.tryHead

let public saveGroup( id, updated : DateTime, title ) =
    let possibleGroup = getGroupById( id )
    // https://sergeytihon.wordpress.com/2013/04/10/f-null-trick/
    if ( box possibleGroup = null ) then
        let newGroup = new EntityConnection.ServiceTypes.Google_Contacts_Group( id = id, updated = new Nullable<DateTimeOffset>( DateTimeOffset( updated )  ), title = title )
        fullContext.AddObject("Google_Contacts_Group", newGroup)
    else
        let existingGroup = possibleGroup.Value 
        existingGroup.updated <- new Nullable<DateTimeOffset>( DateTimeOffset( updated ) )
        existingGroup.title <- title
    fullContext.SaveChanges() |> ignore
    id
