USE [SyncToday2015]
GO

INSERT INTO [dbo].[Account]
           ([internalid]
           ,[name]
           ,[ico]
           ,[dic]
           ,[externalid])
     SELECT NEWID(), [orgName], '', '', id from [dbo].[Google_Contacts_Contact]
	 where GroupID = 
		(SELECT  [id] FROM [Google_Contacts_Group] where Title = 'CERIA' ) and [orgName] is not null and len([orgName])>0
	 UNION
	 Select NEWID(), [givenName] + ' ' + [familyName], '', '', id from [dbo].[Google_Contacts_Contact]
	 where GroupID = 
		(SELECT  [id] FROM [Google_Contacts_Group] where Title = 'CERIA' ) and [familyName] is not null and len([familyName])>0
		and [givenName] is not null and len([givenName])>0
