-- uncomment for testing
/*   

DECLARE @nameVal nvarchar(255) = 'huhla555'
*/
DECLARE @name nvarchar(255) = @nameVal

BEGIN TRAN
if not exists (select * from CustomerCategories with (updlock,serializable) where Name = @name)
BEGIN
  INSERT CustomerCategories(Name, LastModified) SELECT @name, getdate();
END
COMMIT

SELECT * FROM CustomerCategories WHERE Name = @name

