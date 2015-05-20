/* 
declare @idVal int = 0
declare @LoginJSON nvarchar(4000) = '' 
declare @adapterIdVal int = 0
declare @consumerIdVal int = 0
declare @serviceIdVal int = 1
*/

declare @id int = @idVal
declare @adapterId int = @adapterIdVal
declare @consumerId int = @consumerIdVal
declare @serviceId int = @serviceIdVal

IF @adapterId = 0 AND @consumerId = 0 AND @serviceId = 0
	select * from ServiceAccounts where 
		Id = ( CASE WHEN @id = 0 THEN Id ELSE @id END ) AND
		LoginJSON = ISNULL( @LoginJSON, LoginJSON )
ELSE
        select distinct r.* from ServiceAccounts r
        left join Accounts s  on ( r.AccountId = s.Id )
        left join ConsumerAdapters t on (s.ConsumerId = t.ConsumerId)
        where 
		ISNULL(t.AdapterId, 0) = ( CASE WHEN @adapterId = 0 THEN ISNULL(t.AdapterId, 0) ELSE @adapterId END )  AND 
		ISNULL(s.ConsumerId, 0) = ( CASE WHEN @consumerId = 0 THEN ISNULL(s.ConsumerId, 0) ELSE @consumerId END )  AND 
		ISNULL(r.ServiceId, 0) = @serviceId 
	