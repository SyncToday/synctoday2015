USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[entities.Accounts.hikashop.proc]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[entities.Accounts.hikashop.proc] as 

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
  FROM [dbo].[adapters.hikashop.PartialAccounts]
  WHERE PartialAccountId NOT IN
  (
  select accountid from [entities.Accounts]
  )
  and len(Name)>0 and name is not null

GO
