--declare @id int = NULL
SELECT TOP 100  * FROM CustomerCategories where isnull(@id, id) = id

