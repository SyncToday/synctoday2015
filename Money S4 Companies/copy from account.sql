begin tran

INSERT INTO [dbo].[adapters.moneys4.PartialAccounts]
           ([PartialAccountId]
           ,[Name]
           ,[IC]
           ,[DIC]
           ,[ExternalId]
           ,[Email]
           ,[PrimaryPhonenumber]
           ,[City]
           ,[Street]
           ,[Region]
           ,[Postcode]
           ,[Country]
           ,[FormattedAddress]
           ,[Note]
           ,[ChangedOn]
           ,[AdapterId]
           ,[OldAccountId]
           ,[Telephone2]
           ,[Telephone3]
           ,[new_cislo_uctu]
           ,[new_vs]
           ,[new_banka]
           ,[AccountId])
SELECT [AccountId]
      ,[Name]
      ,[IC]
      ,[DIC]
      ,[AccountId]
      ,[Email]
      ,[PrimaryPhonenumber]
      ,[City]
      ,[Street]
      ,[Region]
      ,[Postcode]
      ,[Country]
      ,[FormattedAddress]
      ,[Note]
      ,[ChangedOn]
      ,[AdapterId]
      ,[OldAccountId]
      ,[Telephone2]
      ,[Telephone3]
      ,[new_cislo_uctu]
      ,[new_vs]
      ,[new_banka]
	  , [AccountId]
  FROM [dbo].[entities.Accounts]
  where AccountId not in (
	select AccountId from [adapters.moneys4.PartialAccounts] where AccountId is not null
	union 
	select PartialAccountId from [adapters.moneys4.PartialAccounts] where PartialAccountId is not null
  ) and IsDeleted = 0

commit

