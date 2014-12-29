USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.google.GroupMemberships]    Script Date: 30. 12. 2014 0:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.GroupMemberships](
	[ContactId] [uniqueidentifier] NOT NULL,
	[GroupId] [uniqueidentifier] NOT NULL,
	[GroupMembershipId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupMembershipId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[adapters.google.GroupMemberships] ADD  DEFAULT (newid()) FOR [GroupMembershipId]
GO
ALTER TABLE [dbo].[adapters.google.GroupMemberships]  WITH CHECK ADD FOREIGN KEY([ContactId])
REFERENCES [dbo].[adapters.google.Contacts] ([ContactId])
GO
ALTER TABLE [dbo].[adapters.google.GroupMemberships]  WITH CHECK ADD FOREIGN KEY([GroupId])
REFERENCES [dbo].[adapters.google.Groups] ([GroupId])
GO
