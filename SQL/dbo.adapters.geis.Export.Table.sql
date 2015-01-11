USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.geis.Export]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.geis.Export](
	[ExportId] [uniqueidentifier] NOT NULL,
	[FileName] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ExportId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[adapters.geis.Export] ADD  DEFAULT (newid()) FOR [ExportId]
GO
