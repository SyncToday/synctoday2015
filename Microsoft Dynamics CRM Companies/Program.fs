module Program

open System
open FSharpx.TypeProviders.XrmProvider

let xrm = XrmDataProvider<"", Username="", Password="">.GetDataContext("", "", "", "")

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
        printfn "%A" account.name
        Repository.saveAccount( account.accountid, account.modifiedon, 
            int account.accountcategorycode, entityId(account.territoryid), 
            entityId(account.defaultpricelevelid),
            int account.customersizecode, int account.preferredcontactmethodcode, int account.customertypecode,
            int account.accountratingcode, int account.industrycode, int account.territorycode, int account.accountclassificationcode, int account.businesstypecode, 
            entityId(account.owningbusinessunit),
            entityId(account.originatingleadid),             
            int account.paymenttermscode, int account.shippingmethodcode, entityId( account.primarycontactid), account.name, account.accountnumber, money(account.revenue),
            account.numberofemployees, account.description, account.sic, int account.ownershipcode, money(account.marketcap), account.sharesoutstanding, account.tickersymbol, 
            account.stockexchange, account.websiteurl, account.ftpsiteurl, account.emailaddress1, account.emailaddress2, account.emailaddress3, account.donotphone, account.donotfax,
            account.telephone1, account.donotemail, account.telephone2, account.fax, account.telephone3, account.donotpostalmail, account.donotbulkemail, account.donotbulkpostalmail,
            money(account.creditlimit), account.creditonhold, account.isprivate, account.createdon, entityId(account.createdby), entityId(account.modifiedby), account.versionnumber, 
            entityId(account.parentaccountid),
            money(account.aging30), int account.statecode, money(account.aging60), int account.statuscode, money(account.aging90), int account.preferredappointmentdaycode, 
            entityId(account.preferredsystemuserid),
            int account.preferredappointmenttimecode, account.merged, account.donotsendmm, entityId(account.masterid), account.lastusedincampaign, entityId(account.preferredserviceid),
            entityId(account.preferredequipmentid), account.exchangerate, int account.utcconversiontimezonecode, account.timezoneruleversionnumber, account.importsequencenumber,
            entityId(account.transactioncurrencyid), money(account.creditlimit_base), money(account.aging30_base), money(account.revenue_base), money(account.aging90_base), 
            money(account.marketcap_base),
            money(account.aging60_base), account.yominame, Guid.Parse(account.ownerid), entityId(account.modifiedonbehalfby), entityId(account.createdonbehalfby), 
            Int32.Parse(account.owneridtype), 
            account.stageid,
            account.processid, account.entityimageid, account.new_dic, account.new_ico )
            |> ignore

    Console.ReadLine() |> ignore
    0 // return an integer exit code
