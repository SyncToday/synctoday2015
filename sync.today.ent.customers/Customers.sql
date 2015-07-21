/*
declare @idVal int = 2
declare @search nvarchar(max) = null
*/

declare @id int =  @idVal
SELECT TOP 100  * FROM Customers where case when @id = 0 then id else @id end = id AND Name like '%' + ISNULL(@search, '') + '%'


