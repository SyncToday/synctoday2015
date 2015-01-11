USE [SyncToday2015]
GO
/****** Object:  User [ONCRM\Administrator]    Script Date: 11. 1. 2015 15:43:42 ******/
CREATE USER [ONCRM\Administrator] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [ONCRM\Administrator]
GO
