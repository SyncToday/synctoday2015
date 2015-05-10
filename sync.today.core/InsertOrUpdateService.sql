-- uncomment for testing
/* 
declare @idVal int = 7
DECLARE @nameVal nvarchar(255) = 'huhla2'
*/

DECLARE @Name nvarchar(255) = @NameVal
DECLARE @Key nvarchar(255) = @KeyVal

BEGIN TRAN
UPDATE [Services] with (serializable) SET Name=@Name WHERE [Key] = @Key
IF @@ROWCOUNT = 0
BEGIN
  INSERT [Services](Name,[Key]) SELECT @Name, @Key
END
COMMIT

SELECT * FROM [Services] WHERE [Key] = @Key

