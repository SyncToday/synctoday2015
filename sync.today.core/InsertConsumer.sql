--DECLARE @Name nvarchar(255) = 'joe doe'
INSERT INTO [dbo].[Consumers]
           ([Name])
     VALUES
           (@Name)
DECLARE @id int = SCOPE_IDENTITY()
SELECT * FROM [Consumers] WHERE Id = @id
