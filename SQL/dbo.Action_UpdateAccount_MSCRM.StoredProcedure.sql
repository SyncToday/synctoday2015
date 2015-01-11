USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[Action_UpdateAccount_MSCRM]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Action_UpdateAccount_MSCRM]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DELETE [Action_UpdateAccount]

	INSERT INTO [dbo].[Action_UpdateAccount]
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
			   ,[Country]
			   ,[Note]
			   )


		select [internalid]
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
			   ,[Note]
			    from
	(
	select *,
	( select ISNULL([LastModified], /**/ getdate() ) from Account A where A.internalid = T.internalid ) as Account_LastModified_A
	,ISNULL(( select [ModifiedOn] from [dbo].[MSCRM_Companies_Account] M where cast(M.accountId as nvarchar(max) )  = T.externalid ), datefromparts(1975,12,22) ) as Account_LastModified_M
	 from 
	(
	SELECT [internalid]
		  ,ISNULL(A.[name], '') as name
		  ,ISNULL(A.[ico], '') as ico
		  ,ISNULL(A.[dic], '') as dic
		  ,( case when M.OriginalInternalId is null then A.externalid else 
		     M.AccountId
		  end ) as externalid
		  ,ISNULL(A.[email], '') as email
		  ,ISNULL(A.[PrimaryPhonenumber], '') as [PrimaryPhonenumber]
		  ,ISNULL(A.[City], '') as [City]
		  ,ISNULL(A.[Street], '') as [Street]
		  ,ISNULL(A.[Region], '') as [Region]
		  ,ISNULL(A.[Postcode], '') as [Postcode]
		  ,ISNULL(A.[Country], '') as [Country]
		  ,ISNULL(A.[FormattedAddress], '') as [FormattedAddress]
		  ,ISNULL(A.[note], '') as [note]
	FROM [dbo].[Account] A inner join [dbo].[MSCRM_Companies_Account] M on 
	  ( cast(M.accountId as nvarchar(max) )  = A.externalid ) OR
	  ( M.OriginalInternalId is not null AND ( A.internalid = M.OriginalInternalId  ) )
	  except
	SELECT [internalid]
		  ,ISNULL(M.[name],'') as name
		  ,ISNULL(M.[new_ico],'') as ico
		  ,ISNULL(M.[new_dic],'') as dic
		  ,cast(M.accountId as nvarchar(max) )  as externalid
		  ,ISNULL(M.[EMailAddress1],'') as email
		  ,ISNULL(M.[Telephone1],'') as [PrimaryPhonenumber]
		  ,ISNULL(M.address1_city,'') as [City]
		  ,ISNULL(M.address1_line1,'') as [Street]
		  ,ISNULL(A.Region,'') as [Region]
		  ,ISNULL(M.address1_postalcode,'') as [Postcode]
		  ,ISNULL(M.address1_country,'') as [Country]
		  ,ISNULL(A.[FormattedAddress],'') as [FormattedAddress]
		  ,ISNULL(M.Description,'') as [note]
	  FROM [dbo].[Account] A inner join [dbo].[MSCRM_Companies_Account] M on 
	  ( cast(M.accountId as nvarchar(max) )  = A.externalid ) OR
	  ( M.OriginalInternalId is not null AND ( A.internalid = M.OriginalInternalId  ) )
	) T
	) U where Account_LastModified_M < Account_LastModified_A

END


GO
