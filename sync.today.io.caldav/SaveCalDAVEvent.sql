-- uncomment for testing
/*  
DECLARE @idVal int = 0
DECLARE @InternalIdVal uniqueidentifier = '40995F91-6236-4E5F-B289-0967E18D1E67'
DECLARE @ExternalIdVal nvarchar(2048) = NULL
DECLARE @DescriptionVal nvarchar(max) = 'Our event description'
DECLARE @StartVal datetime = '2015-05-05 10:35:42.213'
DECLARE @EndVal datetime = '2015-05-05 10:36:42.213'
DECLARE @LastModifiedVal datetime = getdate()
DECLARE @LocationVal nvarchar(max) = 'Here'
DECLARE @SummaryVal nvarchar(max) = 'Title635664189422126569'
DECLARE @CategoriesJSONVal nvarchar(max) = NULL
DECLARE @ServiceAccountIdVal int = 1
DECLARE @UploadVal bit = 1
DECLARE @TagVal int = 0
DECLARE @LastDLErrorVal nvarchar(max) = NULL
DECLARE @LastUPErrorVal nvarchar(max) = NULL
*/

DECLARE @id int = @idVal
DECLARE @InternalId uniqueidentifier = @InternalIdVal
DECLARE @ExternalId nvarchar(2048) = @ExternalIdVal
DECLARE @Description nvarchar(max) = @DescriptionVal
DECLARE @Start datetime = @StartVal
DECLARE @End datetime = @EndVal
DECLARE @LastModified datetime = @LastModifiedVal
DECLARE @Location nvarchar(max) = @LocationVal
DECLARE @Summary nvarchar(max) = @SummaryVal
DECLARE @CategoriesJSON nvarchar(max) = @CategoriesJSONVal
DECLARE @ServiceAccountId int = @ServiceAccountIdVal
DECLARE @Upload bit = @UploadVal
DECLARE @Tag int = @TagVal
DECLARE @LastDLError nvarchar(max) = @LastDLErrorVal
DECLARE @LastUPError nvarchar(max) = @LastUPErrorVal

BEGIN TRAN
UPDATE CalDavEvents with (serializable) SET 
	   InternalId = @InternalId
      ,ExternalId = @ExternalId
      ,[Description] = @Description
      ,Start = @Start
      ,[End] = @End
      ,LastModified = @LastModified
      ,Location = @Location
      ,Summary = @Summary
      ,CategoriesJSON = @CategoriesJSON
      ,ServiceAccountId = @ServiceAccountId
      ,Upload = @Upload
      ,Tag = @Tag
      ,IsNew = 0
      ,WasJustUpdated = 1
      ,LastDLError = @LastDLError
      ,LastUPError = @LastUPError
	WHERE Id = ISNULL(@id, -1) OR InternalId = ISNULL(@InternalId, 'ABDEB065-DFE0-4E4F-B504-F62841690930') OR ExternalId = ISNULL(@ExternalId, '{ABDEB065-DFE0-4E4F-B504-F62841690930}')

IF @@ROWCOUNT = 0
BEGIN
  INSERT CalDavEvents(
	   InternalId
      ,ExternalId
      ,[Description]
      ,Start
      ,[End]
      ,LastModified
      ,Location
      ,Summary
      ,CategoriesJSON
      ,ServiceAccountId
      ,Upload
      ,Tag
      ,IsNew
      ,WasJustUpdated
      ,LastDLError
      ,LastUPError
		   ) 
   SELECT @InternalId, @ExternalId, @Description, @Start, @End, @LastModified, @Location, @Summary, @CategoriesJSON, @ServiceAccountId,
			@Upload, @Tag, 1, 0, @LastDLError, @LastUPError
;
  SELECT @id = SCOPE_IDENTITY()
END

COMMIT

SELECT * FROM CalDavEvents
	WHERE Id = ISNULL(@id, -1) OR InternalId = ISNULL(@InternalId, 'ABDEB065-DFE0-4E4F-B504-F62841690930') OR ExternalId = ISNULL(@ExternalId, '{ABDEB065-DFE0-4E4F-B504-F62841690930}')

