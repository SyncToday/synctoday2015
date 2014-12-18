module Repository

open System
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders

[<Literal>]
let connectionString = "Data Source=(localdb)\ProjectsV12; Initial Catalog=SyncToday2015; Integrated Security=True;"

type internal EntityConnection = SqlEntityConnection<ConnectionString=connectionString,
                                                        Pluralize = true>


let private context = EntityConnection.GetDataContext()

let private fullContext = context.DataContext

// this should got to Common.fs
module Seq =
    let tryHead xs = xs |> Seq.tryPick Some

let internal getAccountById( id ) =
    query {
        for account in context.MSCRM_Companies_Account do
        where ( account.AccountId = id )        
    } |> Seq.tryHead

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
    let possibleAccount = getAccountById( accountId )
    // https://sergeytihon.wordpress.com/2013/04/10/f-null-trick/
    if ( box possibleAccount = null ) then
        let newAccount = new EntityConnection.ServiceTypes.MSCRM_Companies_Account( 
                            AccountId = accountId, 
                            ModifiedOn = new Nullable<DateTime>(updated), 
                            AccountCategoryCode = new Nullable<int>(accountCategoryCode),
                            TerritoryId = territoryId,
                            DefaultPriceLevelId = defaultPriceLevelId,
                            CustomerSizeCode = new Nullable<int>(customerSizeCode),
                            PreferredContactMethodCode = new Nullable<int>(preferredContactMethodCode),
                            CustomerTypeCode = new Nullable<int>(customerTypeCode),
                            AccountRatingCode = new Nullable<int>(accountRatingCode),
                            IndustryCode = new Nullable<int>(industryCode),
                            TerritoryCode = new Nullable<int>(territoryCode),
                            AccountClassificationCode = new Nullable<int>(accountClassificationCode),
                            BusinessTypeCode = new Nullable<int>(businessTypeCode),
                            OwningBusinessUnit = owningBusinessUnit,
                            OriginatingLeadId = originatingLeadId,
                            PaymentTermsCode =  new Nullable<int>(paymentTermsCode),
                            ShippingMethodCode =  new Nullable<int>(shippingMethodCode),
                            PrimaryContactId = primaryContactId,
                            Name = name,
                            AccountNumber = accountNumber,
                            Revenue = revenue,
                            NumberOfEmployees =new Nullable<int>(numberOfEmployees),
                            Description = description,
                            SIC = sic,
                            OwnershipCode = new Nullable<int>(ownershipCode),
                            MarketCap = marketCap,
                            SharesOutstanding = new Nullable<int>(sharesOutstanding),
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
                            CreatedOn =new Nullable<DateTime>(createdOn),
                            CreatedBy =  createdBy,
                            ModifiedBy = modifiedBy,
                            //VersionNumber = versionNumber,
                            ParentAccountId = parentAccountId,
                            Aging30 = aging30,
                            StateCode = stateCode,
                            Aging60 = aging60,
                            StatusCode = new Nullable<int>(statusCode),
                            Aging90 =  aging90,
                            PreferredAppointmentDayCode = new Nullable<int>(preferredAppointmentDayCode),
                            PreferredSystemUserId =  preferredSystemUserId,
                            PreferredAppointmentTimeCode = new Nullable<int>(preferredAppointmentTimeCode),
                            Merged =  new Nullable<bool>(merged),
                            DoNotSendMM =  new Nullable<bool>(doNotSendMM),
                            MasterId = masterId,
                            LastUsedInCampaign = new Nullable<DateTime>(lastUsedInCampaign),
                            PreferredServiceId = preferredServiceId,
                            PreferredEquipmentId = preferredEquipmentId,
                            ExchangeRate = new Nullable<decimal>(exchangeRate),
                            UTCConversionTimeZoneCode = new Nullable<int>(utcConversionTimeZoneCode),
                            TimeZoneRuleVersionNumber = new Nullable<int>(timeZoneRuleVersionNumber),
                            ImportSequenceNumber = new Nullable<int>(importSequenceNumber),
                            TransactionCurrencyId = transactionCurrencyId,
                            CreditLimit_Base = creditLimit_Base,
                            Aging30_Base = aging30_Base,
                            Revenue_Base = revenue_Base,
                            Aging90_Base = aging90_Base,
                            MarketCap_Base = marketCap_Base,
                            Aging60_Base = aging60_Base,
                            YomiName = yomiName,
                            OwnerId = ownerId,
                            ModifiedOnBehalfBy = modifiedOnBehalfBy,
                            CreatedOnBehalfBy = createdOnBehalfBy,
                            OwnerIdType = ownerIdType,
                            StageId = new Nullable<Guid>(stageId),
                            ProcessId = new Nullable<Guid>(processId),
                            EntityImageId = new Nullable<Guid>(entityImageId),
                            new_dic = new_dic,
                            new_ico = new_ico
                          )
        fullContext.AddObject("MSCRM_Companies_Account", newAccount)
    else
        let existingAccount = possibleAccount.Value 
        existingAccount.ModifiedOn <- new Nullable<DateTime>(updated)
        existingAccount.AccountCategoryCode <- new Nullable<int>(accountCategoryCode)
        existingAccount.TerritoryId <- territoryId
        existingAccount.DefaultPriceLevelId <- defaultPriceLevelId
        existingAccount.CustomerSizeCode <- new Nullable<int>(customerSizeCode)
        existingAccount.PreferredContactMethodCode <- new Nullable<int>(preferredContactMethodCode)
        existingAccount.CustomerTypeCode <- new Nullable<int>(customerTypeCode)
        existingAccount.AccountRatingCode <- new Nullable<int>(accountRatingCode)
        existingAccount.IndustryCode <- new Nullable<int>(industryCode)
        existingAccount.TerritoryCode <- new Nullable<int>(territoryCode)
        existingAccount.AccountClassificationCode <- new Nullable<int>(accountClassificationCode)
        existingAccount.BusinessTypeCode <- new Nullable<int>(businessTypeCode)
        existingAccount.OwningBusinessUnit <- owningBusinessUnit
        existingAccount.OriginatingLeadId <- originatingLeadId
        existingAccount.PaymentTermsCode <-  new Nullable<int>(paymentTermsCode)
        existingAccount.ShippingMethodCode <-  new Nullable<int>(shippingMethodCode)
        existingAccount.PrimaryContactId <- primaryContactId
        existingAccount.Name <- name
        existingAccount.AccountNumber <- accountNumber
        existingAccount.Revenue <- revenue
        existingAccount.NumberOfEmployees <-new Nullable<int>(numberOfEmployees)
        existingAccount.Description <- description
        existingAccount.SIC <- sic
        existingAccount.OwnershipCode <- new Nullable<int>(ownershipCode)
        existingAccount.MarketCap <- marketCap
        existingAccount.SharesOutstanding <- new Nullable<int>(sharesOutstanding)
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
        existingAccount.CreatedOn <-new Nullable<DateTime>(createdOn)
        existingAccount.CreatedBy <-  createdBy
        existingAccount.ModifiedBy <- modifiedBy
        //existingAccount.VersionNumber <- versionNumber
        existingAccount.ParentAccountId <- parentAccountId
        existingAccount.Aging30 <- aging30
        existingAccount.StateCode <- stateCode
        existingAccount.Aging60 <- aging60
        existingAccount.StatusCode <- new Nullable<int>(statusCode)
        existingAccount.Aging90 <-  aging90
        existingAccount.PreferredAppointmentDayCode <- new Nullable<int>(preferredAppointmentDayCode)
        existingAccount.PreferredSystemUserId <-  preferredSystemUserId
        existingAccount.PreferredAppointmentTimeCode <- new Nullable<int>(preferredAppointmentTimeCode)
        existingAccount.Merged <-  new Nullable<bool>(merged)
        existingAccount.DoNotSendMM <-  new Nullable<bool>(doNotSendMM)
        existingAccount.MasterId <- masterId
        existingAccount.LastUsedInCampaign <- new Nullable<DateTime>(lastUsedInCampaign)
        existingAccount.PreferredServiceId <- preferredServiceId
        existingAccount.PreferredEquipmentId <- preferredEquipmentId
        existingAccount.ExchangeRate <- new Nullable<decimal>(exchangeRate)
        existingAccount.UTCConversionTimeZoneCode <- new Nullable<int>(utcConversionTimeZoneCode)
        existingAccount.TimeZoneRuleVersionNumber <- new Nullable<int>(timeZoneRuleVersionNumber)
        existingAccount.ImportSequenceNumber <- new Nullable<int>(importSequenceNumber)
        existingAccount.TransactionCurrencyId <- transactionCurrencyId
        existingAccount.CreditLimit_Base <- creditLimit_Base
        existingAccount.Aging30_Base <- aging30_Base
        existingAccount.Revenue_Base <- revenue_Base
        existingAccount.Aging90_Base <- aging90_Base
        existingAccount.MarketCap_Base <- marketCap_Base
        existingAccount.Aging60_Base <- aging60_Base
        existingAccount.YomiName <- yomiName
        existingAccount.OwnerId <- ownerId
        existingAccount.ModifiedOnBehalfBy <- modifiedOnBehalfBy
        existingAccount.CreatedOnBehalfBy <- createdOnBehalfBy
        existingAccount.OwnerIdType <- ownerIdType
        existingAccount.StageId <- new Nullable<Guid>(stageId)
        existingAccount.ProcessId <- new Nullable<Guid>(processId)
        existingAccount.EntityImageId <- new Nullable<Guid>(entityImageId)
        existingAccount.new_dic <- new_dic
        existingAccount.new_ico <- new_ico    
        fullContext.SaveChanges() 
                            |> ignore
    id