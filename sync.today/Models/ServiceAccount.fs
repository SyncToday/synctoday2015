namespace sync.today.Models

open System

[<CLIMutable>]
type ServiceAccountDTO =
    {   Id : int
        LoginJSON : string
        ServiceId : int
        AccountId : int
        LastSuccessfulDownload : Nullable<DateTime>
        LastDownloadAttempt: Nullable<DateTime>
        LastSuccessfulUpload : Nullable<DateTime>
        LastUploadAttempt: Nullable<DateTime>
    }
    override m.ToString() = sprintf "[%A] [%A] [%A] (%A/%A)" m.Id m.ServiceId m.AccountId m.LastSuccessfulDownload m.LastSuccessfulUpload