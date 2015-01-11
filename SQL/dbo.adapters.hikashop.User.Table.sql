USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.hikashop.User]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.hikashop.User](
	[user_id] [int] NOT NULL,
	[user_cms_id] [int] NULL,
	[user_email] [nvarchar](max) NULL,
	[user_partner_email] [nvarchar](max) NULL,
	[user_params] [nvarchar](max) NULL,
	[user_partner_id] [int] NULL,
	[user_partner_price] [decimal](18, 0) NULL,
	[user_partner_paid] [int] NULL,
	[user_created_ip] [nvarchar](max) NULL,
	[user_unpaid_amount] [decimal](18, 0) NULL,
	[user_partner_currency_id] [int] NULL,
	[user_created] [int] NULL,
	[user_currency_id] [int] NULL,
	[user_partner_activated] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
