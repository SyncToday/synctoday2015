USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[adapters.google.dupl.Accounts]    Script Date: 26. 12. 2014 1:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[adapters.google.dupl.Accounts]
AS
BEGIN
	Declare @affected int

	Select @affected = 0

	update [adapters.google.Contacts] set 
	AccountId = A.AccountId 
	from [entities.Accounts] A, [dbo].[changesets.Accounts] C
	where 
	[adapters.google.Contacts].ExternalId = C.ExternalId AND
	A.Name = [adapters.google.Contacts].OrgName AND 
	[adapters.google.Contacts].AccountId IS NULL

	select @affected = @affected + @@ROWCOUNT

	update [adapters.google.Contacts] set 
	AccountId = A.AccountId 
	from [entities.Accounts] A , [dbo].[changesets.Accounts] C
	where 
	[adapters.google.Contacts].ExternalId = C.ExternalId AND
	A.Name = RTRIM(LTRIM(ISNULL([adapters.google.Contacts].GivenName, '') + ' ' + ISNULL([adapters.google.Contacts].FamilyName, '' )))
	AND LEN(RTRIM(LTRIM(ISNULL([adapters.google.Contacts].GivenName, '') + ' ' + ISNULL([adapters.google.Contacts].FamilyName, '' )))) > 0
	AND 	[adapters.google.Contacts].AccountId IS NULL

	select @affected = @affected + @@ROWCOUNT

	if @affected > 0
	begin
		exec [adapters.google.changesets.Accounts]
	end
END

GO
