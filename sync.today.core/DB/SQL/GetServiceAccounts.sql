/* */
declare @idVal int = 0
declare @LoginJSON nvarchar(max) = '' 
declare @adapterIdVal int = 0
declare @consumerIdVal int = 0
declare @serviceIdVal int = 1
 

declare @id int = @idVal
declare @adapterId int = @adapterIdVal
declare @consumerId int = @consumerIdVal
declare @serviceId int = @serviceIdVal

IF @adapterId = 0 AND @consumerId = 0 AND @serviceId = 0
	select * from ServiceAccounts where 
		Id = ( CASE WHEN @id = 0 THEN Id ELSE @id END ) AND
		LoginJSON = ISNULL( @LoginJSON, LoginJSON )
ELSE
        select r.* from ServiceAccounts r
        left join Accounts s  on ( r.AccountId = s.Id )
        left join ConsumerAdapters t on (s.ConsumerId = t.ConsumerId)
        where 
		t.AdapterId = ( CASE WHEN @adapterId = 0 THEN t.AdapterId ELSE @adapterId END )  AND 
		s.ConsumerId = ( CASE WHEN @consumerId = 0 THEN s.ConsumerId ELSE @consumerId END )  AND 
		r.ServiceId = @serviceId 
	