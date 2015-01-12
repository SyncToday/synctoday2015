USE [SyncToday2015]
GO

begin tran

INSERT INTO [dbo].[entities.Order]
           ([OrderId]
           ,[AccountId]
           ,[CreatedOn]
           ,[PaymentMethodId]
           ,[Number]
           ,[AdapterId]
           ,[KoncovyPrijemce_Email]
           ,[KoncovyPrijemce_KontaktniOsobaNazev]
           ,[KoncovyPrijemce_Misto]
           ,[KoncovyPrijemce_Nazev]
           ,[KoncovyPrijemce_PSC]
           ,[KoncovyPrijemce_Stat]
           ,[KoncovyPrijemce_Telefon]
           ,[KoncovyPrijemce_Ulice]
		   , [OrderStatusId]
		   , [KoncovyPrijemce_AddressID]
		   )

select 
	newid(),
	( select top 1 PartialAccountId from [dbo].[adapters.hikashop.PartialAccounts] PA 
	inner join [dbo].[entities.Accounts] on PA.PartialAccountId = [dbo].[entities.Accounts].AccountId
	where PA.ExternalID = [order_billing_address_id] order by PA.IsOriginal desc),
	DATEADD(SECOND, cast(order_created as int), '19700101') ,
	( CASE when order_payment_method = 'banktransfer' then '1ECEAA4B-35CB-4200-8D7B-230E32086105' else '5BC03214-9470-4074-A13D-39ACED4E613F' end ) ,
	order_number,
	'18077449-4CB9-4FE2-BE4C-B5AD34AD5AC2'
	, [adapters.hikashop.User].[user_email]
	, ISNULL(address_firstname,'') + ' ' + ISNULL(address_lastname,'')
	, [address_city]
	, ISNULL([address_company], (ISNULL(address_firstname,'') + ' ' + ISNULL(address_lastname,'')) )
	, [address_post_code]
	,( case when [address_country] = 'country_Czech_Republic_56' then 'Èeská Republika' else 
		(case when [address_country] = 'country_Slovakia_189' then 'Slovensko' else '' end ) end
	  )
	, [address_telephone]
	, [address_street]
	, [entities.OrderStatus].OrderStatusId
	, [adapters.hikashop.User].EmailSpojeni_ID

from [dbo].[adapters.hikashop.Order]
inner join [dbo].[adapters.hikashop.Address] on [order_shipping_address_id] = [address_id]
inner join [adapters.hikashop.User] on [order_user_id] = [user_id]
inner join [dbo].[entities.OrderStatus] on [entities.OrderStatus].[Name] = [adapters.hikashop.Order].order_status

commit

