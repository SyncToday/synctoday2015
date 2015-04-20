module ExchangeContactsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection
open FSharp.Data
open FSharp.Data

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
let standardAttrsVisiblyDifferentLogger = log4net.LogManager.GetLogger( "StandardAttrsVisiblyDifferent" )

let internal convert( r :SqlConnection.ServiceTypes.ExchangeContacts ) : ExchangeContactDTO =
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; JobTitle = r.JobTitle; CompanyName = r.CompanyName; EmailAddress1 = r.EmailAddress1; 
    LastModifiedTime = r.LastModifiedTime; EmailAddress2 = r.EmailAddress2;
    EmailAddress3 = r.EmailAddress3; GivenName = r.GivenName; MiddleName = r.MiddleName; Surname = r.Surname;
#if ALIAS
    Alias = r.Alias; 
#endif
    NickName = r.NickName; HomePhone = r.HomePhone; MobilePhone = r.MobilePhone;
    BusinessPhone = r.BusinessPhone; OtherTelephone = r.OtherTelephone; HomeAddressCity = r.HomeAddressCity; 
    HomeAddressCountryOrRegion = r.HomeAddressCountryOrRegion; 
    HomeAddressPostalCode = r.HomeAddressPostalCode; HomeAddressState = r.HomeAddressState; HomeAddressStreet = r.HomeAddressStreet; OtherAddressCity = r.OtherAddressCity; 
    OtherAddressPostalCode = r.OtherAddressPostalCode; OtherAddressCountryOrRegion = r.OtherAddressCountryOrRegion; OtherAddressState = r.OtherAddressState;
    OtherAddressStreet = r.OtherAddressStreet; BusinessAddressCity = r.BusinessAddressCity; BusinessAddressCountryOrRegion = r.BusinessAddressCountryOrRegion;
    BusinessAddressState = r.BusinessAddressState; BusinessAddressStreet = r.BusinessAddressStreet; BusinessAddressPostalCode = r.BusinessAddressPostalCode;
    CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; 
    Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }


let exchangeContactInternalIds() = 
    query {
        for r in db().ExchangeContacts do
        select r.InternalId
    } |> Seq.toList

let exchangeContactIds() = 
    query {
        for r in db().ExchangeContacts do
        select r.Id
    } |> Seq.toList

let private ExchangeContactsByExternalId( externalId : string ) = 
    query {
        for r in db().ExchangeContacts do
        where ( r.ExternalId = externalId )
        select r
    } |> Seq.tryHead

let private ExchangeContactsByInternalId( internalId : Guid ) = 
    query {
        for r in db().ExchangeContacts do
        where ( r.InternalId = internalId )
        select r
    } |> Seq.tryHead

let exchangeContactByInternalId( internalId : Guid ) = 
    query {
        for r in db().ExchangeContacts do
        where ( r.InternalId = internalId )
        select ( convert(r) )
    } |> Seq.tryHead

let private copyToExchangeContact(destination : SqlConnection.ServiceTypes.ExchangeContacts, source : ExchangeContactDTO ) =
    destination.JobTitle <- source.JobTitle
    destination.CompanyName <- source.CompanyName
    destination.EmailAddress1 <- source.EmailAddress1
    destination.EmailAddress2 <- source.EmailAddress2
    destination.CategoriesJSON <- source.CategoriesJSON
    destination.EmailAddress3 <- source.EmailAddress3
    destination.GivenName <- source.GivenName
    destination.MiddleName <- source.MiddleName
    destination.Surname <- source.Surname
    destination.ExternalId <- source.ExternalId
#if ALIAS
    destination.Alias <- source.Alias
#endif
    destination.NickName <- source.NickName
    if destination.Id = 0  then
        destination.Id <- source.Id
    destination.InternalId  <- source.InternalId
    destination.HomePhone <- source.HomePhone
    destination.MobilePhone <- source.MobilePhone
    destination.BusinessPhone <- source.BusinessPhone
    destination.LastModifiedTime <- source.LastModifiedTime
    destination.OtherTelephone <- source.OtherTelephone
    destination.HomeAddressCity <- source.HomeAddressCity
    destination.HomeAddressCountryOrRegion <- source.HomeAddressCountryOrRegion
    destination.HomeAddressPostalCode <- source.HomeAddressPostalCode
    destination.HomeAddressState <- source.HomeAddressState
    destination.HomeAddressStreet <- source.HomeAddressStreet
    destination.ServiceAccountId <- source.ServiceAccountId
    destination.OtherAddressCity <- source.OtherAddressCity
    destination.OtherAddressPostalCode <- source.OtherAddressPostalCode
    destination.OtherAddressCountryOrRegion <- source.OtherAddressCountryOrRegion
    destination.OtherAddressState <- source.OtherAddressState
    destination.OtherAddressStreet <- source.OtherAddressStreet
    destination.BusinessAddressCity <- source.BusinessAddressCity
    destination.BusinessAddressCountryOrRegion <- source.BusinessAddressCountryOrRegion
    destination.BusinessAddressState <- source.BusinessAddressState
    destination.BusinessAddressStreet <- source.BusinessAddressStreet
    destination.BusinessAddressPostalCode <- source.BusinessAddressPostalCode
    destination.Tag <- Nullable<int>(source.Tag)

let saveDLUPIssues( internalId : Guid, externalId : string, lastDLError : string, lastUPError : string, serviceAccountId : int, downloadRound : int  ) = 
    logger.Debug( ( sprintf "saveDLUPIssues: internalId '%A' externalId:'%A', LastDLError:'%A', LastUPError:'%A'" internalId externalId, lastDLError, lastUPError  ) )
    let db = db()
    let possibleApp = 
        query {
            for r in db.ExchangeContacts do
            where ( r.ExternalId = externalId || r.InternalId = internalId)
            select r
        } |> Seq.tryHead
    if ( possibleApp.IsNone ) then
        let newApp = new SqlConnection.ServiceTypes.ExchangeContacts()
        newApp.ExternalId <- externalId
        newApp.LastDLError <- lastDLError
        newApp.LastUPError <- lastUPError
        newApp.LastModifiedTime <- DateTime.Now.AddMonths(-12)
        newApp.ServiceAccountId <- serviceAccountId
        newApp.Upload <- false
        newApp.IsNew <- false
        newApp.WasJustUpdated <- false
        newApp.DownloadRound <- downloadRound
        db.ExchangeContacts.InsertOnSubmit newApp
    else
        if ( not ( String.IsNullOrWhiteSpace(lastDLError) ) ) then possibleApp.Value.LastDLError <- lastDLError
        if ( not ( String.IsNullOrWhiteSpace(lastUPError) ) ) then possibleApp.Value.LastUPError <- lastUPError
    db.DataContext.SubmitChanges()

let categories( r : ExchangeContactDTO ) : string array =
    if String.IsNullOrWhiteSpace(r.CategoriesJSON) then [| |] else unjson<string array>( r.CategoriesJSON )
    
let normalize( r : ExchangeContactDTO ) : ExchangeContactDTO =
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; JobTitle = r.JobTitle; CompanyName = r.CompanyName; EmailAddress1 = r.EmailAddress1; 
    LastModifiedTime = r.LastModifiedTime; EmailAddress2 = r.EmailAddress2;
    EmailAddress3 = r.EmailAddress3; GivenName = r.GivenName; MiddleName = r.MiddleName; Surname = r.Surname;
#if ALIAS
    Alias = r.Alias; 
#endif
    NickName = r.NickName; HomePhone = r.HomePhone; MobilePhone = r.MobilePhone;
    BusinessPhone = r.BusinessPhone; OtherTelephone = r.OtherTelephone; HomeAddressCity = r.HomeAddressCity; 
    HomeAddressCountryOrRegion = r.HomeAddressCountryOrRegion; 
    HomeAddressPostalCode = r.HomeAddressPostalCode; HomeAddressState = r.HomeAddressState; HomeAddressStreet = r.HomeAddressStreet; OtherAddressCity = r.OtherAddressCity; 
    OtherAddressPostalCode = r.OtherAddressPostalCode; OtherAddressCountryOrRegion = r.OtherAddressCountryOrRegion; OtherAddressState = r.OtherAddressState;
    OtherAddressStreet = r.OtherAddressStreet; BusinessAddressCity = r.BusinessAddressCity; BusinessAddressCountryOrRegion = r.BusinessAddressCountryOrRegion;
    BusinessAddressState = r.BusinessAddressState; BusinessAddressStreet = r.BusinessAddressStreet; BusinessAddressPostalCode = r.BusinessAddressPostalCode;
    CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; 
    Tag = r.Tag }

let areStandardAttrsVisiblyDifferent( a1 : ExchangeContactDTO, a2 : ExchangeContactDTO ) : bool =
    let a1n = normalize( a1 )
    let a2n = normalize( a2 )
    let result = not (( a1n.CategoriesJSON = a2n.CategoriesJSON ) && ( a1n.JobTitle = a2n.JobTitle ) && ( a1n.CompanyName = a2n.CompanyName ) && ( a1n.EmailAddress1 = a2n.EmailAddress1 )
                    && ( a1n.GivenName = a2n.GivenName ) && ( a1n.MiddleName = a2n.MiddleName ) && ( a1n.Surname = a2n.Surname ) && ( a1n.HomePhone = a2n.HomePhone )
                    && ( a1n.MobilePhone = a2n.MobilePhone ) && ( a1n.BusinessPhone = a2n.BusinessPhone ) 
                    )
    if result then
        logger.Debug( sprintf "StandardAttrsAREVisiblyDifferent for '%A' '%A'" a1n.Id a2n.Id )
        standardAttrsVisiblyDifferentLogger.Debug( sprintf "StandardAttrsAREVisiblyDifferent for '%A' '%A'" a1n a2n )
    result

let saveExchangeContact( app : ExchangeContactDTO, upload : bool, downloadRound : int ) = 
    let db = db()
    let possibleApp = 
        if upload then 
            query {
                for r in db.ExchangeContacts do
                where ( r.InternalId = app.InternalId )
                select r
            } |> Seq.tryHead
        else 
            query {
                for r in db.ExchangeContacts do
                where ( r.ExternalId = app.ExternalId )
                select r
            } |> Seq.tryHead

    //logger.Debug( sprintf "upload:'%A', app.InternalId:'%A', app.ExternalId:'%A', possibleApp:'%A' serviceAccountId: '%A' app.LastModifiedTime:'%A'" upload app.InternalId app.ExternalId possibleApp app.ServiceAccountId app.LastModifiedTime )
    logger.Debug( sprintf "saveExchangeContact app.InternalId:'%A', app.ExternalId:'%A'" app.InternalId app.ExternalId )
    if ( possibleApp.IsNone ) then
        let newApp = new SqlConnection.ServiceTypes.ExchangeContacts()
        copyToExchangeContact(newApp, app)
        newApp.Upload <- upload
        newApp.IsNew <- true
        newApp.DownloadRound <- downloadRound
        db.ExchangeContacts.InsertOnSubmit newApp
    else
        if ( possibleApp.Value.DownloadRound <> downloadRound) then // ignore duplicities received from EWS
            if areStandardAttrsVisiblyDifferent(app, convert(possibleApp.Value)) then
                let originalInternalId = possibleApp.Value.InternalId
                copyToExchangeContact(possibleApp.Value, app)
                possibleApp.Value.InternalId <- originalInternalId
                possibleApp.Value.Upload <- upload
                possibleApp.Value.WasJustUpdated <- true
                possibleApp.Value.DownloadRound <- downloadRound
                logger.Debug ( sprintf "saved:'%A'" possibleApp.Value.Id )
            else
                logger.Debug ( sprintf "ignoring:'%A', have same values as '%A'" app.InternalId possibleApp.Value.InternalId )
        else
            logger.Debug ( sprintf "ignoring:'%A', have same downloadRound '%A'" app.InternalId downloadRound )

    db.DataContext.SubmitChanges()
        
let ExchangeContactsToUpload( serviceAccountId : int ) = 
    let db = db()
    query {
        for r in db.ExchangeContacts do
        where ( r.ServiceAccountId = serviceAccountId && r.Upload )
        select (convert(r))
    } |> Seq.toList

let changeExchangeContactExternalId(app : ExchangeContactDTO, externalId : string) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeContacts SET ExternalId = {0} WHERE InternalId = {1}", externalId, app.InternalId ) |> ignore

let setExchangeContactAsUploaded(app : ExchangeContactDTO) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeContacts SET Upload = 0 WHERE InternalId = {0}", app.InternalId ) |> ignore

let prepareForDownload( serviceAccountId : int ) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeContacts SET IsNew=0, WasJustUpdated=0 WHERE ServiceAccountId = {0}", serviceAccountId ) |> ignore

let prepareForUpload() =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeContacts SET Upload=1 WHERE Upload=0 and (ExternalID IS NULL OR LEN(ExternalID)=0)" ) |> ignore

let exchangeContacts() =
    let db = db()
    query {
        for r in db.ExchangeContacts do
        select (convert(r))
    } |> Seq.toList

let getUpdatedExchangeContacts() =
    let db = db()
    query {
        for r in db.ExchangeContacts do
        where ( r.WasJustUpdated )
        select (convert(r))
    } |> Seq.toList

type NewExchangeContactsQuery = SqlCommandProvider<"GetNewContacts.sql", ConnectionStringName>
let internal convertNewExchangeContact( r : NewExchangeContactsQuery.Record ) : ExchangeContactDTO = 
    { Id = r.Id; InternalId = r.InternalId; ExternalId = optionString2String( r.ExternalId ); 
    JobTitle = optionString2String(r.JobTitle); CompanyName = optionString2String(r.CompanyName); 
    EmailAddress1 = optionString2String(r.EmailAddress1); 
    LastModifiedTime = r.LastModifiedTime; EmailAddress2 = optionString2String(r.EmailAddress2);
    EmailAddress3 = optionString2String(r.EmailAddress3); GivenName = optionString2String(r.GivenName); 
    MiddleName = optionString2String(r.MiddleName); Surname = optionString2String(r.Surname);
#if ALIAS
    Alias = r.Alias; 
#endif
    NickName = optionString2String(r.NickName); HomePhone = optionString2String(r.HomePhone); 
    MobilePhone = optionString2String(r.MobilePhone);
    BusinessPhone = optionString2String(r.BusinessPhone); OtherTelephone = optionString2String(r.OtherTelephone); 
    HomeAddressCity = optionString2String(r.HomeAddressCity); 
    HomeAddressCountryOrRegion = optionString2String(r.HomeAddressCountryOrRegion); 
    HomeAddressPostalCode = optionString2String(r.HomeAddressPostalCode); 
    HomeAddressState = optionString2String(r.HomeAddressState); HomeAddressStreet = optionString2String(r.HomeAddressStreet); 
    OtherAddressCity = optionString2String(r.OtherAddressCity); 
    OtherAddressPostalCode = optionString2String(r.OtherAddressPostalCode); 
    OtherAddressCountryOrRegion = optionString2String(r.OtherAddressCountryOrRegion); 
    OtherAddressState = optionString2String(r.OtherAddressState);
    OtherAddressStreet = optionString2String(r.OtherAddressStreet); BusinessAddressCity = optionString2String(r.BusinessAddressCity); 
    BusinessAddressCountryOrRegion = optionString2String(r.BusinessAddressCountryOrRegion);
    BusinessAddressState = optionString2String(r.BusinessAddressState); BusinessAddressStreet = optionString2String(r.BusinessAddressStreet); 
    BusinessAddressPostalCode = optionString2String(r.BusinessAddressPostalCode);
    CategoriesJSON = optionString2String(r.CategoriesJSON); ServiceAccountId = r.ServiceAccountId; 
    Tag = ( if r.Tag.IsSome then r.Tag.Value else 0 ) }

let getNewExchangeContacts() =
    ( new NewExchangeContactsQuery() ).AsyncExecute() |> Async.RunSynchronously |> Seq.map ( fun t -> convertNewExchangeContact(t) )
    
let changeInternalIdBecauseOfDuplicitySimple( internalId : Guid, exchangeContactId : int ) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeContacts SET InternalId = {0} WHERE Id = {1}", internalId, exchangeContactId ) |> ignore

#if changeInternalIdBecauseOfDuplicity
let changeInternalIdBecauseOfDuplicity( exchangeContact : ExchangeContactDTO, foundDuplicity : AdapterContactDTO ) =
    let cnn = cnn()
    changeInternalIdBecauseOfDuplicitySimple( foundDuplicity.InternalId, exchangeContact.Id )
#endif

