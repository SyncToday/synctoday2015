USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.google.PartialAccounts]    Script Date: 28. 12. 2014 0:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.PartialAccounts](
	[PartialAccountId] [uniqueidentifier] NOT NULL,
	[ChangedOn] [datetimeoffset](7) NULL,
	[ExternalId] [nvarchar](800) NULL,
	[AdapterId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IC] [nvarchar](max) NULL,
	[DIC] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[PrimaryPhonenumber] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Street] [nvarchar](max) NULL,
	[Region] [nvarchar](max) NULL,
	[Postcode] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[FormattedAddress] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[TransformTag] [nvarchar](100) NULL,
	[AccountId] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[PartialAccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[adapters.google.PartialAccounts] ADD  DEFAULT (newid()) FOR [PartialAccountId]
GO
ALTER TABLE [dbo].[adapters.google.PartialAccounts]  WITH CHECK ADD FOREIGN KEY([AccountId])
REFERENCES [dbo].[entities.Accounts] ([AccountId])
GO
ALTER TABLE [dbo].[adapters.google.PartialAccounts]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
