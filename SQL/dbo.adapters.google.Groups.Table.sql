USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.google.Groups]    Script Date: 30. 12. 2014 0:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Groups](
	[ExternalId] [nvarchar](400) NOT NULL,
	[ChangedOn] [datetimeoffset](7) NULL,
	[Title] [nvarchar](max) NULL,
	[GroupId] [uniqueidentifier] NOT NULL,
	[AdapterId] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[adapters.google.Groups] ADD  DEFAULT (newid()) FOR [GroupId]
GO
