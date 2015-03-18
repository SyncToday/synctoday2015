namespace sync.today.Models

open System

[<CLIMutable>]
type ServiceAccountDTO =
    {   Id : int
        LoginJSON : string
        ServiceId : int
        AccountId : int
        LastSuccessfulDownload : Option<DateTime>
        LastDownloadAttempt: Option<DateTime>
        LastSuccessfulUpload : Option<DateTime>
        LastUploadAttempt: Option<DateTime>
    }
    override m.ToString() = sprintf "[%A] [%A] [%A] (%A/%A)" m.Id m.ServiceId m.AccountId m.LastSuccessfulDownload m.LastSuccessfulUpload