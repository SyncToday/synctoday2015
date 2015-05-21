-- uncomment for testing
/* 
DECLARE @InternalIdVal uniqueidentifier = '6E449D0A-952C-4ACC-AE85-6C542B56BDBC'
DECLARE @ConsumerIdVal int = 1
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
DECLARE @AppointmentIdVal int = 1
DECLARE @TagVal int = 0
DECLARE @UploadVal bit = 0
*/

DECLARE @InternalId uniqueidentifier
select @InternalId = @InternalIdVal
DECLARE @ConsumerId int
select @ConsumerId = @ConsumerIdVal
DECLARE @LastModified datetime
select @LastModified  = @LastModifiedVal
DECLARE @Category nvarchar(4000)
select @Category  = @CategoryVal 
DECLARE @Location nvarchar(4000)
select @Location  = @LocationVal
DECLARE @Content nvarchar(4000)
select @Content  = @ContentVal
DECLARE @Title nvarchar(4000)
select @Title  = @TitleVal
DECLARE @DateFrom datetime
select @DateFrom  = @DateFromVal
DECLARE @DateTo datetime
select @DateTo  = @DateToVal
DECLARE @ReminderMinutesBeforeStart int
select @ReminderMinutesBeforeStart  = @ReminderMinutesBeforeStartVal
DECLARE @Notification bit
select @Notification  = @NotificationVal
DECLARE @IsPrivate bit
select @IsPrivate  = @IsPrivateVal
DECLARE @Priority tinyint
select @Priority  = @PriorityVal

BEGIN TRAN
UPDATE Appointments with (serializable) SET 
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
	WHERE InternalId = @InternalId
IF @@ROWCOUNT = 0
BEGIN
  INSERT Appointments(
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
	ConsumerId
  ) 
	SELECT @InternalId, @LastModified, @Category, @Location, @Content, @Title, @DateFrom, @DateTo,
	@ReminderMinutesBeforeStart, @Notification, @IsPrivate, @Priority, @ConsumerId
;

  DECLARE @id int = SCOPE_IDENTITY()

	select [Id]
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
		  ,[ConsumerId]
		  ,cast( [ReminderMinutesBeforeStart] as int ) ReminderMinutesBeforeStart
	from Appointments
  WHERE Id = @id
END
ELSE
BEGIN
	select [Id]
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
		  ,[ConsumerId]
		  ,cast( [ReminderMinutesBeforeStart] as int ) ReminderMinutesBeforeStart
	from Appointments
  WHERE InternalId = @InternalId
END
COMMIT
