module ExchangeEmailMessagesSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
let standardAttrsVisiblyDifferentLogger = log4net.LogManager.GetLogger( "StandardAttrsVisiblyDifferent" )

let internal convert( r :SqlConnection.ServiceTypes.ExchangeEmailMessages ) : ExchangeEmailMessageDTO =
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; LastModifiedTime = r.LastModifiedTime; 
    
    Subject = r.Subject; Body = r.Body; 
    
    BccRecipientsJSON = r.BccRecipientsJSON; 
    CcRecipientsJSON = r.CcRecipientsJSON;
    From = r.From; InternetMessageId = r.InternetMessageId; 
    ReceivedByJSON = r.ReceivedByJSON; ReceivedRepresentingJSON = r.ReceivedRepresentingJSON;
    References = r.References; ReplyToJSON = r.ReplyToJSON; SenderJSON = r.SenderJSON; ToRecipientsJSON = r.ToRecipientsJSON;

    CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; 
    Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ) }

let exchangeEmailMessageInternalIds() = 
    query {
        for r in db().ExchangeEmailMessages do
        select r.InternalId
    } |> Seq.toList

let exchangeEmailMessageIds() = 
    query {
        for r in db().ExchangeEmailMessages do
        select r.Id
    } |> Seq.toList

let private ExchangeEmailMessagesByExternalId( externalId : string ) = 
    query {
        for r in db().ExchangeEmailMessages do
        where ( r.ExternalId = externalId )
        select r
    } |> Seq.tryHead

let private ExchangeEmailMessagesByInternalId( internalId : Guid ) = 
    query {
        for r in db().ExchangeEmailMessages do
        where ( r.InternalId = internalId )
        select r
    } |> Seq.tryHead

let exchangeEmailMessageByInternalId( internalId : Guid ) = 
    query {
        for r in db().ExchangeEmailMessages do
        where ( r.InternalId = internalId )
        select ( convert(r) )
    } |> Seq.tryHead

let private copyToExchangeEmailMessage(destination : SqlConnection.ServiceTypes.ExchangeEmailMessages, source : ExchangeEmailMessageDTO ) =
    if destination.Id = 0  then
        destination.Id <- source.Id
    destination.InternalId  <- source.InternalId
    destination.CategoriesJSON <- source.CategoriesJSON
    destination.ExternalId <- source.ExternalId
    destination.LastModifiedTime <- source.LastModifiedTime
    destination.Tag <- Nullable<int>(source.Tag)
    destination.ServiceAccountId <- source.ServiceAccountId

    destination.Subject <- source.Subject
    destination.Body <- source.Body
    destination.BccRecipientsJSON <- source.BccRecipientsJSON
    destination.CcRecipientsJSON <- source.CcRecipientsJSON
    destination.From <- source.From
    destination.InternetMessageId <- source.InternetMessageId
    destination.ReceivedByJSON <- source.ReceivedByJSON
    destination.ReceivedRepresentingJSON <- source.ReceivedRepresentingJSON
    destination.References <- source.References
    destination.ReplyToJSON <- source.ReplyToJSON
    destination.SenderJSON <- source.SenderJSON
    destination.ToRecipientsJSON <- source.ToRecipientsJSON

let saveDLUPIssues( internalId : Guid, externalId : string, lastDLError : string, lastUPError : string  ) = 
    logger.Debug( ( sprintf "saveDLUPIssues: internalId '%A' externalId:'%A', LastDLError:'%A', LastUPError:'%A'" internalId externalId, lastDLError, lastUPError  ) )
    let db = db()
    let possibleApp = 
        query {
            for r in db.ExchangeEmailMessages do
            where ( r.ExternalId = externalId || r.InternalId = internalId)
            select r
        } |> Seq.tryHead
    if ( possibleApp.IsNone ) then
        let newApp = new SqlConnection.ServiceTypes.ExchangeEmailMessages()
        newApp.ExternalId <- externalId
        newApp.LastDLError <- lastDLError
        newApp.LastUPError <- lastUPError
        db.ExchangeEmailMessages.InsertOnSubmit newApp
    else
        if ( not ( String.IsNullOrWhiteSpace(lastDLError) ) ) then possibleApp.Value.LastDLError <- lastDLError
        if ( not ( String.IsNullOrWhiteSpace(lastUPError) ) ) then possibleApp.Value.LastUPError <- lastUPError
    db.DataContext.SubmitChanges()

let categories( r : ExchangeEmailMessageDTO ) : string array =
    if String.IsNullOrWhiteSpace(r.CategoriesJSON) then [| |] else unjson<string array>( r.CategoriesJSON )
    
let normalize( r : ExchangeEmailMessageDTO ) : ExchangeEmailMessageDTO =
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; LastModifiedTime = r.LastModifiedTime; 
    
    Subject = r.Subject; Body = r.Body; 
    
    BccRecipientsJSON = r.BccRecipientsJSON; 
    CcRecipientsJSON = r.CcRecipientsJSON;
    From = r.From; InternetMessageId = r.InternetMessageId; 
    ReceivedByJSON = r.ReceivedByJSON; ReceivedRepresentingJSON = r.ReceivedRepresentingJSON;
    References = r.References; ReplyToJSON = r.ReplyToJSON; SenderJSON = r.SenderJSON; ToRecipientsJSON = r.ToRecipientsJSON;

    CategoriesJSON = r.CategoriesJSON; ServiceAccountId = r.ServiceAccountId; 
    Tag = r.Tag }

let areStandardAttrsVisiblyDifferent( a1 : ExchangeEmailMessageDTO, a2 : ExchangeEmailMessageDTO ) : bool =
    let a1n = normalize( a1 )
    let a2n = normalize( a2 )
    let result = not (( a1n.CategoriesJSON = a2n.CategoriesJSON ) && ( a1n.Subject = a2n.Subject ) && ( a1n.Body = a2n.Body ) && ( a1n.From = a2n.From )
                    )
    if result then
        logger.Debug( sprintf "StandardAttrsAREVisiblyDifferent for '%A' '%A'" a1n.Id a2n.Id )
        standardAttrsVisiblyDifferentLogger.Debug( sprintf "StandardAttrsAREVisiblyDifferent for '%A' '%A'" a1n a2n )
    result

let saveExchangeEmailMessage( app : ExchangeEmailMessageDTO, upload : bool, downloadRound : int ) = 
    let db = db()
    let possibleApp = 
        if upload then 
            query {
                for r in db.ExchangeEmailMessages do
                where ( r.InternalId = app.InternalId )
                select r
            } |> Seq.tryHead
        else 
            query {
                for r in db.ExchangeEmailMessages do
                where ( r.ExternalId = app.ExternalId )
                select r
            } |> Seq.tryHead

    //logger.Debug( sprintf "upload:'%A', app.InternalId:'%A', app.ExternalId:'%A', possibleApp:'%A' serviceAccountId: '%A' app.LastModifiedTime:'%A'" upload app.InternalId app.ExternalId possibleApp app.ServiceAccountId app.LastModifiedTime )
    logger.Debug( sprintf "saveExchangeEmailMessage app.InternalId:'%A', app.ExternalId:'%A'" app.InternalId app.ExternalId )
    if ( possibleApp.IsNone ) then
        let newApp = new SqlConnection.ServiceTypes.ExchangeEmailMessages()
        copyToExchangeEmailMessage(newApp, app)
        newApp.Upload <- upload
        newApp.IsNew <- true
        newApp.DownloadRound <- downloadRound
        db.ExchangeEmailMessages.InsertOnSubmit newApp
    else
        if ( possibleApp.Value.DownloadRound <> downloadRound) then // ignore duplicities received from EWS
            if areStandardAttrsVisiblyDifferent(app, convert(possibleApp.Value)) then
                let originalInternalId = possibleApp.Value.InternalId
                copyToExchangeEmailMessage(possibleApp.Value, app)
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
        
let ExchangeEmailMessagesToUpload( serviceAccountId : int ) = 
    let db = db()
    query {
        for r in db.ExchangeEmailMessages do
        where ( r.ServiceAccountId = serviceAccountId && r.Upload )
        select (convert(r))
    } |> Seq.toList

let changeExchangeEmailMessageExternalId(app : ExchangeEmailMessageDTO, externalId : string) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeEmailMessages SET ExternalId = {0} WHERE InternalId = {1}", externalId, app.InternalId ) |> ignore

let setExchangeEmailMessageAsUploaded(app : ExchangeEmailMessageDTO) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeEmailMessages SET Upload = 0 WHERE InternalId = {0}", app.InternalId ) |> ignore

let prepareForDownload( serviceAccountId : int ) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeEmailMessages SET IsNew=0, WasJustUpdated=0 WHERE ServiceAccountId = {0}", serviceAccountId ) |> ignore

let prepareForUpload() =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeEmailMessages SET Upload=1 WHERE Upload=0 and (ExternalID IS NULL OR LEN(ExternalID)=0)" ) |> ignore

let exchangeEmailMessages() =
    let db = db()
    query {
        for r in db.ExchangeEmailMessages do
        select (convert(r))
    } |> Seq.toList

let getUpdatedExchangeEmailMessages() =
    let db = db()
    query {
        for r in db.ExchangeEmailMessages do
        where ( r.WasJustUpdated )
        select (convert(r))
    } |> Seq.toList

let getNewExchangeEmailMessages() =
    let db = db()
    query {
        for r in db.ExchangeEmailMessages do
        where ( r.IsNew )
        select (convert(r))
    } |> Seq.toList
    
let changeInternalIdBecauseOfDuplicitySimple( internalId : Guid, exchangeEmailMessageId : int ) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE ExchangeEmailMessages SET InternalId = {0} WHERE Id = {1}", internalId, exchangeEmailMessageId ) |> ignore

#if changeInternalIdBecauseOfDuplicity
let changeInternalIdBecauseOfDuplicity( exchangeEmailMessage : ExchangeEmailMessageDTO, foundDuplicity : AdapterEmailMessageDTO ) =
    let cnn = cnn()
    changeInternalIdBecauseOfDuplicitySimple( foundDuplicity.InternalId, exchangeEmailMessage.Id )
#endif

