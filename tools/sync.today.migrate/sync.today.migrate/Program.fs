module Main

open ConsumersSQL
open sync.today.Models
open OldDataConnection
open System
open sync.today.cipher

[<EntryPoint>]
let main argv = 

    let EXCHANGE_SERVICE_KEY="EXCHANGE"
    let FLORES_SERVICE_KEY="FLORES"
    
    // GENERAL SETUP
    let exchangeService = ServiceRepository.EnsureService(EXCHANGE_SERVICE_KEY, "Exchange")
    let EmptyExchangeAdapter : AdapterDTO = { Id = 0; Name = EXCHANGE_SERVICE_KEY }
    let exchangeAdapter = AdapterRepository.Insert(EmptyExchangeAdapter)

            
    let floresService = ServiceRepository.EnsureService(FLORES_SERVICE_KEY, "Exchange");
    let EmptyFloresAdapter : AdapterDTO = { Id = 0; Name = FLORES_SERVICE_KEY }
    let FloresAdapterId = AdapterRepository.Insert(EmptyFloresAdapter)

    let oldUsers = OldDataConnection.users()
    let newUsers = ConsumerRepository.Consumers()

    for oldUser in oldUsers do
        let oldUserName = oldUser.FirstName + " " + oldUser.LastName + " " + oldUser.Email
        let newUser = consumerByName(oldUserName)
        if newUser.IsNone then
            insertConsumer( { Id = 0; Name = oldUserName} ) |> ignore

    for oldUser in oldUsers do
        let oldUserName = oldUser.FirstName + " " + oldUser.LastName + " " + oldUser.Email
        let newUser = consumerByName(oldUserName).Value
        let consumerId = newUser.Id
        let userAccounts = accounts( newUser.Id )
        for oldAccount in userAccounts do
            let length = oldAccount.Password.Length
            if ( length = 0 ) then
                // Flores
                let EmptyFloresAccount : AccountDTO  = { Id = 0; Name = oldAccount.UserName; ConsumerId = Nullable(consumerId )}
                let FloresAccountId = MainDataConnection.insertAccount(EmptyFloresAccount)
                let FloresServiceAccountId = ServiceAccountsSQL.insertServiceAccount( { Id = 0; LoginJSON = String.Format("{\"server\" : \"{0}\"}", oldAccount.Server ); ServiceId = floresService.Id; AccountId = FloresAccountId; LastUploadAttempt = Nullable(DateTime.Now); LastSuccessfulUpload = Nullable(DateTime.Now); LastDownloadAttempt = Nullable(DateTime.Now); LastSuccessfulDownload = Nullable(DateTime.Now.AddDays(-30.0)) })
                ConsumerAdapterRepository.Insert( { Id = 0; AdapterId = FloresAdapterId; ConsumerId = consumerId; DataJSON = oldAccount.UserName} ) |> ignore
                printfn "%A" oldAccount.Id 
            else
                // Exchange
                let EmptyExchangeAccount : AccountDTO = { Id = 0; Name = oldAccount.UserName; ConsumerId = Nullable(consumerId) }
                let exchangeAccountId = MainDataConnection.insertAccount(EmptyExchangeAccount)
                let serviceAccount : ServiceAccountDTO = { Id = 0; LoginJSON = String.Format("{{\"loginName\" : \"{2}\", \"password\" : \"{0}\", \"server\" : \"{1}\"}}", oldAccount.Password, oldAccount.Server); ServiceId = exchangeService.Id; AccountId = exchangeAccountId; LastUploadAttempt = Nullable(DateTime.Now); LastSuccessfulUpload = Nullable(DateTime.Now); LastDownloadAttempt = Nullable(DateTime.Now); LastSuccessfulDownload = Nullable(DateTime.Now.AddDays(-30.0)) }
                let exchangeServiceAccountId = ServiceAccountsSQL.insertServiceAccount(serviceAccount)
                let consumerAdapter : ConsumerAdapterDTO = { Id = 0; AdapterId = exchangeAdapter; ConsumerId = consumerId; DataJSON = "" }
                ConsumerAdapterRepository.Insert(consumerAdapter ) |> ignore
                printfn "%A" oldAccount.Id 

(* 
    let EmptyExchangeAccount : AccountDTO = { Id = 0; Name = "AlexD@florestest.onmicrosoft.com"; ConsumerId = consumerId }
    let exchangeAccountId = MainDataConnection.insertAccount(EmptyExchangeAccount);
    let exchangeServiceAccountId = ServiceAccountsSQL.insertServiceAccount(new Models.ServiceAccountDTO() { Id = 0, LoginJSON = string.Format("{{\"loginName\" : \"AlexD@florestest.onmicrosoft.com\", \"password\" : \"{0}\", \"server\" : \"{1}\"}}", StringCipher.Encrypt("pass@word1", "AlexD@florestest.onmicrosoft.com"), office365server), ServiceId = exchangeService.Id, AccountId = exchangeAccountId, LastUploadAttempt = DateTime.Now, LastSuccessfulUpload = DateTime.Now, LastDownloadAttempt = DateTime.Now, LastSuccessfulDownload = DateTime.Now.AddDays(-30.0) });
    ConsumerAdapterRepository.Insert(new Models.ConsumerAdapterDTO() { Id = 0, AdapterId = exchangeAdapter, ConsumerId = consumerId, DataJSON = "" });

    let EmptyFloresAccount = new Models.AccountDTO() { Id = 0, Name = "Flores", ConsumerId = consumerId };
    let FloresAccountId = MainDataConnection.insertAccount(EmptyFloresAccount);
    let FloresServiceAccountId = ServiceAccountsSQL.insertServiceAccount(new Models.ServiceAccountDTO() { Id = 0, LoginJSON = "{\"server\" : \"http://172.16.1.132:8080/REST4/\"}", ServiceId = floresService.Id, AccountId = FloresAccountId, LastUploadAttempt = DateTime.Now, LastSuccessfulUpload = DateTime.Now, LastDownloadAttempt = DateTime.Now, LastSuccessfulDownload = DateTime.Now.AddDays(-30.0) });
    ConsumerAdapterRepository.Insert(new Models.ConsumerAdapterDTO() { Id = 0, AdapterId = FloresAdapterId, ConsumerId = consumerId, DataJSON = "1200000101" });
*)
    0 // return an integer exit code