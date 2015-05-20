-- uncomment for testing
/* 
declare @idVal int = 7
DECLARE @nameVal nvarchar(255) = 'huhla2'
*/

DECLARE @id int
select @id  = @idVal
DECLARE @LoginJSON nvarchar(4000)
select @LoginJSON  = @LoginJSONVal
DECLARE @ServiceId int
select @ServiceId = @ServiceIdVal
DECLARE @AccountId int
select @AccountId = @AccountIdVal
DECLARE @LastSuccessfulDownload datetime
select @LastSuccessfulDownload = @LastSuccessfulDownloadVal
DECLARE @LastDownloadAttempt datetime
select @LastDownloadAttempt = @LastDownloadAttemptVal
DECLARE @LastSuccessfulUpload datetime
select @LastSuccessfulUpload = @LastSuccessfulUploadVal
DECLARE @LastUploadAttempt datetime
select @LastUploadAttempt  = @LastUploadAttemptVal

BEGIN TRAN
UPDATE ServiceAccounts with (serializable) SET 
	LoginJSON=@LoginJSON,ServiceId=@ServiceId,AccountId=@AccountId,
	LastSuccessfulDownload=@LastSuccessfulDownload,
	LastDownloadAttempt=@LastDownloadAttempt,
	LastSuccessfulUpload=@LastSuccessfulUpload,
	LastUploadAttempt=@LastUploadAttempt
	WHERE Id = @id;
IF @@ROWCOUNT = 0
BEGIN
  INSERT ServiceAccounts(LoginJSON
           ,ServiceId
           ,AccountId
           ,LastSuccessfulDownload
           ,LastDownloadAttempt
           ,LastSuccessfulUpload
           ,LastUploadAttempt) SELECT @LoginJSON
           ,@ServiceId
           ,@AccountId
           ,@LastSuccessfulDownload
           ,@LastDownloadAttempt
           ,@LastSuccessfulUpload
           ,@LastUploadAttempt
;
  SELECT @id = SCOPE_IDENTITY()
END
COMMIT

SELECT * FROM ServiceAccounts WHERE Id = @id
