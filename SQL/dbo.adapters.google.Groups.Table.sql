USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.google.Groups]    Script Date: 26. 12. 2014 1:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Groups](
	[GroupId] [int] IDENTITY(1,1) NOT NULL,
	[ChangedOn] [datetimeoffset](7) NULL,
	[ExternalId] [nvarchar](max) NULL,
	[AdapterId] [int] NOT NULL,
	[Title] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[adapters.google.Groups]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync_Adapters] ([AdapterId])
GO
ALTER TABLE [dbo].[adapters.google.Groups]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync_Adapters] ([AdapterId])
GO
