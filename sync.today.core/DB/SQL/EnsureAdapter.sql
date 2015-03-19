-- uncomment for testing
/*  
DECLARE @nameVal nvarchar(255) = 'huhla555'
*/

DECLARE @name nvarchar(255) = @nameVal

BEGIN TRAN
if not exists (select * from Adapters with (updlock,serializable) where Name = @name)
BEGIN
  INSERT Adapters(Name) SELECT @name;
END
COMMIT

SELECT * FROM Adapters WHERE Name = @name

