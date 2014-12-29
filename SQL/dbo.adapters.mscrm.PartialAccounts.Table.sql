USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.mscrm.PartialAccounts]    Script Date: 30. 12. 2014 0:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.mscrm.PartialAccounts](
	[PartialAccountId] [uniqueidentifier] NOT NULL,
	[AccountCategoryCode] [int] NULL,
	[TerritoryId] [uniqueidentifier] NULL,
	[DefaultPriceLevelId] [uniqueidentifier] NULL,
	[CustomerSizeCode] [int] NULL,
	[PreferredContactMethodCode] [int] NULL,
	[CustomerTypeCode] [int] NULL,
	[AccountRatingCode] [int] NULL,
	[IndustryCode] [int] NULL,
	[TerritoryCode] [int] NULL,
	[AccountClassificationCode] [int] NULL,
	[BusinessTypeCode] [int] NULL,
	[OwningBusinessUnit] [uniqueidentifier] NULL,
	[OriginatingLeadId] [uniqueidentifier] NULL,
	[PaymentTermsCode] [int] NULL,
	[ShippingMethodCode] [int] NULL,
	[PrimaryContactId] [uniqueidentifier] NULL,
	[Name] [nvarchar](160) NULL,
	[AccountNumber] [nvarchar](20) NULL,
	[Revenue] [money] NULL,
	[NumberOfEmployees] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[SIC] [nvarchar](20) NULL,
	[OwnershipCode] [int] NULL,
	[MarketCap] [money] NULL,
	[SharesOutstanding] [int] NULL,
	[TickerSymbol] [nvarchar](10) NULL,
	[StockExchange] [nvarchar](20) NULL,
	[WebSiteURL] [nvarchar](200) NULL,
	[FtpSiteURL] [nvarchar](200) NULL,
	[EMailAddress1] [nvarchar](100) NULL,
	[EMailAddress2] [nvarchar](100) NULL,
	[EMailAddress3] [nvarchar](100) NULL,
	[DoNotPhone] [bit] NULL,
	[DoNotFax] [bit] NULL,
	[Telephone1] [nvarchar](50) NULL,
	[DoNotEMail] [bit] NULL,
	[Telephone2] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[Telephone3] [nvarchar](50) NULL,
	[DoNotPostalMail] [bit] NULL,
	[DoNotBulkEMail] [bit] NULL,
	[DoNotBulkPostalMail] [bit] NULL,
	[CreditLimit] [money] NULL,
	[CreditOnHold] [bit] NULL,
	[IsPrivate] [bit] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[VersionNumber] [timestamp] NULL,
	[ParentAccountId] [uniqueidentifier] NULL,
	[Aging30] [money] NULL,
	[StateCode] [int] NOT NULL,
	[Aging60] [money] NULL,
	[StatusCode] [int] NULL,
	[Aging90] [money] NULL,
	[PreferredAppointmentDayCode] [int] NULL,
	[PreferredSystemUserId] [uniqueidentifier] NULL,
	[PreferredAppointmentTimeCode] [int] NULL,
	[Merged] [bit] NULL,
	[DoNotSendMM] [bit] NULL,
	[MasterId] [uniqueidentifier] NULL,
	[LastUsedInCampaign] [datetime] NULL,
	[PreferredServiceId] [uniqueidentifier] NULL,
	[PreferredEquipmentId] [uniqueidentifier] NULL,
	[ExchangeRate] [decimal](23, 10) NULL,
	[UTCConversionTimeZoneCode] [int] NULL,
	[OverriddenCreatedOn] [datetime] NULL,
	[TimeZoneRuleVersionNumber] [int] NULL,
	[ImportSequenceNumber] [int] NULL,
	[TransactionCurrencyId] [uniqueidentifier] NULL,
	[CreditLimit_Base] [money] NULL,
	[Aging30_Base] [money] NULL,
	[Revenue_Base] [money] NULL,
	[Aging90_Base] [money] NULL,
	[MarketCap_Base] [money] NULL,
	[Aging60_Base] [money] NULL,
	[YomiName] [nvarchar](160) NULL,
	[OwnerId] [uniqueidentifier] NOT NULL,
	[ModifiedOnBehalfBy] [uniqueidentifier] NULL,
	[CreatedOnBehalfBy] [uniqueidentifier] NULL,
	[OwnerIdType] [int] NOT NULL,
	[StageId] [uniqueidentifier] NULL,
	[ProcessId] [uniqueidentifier] NULL,
	[EntityImageId] [uniqueidentifier] NULL,
	[new_dic] [nvarchar](100) NULL,
	[new_ic] [nvarchar](10) NULL,
	[AccountId] [uniqueidentifier] NULL,
	[address1_city] [nvarchar](max) NULL,
	[address1_country] [nvarchar](max) NULL,
	[address1_line1] [nvarchar](max) NULL,
	[address1_postalcode] [nvarchar](max) NULL,
	[address1_telephone1] [nvarchar](max) NULL,
	[adapterid] [uniqueidentifier] NULL,
	[new_Zdroj] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[PartialAccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [DF_AccountBase_DoNotPhone]  DEFAULT ((0)) FOR [DoNotPhone]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [DF_AccountBase_DoNotFax]  DEFAULT ((0)) FOR [DoNotFax]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [DF_AccountBase_DoNotEMail]  DEFAULT ((0)) FOR [DoNotEMail]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [DF_AccountBase_DoNotPostalMail]  DEFAULT ((0)) FOR [DoNotPostalMail]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [DF_AccountBase_DoNotBulkEMail]  DEFAULT ((0)) FOR [DoNotBulkEMail]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [DF_AccountBase_DoNotBulkPostalMail]  DEFAULT ((0)) FOR [DoNotBulkPostalMail]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [Set_To_Zero94]  DEFAULT ((0)) FOR [IsPrivate]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts]  WITH CHECK ADD  CONSTRAINT [fk_AccountId] FOREIGN KEY([AccountId])
REFERENCES [dbo].[entities.Accounts] ([AccountId])
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] CHECK CONSTRAINT [fk_AccountId]
GO
