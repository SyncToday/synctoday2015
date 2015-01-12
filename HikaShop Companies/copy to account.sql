USE [SyncToday2015]
GO

begin tran
/*
INSERT INTO [dbo].[Account]
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
           )

-- osoby
select newid(),
      [address_firstname] + ' ' + [address_lastname], --,[name]
           NULL, --,[ico]
           address_vat, --,[dic]
           address_id, --,[externalid]
           (select [user_email] from [Hikashop_User] U where U.user_id = address_user_id ),--[email]
           address_telephone, --,[PrimaryPhonenumber]
           address_city, --,[City]
           address_street, --,[Street]
           address_state, --,[Region]
           address_post_code, --,[Postcode]
           address_country --,[Country]
FROM [dbo].[Hikashop_Address]
where address_company is null or LEN(address_company) = 0

UNION


select newid(),
           address_company, --,[name]
           NULL, --,[ico]
           address_vat, --,[dic]
           address_id, --,[externalid]
           (select [user_email] from [Hikashop_User] U where U.user_id = address_user_id ),--[email]
           address_telephone, --,[PrimaryPhonenumber]
           address_city, --,[City]
           address_street, --,[Street]
           address_state, --,[Region]
           address_post_code, --,[Postcode]
           address_country --,[Country]
FROM [dbo].[Hikashop_Address]
where address_company is not null and LEN(address_company) > 0
*/

USE [SyncToday2015]
GO

INSERT INTO [dbo].[entities.Accounts]
           ([AccountId]
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
           ,[new_banka])


select 

[PartialAccountId]
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
           ,NULL
           ,NULL
           ,NULL
           ,NULL
           ,NULL
           ,NULL
 from [dbo].[adapters.hikashop.PartialAccounts]
where PartialAccountId not IN
(
select AccountID from [dbo].[entities.Accounts]
)


commit
