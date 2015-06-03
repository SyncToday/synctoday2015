-- uncomment for testing
/* 
DECLARE @InternalIdVal uniqueidentifier = '5E449D0A-952C-4ACC-AE85-6C542B56BDBC'
DECLARE @AdapterIdVal int = 1
DECLARE @LastModifiedVal datetime = '2015-01-01'
DECLARE @CategoryVal nvarchar(4000) =  'category'
DECLARE @LocationVal nvarchar(4000) = 'location'
DECLARE @ContentVal nvarchar(4000) = 'content'
DECLARE @TitleVal nvarchar(4000) = 'title'
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


DECLARE @InternalId uniqueidentifier
select @InternalId = cast ( @InternalIdVal as uniqueidentifier )
DECLARE @AdapterId int
select @AdapterId  = cast( @AdapterIdVal as int )
DECLARE @LastModified datetime
select @LastModified = cast( @LastModifiedVal as datetime)
DECLARE @Category nvarchar(4000)
select @Category  = cast( @CategoryVal  as nvarchar(4000) )
DECLARE @Location nvarchar(4000)
select @Location  = @LocationVal
DECLARE @Content nvarchar(4000)
select @Content = @ContentVal
DECLARE @Title nvarchar(4000)
select @Title = @TitleVal
DECLARE @DateFrom datetime
select @DateFrom  = @DateFromVal
DECLARE @DateTo datetime
select @DateTo  = @DateToVal
DECLARE @ReminderMinutesBeforeStart int
select @ReminderMinutesBeforeStart  = cast( @ReminderMinutesBeforeStartVal as int )
DECLARE @Notification bit
select @Notification  = cast( @NotificationVal as bit )
DECLARE @IsPrivate bit
select @IsPrivate  = cast( @IsPrivateVal as bit )
DECLARE @Priority int
select @Priority  = cast( @PriorityVal as int )
DECLARE @AppointmentId int
select @AppointmentId  = cast( @AppointmentIdVal as int )
DECLARE @Tag int
select @Tag  = cast( @TagVal as int )
DECLARE @Upload bit
select @Upload  = cast( @UploadVal as bit )

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

  DECLARE @id int
  SELECT @id = SCOPE_IDENTITY()

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

