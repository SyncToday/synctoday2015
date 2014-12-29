USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.google.PhoneNumbers]    Script Date: 30. 12. 2014 0:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.PhoneNumbers](
	[PhoneNumberId] [uniqueidentifier] NOT NULL,
	[Value] [nvarchar](max) NULL,
	[Label] [nvarchar](max) NULL,
	[Home] [bit] NULL,
	[Other] [bit] NULL,
	[Work] [bit] NULL,
	[ContactId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PhoneNumberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Index [IX_ContactId]    Script Date: 30. 12. 2014 0:06:34 ******/
CREATE NONCLUSTERED INDEX [IX_ContactId] ON [dbo].[adapters.google.PhoneNumbers]
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Value]    Script Date: 30. 12. 2014 0:06:34 ******/
CREATE NONCLUSTERED INDEX [IX_Value] ON [dbo].[adapters.google.PhoneNumbers]
(
	[PhoneNumberId] ASC
)
INCLUDE ( 	[Value]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[adapters.google.PhoneNumbers] ADD  DEFAULT (newid()) FOR [PhoneNumberId]
GO
ALTER TABLE [dbo].[adapters.google.PhoneNumbers]  WITH CHECK ADD FOREIGN KEY([ContactId])
REFERENCES [dbo].[adapters.google.Contacts] ([ContactId])
GO
