namespace sync.today.Models

open System

[<CLIMutable>]
type ConsumerAdapterDTO =
    {   Id : int
        AdapterId : int
        ConsumerId : int
        DataJSON : string
    }
    override m.ToString() = sprintf "[%A] %A (%A-%A)" m.Id m.DataJSON m.AdapterId m.ConsumerId
        