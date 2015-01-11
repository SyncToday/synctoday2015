USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[adapters.hikashop.Accounts.proc]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[adapters.hikashop.Accounts.proc] as 

INSERT INTO [dbo].[adapters.hikashop.PartialAccounts]
           ([PartialAccountId]
           ,Name
           ,IC
           ,[dic]
           ,[externalid]
           ,[email]
           ,[PrimaryPhonenumber]
           ,[City]
           ,[Street]
           ,[Region]
           ,[Postcode]
           ,[Country]
		   ,AdapterId
           )

-- osoby
select 
isnull((select AccountID from [dbo].[entities.Accounts] where AdapterId = '18077449-4CB9-4FE2-BE4C-B5AD34AD5AC2' and
ExternalId = address_id and Name = rtrim(ltrim(isnull([address_firstname], '') + ' ' + isnull([address_lastname], '')))
),newid()),

      rtrim(ltrim(isnull([address_firstname], '') + ' ' + isnull([address_lastname], ''))), --,[name]
           NULL, --,[ico]
           address_vat, --,[dic]
           address_id, --,[externalid]
           (select [user_email] from [dbo].[adapters.hikashop.User] U where U.user_id = address_user_id ),--[email]
           address_telephone, --,[PrimaryPhonenumber]
           address_city, --,[City]
           address_street, --,[Street]
           address_state, --,[Region]
           address_post_code, --,[Postcode]
           address_country --,[Country
		   , '18077449-4CB9-4FE2-BE4C-B5AD34AD5AC2'
FROM [dbo].[adapters.hikashop.Address]
where rtrim(ltrim(isnull([address_firstname], '') + ' ' + isnull([address_lastname], ''))) <> ''
UNION


select 
isnull((select AccountID from [dbo].[entities.Accounts] where AdapterId = '18077449-4CB9-4FE2-BE4C-B5AD34AD5AC2' and
ExternalId = address_id and Name = ([address_company])
),newid()),

      [address_company], --,[name]
           NULL, --,[ico]
           address_vat, --,[dic]
           address_id, --,[externalid]
           (select [user_email] from [dbo].[adapters.hikashop.User] U where U.user_id = address_user_id ),--[email]
           address_telephone, --,[PrimaryPhonenumber]
           address_city, --,[City]
           address_street, --,[Street]
           address_state, --,[Region]
           address_post_code, --,[Postcode]
           address_country --,[Country]
		   , '18077449-4CB9-4FE2-BE4C-B5AD34AD5AC2'
		   FROM [dbo].[adapters.hikashop.Address]
where address_company is not null and LEN(address_company) > 0

GO
