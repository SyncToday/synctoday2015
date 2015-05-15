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
DECLARE @AppointmentIdVal int = 1
DECLARE @TagVal int = 0
DECLARE @UploadVal bit = 0
*/

DECLARE @InternalId uniqueidentifier = @InternalIdVal
DECLARE @AdapterId int = @AdapterIdVal
DECLARE @LastModified datetime = @LastModifiedVal
DECLARE @Category nvarchar(max) = @CategoryVal 
DECLARE @Location nvarchar(max) = @LocationVal
DECLARE @Content nvarchar(max) = @ContentVal
DECLARE @Title nvarchar(max) = @TitleVal
DECLARE @DateFrom datetime = @DateFromVal
DECLARE @DateTo datetime = @DateToVal
DECLARE @ReminderMinutesBeforeStart int = @ReminderMinutesBeforeStartVal
DECLARE @Notification bit = @NotificationVal
DECLARE @IsPrivate bit = @IsPrivateVal
DECLARE @Priority tinyint = @PriorityVal
DECLARE @AppointmentId int = @AppointmentIdVal
DECLARE @Tag int = @TagVal
DECLARE @Upload bit = @UploadVal

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

  SELECT * FROM AdapterAppointments WHERE Id = @id
END
COMMIT

