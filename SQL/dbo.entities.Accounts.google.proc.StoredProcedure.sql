USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[entities.Accounts.google.proc]    Script Date: 30. 12. 2014 0:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[entities.Accounts.google.proc] as 

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
  FROM [dbo].[adapters.google.PartialAccounts]
  WHERE PartialAccountId NOT IN
  (
  select accountid from [entities.Accounts]
  )

GO
