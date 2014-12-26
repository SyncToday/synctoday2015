USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[adapters.google.changesets.Accounts]    Script Date: 26. 12. 2014 1:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[adapters.google.changesets.Accounts] as
delete [changesets.Accounts] where AdapterId = ( select distinct [AdapterId] from [adapters.google.Contacts]) 
INSERT INTO [changesets.Accounts]
           ([ExternalId]
           ,[AdapterId]
           ,[AccountId])
select [ExternalId], [AdapterId], AccountId from (
select * from [adapters.google.Contacts]
except
select * from [adapters.google.Contacts.old]
) T

GO
