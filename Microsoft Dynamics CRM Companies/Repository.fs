module Repository

open System
open System.Data.Linq
open System.Data.Entity
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders

[<Literal>]
let connectionString = "Data Source=(localdb)\ProjectsV12; Initial Catalog=SyncToday2015; Integrated Security=True;"

let adapterId = Guid.Parse("3A7E2EAC-3664-4404-9001-E40BA1CDFCC0")

type internal EntityConnection = SqlEntityConnection<ConnectionStringName="sync-today-mssql",
                                                        Pluralize = true>


let private context = EntityConnection.GetDataContext()

let private fullContext = context.DataContext

// this should got to Common.fs
module Seq =
    let tryHead xs = xs |> Seq.tryPick Some

let internal getAccountById( id ) =
    query {
        for account in context.adapters_mscrm_PartialAccounts do
        where ( account.PartialAccountId = id )        
    } |> Seq.tryHead


let fixDateTime( par : DateTime ) =
    if par.Year < 1900 then new Nullable<DateTime>() else Nullable<DateTime>(par)

let internal getInternalAccountById( id ) =
    let gid = Guid.Parse(id)
    query {
        for account in context.entities_Accounts do
        where ( account.AccountId = gid )        
    } |> Seq.tryHead

let internal getAccountsToCreate()  =
    fullContext.ExecuteStoreCommand("[actions.Accounts.create.mscrm.proc]", null) |> ignore
    query {
        for account in context.actions_Accounts_create do
        where ( account.AdapterId = adapterId )
        select account
    } |> Seq.toList

    (*
let internal getAccountsToUpdate()  =
    //fullContext.ExecuteStoreCommand("Action_UpdateAccount_MSCRM", null) |> ignore
    query {
        for account in context.Action_UpdateAccount do
        select account
    } |> Seq.toList
    *)

let public saveAccountFromOrig(accountId, originalId) =
    try
        let newAccount = new EntityConnection.ServiceTypes.adapters_mscrm_PartialAccounts( 
                            PartialAccountId = accountId, AccountId = Nullable<Guid>(originalId), AdapterId = adapterId )
        fullContext.AddObject("adapters_mscrm_PartialAccounts", newAccount)
        fullContext.SaveChanges() |> ignore
    with
        | ex -> raise (System.ArgumentException("saveAccountFromOrig failed", ex))
    
let public saveAccount( accountId, updated : DateTime, 
                        accountCategoryCode, territoryId, defaultPriceLevelId, customerSizeCode, preferredContactMethodCode, customerTypeCode, 
                        accountRatingCode, industryCode, territoryCode, accountClassificationCode, businessTypeCode, owningBusinessUnit, 
                        originatingLeadId, paymentTermsCode, shippingMethodCode, primaryContactId, name, accountNumber, revenue, 
                        numberOfEmployees, description, sic, ownershipCode, marketCap, sharesOutstanding, tickerSymbol, 
                        stockExchange, webSiteURL, ftpSiteURL, eMailAddress1, eMailAddress2, eMailAddress3, doNotPhone, doNotFax, 
                        telephone1, doNotEMail, telephone2, fax, telephone3, doNotPostalMail, doNotBulkEMail, doNotBulkPostalMail, 
                        creditLimit, creditOnHold, isPrivate, createdOn,createdBy,modifiedBy,versionNumber,parentAccountId,
                        aging30,stateCode,aging60,statusCode,aging90,preferredAppointmentDayCode,preferredSystemUserId,
                        preferredAppointmentTimeCode,merged,doNotSendMM,masterId,lastUsedInCampaign,preferredServiceId,
                        preferredEquipmentId,exchangeRate,utcConversionTimeZoneCode,timeZoneRuleVersionNumber,importSequenceNumber,
                        transactionCurrencyId,creditLimit_Base,aging30_Base,revenue_Base,aging90_Base,marketCap_Base,
                        aging60_Base,yomiName,ownerId,modifiedOnBehalfBy,createdOnBehalfBy,ownerIdType,stageId,
                        processId,entityImageId,new_dic,new_ico
                        ) =
                            try
                                let possibleAccount = getAccountById( accountId )
                                // https://sergeytihon.wordpress.com/2013/04/10/f-null-trick/
                                if ( box possibleAccount = null ) then
                                    let newAccount = new EntityConnection.ServiceTypes.adapters_mscrm_PartialAccounts( 
                                                        PartialAccountId = accountId, 
                                                        ModifiedOn = fixDateTime(updated), 
                                                        AccountCategoryCode = (accountCategoryCode),
                                                        TerritoryId = territoryId,
                                                        DefaultPriceLevelId = defaultPriceLevelId,
                                                        CustomerSizeCode = (customerSizeCode),
                                                        PreferredContactMethodCode = (preferredContactMethodCode),
                                                        CustomerTypeCode = (customerTypeCode),
                                                        AccountRatingCode = (accountRatingCode),
                                                        IndustryCode = (industryCode),
                                                        TerritoryCode = (territoryCode),
                                                        AccountClassificationCode = (accountClassificationCode),
                                                        BusinessTypeCode = (businessTypeCode),
                                                        OwningBusinessUnit = owningBusinessUnit,
                                                        OriginatingLeadId = originatingLeadId,
                                                        PaymentTermsCode =  (paymentTermsCode),
                                                        ShippingMethodCode =  (shippingMethodCode),
                                                        PrimaryContactId = primaryContactId,
                                                        Name = name,
                                                        AccountNumber = accountNumber,
                                                        Revenue = revenue,
                                                        NumberOfEmployees =(numberOfEmployees),
                                                        Description = description,
                                                        SIC = sic,
                                                        OwnershipCode = (ownershipCode),
                                                        MarketCap = marketCap,
                                                        SharesOutstanding = (sharesOutstanding),
                                                        TickerSymbol = tickerSymbol,
                                                        StockExchange = stockExchange,
                                                        WebSiteURL = webSiteURL,
                                                        FtpSiteURL = ftpSiteURL,
                                                        EMailAddress1 = eMailAddress1,
                                                        EMailAddress2 = eMailAddress2,
                                                        EMailAddress3 = eMailAddress3,
                                                        DoNotPhone = new Nullable<bool>(doNotPhone),
                                                        DoNotFax = new Nullable<bool>(doNotFax),
                                                        Telephone1 = telephone1,
                                                        DoNotEMail = new Nullable<bool>(doNotEMail),
                                                        Telephone2 = telephone2,
                                                        Fax = fax,
                                                        Telephone3 = telephone3,
                                                        DoNotPostalMail = new Nullable<bool>(doNotPostalMail),
                                                        DoNotBulkEMail = new Nullable<bool>(doNotBulkEMail),
                                                        DoNotBulkPostalMail = new Nullable<bool>(doNotBulkPostalMail),
                                                        CreditLimit = creditLimit,
                                                        CreditOnHold = new Nullable<bool>(creditOnHold),
                                                        IsPrivate = new Nullable<bool>(isPrivate),
                                                        CreatedOn =fixDateTime(createdOn),
                                                        CreatedBy =  createdBy,
                                                        ModifiedBy = modifiedBy,
                                                        //VersionNumber = versionNumber,
                                                        ParentAccountId = parentAccountId,
                                                        Aging30 = aging30,
                                                        StateCode = stateCode,
                                                        Aging60 = aging60,
                                                        StatusCode = (statusCode),
                                                        Aging90 =  aging90,
                                                        PreferredAppointmentDayCode = (preferredAppointmentDayCode),
                                                        PreferredSystemUserId =  preferredSystemUserId,
                                                        PreferredAppointmentTimeCode = (preferredAppointmentTimeCode),
                                                        Merged =  new Nullable<bool>(merged),
                                                        DoNotSendMM =  new Nullable<bool>(doNotSendMM),
                                                        MasterId = masterId,
                                                        LastUsedInCampaign = fixDateTime(lastUsedInCampaign),
                                                        PreferredServiceId = preferredServiceId,
                                                        PreferredEquipmentId = preferredEquipmentId,
                                                        ExchangeRate = new Nullable<decimal>(exchangeRate),
                                                        UTCConversionTimeZoneCode = (utcConversionTimeZoneCode),
                                                        TimeZoneRuleVersionNumber = (timeZoneRuleVersionNumber),
                                                        ImportSequenceNumber = (importSequenceNumber),
                                                        TransactionCurrencyId = transactionCurrencyId,
                                                        CreditLimit_Base = creditLimit_Base,
                                                        Aging30_Base = aging30_Base,
                                                        Revenue_Base = revenue_Base,
                                                        Aging90_Base = aging90_Base,
                                                        MarketCap_Base = marketCap_Base,
                                                        Aging60_Base = aging60_Base,
                                                        YomiName = yomiName,
                                                        //OwnerId = ownerId,
                                                        ModifiedOnBehalfBy = modifiedOnBehalfBy,
                                                        CreatedOnBehalfBy = createdOnBehalfBy,
                                                        //OwnerIdType = ownerIdType,
                                                        StageId = new Nullable<Guid>(stageId),
                                                        ProcessId = new Nullable<Guid>(processId),
                                                        EntityImageId = new Nullable<Guid>(entityImageId),
                                                        new_dic = new_dic,
                                                        new_ic = new_ico,
                                                        AdapterId = adapterId
                                                      )
                                    fullContext.AddObject("adapters_mscrm_PartialAccounts", newAccount)
                                else
                                    let existingAccount = possibleAccount.Value 
                                    existingAccount.ModifiedOn <- fixDateTime(updated)
                                    existingAccount.AccountCategoryCode <- (accountCategoryCode)
                                    existingAccount.TerritoryId <- territoryId
                                    existingAccount.DefaultPriceLevelId <- defaultPriceLevelId
                                    existingAccount.CustomerSizeCode <- (customerSizeCode)
                                    existingAccount.PreferredContactMethodCode <- (preferredContactMethodCode)
                                    existingAccount.CustomerTypeCode <- (customerTypeCode)
                                    existingAccount.AccountRatingCode <- (accountRatingCode)
                                    existingAccount.IndustryCode <- (industryCode)
                                    existingAccount.TerritoryCode <- (territoryCode)
                                    existingAccount.AccountClassificationCode <- (accountClassificationCode)
                                    existingAccount.BusinessTypeCode <- (businessTypeCode)
                                    existingAccount.OwningBusinessUnit <- owningBusinessUnit
                                    existingAccount.OriginatingLeadId <- originatingLeadId
                                    existingAccount.PaymentTermsCode <-  (paymentTermsCode)
                                    existingAccount.ShippingMethodCode <-  (shippingMethodCode)
                                    existingAccount.PrimaryContactId <- primaryContactId
                                    existingAccount.Name <- name
                                    existingAccount.AccountNumber <- accountNumber
                                    existingAccount.Revenue <- revenue
                                    existingAccount.NumberOfEmployees <-(numberOfEmployees)
                                    existingAccount.Description <- description
                                    existingAccount.SIC <- sic
                                    existingAccount.OwnershipCode <- (ownershipCode)
                                    existingAccount.MarketCap <- marketCap
                                    existingAccount.SharesOutstanding <- (sharesOutstanding)
                                    existingAccount.TickerSymbol <- tickerSymbol
                                    existingAccount.StockExchange <- stockExchange
                                    existingAccount.WebSiteURL <- webSiteURL
                                    existingAccount.FtpSiteURL <- ftpSiteURL
                                    existingAccount.EMailAddress1 <- eMailAddress1
                                    existingAccount.EMailAddress2 <- eMailAddress2
                                    existingAccount.EMailAddress3 <- eMailAddress3
                                    existingAccount.DoNotPhone <- new Nullable<bool>(doNotPhone)
                                    existingAccount.DoNotFax <- new Nullable<bool>(doNotFax)
                                    existingAccount.Telephone1 <- telephone1
                                    existingAccount.DoNotEMail <- new Nullable<bool>(doNotEMail)
                                    existingAccount.Telephone2 <- telephone2
                                    existingAccount.Fax <- fax
                                    existingAccount.Telephone3 <- telephone3
                                    existingAccount.DoNotPostalMail <- new Nullable<bool>(doNotPostalMail)
                                    existingAccount.DoNotBulkEMail <- new Nullable<bool>(doNotBulkEMail)
                                    existingAccount.DoNotBulkPostalMail <- new Nullable<bool>(doNotBulkPostalMail)
                                    existingAccount.CreditLimit <- creditLimit
                                    existingAccount.CreditOnHold <- new Nullable<bool>(creditOnHold)
                                    existingAccount.IsPrivate <- new Nullable<bool>(isPrivate)
                                    existingAccount.CreatedOn <-fixDateTime(createdOn)
                                    existingAccount.CreatedBy <-  createdBy
                                    existingAccount.ModifiedBy <- modifiedBy
                                    //existingAccount.VersionNumber <- versionNumber
                                    existingAccount.ParentAccountId <- parentAccountId
                                    existingAccount.Aging30 <- aging30
                                    existingAccount.StateCode <- stateCode
                                    existingAccount.Aging60 <- aging60
                                    existingAccount.StatusCode <- (statusCode)
                                    existingAccount.Aging90 <-  aging90
                                    existingAccount.PreferredAppointmentDayCode <- (preferredAppointmentDayCode)
                                    existingAccount.PreferredSystemUserId <-  preferredSystemUserId
                                    existingAccount.PreferredAppointmentTimeCode <- (preferredAppointmentTimeCode)
                                    existingAccount.Merged <-  new Nullable<bool>(merged)
                                    existingAccount.DoNotSendMM <-  new Nullable<bool>(doNotSendMM)
                                    existingAccount.MasterId <- masterId
                                    existingAccount.LastUsedInCampaign <- fixDateTime(lastUsedInCampaign)
                                    existingAccount.PreferredServiceId <- preferredServiceId
                                    existingAccount.PreferredEquipmentId <- preferredEquipmentId
                                    existingAccount.ExchangeRate <- new Nullable<decimal>(exchangeRate)
                                    existingAccount.UTCConversionTimeZoneCode <- (utcConversionTimeZoneCode)
                                    existingAccount.TimeZoneRuleVersionNumber <- (timeZoneRuleVersionNumber)
                                    existingAccount.ImportSequenceNumber <- (importSequenceNumber)
                                    existingAccount.TransactionCurrencyId <- transactionCurrencyId
                                    existingAccount.CreditLimit_Base <- creditLimit_Base
                                    existingAccount.Aging30_Base <- aging30_Base
                                    existingAccount.Revenue_Base <- revenue_Base
                                    existingAccount.Aging90_Base <- aging90_Base
                                    existingAccount.MarketCap_Base <- marketCap_Base
                                    existingAccount.Aging60_Base <- aging60_Base
                                    existingAccount.YomiName <- yomiName
                                    //existingAccount.OwnerId <- ownerId
                                    existingAccount.ModifiedOnBehalfBy <- modifiedOnBehalfBy
                                    existingAccount.CreatedOnBehalfBy <- createdOnBehalfBy
                                    //existingAccount.OwnerIdType <- ownerIdType
                                    existingAccount.StageId <- new Nullable<Guid>(stageId)
                                    existingAccount.ProcessId <- new Nullable<Guid>(processId)
                                    existingAccount.EntityImageId <- new Nullable<Guid>(entityImageId)
                                    existingAccount.new_dic <- new_dic
                                    existingAccount.new_ic <- new_ico           

                                fullContext.SaveChanges() |> ignore
                                accountId
                            with
                                | ex -> accountId
