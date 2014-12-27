USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[entities.Accounts.mscrm.proc]    Script Date: 27. 12. 2014 0:43:15 ******/
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
           ,[Note])

SELECT [PartialAccountId]
      ,[ModifiedOn]
      ,[PartialAccountId]
      ,[AdapterId]
      ,[Name]
      ,[new_ic]
      ,[new_dic]
      ,[EMailAddress1]
      ,[Telephone1]
      ,address1_city
      ,address1_line1
      ,NULL
      ,address1_postalcode
      ,address1_country
      ,NULL
      ,Description
  FROM [dbo].[adapters.mscrm.PartialAccounts]
  WHERE PartialAccountId IN
  (
  SELECT cast( PA.PartialAccountId as nvarchar(max))
  FROM [adapters.mscrm.PartialAccounts] PA
except (
select ExternalId from [dbo].[entities.Accounts]
union
select A.ExternalId from [dbo].[entities.Accounts] A
inner join [dbo].[adapters.mscrm.PartialAccounts] PA on PA.AccountId = A.AccountId
)
  )


GO
