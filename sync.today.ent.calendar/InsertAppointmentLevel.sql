--DECLARE @Name nvarchar(255) = 'joe doe'
INSERT INTO AppointmentLevels
           ([Name])
     VALUES
           (@Name)
DECLARE @id int
SELECT @id = SCOPE_IDENTITY()
SELECT * FROM AppointmentLevels WHERE Id = @id
