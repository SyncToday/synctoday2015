-- uncomment for testing
/* 
DECLARE @InternalIdVal uniqueidentifier = '5E449D0A-952C-4ACC-AE85-6C542B56BDBC'
DECLARE @AdapterIdVal int = 1
DECLARE @LastModifiedVal datetime = '2015-01-01'
DECLARE @CategoryVal nvarchar(max) =  'category'
DECLARE @LocationVal nvarchar(max) = 'location'
DECLARE @ContentVal nvarchar(max) = 'content'
DECLARE @TitleVal nvarchar(max) = 'title'
DECLARE @DateFromVal datetime = '2015-02-02'
DECLARE @DateToVal datetime = '2015-03-03'
DECLARE @ReminderMinutesBeforeStartVal int = 15
DECLARE @NotificationVal bit = 0
DECLARE @IsPrivateVal bit = 0
DECLARE @PriorityVal tinyint = 0
DECLARE @AppointmentIdVal int = 6
DECLARE @TagVal int = 0
DECLARE @UploadVal bit = 0
*/


DECLARE @InternalId uniqueidentifier = cast ( @InternalIdVal as uniqueidentifier )
DECLARE @AdapterId int = cast( @AdapterIdVal as int )
DECLARE @LastModified datetime = cast( @LastModifiedVal as datetime)
DECLARE @Category nvarchar(max) = cast( @CategoryVal  as nvarchar(max) )
DECLARE @Location nvarchar(max) = @LocationVal
DECLARE @Content nvarchar(max) = @ContentVal
DECLARE @Title nvarchar(max) = @TitleVal
DECLARE @DateFrom datetime = @DateFromVal
DECLARE @DateTo datetime = @DateToVal
DECLARE @ReminderMinutesBeforeStart int = cast( @ReminderMinutesBeforeStartVal as int )
DECLARE @Notification bit = cast( @NotificationVal as bit )
DECLARE @IsPrivate bit = cast( @IsPrivateVal as bit )
DECLARE @Priority int = cast( @PriorityVal as int )
DECLARE @AppointmentId int = cast( @AppointmentIdVal as int )
DECLARE @Tag int = cast( @TagVal as int )
DECLARE @Upload bit = cast( @UploadVal as bit )

BEGIN TRAN
UPDATE AdapterAppointments with (serializable) SET 
	LastModified = @LastModified
	,Category = @Category 
	,Location = @Location 
	,Content = @Content 
	,Title = @Title 
	,DateFrom = @DateFrom
	,DateTo = @DateTo
	,ReminderMinutesBeforeStart = @ReminderMinutesBeforeStart
	,[Notification] = @Notification
	,IsPrivate = @IsPrivate
	,[Priority] = @Priority
	,Tag = @Tag
	,Upload = @Upload
	WHERE InternalId = @InternalId and AdapterId = @AdapterId
IF @@ROWCOUNT = 0
BEGIN
  INSERT AdapterAppointments(
	[InternalId],
	[LastModified],
	[Category],
	[Location],
	[Content],
	[Title],
	[DateFrom],
	[DateTo],
	[ReminderMinutesBeforeStart],
	[Notification],
	[IsPrivate],
	[Priority],
	[AppointmentId],
	[AdapterId],
	[Tag],
	[Upload]
  ) 
	SELECT @InternalId, @LastModified, @Category, @Location, @Content, @Title, @DateFrom, @DateTo,
	@ReminderMinutesBeforeStart, @Notification, @IsPrivate, @Priority, @AppointmentId, @AdapterId,
	@Tag, @Upload
;

  DECLARE @id int = SCOPE_IDENTITY()

SELECT [Id]
      ,[InternalId]
      ,[LastModified]
      ,[Category]
      ,[Location]
      ,[Content]
      ,[Title]
      ,[DateFrom]
      ,[DateTo]
      ,[Notification]
      ,cast( [IsPrivate] as bit ) IsPrivate
      ,[Priority]
      ,[AppointmentId]
      ,[AdapterId]
      ,[Tag]
      ,[Upload]
      ,cast( [ReminderMinutesBeforeStart] as int )  ReminderMinutesBeforeStart
  FROM AdapterAppointments 
  WHERE Id = @id
END
ELSE
BEGIN
SELECT [Id]
      ,[InternalId]
      ,[LastModified]
      ,[Category]
      ,[Location]
      ,[Content]
      ,[Title]
      ,[DateFrom]
      ,[DateTo]
      ,[Notification]
      ,cast( [IsPrivate] as bit ) IsPrivate
      ,[Priority]
      ,[AppointmentId]
      ,[AdapterId]
      ,[Tag]
      ,[Upload]
      ,cast( [ReminderMinutesBeforeStart] as int )  ReminderMinutesBeforeStart
  FROM AdapterAppointments 
  WHERE InternalId = @InternalId and AdapterId = @AdapterId
END
COMMIT

