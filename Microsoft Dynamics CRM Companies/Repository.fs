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

let public saveAccount( accountId, updated, 
                        accountCategoryCode, territoryId, defaultPriceLevelId, customerSizeCode, preferredContactMethodCode, customerTypeCode, accountRatingCode, industryCode,
                        territoryCode, accountClassificationCode, businessTypeCode, owningBusinessUnit, originatingLeadId, paymentTermsCode, shippingMethodCode, primaryContactId,
                        name, accountNumber, revenue, numberOfEmployees, description, sic, ownershipCode, marketCap, sharesOutstanding, tickerSymbol, stockExchange, webSiteURL,
                        ftpSiteURL, eMailAddress1, eMailAddress2, eMailAddress3, doNotPhone, doNotFax, telephone1, doNotEMail, telephone2, fax, telephone3, doNotPostalMail,
                        doNotBulkEMail, doNotBulkPostalMail, creditLimit, creditOnHold, isPrivate, createdOn,createdBy,modifiedBy,versionNumber,parentAccountId,aging30,
                        stateCode,aging60,statusCode,aging90,preferredAppointmentDayCode,preferredSystemUserId,preferredAppointmentTimeCode,merged,doNotSendMM,masterId,
                        lastUsedInCampaign,preferredServiceId,preferredEquipmentId,exchangeRate,utcConversionTimeZoneCode,timeZoneRuleVersionNumber,importSequenceNumber,
                        transactionCurrencyId,creditLimit_Base,aging30_Base,revenue_Base,aging90_Base,marketCap_Base,aging60_Base,yomiName,ownerId,modifiedOnBehalfBy,
                        createdOnBehalfBy,ownerIdType,stageId,processId,entityImageId,new_dic,new_ico
                        ) =
    let possibleAccount = getAccountById( accountId )
    // https://sergeytihon.wordpress.com/2013/04/10/f-null-trick/
    if ( box possibleAccount = null ) then
        let newAccount = new EntityConnection.ServiceTypes.MSCRM_Companies_Account( 
                            AccountId = accountId, ModifiedOn = updated, 
                            AccountCategoryCode = accountCategoryCode,
                            TerritoryId = territoryId,
                            DefaultPriceLevelId = defaultPriceLevelId,
                            CustomerSizeCode = customerSizeCode,
                            PreferredContactMethodCode = preferredContactMethodCode,
                            CustomerTypeCode = customerTypeCode,
                            AccountRatingCode = accountRatingCode,
                            IndustryCode = industryCode,
                            TerritoryCode = territoryCode,
                            AccountClassificationCode = accountClassificationCode,
                            BusinessTypeCode = businessTypeCode,
                            OwningBusinessUnit = owningBusinessUnit,
                            OriginatingLeadId = originatingLeadId,
                            PaymentTermsCode = paymentTermsCode,
                            ShippingMethodCode = shippingMethodCode,
                            PrimaryContactId = primaryContactId,
                            Name = name,
                            AccountNumber = accountNumber,
                            Revenue = revenue,
                            NumberOfEmployees =numberOfEmployees,
                            Description = description,
                            SIC = sic,
                            OwnershipCode = ownershipCode,
                            MarketCap = marketCap,
                            SharesOutstanding = sharesOutstanding,
                            TickerSymbol = tickerSymbol,
                            StockExchange = stockExchange,
                            WebSiteURL = webSiteURL,
                            FtpSiteURL = ftpSiteURL,
                            EMailAddress1 = eMailAddress1,
                            EMailAddress2 = eMailAddress2,
                            EMailAddress3 = eMailAddress3,
                            DoNotPhone = doNotPhone,
                            DoNotFax = doNotFax,
                            Telephone1 = telephone1,
                            DoNotEMail = doNotEMail,
                            Telephone2 = telephone2,
                            Fax = fax,
                            Telephone3 = telephone3,
                            DoNotPostalMail = doNotPostalMail,
                            DoNotBulkEMail = doNotBulkEMail,
                            DoNotBulkPostalMail = doNotBulkPostalMail,
                            CreditLimit = creditLimit,
                            CreditOnHold = creditOnHold,
                            IsPrivate = isPrivate,
                            CreatedOn =createdOn,
                            CreatedBy =  createdBy,
                            ModifiedBy = modifiedBy,
                            VersionNumber = versionNumber,
                            ParentAccountId = parentAccountId,
                            Aging30 = aging30,
                            StateCode = stateCode,
                            Aging60 = aging60,
                            StatusCode = statusCode,
                            Aging90 =  aging90,
                            PreferredAppointmentDayCode = preferredAppointmentDayCode,
                            PreferredSystemUserId =  preferredSystemUserId,
                            PreferredAppointmentTimeCode = preferredAppointmentTimeCode,
                            Merged = merged,
                            DoNotSendMM = doNotSendMM,
                            MasterId = masterId,
                            LastUsedInCampaign = lastUsedInCampaign,
                            PreferredServiceId = preferredServiceId,
                            PreferredEquipmentId = preferredEquipmentId,
                            ExchangeRate = exchangeRate,
                            UTCConversionTimeZoneCode = utcConversionTimeZoneCode,
                            TimeZoneRuleVersionNumber = timeZoneRuleVersionNumber,
                            ImportSequenceNumber = importSequenceNumber,
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
                            StageId = stageId,
                            ProcessId = processId,
                            EntityImageId = entityImageId,
                            new_dic = new_dic,
                            new_ico = new_ico
                          )
        fullContext.AddObject("MSCRM_Companies_Account", newAccount)
    else
        let existingAccount = possibleAccount.Value 
        existingAccount.ModifiedOn <- updated
        existingAccount.AccountCategoryCode <- accountCategoryCode
        existingAccount.TerritoryId <- territoryId
        existingAccount.DefaultPriceLevelId <- defaultPriceLevelId
        existingAccount.CustomerSizeCode <- customerSizeCode
        existingAccount.PreferredContactMethodCode <- preferredContactMethodCode
        existingAccount.CustomerTypeCode <- customerTypeCode
        existingAccount.AccountRatingCode <- accountRatingCode
        existingAccount.IndustryCode <- industryCode
        existingAccount.TerritoryCode <- territoryCode
        existingAccount.AccountClassificationCode <- accountClassificationCode
        existingAccount.BusinessTypeCode <- businessTypeCode
        existingAccount.OwningBusinessUnit <- owningBusinessUnit
        existingAccount.OriginatingLeadId <- originatingLeadId
        existingAccount.PaymentTermsCode <- paymentTermsCode
        existingAccount.ShippingMethodCode <- shippingMethodCode
        existingAccount.PrimaryContactId <- primaryContactId
        existingAccount.Name <- name
        existingAccount.AccountNumber <- accountNumber
        existingAccount.Revenue <- revenue
        existingAccount.NumberOfEmployees <-numberOfEmployees
        existingAccount.Description <- description
        existingAccount.SIC <- sic
        existingAccount.OwnershipCode <- ownershipCode
        existingAccount.MarketCap <- marketCap
        existingAccount.SharesOutstanding <- sharesOutstanding
        existingAccount.TickerSymbol <- tickerSymbol
        existingAccount.StockExchange <- stockExchange
        existingAccount.WebSiteURL <- webSiteURL
        existingAccount.FtpSiteURL <- ftpSiteURL
        existingAccount.EMailAddress1 <- eMailAddress1
        existingAccount.EMailAddress2 <- eMailAddress2
        existingAccount.EMailAddress3 <- eMailAddress3
        existingAccount.DoNotPhone <- doNotPhone
        existingAccount.DoNotFax <- doNotFax
        existingAccount.Telephone1 <- telephone1
        existingAccount.DoNotEMail <- doNotEMail
        existingAccount.Telephone2 <- telephone2
        existingAccount.Fax <- fax
        existingAccount.Telephone3 <- telephone3
        existingAccount.DoNotPostalMail <- doNotPostalMail
        existingAccount.DoNotBulkEMail <- doNotBulkEMail
        existingAccount.DoNotBulkPostalMail <- doNotBulkPostalMail
        existingAccount.CreditLimit <- creditLimit
        existingAccount.CreditOnHold <- creditOnHold
        existingAccount.IsPrivate <- isPrivate
        existingAccount.CreatedOn <-createdOn
        existingAccount.CreatedBy <-  createdBy
        existingAccount.ModifiedBy <- modifiedBy
        existingAccount.VersionNumber <- versionNumber
        existingAccount.ParentAccountId <- parentAccountId
        existingAccount.Aging30 <- aging30
        existingAccount.StateCode <- stateCode
        existingAccount.Aging60 <- aging60
        existingAccount.StatusCode <- statusCode
        existingAccount.Aging90 <-  aging90
        existingAccount.PreferredAppointmentDayCode <- preferredAppointmentDayCode
        existingAccount.PreferredSystemUserId <-  preferredSystemUserId
        existingAccount.PreferredAppointmentTimeCode <- preferredAppointmentTimeCode
        existingAccount.Merged <- merged
        existingAccount.DoNotSendMM <- doNotSendMM
        existingAccount.MasterId <- masterId
        existingAccount.LastUsedInCampaign <- lastUsedInCampaign
        existingAccount.PreferredServiceId <- preferredServiceId
        existingAccount.PreferredEquipmentId <- preferredEquipmentId
        existingAccount.ExchangeRate <- exchangeRate
        existingAccount.UTCConversionTimeZoneCode <- utcConversionTimeZoneCode
        existingAccount.TimeZoneRuleVersionNumber <- timeZoneRuleVersionNumber
        existingAccount.ImportSequenceNumber <- importSequenceNumber
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
        existingAccount.StageId <- stageId
        existingAccount.ProcessId <- processId
        existingAccount.EntityImageId <- entityImageId
        existingAccount.new_dic <- new_dic
        existingAccount.new_ico <- new_ico
    fullContext.SaveChanges() |> ignore
    id