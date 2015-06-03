/*  
DECLARE @Name nvarchar(255) = 'Alfons'
DECLARE @ConsumerIdVal int = 1
*/

DECLARE @ConsumerId int
select @ConsumerId  = @ConsumerIdVal

INSERT INTO [Accounts] ([Name],[ConsumerId])
     SELECT @Name, ( CASE WHEN @ConsumerId = 0 THEN NULL ELSE @ConsumerId END )
  DECLARE @id int
  SELECT @id = SCOPE_IDENTITY()
SELECT * FROM [Accounts] where Id = @id



