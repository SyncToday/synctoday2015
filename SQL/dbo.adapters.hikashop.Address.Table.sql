USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.hikashop.Address]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.hikashop.Address](
	[address_id] [int] NOT NULL,
	[address_user_id] [int] NULL,
	[address_title] [nvarchar](max) NULL,
	[address_firstname] [nvarchar](max) NULL,
	[address_middle_name] [nvarchar](max) NULL,
	[address_lastname] [nvarchar](max) NULL,
	[address_company] [nvarchar](max) NULL,
	[address_street] [nvarchar](max) NULL,
	[address_post_code] [nvarchar](max) NULL,
	[address_city] [nvarchar](max) NULL,
	[address_telephone] [nvarchar](max) NULL,
	[address_telephone2] [nvarchar](max) NULL,
	[address_fax] [nvarchar](max) NULL,
	[address_state] [nvarchar](max) NULL,
	[address_country] [nvarchar](max) NULL,
	[address_published] [int] NULL,
	[address_vat] [nvarchar](max) NULL,
	[address_default] [int] NULL,
	[address_street2] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[address_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
