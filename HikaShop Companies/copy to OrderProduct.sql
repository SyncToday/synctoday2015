begin tran

update [adapters.hikashop.OrderProduct] set OrderProductId = newid() where OrderProductId ='00000000-0000-0000-0000-000000000000'

INSERT INTO [dbo].[entities.OrderProduct]
           ([OrderProductId]
           ,[OrderId]
           ,[ProductId]
           ,[Quantity]
           ,[UnitPrice])

select 
[OrderProductId],
[adapters.hikashop.Order].[PartialOrderId],
[adapters.hikashop.Product].[PartialProductId],
[order_product_quantity],
[order_product_price]

from [dbo].[adapters.hikashop.OrderProduct]
inner join [dbo].[adapters.hikashop.Order] ON [dbo].[adapters.hikashop.Order].[order_id] = [adapters.hikashop.OrderProduct].[order_id]
inner join [dbo].[adapters.hikashop.Product] ON [dbo].[adapters.hikashop.Product].[product_id] = [dbo].[adapters.hikashop.OrderProduct].[product_id]
inner join [dbo].[entities.Order] ON [adapters.hikashop.Order].[PartialOrderId] = [dbo].[entities.Order].OrderId
where [OrderProductId] NOT IN
( select [OrderProductId] from [entities.OrderProduct]
)

commit


