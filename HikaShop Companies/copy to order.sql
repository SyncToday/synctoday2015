USE [SyncToday2015]
GO

USE [SyncToday2015]
GO

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
           ,[KoncovyPrijemce_Ulice])

select 
	newid(),
	( select top 1 PartialAccountId from [dbo].[adapters.hikashop.PartialAccounts] PA 
	where PA.ExternalID = [order_billing_address_id] order by PA.IsOriginal desc),
	DATEADD(SECOND, cast(order_created as int), '19700101') ,
	( CASE when order_payment_method = 'banktransfer' then '1ECEAA4B-35CB-4200-8D7B-230E32086105' else '5BC03214-9470-4074-A13D-39ACED4E613F' end ) ,
	order_number
from [dbo].[adapters.hikashop.Order]
