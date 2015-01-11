USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[actions.Accounts.create.mscrm.proc]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[actions.Accounts.create.mscrm.proc] as 

delete [actions.Accounts.create] where [AdapterId] = '3A7E2EAC-3664-4404-9001-E40BA1CDFCC0'
INSERT INTO [dbo].[actions.Accounts.create]
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
		   ,CreateAccountId)

SELECT 
           [AccountId]
           ,[ChangedOn]
           ,[ExternalId]
           ,'3A7E2EAC-3664-4404-9001-E40BA1CDFCC0'
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
		              ,[Note], newid()
  FROM [dbo].[entities.Accounts]
  WHERE AccountId IN
  ( select AccountId from (
  (
select * from [dbo].[entities.Accounts] A 
except
(
select A.* from [dbo].[entities.Accounts] A 
inner join [dbo].[adapters.mscrm.PartialAccounts] PA
on ( A.AccountId = PA.PartialAccountId )
union
select A.* from [dbo].[entities.Accounts] A 
inner join [dbo].[adapters.mscrm.PartialAccounts] PA
on ( PA.AccountId is not null and A.AccountId = PA.AccountId )
)  )
) T
)

GO
