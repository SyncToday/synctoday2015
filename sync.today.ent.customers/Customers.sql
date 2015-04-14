--declare @id int = NULL
SELECT TOP 100  * FROM Customers where isnull(@id, id) = id

