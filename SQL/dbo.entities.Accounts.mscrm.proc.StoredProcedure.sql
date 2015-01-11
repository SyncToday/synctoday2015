USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[entities.Accounts.mscrm.proc]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[entities.Accounts.mscrm.proc] as 

INSERT INTO [dbo].[entities.Accounts]
           ([AccountId]
           ,[ChangedOn]
           ,[ExternalId]
           ,[AdapterId]
           ,[Name]
           ,[IC]
           ,[DIC]
           ,[Email]
           ,[PrimaryPhonenumber]
           ,[City]
           ,[Street]
           ,[Region]
           ,[Postcode]
           ,[Country]
           ,[FormattedAddress]
           ,[Note]
		   ,[Telephone2]
		   ,[Telephone3]
		   )

SELECT [PartialAccountId]
      ,ModifiedOn
      ,[PartialAccountId]
      ,[AdapterId]
      ,[Name]
      ,new_ic
      ,new_dic
      ,EMailAddress1
      ,Telephone1
      ,address1_city
      ,address1_line1
      ,NULL
      ,address1_postalcode
      ,address1_country
      ,NULL
      ,[Description]
		   ,[Telephone2]
		   ,[Telephone3]
  FROM [dbo].[adapters.mscrm.PartialAccounts]
  WHERE 
  AccountId is null and 
  PartialAccountId NOT IN
  (
  select accountid from [entities.Accounts]
  )

GO
