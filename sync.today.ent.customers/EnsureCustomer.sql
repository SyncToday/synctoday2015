-- uncomment for testing
/*   

DECLARE @nameVal nvarchar(255) = 'huhla555'
DECLARE @customerCategoryId int = ( select top 1 Id from CustomerCategories )
*/
DECLARE @name nvarchar(255) = @nameVal

BEGIN TRAN
if not exists (select * from Customers with (updlock,serializable) where Name = @name)
BEGIN
  INSERT Customers(Name, CustomerCategoryId, LastModified) SELECT @name, @customerCategoryId, getdate();
END
COMMIT

SELECT * FROM Customers WHERE Name = @name

