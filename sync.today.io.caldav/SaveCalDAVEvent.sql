-- uncomment for testing
/*  
DECLARE @idVal int = 0
DECLARE @InternalIdVal uniqueidentifier = '40995F91-6236-4E5F-B289-0967E18D1E67'
DECLARE @ExternalIdVal nvarchar(2048) = NULL
DECLARE @DescriptionVal nvarchar(4000) = 'Our event description'
DECLARE @StartVal datetime = '2015-05-05 10:35:42.213'
DECLARE @EndVal datetime = '2015-05-05 10:36:42.213'
DECLARE @LastModifiedVal datetime = '2015-05-05 10:36:42.213'
DECLARE @LocationVal nvarchar(4000) = 'Here'
DECLARE @SummaryVal nvarchar(4000) = 'Title635664189422126569'
DECLARE @CategoriesJSONVal nvarchar(4000) = NULL
DECLARE @ServiceAccountIdVal int = 3
DECLARE @UploadVal bit = 1
DECLARE @TagVal int = 0
DECLARE @LastDLErrorVal nvarchar(4000) = NULL
DECLARE @LastUPErrorVal nvarchar(4000) = NULL
*/

DECLARE @id int = @idVal
DECLARE @InternalId uniqueidentifier = @InternalIdVal
DECLARE @ExternalId nvarchar(2048) = @ExternalIdVal
DECLARE @Description nvarchar(4000) = @DescriptionVal
DECLARE @Start datetime = @StartVal
DECLARE @End datetime = @EndVal
DECLARE @LastModified datetime = @LastModifiedVal
DECLARE @Location nvarchar(4000) = @LocationVal
DECLARE @Summary nvarchar(4000) = @SummaryVal
DECLARE @CategoriesJSON nvarchar(4000) = @CategoriesJSONVal
DECLARE @ServiceAccountId int = @ServiceAccountIdVal
DECLARE @Upload bit = @UploadVal
DECLARE @Tag int = @TagVal
DECLARE @LastDLError nvarchar(4000) = @LastDLErrorVal
DECLARE @LastUPError nvarchar(4000) = @LastUPErrorVal

BEGIN TRAN
UPDATE CalDavEvents with (serializable) SET 
	   --InternalId = @InternalId NO, we have ChangeInternalIdBecauseOfDuplicity for this
      ExternalId = @ExternalId
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
      ,WasJustUpdated = 
		( CASE WHEN 
			ISNULL(ExternalId, '') <> ISNULL(@ExternalId, '')
		  OR ISNULL([Description], '') <> ISNULL(@Description, '')
		  OR ISNULL(Start, '2015-01-01') <> ISNULL(@Start, '2015-01-01')
		  OR ISNULL([End], '2015-01-01') <> ISNULL(@End, '2015-01-01')
		  OR ISNULL(LastModified, '2015-01-01') <> ISNULL(@LastModified, '2015-01-01')
		  OR ISNULL(Location, '') <> ISNULL(@Location, '')
		  OR ISNULL(Summary, '') <> ISNULL(@Summary, '')
		  OR ISNULL(CategoriesJSON, '') <> ISNULL(@CategoriesJSON, '')
		  OR ISNULL(ServiceAccountId, 0) <> ISNULL(@ServiceAccountId, 0)
		  OR ISNULL(Tag, 0) <> ISNULL(@Tag,0)
		THEN 1 ELSE 0 END )
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

