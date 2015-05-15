namespace sync.today.Models

open Common
open System

[<CLIMutable>]
[<CustomEquality>]
[<CustomComparison>]
type AdapterAppointmentDTO =
    {   Id : int
        InternalId : Guid
        LastModified : DateTime
        Category : string option
        Location : string option
        Content : string option
        Title : string option
        DateFrom: DateTime
        DateTo: DateTime
        ReminderMinutesBeforeStart: int
        Notification : bool
        IsPrivate : bool
        Priority : byte
        AppointmentId  : int
        AdapterId : int
        Tag : int option
    }

     member private m.composed() = 
        [ optionString2String m.Category; 
          optionString2String m.Location; 
          optionString2String m.Content; 
          optionString2String m.Title; 
          sprintf "%A" m.DateFrom; 
          sprintf "%A" m.DateTo; 
          sprintf "%A" m.ReminderMinutesBeforeStart; 
          sprintf "%A" m.Notification; sprintf "%A" m.IsPrivate; sprintf "%A" m.Priority ] |> String.concat "#" 

    override m.ToString() = sprintf "[%A] (%A) %A %A -> %A [%A-%A] %A" m.Id m.InternalId m.Title m.DateFrom m.DateTo m.AppointmentId m.AdapterId m.LastModified
    override m.Equals( that ) = (m, that) ||> equalByString (fun a -> m.composed() )
    override m.GetHashCode() = hash(m.composed())

    interface System.IComparable with
        member x.CompareTo yobj =
            match yobj with
            | :? AdapterAppointmentDTO as y -> compare (x.composed()) (y.composed())
            | _ -> invalidArg "yobj" "cannot compare value of different types"
