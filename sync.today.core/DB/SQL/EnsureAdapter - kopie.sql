-- uncomment for testing
/* 
declare @idVal int = 7
DECLARE @nameVal nvarchar(255) = 'huhla2'
*/

DECLARE @id int = @idVal
DECLARE @name nvarchar(255) = @nameVal

BEGIN TRAN
UPDATE Adapters with (serializable) SET Name=@name WHERE Id = @id;
IF @@ROWCOUNT = 0
BEGIN
  INSERT Adapters(Name) SELECT @name;
  SELECT @id = SCOPE_IDENTITY()
END
COMMIT

SELECT * FROM Adapters WHERE Id = @id

