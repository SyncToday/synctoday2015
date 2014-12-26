USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.google.Groups]    Script Date: 27. 12. 2014 0:43:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Groups](
	[GroupId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[ChangedOn] [datetimeoffset](7) NULL,
	[ExternalId] [nvarchar](max) NULL,
	[AdapterId] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_ExternalId]    Script Date: 27. 12. 2014 0:43:15 ******/
CREATE NONCLUSTERED INDEX [IX_ExternalId] ON [dbo].[adapters.google.Groups]
(
	[GroupId] ASC
)
INCLUDE ( 	[ExternalId]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[adapters.google.Groups]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
