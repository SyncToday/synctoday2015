INSERT INTO [dbo].[adapters.moneys4.PartialContacts]
           ([PartialContactId]
           ,[ModifiedOn]
           ,[Firstname]
           ,[LastName]
           ,[ParentAccountId]
           ,[JobTitle]
           ,[EmailAddress1]
           ,[EmailAddress2]
           ,[EmailAddress3]
           ,[MobilePhone]
           ,[Telephone1]
           ,[Telephone2]
           ,[Telephone3]
           ,[AdapterId]
           ,[StateCode]
           ,[StatusCode]
           ,[ContactId]) 
SELECT [ContactId]
      ,[ModifiedOn]
      ,[Firstname]
      ,[LastName]
      ,( select PartialAccountId from [adapters.moneys4.PartialAccounts] PA where 
( PA.PartialAccountId = ParentAccountId OR PA.AccountId = ParentAccountId) )
      ,[JobTitle]
      ,[EmailAddress1]
      ,[EmailAddress2]
      ,[EmailAddress3]
      ,[MobilePhone]
      ,[Telephone1]
      ,[Telephone2]
      ,[Telephone3]
      ,[AdapterId]
      ,[StateCode]
      ,[StatusCode]
	  , [ContactId]
  FROM [dbo].[entities.Contacts]

  
