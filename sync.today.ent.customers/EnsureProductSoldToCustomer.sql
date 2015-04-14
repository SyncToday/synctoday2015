-- uncomment for testing
/*   

DECLARE @productIdVal int = ( select top 1 Id from Products )
DECLARE @customerIdVal int = ( select top 1 Id from Customers )
declare @SoldWhen datetime = getdate()
declare @unitprice decimal = 1.50
declare @units decimal = 3.14
*/

DECLARE @productId int = @productIdVal
DECLARE @customerId int = @customerIdVal

BEGIN TRAN
if not exists (select * from ProductSoldToCustomers with (updlock,serializable) where ProductId = @productId and CustomerId= @customerId)
BEGIN
  INSERT ProductSoldToCustomers(LastModified, ProductId, CustomerId, SoldWhen, UnitPrice, Units) SELECT getdate(), @productId, @customerId, @SoldWhen, @unitprice, @units;
END
COMMIT

SELECT * FROM ProductSoldToCustomers WHERE ProductId = @productId and CustomerId= @customerId


