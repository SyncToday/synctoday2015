USE [SyncToday2015]
GO

INSERT INTO [dbo].[Account]
           ([internalid]
           ,[name]
           ,[ico]
           ,[dic]
           ,[externalid])
     SELECT NEWID(), [Name], [new_ico], [new_dic], [AccountId] from [dbo].[MSCRM_Companies_Account]