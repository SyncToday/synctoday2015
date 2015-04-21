-- uncomment for testing
/*  
DECLARE @nameVal nvarchar(255) = 'huhla555'
*/

DECLARE @id nvarchar(255) = @idVal
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
DECLARE @IsNew bit = @IsNewVal
DECLARE @WasJustUpdated bit = @WasJustUpdatedVal
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
      ,IsNew = @IsNew
      ,WasJustUpdated = @WasJustUpdated
      ,LastDLError = @LastDLError
      ,LastUPError = @LastUPError
	WHERE Id = @id;


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
			@Upload, @Tag, @IsNew, @WasJustUpdated, @LastDLError, @LastUPError
;
  SELECT @id = SCOPE_IDENTITY()
END

COMMIT

SELECT * FROM CalDavEvents where Id = @id
