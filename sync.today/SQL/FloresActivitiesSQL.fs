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
open FSharp.Data

let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
let standardAttrsVisiblyDifferentLogger = log4net.LogManager.GetLogger( "StandardAttrsVisiblyDifferent" )

type GetActivitiesBulk = JsonProvider<"""{"crmactivity":[{"RealEndDate":"2015-03-05T14:18:00","Person_ID":"XX00000000","ActQueue_ID":"Y000000101","FirmOffice_ID":"YI10000101","Status_ID":"DB00000001","CorrectedDATE":"2015-03-05T14:48:09","Period_ID":"Y400000101","Description":"LLL","Division_ID":"Y000000000","SheduledStartDate":"2015-03-05T14:17:00","Firm_Address":"A7","Category":"Komunikace","FirmOffice_Address":"CcechtickC 386C4 142 00 Praha 4","ID":"YL00000101","Subject":"Test adres 123","ActivityArea_ID":"3000000101","Firm_ID":"Y300000101","RealStartDate":"2015-03-05T14:17:00","ActivityType_ID":"Y200000101","SheduledEndDate":"2015-03-05T14:18:00","ResponsibleUser_ID":"Y200000101"},{"RealEndDate":"2015-03-05T14:48:00","Person_ID":"Y000000000","ActQueue_ID":"Y000000101","FirmOffice_ID":"Y000000000","Status_ID":"DB00000001","CorrectedDATE":"2015-03-05T14:48:43","Period_ID":"Y400000101","Description":"JJJ","Division_ID":"Y000000000","SheduledStartDate":"2015-03-05T14:48:00","Firm_Address":"AAA","Category":"Komunikace","FirmOffice_Address":"GGG","ID":"YM00000101","Subject":"Jec jeden testCdk","ActivityArea_ID":"3000000101","Firm_ID":"Y000000000","RealStartDate":"2015-03-05T14:48:00","ActivityType_ID":"Y200000101","SheduledEndDate":"2015-03-05T14:48:00","ResponsibleUser_ID":"Y200000101"},{"RealEndDate":"2015-03-06T11:06:00","Person_ID":"Y000000000","ActQueue_ID":"Y000000101","FirmOffice_ID":"Y000000000","Status_ID":"DB00000001","CorrectedDATE":"2015-03-06T11:06:39","Period_ID":"Y400000101","Description":"HHH","Division_ID":"Y000000000","SheduledStartDate":"2015-03-06T11:06:00","Firm_Address":"FFF","Category":"","FirmOffice_Address":"GGG","ID":"YN00000101","Subject":"Nebude zat7u00edm v outlooku","ActivityArea_ID":"Y100000101","Firm_ID":"Y000000000","RealStartDate":"2015-03-06T11:06:00","ActivityType_ID":"Y300000101","SheduledEndDate":"2015-03-06T11:06:00","ResponsibleUser_ID":"Y200000101"},{"RealEndDate":"2015-03-02T09:39:00","Person_ID":"Y000000000","ActQueue_ID":"Y000000101","FirmOffice_ID":"YI10000101","Status_ID":"DB00000001","CorrectedDATE":"2015-03-05T14:48:17","Period_ID":"Y400000101","Description":"LLL","Division_ID":"Y000000000","SheduledStartDate":"2015-03-02T09:39:00","Firm_Address":"AAA","Category":"Komunikace","FirmOffice_Address":"dcechtickf00e1 386f 142 00 Praha 4","ID":"2J00000101","Subject":"Test komunikace (zase)","ActivityArea_ID":"3000000101","Firm_ID":"Y300000101","RealStartDate":"2015-03-02T09:39:00","ActivityType_ID":"Y200000101","SheduledEndDate":"2015-03-02T09:39:00","ResponsibleUser_ID":"Y200000101"}]}""">
type CreateActivity2 = JsonProvider<"""{"newactivity":[{"ActivityID":"XXX123"}]}""">
type UpdateActivity2 = JsonProvider<"""{"updateactivity":[{"ActivityID":"'JJJ123KK'"}]}""">
type FloresLogin = JsonProvider<"""{ "server" : "jidasjidjasi.dasjdasij.com"  }""">
type ActivityTypes = JsonProvider<"""{"crmactivitytype":[{"ID":"1L50000101","NAME":" kategorie","CODE":"flores"}]}""">

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
    destination.Division_ID <- source.Division_ID
    destination.ExternalId <- source.ExternalId
    destination.FirmOffice_Address <- source.FirmOffice_Address
    destination.Firm_Address <- source.Firm_Address
    destination.Firm_ID <- source.Firm_ID
    destination.InternalId <- source.InternalId
    destination.OutlookCategory_ID <- source.OutlookCategory_ID
    destination.Period_ID <- source.Period_ID
    destination.Person_ID <- source.Person_ID
    destination.RealEndDate <- source.RealEndDate
    destination.RealStartDate <- source.RealStartDate
    destination.ResponsibleUser_ID <- source.ResponsibleUser_ID
    destination.SheduledEndDate <- source.SheduledEndDate
    destination.SheduledStartDate <- source.SheduledStartDate
    destination.Status_ID <- source.Status_ID
    destination.Subject <- source.Subject
    destination.Tag <- Nullable<int>(source.Tag)

let normalize( r : FloresActivityDTO ) : FloresActivityDTO =
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; CorrectedDATE = fixDateSecs(r.CorrectedDATE); ActivityType_ID = r.ActivityType_ID; 
    Description = r.Description;
    Subject = r.Subject; SheduledStartDate = fixDateSecs(r.SheduledStartDate); SheduledEndDate = fixDateSecs(r.SheduledEndDate); RealStartDate = fixDateSecs(r.RealStartDate); 
    RealEndDate = fixDateSecs(r.RealEndDate);
    ResponsibleUser_ID = r.ResponsibleUser_ID; 
    Period_ID = r.Period_ID; Status_ID = r.Status_ID; Division_ID = r.Division_ID; Firm_ID = r.Firm_ID; Person_ID = r.Person_ID; OutlookCategory_ID = r.OutlookCategory_ID;
    Tag = r.Tag; FirmOffice_Address = r.FirmOffice_Address; Firm_Address = r.Firm_Address }

let areStandardAttrsVisiblyDifferent( a1 : FloresActivityDTO, a2 : FloresActivityDTO ) : bool =
    let a1n = normalize( a1 )
    let a2n = normalize( a2 )
    let result = not ((a1n.OutlookCategory_ID = a2n.OutlookCategory_ID ) && ( a1n.FirmOffice_Address = a2n.FirmOffice_Address ) && ( a1n.Description = a2n.Description ) && ( a1n.Subject = a2n.Subject )
    && ( a1n.RealStartDate = a2n.RealStartDate ) && ( a1n.RealEndDate = a2n.RealEndDate ) && ( a1n.Firm_Address = a2n.Firm_Address ) && ( a1n.Person_ID = a2n.Person_ID )
    && ( a1n.ResponsibleUser_ID = a2n.ResponsibleUser_ID ))
    if result then
        logger.Debug( sprintf "StandardAttrsAREVisiblyDifferent for '%A' '%A'" a1n.Id a2n.Id )
        standardAttrsVisiblyDifferentLogger.Debug( sprintf "StandardAttrsAREVisiblyDifferent for '%A' '%A'" a1n a2n )
    result


let saveFloresActivity( app : FloresActivityDTO, upload : bool ) = 
    //logger.Debug( sprintf "app.InternalId: '%A' upload: '%A'" app.InternalId upload )
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
    //logger.Debug( sprintf "possibleApp: '%A'" possibleApp)
    if ( possibleApp.IsNone ) then
        let newApp = new SqlConnection.ServiceTypes.FloresActivities()
        copyToFloresActivity(newApp, app)
        newApp.Upload <- upload
        newApp.IsNew <- true
        db.FloresActivities.InsertOnSubmit newApp
    else
        if areStandardAttrsVisiblyDifferent(app, convert(possibleApp.Value)) then
            let originalInternalId = possibleApp.Value.InternalId
            copyToFloresActivity(possibleApp.Value, app)
            possibleApp.Value.InternalId <- originalInternalId
            possibleApp.Value.Upload <- upload
            possibleApp.Value.WasJustUpdated <- true
        else
            logger.Debug ( sprintf "ignoring:'%A', have same values as '%A'" app.Id possibleApp.Value.InternalId )
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

let prepareForUpload() =
    let cnn = cnn()
    cnn.ExecuteCommand("UPDATE FloresActivities SET Upload=1 WHERE Upload=0 and (ExternalID IS NULL OR LEN(ExternalID)=0)" ) |> ignore

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
    logger.Debug( ( sprintf "Changing ID to '%A' for '%A'" internalId, exchangeAppointmentId ) )
    cnn.ExecuteCommand("UPDATE FloresActivities SET InternalId = {0} WHERE Id = {1}", internalId, exchangeAppointmentId ) |> ignore
    logger.Debug( "Changed" )

let changeInternalIdBecauseOfDuplicity( exchangeAppointment : FloresActivityDTO, foundDuplicity : AdapterAppointmentDTO ) =
    let cnn = cnn()
    changeInternalIdBecauseOfDuplicitySimple( foundDuplicity.InternalId, exchangeAppointment.Id )

