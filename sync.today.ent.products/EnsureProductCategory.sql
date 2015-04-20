-- uncomment for testing
/*   
DECLARE @nameVal nvarchar(255) = 'huhla555'
*/


DECLARE @name nvarchar(255) = @nameVal

BEGIN TRAN
if not exists (select * from ProductCategories with (updlock,serializable) where Name = @name)
BEGIN
  INSERT ProductCategories(Name, LastModified) SELECT @name, getdate();
END
COMMIT

SELECT * FROM ProductCategories WHERE Name = @name
