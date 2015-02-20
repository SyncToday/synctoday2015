namespace sync.today.Models

open System

[<CLIMutable>]
type ServiceAccountDTO =
    {   Id : int
        LoginJSON : string
        ServiceId : int
        AccountId : int
        LastDownload : DateTime
    }
    override m.ToString() = sprintf "[%A] [%A] [%A] (%A)" m.Id m.ServiceId m.AccountId m.LastDownload