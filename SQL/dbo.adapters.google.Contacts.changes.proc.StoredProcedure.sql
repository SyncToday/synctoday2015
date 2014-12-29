USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[adapters.google.Contacts.changes.proc]    Script Date: 30. 12. 2014 0:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[adapters.google.Contacts.changes.proc] as
delete [adapters.google.Contacts.changes]
INSERT INTO [dbo].[adapters.google.Contacts.changes]
           ([ContactId]
           ,[ChangedOn]
           ,[ExternalId]
           ,[AdapterId]
           ,[Content]
           ,[Title]
           ,[Email]
           ,[GivenName]
           ,[FamilyName]
           ,[OrgDepartment]
           ,[OrgJobDescription]
           ,[OrgName]
           ,[OrgTitle]
           ,[PrimaryPhonenumber]
           ,[postalAddressCity]
           ,[postalAddressStreet]
           ,[postalAddressRegion]
           ,[postalAddressPostcode]
           ,[postalAddressCountry]
           ,[postalAddressFormattedAddress])
select T.[ContactId]
           ,T.[ChangedOn]
           ,T.[ExternalId]
           ,T.[AdapterId]
           ,[Content]
           ,T.[Title]
           ,[Email]
           ,[GivenName]
           ,[FamilyName]
           ,[OrgDepartment]
           ,[OrgJobDescription]
           ,[OrgName]
           ,[OrgTitle]
           ,[PrimaryPhonenumber]
           ,[postalAddressCity]
           ,[postalAddressStreet]
           ,[postalAddressRegion]
           ,[postalAddressPostcode]
           ,[postalAddressCountry]
           ,[postalAddressFormattedAddress] from [dbo].[adapters.google.Contacts] T
inner join [dbo].[adapters.google.GroupMemberships] GM on T.ContactId = GM.ContactId 
inner join [dbo].[adapters.google.Groups] G on G.GroupId = GM.GroupId
where G.Title = 'CERIA'


GO
