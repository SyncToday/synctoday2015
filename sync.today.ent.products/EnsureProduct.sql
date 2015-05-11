-- uncomment for testing
/*   

DECLARE @nameVal nvarchar(255) = 'huhla555'
*/

DECLARE @name nvarchar(255) = @nameVal
DECLARE @Code nvarchar(255) = @CodeVal

BEGIN TRAN
if not exists (select * from Products with (updlock,serializable) where Name = @name)
BEGIN
  INSERT Products(Name, LastModified, Code) SELECT @name, getdate(), @code;
END
ELSE
BEGIN
	UPDATE Products SET LastModified = getdate(), Code = @code where Name = @name AND ISNULL(Code, '') <> ISNULL(@Code, '')
END
COMMIT

SELECT * FROM Products WHERE Name = @name
