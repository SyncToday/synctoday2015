-- uncomment for testings
/* 
DECLARE @AdapterIdVal int = 1
DECLARE @ConsumerIdVal int = 2
DECLARE @DataJSONVal nvarchar(4000) = 'AAA\b'
*/

DECLARE @AdapterId int
select @AdapterId = @AdapterIdVal
DECLARE @ConsumerId int
select @ConsumerId  = @ConsumerIdVal
DECLARE @DataJSON nvarchar(4000)
select @DataJSON  = @DataJSONVal

BEGIN TRAN
UPDATE [ConsumerAdapters] with (serializable) SET DateJSON=@DataJSON WHERE AdapterId = @AdapterId AND ConsumerId = @ConsumerId
IF @@ROWCOUNT = 0
BEGIN
  INSERT [ConsumerAdapters](AdapterId,ConsumerId,DateJSON) SELECT @AdapterId, @ConsumerId, @DataJSON
END
COMMIT

SELECT * FROM [ConsumerAdapters] WHERE AdapterId = @AdapterId AND ConsumerId = @ConsumerId
