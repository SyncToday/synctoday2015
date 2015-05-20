/*
DECLARE @id int = 0
DECLARE @Name nvarchar(4000) = 'ahoj'
*/
DECLARE @idVal int = @Id
SELECT * FROM Consumers WHERE Id = ( CASE WHEN @idVal = 0 THEN Id ELSE @idVal END ) AND Name = ISNULL(@Name, Name) ORDER BY Name ASC