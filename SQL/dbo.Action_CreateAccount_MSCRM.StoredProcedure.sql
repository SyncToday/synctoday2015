USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[Action_CreateAccount_MSCRM]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Action_CreateAccount_MSCRM]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DELETE [Action_CreateAccount]

	INSERT INTO [dbo].[Action_CreateAccount]
			   ([internalid]
			   ,[name]
			   ,[ico]
			   ,[dic]
			   ,[externalid]
			   ,[email]
			   ,[PrimaryPhonenumber]
			   ,[City]
			   ,[Street]
			   ,[Region]
			   ,[Postcode]
			   ,[Country])


	SELECT [internalid]
		  ,[name]
		  ,[ico]
		  ,[dic]
		  ,[externalid]
		  ,[email]
		  ,[PrimaryPhonenumber]
		  ,[City]
		  ,[Street]
		  ,[Region]
		  ,[Postcode]
		  ,[Country]
	  FROM [Account]
	where [externalid] in 
	(
		SELECT 
			  [externalid]
		  from [Account]
		except
		select cast(accountId as nvarchar(max) ) from [dbo].[MSCRM_Companies_Account]
		except
		select externalid from Account where internalid in
		(
		SELECT [OriginalInternalId]
		  FROM [MSCRM_Companies_Account] WHERE [OriginalInternalId] is not null
		  )
	)
	order by name
END


GO
