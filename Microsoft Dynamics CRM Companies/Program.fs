module Program

open System
open FSharpx.TypeProviders.XrmProvider

let server = "http://localhost/Ceriasro/XRMServices/2011/Organization.svc" // "http://nucrm/nudev2/XRMServices/2011/Organization.svc"
let username = "" 
let password = "" 
let xrm = XrmDataProvider<"http://nucrm/nudev2/XRMServices/2011/Organization.svc", Username="", Password="">.GetDataContext(server, username, password, "")

// this should got to Common.fs
module Seq =
    let tryHead xs = xs |> Seq.tryPick Some

let entityId( entity : Microsoft.Xrm.Sdk.EntityReference ) =
    (if entity = null then new Nullable<Guid>() else new Nullable<Guid>(entity.Id))

let money( par : Microsoft.Xrm.Sdk.Money ) =
    (if par = null then new Nullable<Decimal>() else Nullable<Decimal>(par.Value) )     

let activeXrmAccountById( externalId ) =
    //let accounts = xrm.accountSet |> Seq.toList
    //let activeAccounts = 
    query {
                            for account in xrm.accountSet do
                            where ( 
                             ( account.accountid = externalId )
                            ) 
                            select account
                            } 
        |> Seq.tryHead 
//    query {
//        for account in activeAccounts do
//        where ( account.accountid = externalId )
//        select account
//    } |> Seq.tryHead                

let maintenanceRun(really) =
    for internalAccount in Repository.getAccounts() do
        printfn "%A:" internalAccount.Name
        let xrmAccountId = internalAccount.PartialAccountId
        let possibleAccount = activeXrmAccountById( xrmAccountId ) 
        if ( box possibleAccount = null  ) then
            printfn "deleting"
            Repository.saveAccountStateAsDeleted( xrmAccountId)
        else
            let account = possibleAccount.Value
            let account_name = account.name
            printfn "saving %A" account_name
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
            let account_new_ico = account.new_ic
            let account_new_cislo_uctu = account.new_cislo_uctu
            let account_new_vs = account.new_vs
            let account_new_banka = account.new_banka

            let account_address1_city = account.address1_city
            let account_address1_country = account.address1_country
            let account_address1_line1 = account.address1_line1
            let account_address1_postalcode = account.address1_postalcode

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
                account_processid, account_entityimageid, account_new_dic, account_new_ico, account_new_cislo_uctu, account_new_vs, account_new_banka,
                account_address1_city, account_address1_country, account_address1_line1, account_address1_postalcode )
                |> ignore

let standardRun(really) =
            
    let accounts = xrm.accountSet |> Seq.toList
    let activeAccounts = query {
                            for account in accounts do
                            where ( ( int account.statecode )  = 0 )
                            select account
                        }          
                                      
    for account in activeAccounts do
        printfn "%A:" account.name
        let xrmAccountId = account.accountid
        let possibleAccount = activeXrmAccountById( xrmAccountId ) 
        if ( box possibleAccount = null  ) then
            printfn "deleting"
            Repository.saveAccountStateAsDeleted( xrmAccountId)
        else
            let account = possibleAccount.Value
            let account_name = account.name
            printfn "saving %A" account_name
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
            let account_new_ico = account.new_ic
            let account_new_cislo_uctu = account.new_cislo_uctu
            let account_new_vs = account.new_vs
            let account_new_banka = account.new_banka

            let account_address1_city = account.address1_city
            let account_address1_country = account.address1_country
            let account_address1_line1 = account.address1_line1
            let account_address1_postalcode = account.address1_postalcode

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
                account_processid, account_entityimageid, account_new_dic, account_new_ico, account_new_cislo_uctu, account_new_vs, account_new_banka,
                account_address1_city, account_address1_country, account_address1_line1, account_address1_postalcode )
                |> ignore
     
          

[<EntryPoint>]
let main argv = 
    printf "%A" xrm
    Microsoft.Xrm.Client.Configuration.CrmConfigurationManager.Reset()
    (*  
    printfn "data downloaded from Microsoft CRM"
    // create accounts
    //try
    for account1 in Repository.getAccountsToCreate() do
        printf "%A" account1.Name
        let createCrmAccount = xrm.accountSet.Create() 
        createCrmAccount.name <- account1.Name
        createCrmAccount.address1_city <- account1.City
        createCrmAccount.address1_country <- account1.Country
        //createCrmAccount.address1_composite <- ""
        createCrmAccount.address1_line1 <- account1.Street
        createCrmAccount.address1_postalcode <- account1.Postcode
        createCrmAccount.address1_telephone1 <- account1.PrimaryPhonenumber
        createCrmAccount.emailaddress1 <- account1.Email
        let createdId = xrm.OrganizationService.Create(createCrmAccount)
        Repository.saveAccountFromOrig(createdId, account1.AccountId)
        printf "%A" createdId

//    with
//        | ex -> 0|> ignore
    *)
        (*  
    //try
    for account1 in Repository.getAccountsToUpdate() do
        let gAccountId = Guid.Parse(account1.ExternalId)

        Microsoft.Xrm.Client.Caching.ObjectCacheManager.Clear(Microsoft.Xrm.Client.Caching.ObjectCacheManager.GetInstance(null))

        let accountToUpdate1 =
                query {
                    for account in xrm.accountSet do
                    where ( account.accountid = gAccountId )
                    select account
                } |> Seq.tryHead

        printfn "%A" accountToUpdate1.Value.telephone1
        let columnSet = new Microsoft.Xrm.Sdk.Query.ColumnSet( "name", "address1_city", "address1_country", "address1_line1", "address1_postalcode", "telephone1", "emailaddress1", "description" )
        let accountToUpdate = xrm.OrganizationService.Retrieve("account", gAccountId, columnSet ) 
        accountToUpdate.Attributes.Item("name") <- account1.Name
        accountToUpdate.Attributes.Item("address1_city") <- account1.City
        accountToUpdate.Attributes.Item("address1_country") <- account1.Country
        //createCrmAccount.address1_composite <- ""
        accountToUpdate.Attributes.Item("address1_line1") <- account1.Street
        accountToUpdate.Attributes.Item("address1_postalcode") <- account1.Postcode
        //printf "%A" ( account1.Name + ":" + accountToUpdate1.Value.name + "(" + accountToUpdate1.Value.address1_telephone1 + ":" + accountToUpdate.Attributes.Item("address1_telephone1").ToString() + ")" )
        accountToUpdate.Attributes.Item("telephone1") <- account1.PrimaryPhonenumber
        accountToUpdate.Attributes.Item("emailaddress1") <- account1.Email
        accountToUpdate.Attributes.Item("description") <- ( if account1.Note = null then null else account1.Note.Substring(0, Math.Min(2000,account1.Note.Length)) )
        xrm.OrganizationService.Update(accountToUpdate)
        printf "%A" ( account1.Name + ":" + accountToUpdate1.Value.name + "(" + accountToUpdate1.Value.telephone1 + ")" )
       *)

    //with
    //    | ex -> 0|> ignore

(* 
    let accounts = xrm.accountSet |> Seq.toList
    let activeAccounts = query {
                            for account in accounts do
                            where ( ( int account.statecode )  = 0 )
                            select account
                        }         
    for account in activeAccounts do
        let dbAccount = Repository.getAccountById( account.Id )
        if (( account.telephone1 = null || account.telephone1.Length = 0 ) && (dbAccount.Value.Telephone1 <> null && dbAccount.Value.Telephone1.Length > 0 )) then
            printf "%A:" account.name
            printfn "%A" dbAccount.Value.Name
            printf "(%A," account.telephone1
            printf "%A)" dbAccount.Value.Telephone1
            account.telephone1 <- dbAccount.Value.Telephone1
            xrm.OrganizationService.Update(account)
*)                                               
    (*
    let accounts = xrm.accountSet |> Seq.toList
    let activeAccounts = query {
                            for account in accounts do
                            where ( ( int account.statecode )  = 0 )
                            select account
                        }         
    for account in activeAccounts do
        let dbAccount = Repository.getAccountById( account.Id )
        if (( account.address1_telephone2 = null || account.address1_telephone2.Length = 0 ) && (dbAccount.Value.Telephone2 <> null && dbAccount.Value.Telephone2.Length > 0 )) then
            printf "%A:" account.name
            printfn "%A" dbAccount.Value.Name
            printf "(%A," account.address1_telephone2
            printf "%A)" dbAccount.Value.Telephone2
            account.address1_telephone2 <- dbAccount.Value.Telephone2
            xrm.OrganizationService.Update(account)
        if (( account.address1_telephone3 = null || account.address1_telephone3.Length = 0 ) && (dbAccount.Value.Telephone3 <> null && dbAccount.Value.Telephone3.Length > 0 )) then
            printf "%A:" account.name
            printfn "%A" dbAccount.Value.Name
            printf "(%A," account.address1_telephone3
            printf "%A)" dbAccount.Value.Telephone3
            account.address1_telephone3 <- dbAccount.Value.Telephone3
            xrm.OrganizationService.Update(account)
    for account in activeAccounts do
        let dbAccount = Repository.getAccountById( account.Id )
        account.new_zdroj <- dbAccount.Value.new_Zdroj
        xrm.OrganizationService.Update(account)
    *)

    (*
    *)
    let contacts = xrm.contactSet |> Seq.toList
    let activeContacts = 
        query {
            for contact in contacts do
            where ( ( int contact.statecode = 0 )) 
            select contact
        } |> Seq.toList
    for contact in activeContacts do
        printf "%A " contact.contactid
        printf "%A " contact.firstname
        printf "%A " contact.lastname 
        printf "%A " ( entityId( contact.["parentcustomerid"] :?> Microsoft.Xrm.Sdk.EntityReference ) )
        printf "%A " contact.jobtitle 
        printf "%A " contact.emailaddress1 
        printf "%A " contact.emailaddress2
        printf "%A " contact.emailaddress3
        printf "%A " contact.mobilephone
        printf "%A " contact.telephone1
        printf "%A " contact.telephone2
        printf "%A " contact.telephone3
        printf "%A " contact.telephone3
        printf "%A " contact.statecode
        printf "%A " contact.statuscode
        printfn ""
        Repository.saveContact(contact.contactid, contact.emailaddress1, contact.emailaddress2, contact.emailaddress3, contact.firstname, contact.jobtitle, contact.lastname, 
                                 contact.mobilephone, Nullable<DateTime>(contact.modifiedon), ( entityId( contact.["parentcustomerid"] :?> Microsoft.Xrm.Sdk.EntityReference ) ), contact.telephone1, 
                                 contact.telephone2, contact.telephone3, Nullable<int>(int contact.statecode), Nullable<int>(int contact.statuscode) ) |> ignore


    //Console.ReadLine() |> ignore
    0 // return an integer exit code

