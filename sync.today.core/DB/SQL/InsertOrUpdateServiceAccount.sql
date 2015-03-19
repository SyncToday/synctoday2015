-- uncomment for testing
/* 
declare @idVal int = 7
DECLARE @nameVal nvarchar(255) = 'huhla2'
*/

DECLARE @id int = @idVal
DECLARE @LoginJSON nvarchar(max) = @LoginJSONVal
DECLARE @ServiceId int = @ServiceIdVal
DECLARE @AccountId int = @AccountIdVal
DECLARE @LastSuccessfulDownload datetime = @LastSuccessfulDownloadVal
DECLARE @LastDownloadAttempt datetime = @LastDownloadAttemptVal
DECLARE @LastSuccessfulUpload datetime = @LastSuccessfulUploadVal
DECLARE @LastUploadAttempt datetime = @LastUploadAttemptVal

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
