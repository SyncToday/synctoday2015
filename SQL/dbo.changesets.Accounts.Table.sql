USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[changesets.Accounts]    Script Date: 26. 12. 2014 1:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[changesets.Accounts](
	[ExternalId] [nvarchar](max) NOT NULL,
	[AdapterId] [int] NOT NULL,
	[AccountId] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_ExternalId]    Script Date: 26. 12. 2014 1:24:57 ******/
CREATE NONCLUSTERED INDEX [IX_ExternalId] ON [dbo].[changesets.Accounts]
(
	[AdapterId] ASC
)
INCLUDE ( 	[ExternalId]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[changesets.Accounts]  WITH CHECK ADD FOREIGN KEY([AccountId])
REFERENCES [dbo].[entities.Accounts] ([AccountId])
GO
ALTER TABLE [dbo].[changesets.Accounts]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync_Adapters] ([AdapterId])
GO
