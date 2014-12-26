USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.google.GroupMemberships]    Script Date: 26. 12. 2014 18:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.GroupMemberships](
	[ContactId] [uniqueidentifier] NOT NULL,
	[GroupId] [uniqueidentifier] NOT NULL,
	[GroupMembershipId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
PRIMARY KEY CLUSTERED 
(
	[GroupMembershipId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Index [IX_PK]    Script Date: 26. 12. 2014 18:42:11 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_PK] ON [dbo].[adapters.google.GroupMemberships]
(
	[ContactId] ASC,
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[adapters.google.GroupMemberships]  WITH CHECK ADD FOREIGN KEY([ContactId])
REFERENCES [dbo].[adapters.google.Contacts] ([ContactId])
GO
ALTER TABLE [dbo].[adapters.google.GroupMemberships]  WITH CHECK ADD FOREIGN KEY([GroupId])
REFERENCES [dbo].[adapters.google.Groups] ([GroupId])
GO
