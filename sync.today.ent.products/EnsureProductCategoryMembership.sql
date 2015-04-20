-- uncomment for testing
/*     
DECLARE @productIdVal int = ( select top 1 Id from Products )
DECLARE @productCategoryIdVal int = ( select top 1 Id from ProductCategories )
*/
DECLARE @productId int = @productIdVal
DECLARE @productCategoryId int = @productCategoryIdVal

BEGIN TRAN
if not exists (select * from ProductCategoryMemberships with (updlock,serializable) where ProductId = @productId and ProductCategoryId = @productCategoryId)
BEGIN
  INSERT ProductCategoryMemberships(ProductId, ProductCategoryId, LastModified) SELECT @productId, @productCategoryId, getdate();
END
COMMIT

SELECT * FROM ProductCategoryMemberships WHERE ProductId = @productId and ProductCategoryId = @productCategoryId
