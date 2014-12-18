module Program

open System
open FSharpx.TypeProviders.XrmProvider

let server = ""
let username = ""
let password = ""

let xrm = XrmDataProvider<server, Username=username, Password=password>.GetDataContext(server, username, password, "")

let entityId( entity : Microsoft.Xrm.Sdk.EntityReference ) =
    (if entity = null then new Nullable<Guid>() else new Nullable<Guid>(entity.Id))

let money( par : Microsoft.Xrm.Sdk.Money ) =
    (if par = null then new Nullable<Decimal>() else Nullable<Decimal>(par.Value) )     

[<EntryPoint>]
let main argv = 
    let accounts = xrm.accountSet |> Seq.toList
    let activeAccounts = query {
                            for account in accounts do
                            where ( ( int account.statecode )  = 0 )
                            select account
                        }                        
    for account in activeAccounts do
        let account_name = account.name
        let account_accountid = account.accountid
        let account_modifiedon = account.modifiedon

        let account_accountcategorycode = 
            try
               (Nullable<int>(int account.accountcategorycode))
            with
              | :? System.NullReferenceException -> (Nullable<int>())
        
        let account_territoryid = (entityId(account.territoryid))
        let account_defaultpricelevelid = (entityId(account.defaultpricelevelid))
        let account_customersizecode = new Nullable<int>(int account.customersizecode)
        let account_preferredcontactmethodcode = new Nullable<int>(int account.preferredcontactmethodcode)
        
        let account_customertypecode = 
            try
              (Nullable<int>(int account.customertypecode))
            with
              | :? System.NullReferenceException ->(Nullable<int>())
        
        let account_accountratingcode = new Nullable<int>(int account.accountratingcode)
        
        let account_industrycode =
            try
              (Nullable<int>(int account.industrycode))
            with
              | :? System.NullReferenceException -> (Nullable<int>())

        let account_territorycode =  new Nullable<int>(int account.territorycode)
        let account_accountclassificationcode = new Nullable<int>(int account.accountclassificationcode)
        let account_businesstypecode = new Nullable<int>(int account.businesstypecode)
        let account_owningbusinessunit = (entityId(account.owningbusinessunit))
        let account_originatingleadid = (entityId(account.originatingleadid))

        let account_paymenttermscode =
            try
              (Nullable<int>(int account.paymenttermscode))
            with
              | :? System.NullReferenceException -> (Nullable<int>())
        
        let account_shippingmethodcode = new Nullable<int>(int account.shippingmethodcode)
        let account_primarycontactid = (entityId( account.primarycontactid))
        let account_name = account.name
        let account_accountnumber =  account.accountnumber
        let account_revenue = (money(account.revenue))
        let account_numberofemployees = Nullable<int>(account.numberofemployees)
        let account_description = account.description
        let account_sic =  account.sic

        let account_ownershipcode = 
            try
              (Nullable<int>(int account.ownershipcode))
            with
              | :? System.NullReferenceException -> (Nullable<int>())
        
        let account_marketcap = (money(account.marketcap))
        let account_sharesoutstanding = (Nullable<int>( account.sharesoutstanding ))
        let account_tickersymbol = account.tickersymbol
        let account_stockexchange =  account.stockexchange
        let account_websiteurl = account.websiteurl
        let account_ftpsiteurl =  account.ftpsiteurl
        let account_emailaddress1 =  account.emailaddress1
        let account_emailaddress2 = account.emailaddress2
        let account_emailaddress3 = account.emailaddress3
        let account_donotphone = account.donotphone
        let account_donotfax = account.donotfax
        let account_telephone1 = account.telephone1
        let account_donotemail = account.donotemail
        let account_telephone2 = account.telephone2
        let account_fax = account.fax
        let account_telephone3 = account.telephone3
        let account_donotpostalmail = account.donotpostalmail
        let account_donotbulkemail = account.donotbulkemail
        let account_donotbulkpostalmail = account.donotbulkpostalmail
        let account_creditlimit = (money(account.creditlimit))
        let account_creditonhold = account.creditonhold
        let account_isprivate = account.isprivate
        let account_createdon = account.createdon
        let account_createdby = (entityId(account.createdby))
        let account_modifiedby = (entityId(account.modifiedby))
        let account_versionnumber = account.versionnumber
        let account_parentaccountid = (entityId(account.parentaccountid))
        let account_aging30 = (money(account.aging30))
        let account_statecode = (int account.statecode)
        let account_aging60 = (money(account.aging60))
        let account_statuscode = new Nullable<int>(int account.statuscode)
        let account_aging90 = (money(account.aging90))
        
        let  account_preferredappointmentdaycode =
            try
              (Nullable<int>(int account.preferredappointmentdaycode))
            with
              | :? System.NullReferenceException -> (Nullable<int>())
        
        let account_preferredsystemuserid = (entityId(account.preferredsystemuserid))

        let account_preferredappointmenttimecode = 
            try
              (Nullable<int>(int account.preferredappointmenttimecode))
            with
              | :? System.NullReferenceException -> (Nullable<int>())
        
        let account_merged =  account.merged
        let account_donotsendmm = account.donotsendmm
        let account_masterid = (entityId(account.masterid))
        let account_lastusedincampaign = account.lastusedincampaign
        let account_preferredserviceid = (entityId(account.preferredserviceid))
        let account_preferredequipmentid = (entityId(account.preferredequipmentid))
        let account_exchangerate = account.exchangerate
        let account_utcconversiontimezonecode = new Nullable<int>(int account.utcconversiontimezonecode)
        let account_timezoneruleversionnumber = Nullable<int>(account.timezoneruleversionnumber)
        let account_importsequencenumber = Nullable<int>(account.importsequencenumber)
        let account_transactioncurrencyid = (entityId(account.transactioncurrencyid))
        let account_creditlimit_base = (money(account.creditlimit_base))
        let account_aging30_base = (money(account.aging30_base))
        let account_revenue_base = (money(account.revenue_base))
        let account_aging90_base = (money(account.aging90_base))
        let account_marketcap_base = (money(account.marketcap_base))
        let account_aging60_base = (money(account.aging60_base))
        let account_yominame = account.yominame

        let account_ownerid = 
            try
              (account.ownerid)
            with
              | :? System.InvalidCastException -> ""
        
        let account_modifiedonbehalfby = (entityId(account.modifiedonbehalfby))
        let account_createdonbehalfby = (entityId(account.createdonbehalfby))
        let account_owneridtype = (account.owneridtype)
        let account_stageid = account.stageid
        let account_processid = account.processid
        let account_entityimageid = account.entityimageid
        let account_new_dic = account.new_dic
        let account_new_ico = account.new_ico

        Repository.saveAccount( account_accountid, account_modifiedon, 
            account_accountcategorycode, (account_territoryid), 
            (account_defaultpricelevelid),
            account_customersizecode, account_preferredcontactmethodcode, account_customertypecode,
            account_accountratingcode, account_industrycode, account_territorycode, account_accountclassificationcode, account_businesstypecode, 
            (account_owningbusinessunit),
            (account_originatingleadid),             
            account_paymenttermscode, account_shippingmethodcode, ( account_primarycontactid), account_name, account_accountnumber, (account_revenue),
            account_numberofemployees, account_description, account_sic, account_ownershipcode, (account_marketcap), account_sharesoutstanding, account_tickersymbol, 
            account_stockexchange, account_websiteurl, account_ftpsiteurl, account_emailaddress1, account_emailaddress2, account_emailaddress3, account_donotphone, account_donotfax,
            account_telephone1, account_donotemail, account_telephone2, account_fax, account_telephone3, account_donotpostalmail, account_donotbulkemail, account_donotbulkpostalmail,
            (account_creditlimit), account_creditonhold, account_isprivate, account_createdon, (account_createdby), (account_modifiedby), account_versionnumber, 
            (account_parentaccountid),
            (account_aging30), account_statecode, (account_aging60), account_statuscode, (account_aging90), account_preferredappointmentdaycode, 
            (account_preferredsystemuserid),
            account_preferredappointmenttimecode, account_merged, account_donotsendmm, (account_masterid), account_lastusedincampaign, (account_preferredserviceid),
            (account_preferredequipmentid), account_exchangerate, account_utcconversiontimezonecode, account_timezoneruleversionnumber, account_importsequencenumber,
            (account_transactioncurrencyid), (account_creditlimit_base), (account_aging30_base), (account_revenue_base), (account_aging90_base), 
            (account_marketcap_base),
            (account_aging60_base), account_yominame, (account_ownerid), (account_modifiedonbehalfby), (account_createdonbehalfby), 
            (account_owneridtype), 
            account_stageid,
            account_processid, account_entityimageid, account_new_dic, account_new_ico )
            |> ignore

    Console.ReadLine() |> ignore
    0 // return an integer exit code
