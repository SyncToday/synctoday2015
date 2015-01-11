begin tran

update [dbo].[adapters.hikashop.PartialAccounts] set
[IsOriginal] = 1
from [adapters.hikashop.Address]
where ( externalId = address_id ) and
Name = ([address_firstname] + ' ' + [address_lastname])

update [dbo].[adapters.hikashop.PartialAccounts] set
[IsOriginal] = 0
where [IsOriginal] is null

select * from [adapters.hikashop.PartialAccounts]
order by ExternalId

commit


