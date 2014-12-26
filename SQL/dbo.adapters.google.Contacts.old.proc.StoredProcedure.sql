USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[adapters.google.Contacts.old.proc]    Script Date: 27. 12. 2014 0:43:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[adapters.google.Contacts.old.proc] as
INSERT INTO [dbo].[adapters.google.Contacts.old]
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
select * from [adapters.google.Contacts]
GO
