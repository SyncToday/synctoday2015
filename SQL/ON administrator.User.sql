USE [SyncToday2015]
GO
/****** Object:  User [ON\administrator]    Script Date: 11. 1. 2015 15:43:42 ******/
CREATE USER [ON\administrator] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [ON\administrator]
GO
