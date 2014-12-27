USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.google.Emails]    Script Date: 28. 12. 2014 0:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Emails](
	[EmailId] [uniqueidentifier] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Label] [nvarchar](max) NULL,
	[Home] [bit] NULL,
	[Other] [bit] NULL,
	[Work] [bit] NULL,
	[ContactId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[adapters.google.Emails] ADD  DEFAULT (newid()) FOR [EmailId]
GO
ALTER TABLE [dbo].[adapters.google.Emails]  WITH CHECK ADD FOREIGN KEY([ContactId])
REFERENCES [dbo].[adapters.google.Contacts] ([ContactId])
GO
