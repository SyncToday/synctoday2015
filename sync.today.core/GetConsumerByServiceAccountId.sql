--declare @serviceAccountId int = 1

select r.Id,r.Name from Consumers r
inner join Accounts v on r.Id = v.ConsumerId
inner join ServiceAccounts s on v.Id = s.AccountId
where s.Id = @serviceAccountId
