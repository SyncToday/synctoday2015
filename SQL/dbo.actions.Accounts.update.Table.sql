USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[actions.Accounts.update]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[actions.Accounts.update](
	[AccountId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IC] [nvarchar](max) NULL,
	[DIC] [nvarchar](max) NULL,
	[ExternalId] [nvarchar](400) NULL,
	[Email] [nvarchar](max) NULL,
	[PrimaryPhonenumber] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Street] [nvarchar](max) NULL,
	[Region] [nvarchar](max) NULL,
	[Postcode] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[AdapterId] [uniqueidentifier] NOT NULL,
	[UpdateAccountId] [uniqueidentifier] NOT NULL,
	[ChangedOn] [datetimeoffset](7) NULL,
 CONSTRAINT [PK_UpdateAccountId] PRIMARY KEY CLUSTERED 
(
	[UpdateAccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[actions.Accounts.update]  WITH CHECK ADD FOREIGN KEY([AccountId])
REFERENCES [dbo].[entities.Accounts] ([AccountId])
GO
ALTER TABLE [dbo].[actions.Accounts.update]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
