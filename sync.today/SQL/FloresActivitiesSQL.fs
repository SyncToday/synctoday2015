module FloresActivitiesSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection
open ConsumersSQL
open ConsumerAdaptersSQL

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

let private convert( r : SqlConnection.ServiceTypes.FloresActivities ) : FloresActivityDTO =
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; CorrectedDATE = r.CorrectedDATE; ActivityType_ID = r.ActivityType_ID; Description = r.Description;
    Subject = r.Subject; SheduledStartDate = r.SheduledStartDate; SheduledEndDate = r.SheduledEndDate; RealStartDate = r.RealStartDate; RealEndDate = r.RealEndDate;
    ResponsibleUser_ID = r.ResponsibleUser_ID; 
    Period_ID = r.Period_ID; Status_ID = r.Status_ID; Division_ID = r.Division_ID; Firm_ID = r.Firm_ID; Person_ID = r.Person_ID; OutlookCategory_ID = r.OutlookCategory_ID;
    Tag = ( if r.Tag.HasValue then r.Tag.Value else 0 ); FirmOffice_Address = r.FirmOffice_Address; Firm_Address = r.Firm_Address }

let private FloresActivityByInternalId( internalId : Guid ) = 
    query {
        for r in db().FloresActivities do
        where ( r.InternalId = internalId )
        select r
    } |> Seq.tryHead

let private FloresActivityByExternalId( externalId : string ) = 
    query {
        for r in db().FloresActivities do
        where ( r.ExternalId = externalId )
        select r
    } |> Seq.tryHead

let saveDLUPIssues( externalId : string, lastDLError : string, lastUPError : string  ) = 
    logger.Debug( ( sprintf "externalId:'%A', LastDLError:'%A', LastUPError:'%A'" externalId, lastDLError, lastUPError  ) )
    let db = db()
    let possibleApp = 
        query {
            for r in db.FloresActivities do
            where ( r.ExternalId = externalId )
            select r
        } |> Seq.tryHead
    if ( possibleApp.IsNone ) then
        let newApp = new SqlConnection.ServiceTypes.ExchangeAppointments()
        newApp.ExternalId <- externalId
        newApp.LastDLError <- lastDLError
        newApp.LastUPError <- lastUPError
        db.ExchangeAppointments.InsertOnSubmit newApp
    else
        if ( not ( String.IsNullOrWhiteSpace(lastDLError) ) ) then possibleApp.Value.LastDLError <- lastDLError
        if ( not ( String.IsNullOrWhiteSpace(lastUPError) ) ) then possibleApp.Value.LastUPError <- lastUPError
    db.DataContext.SubmitChanges()


let private copyToFloresActivity(destination : SqlConnection.ServiceTypes.FloresActivities, source : FloresActivityDTO ) =
    if destination.Id = 0  then
        destination.Id <- source.Id
    destination.ActivityType_ID <- source.ActivityType_ID
    destination.CorrectedDATE <- source.CorrectedDATE
    destination.Description <- if String.IsNullOrWhiteSpace(source.Description) then "" else source.Description
    destination.ExternalId <- source.ExternalId
    destination.InternalId <- source.InternalId
    destination.RealEndDate <- source.RealEndDate
    destination.RealStartDate <- source.RealStartDate
    destination.ResponsibleUser_ID <- source.ResponsibleUser_ID
    destination.SheduledEndDate <- source.SheduledEndDate
    destination.SheduledStartDate <- source.SheduledStartDate
    destination.Subject <- source.Subject
    destination.Tag <- Nullable<int>(source.Tag)
    destination.Period_ID <- source.Period_ID
    destination.Status_ID <- source.Status_ID
    destination.Division_ID <- source.Division_ID
    destination.Firm_ID <- source.Firm_ID
    destination.Person_ID <- source.Person_ID
    destination.OutlookCategory_ID <- source.OutlookCategory_ID



let saveFloresActivity( app : FloresActivityDTO, upload : bool ) = 
    logger.Debug( sprintf "app.InternalId: '%A' upload: '%A'" app.InternalId upload )
    let db = db()
    let possibleApp = 
        if upload then 
            query {
                for r in db.FloresActivities do
                where ( r.InternalId =  app.InternalId )
                select r
            } |> Seq.tryHead
        else 
            query {
                for r in db.FloresActivities do
                where ( r.ExternalId = app.ExternalId )
                select r
            } |> Seq.tryHead
    logger.Debug( sprintf "possibleApp: '%A'" possibleApp)
    if ( possibleApp.IsNone ) then
        let newApp = new SqlConnection.ServiceTypes.FloresActivities()
        copyToFloresActivity(newApp, app)
        newApp.Upload <- upload
        newApp.IsNew <- true
        db.FloresActivities.InsertOnSubmit newApp
    else
        let originalInternalId = possibleApp.Value.InternalId
        copyToFloresActivity(possibleApp.Value, app)
        possibleApp.Value.InternalId <- originalInternalId
        possibleApp.Value.Upload <- upload
        possibleApp.Value.WasJustUpdated <- true
    db.DataContext.SubmitChanges()

let private FloresActivitiesToUpload1() = 
    let db = db()
    query {
        for r in db.FloresActivities do
        where ( r.Upload )
        select r
    } |> Seq.toList 

let FloresActivitiesToUpload() : FloresActivityDTO list = 
    let activities = FloresActivitiesToUpload1()
    activities |> Seq.map ( fun r -> convert(r) ) |> Seq.toList

let changeFloresActivityExternalId(app : FloresActivityDTO, externalId : string) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE FloresActivities SET ExternalId = {0} WHERE InternalId = {1}", externalId, app.InternalId ) |> ignore

let setFloresActivityAsUploaded(app : FloresActivityDTO) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE FloresActivities SET Upload = 0 WHERE InternalId = {0}", app.InternalId ) |> ignore

let prepareForDownload() =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE FloresActivities SET IsNew=0, WasJustUpdated=0" ) |> ignore

let markAllForUpload() =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE FloresActivities SET Upload=1, Subject=Subject+'|', OutlookCategory_ID='KOM'" ) |> ignore

let getUpdatedFloresActivities() : FloresActivityDTO list =
    let db = db()
    query {
        for r in db.FloresActivities do
        where ( r.WasJustUpdated )
        select ( convert(r) ) 
    } |> Seq.toList

let getNewFloresActivities() =
    let db = db()
    query {
        for r in db.FloresActivities do
        where ( r.IsNew )
        select ( convert(r) ) 
    } |> Seq.toList

let getConsumerByResponsibleId( r : FloresActivityDTO, floresAdapter : AdapterDTO ) : ConsumerDTO option =
    let responsibleId = r.ResponsibleUser_ID
    let adapterId = floresAdapter.Id
    let consumerAdapter = getConsumerAdapterByAdapterIdAndData( adapterId, responsibleId.ToString() )
    if consumerAdapter.IsSome then 
        getConsumerByConsumerAdapterId( consumerAdapter.Value.Id )
    else
        None

let floresActivityByInternalIdRetDTO( internalId : Guid ) = 
    query {
        for r in db().FloresActivities do
        where ( r.InternalId = internalId )
        select ( convert(r) )
    } |> Seq.tryHead

let changeInternalIdBecauseOfDuplicitySimple( internalId : Guid, exchangeAppointmentId : int ) =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE FloresActivities SET InternalId = {0} WHERE Id = {1}", internalId, exchangeAppointmentId ) |> ignore

let changeInternalIdBecauseOfDuplicity( exchangeAppointment : FloresActivityDTO, foundDuplicity : AdapterAppointmentDTO ) =
    let cnn = cnn()
    changeInternalIdBecauseOfDuplicitySimple( foundDuplicity.InternalId, exchangeAppointment.Id )

