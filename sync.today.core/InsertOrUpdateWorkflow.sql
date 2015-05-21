-- uncomment for testing
/*  
DECLARE @nameVal nvarchar(255) = 'huhla2'
DECLARE @XamlCodeVal nvarchar(255) = '<aaa><vbbb222>'
*/

DECLARE @XamlCode nvarchar(4000)
select @XamlCode = @XamlCodeVal
DECLARE @name nvarchar(255)
select @name  = @nameVal
declare @id int
select @id  = 0

BEGIN TRAN
UPDATE Workflows with (serializable) SET [XamlCode]=@XamlCode WHERE Name = @name;
IF @@ROWCOUNT = 0
BEGIN
  INSERT Workflows(Name,CreatedOn, XamlCode) SELECT @name, getdate(), @XamlCode;
  SELECT @id = SCOPE_IDENTITY()
END
COMMIT

SELECT * FROM Workflows  WHERE Name = @name or Id = @id
