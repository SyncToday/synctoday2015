USE [SyncToday2015]
GO

INSERT INTO [dbo].[entities.Product]
           ([ProductId]
           ,[Name]
           ,[Description]
           ,[product_code]
           ,[AdapterId])
select
[PartialProductId]
,[product_name]
,[product_description]
,[product_code]
,'18077449-4CB9-4FE2-BE4C-B5AD34AD5AC2'
from
[dbo].[adapters.hikashop.Product]
where product_published = 1

--truncate table [entities.Product]