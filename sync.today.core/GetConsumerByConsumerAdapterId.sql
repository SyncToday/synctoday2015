--declare @consumerAdapterId int = 1

select distinct r.Id,r.Name from Consumers r 
inner join ConsumerAdapters v on r.Id = v.ConsumerId
where v.Id = @consumerAdapterId
