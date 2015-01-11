USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.moneys4.PartialAccounts]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.moneys4.PartialAccounts](
	[PartialAccountId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
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
	[FormattedAddress] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[ChangedOn] [datetimeoffset](7) NULL,
	[AdapterId] [uniqueidentifier] NULL,
	[OldAccountId] [uniqueidentifier] NULL,
	[Telephone2] [nvarchar](max) NULL,
	[Telephone3] [nvarchar](max) NULL,
	[new_cislo_uctu] [nvarchar](max) NULL,
	[new_vs] [nvarchar](max) NULL,
	[new_banka] [nvarchar](max) NULL,
	[AccountId] [uniqueidentifier] NULL,
	[telefonSpojeni1id] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[telefonSpojeni2id] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[telefonSpojeni3id] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[emailSpojeniId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[wwwSpojeniId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[bankovniSpojeniId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
PRIMARY KEY CLUSTERED 
(
	[PartialAccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[adapters.moneys4.PartialAccounts]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
ALTER TABLE [dbo].[adapters.moneys4.PartialAccounts]  WITH CHECK ADD  CONSTRAINT [fk_money_AccountId] FOREIGN KEY([AccountId])
REFERENCES [dbo].[entities.Accounts] ([AccountId])
GO
ALTER TABLE [dbo].[adapters.moneys4.PartialAccounts] CHECK CONSTRAINT [fk_money_AccountId]
GO
