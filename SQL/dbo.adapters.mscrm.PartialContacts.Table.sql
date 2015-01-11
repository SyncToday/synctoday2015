USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.mscrm.PartialContacts]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.mscrm.PartialContacts](
	[PartialContactId] [uniqueidentifier] NOT NULL,
	[ModifiedOn] [datetime] NULL,
	[Firstname] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[ParentCustomerId] [uniqueidentifier] NULL,
	[JobTitle] [nvarchar](max) NULL,
	[EmailAddress1] [nvarchar](max) NULL,
	[EmailAddress2] [nvarchar](max) NULL,
	[EmailAddress3] [nvarchar](max) NULL,
	[MobilePhone] [nvarchar](max) NULL,
	[Telephone1] [nvarchar](max) NULL,
	[Telephone2] [nvarchar](max) NULL,
	[Telephone3] [nvarchar](max) NULL,
	[AdapterId] [uniqueidentifier] NOT NULL,
	[StateCode] [int] NULL,
	[StatusCode] [int] NULL,
	[ContactId] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[PartialContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[adapters.mscrm.PartialContacts]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialContacts]  WITH CHECK ADD FOREIGN KEY([ContactId])
REFERENCES [dbo].[entities.Contacts] ([ContactId])
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialContacts]  WITH CHECK ADD FOREIGN KEY([ParentCustomerId])
REFERENCES [dbo].[adapters.mscrm.PartialAccounts] ([PartialAccountId])
GO
