USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.hikashop.Order]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.hikashop.Order](
	[order_id] [int] NOT NULL,
	[order_billing_address_id] [int] NOT NULL DEFAULT ('0'),
	[order_shipping_address_id] [int] NOT NULL DEFAULT ('0'),
	[order_user_id] [int] NOT NULL DEFAULT ('0'),
	[order_status] [nvarchar](255) NOT NULL DEFAULT (''),
	[order_discount_code] [nvarchar](255) NOT NULL DEFAULT (''),
	[order_created] [int] NOT NULL DEFAULT ('0'),
	[order_ip] [nvarchar](255) NOT NULL DEFAULT (''),
	[order_currency_id] [int] NOT NULL DEFAULT ('0'),
	[order_shipping_price] [decimal](17, 5) NOT NULL DEFAULT ('0.00000'),
	[order_discount_price] [decimal](17, 5) NOT NULL DEFAULT ('0.00000'),
	[order_shipping_id] [nvarchar](255) NOT NULL DEFAULT (''),
	[order_shipping_method] [nvarchar](255) NOT NULL DEFAULT (''),
	[order_payment_id] [nvarchar](255) NOT NULL DEFAULT (''),
	[order_payment_method] [nvarchar](255) NOT NULL DEFAULT (''),
	[order_full_price] [decimal](17, 5) NOT NULL DEFAULT ('0.00000'),
	[order_modified] [int] NOT NULL DEFAULT ('0'),
	[order_partner_id] [int] NOT NULL DEFAULT ('0'),
	[order_partner_price] [decimal](17, 5) NOT NULL DEFAULT ('0.00000'),
	[order_partner_paid] [int] NOT NULL DEFAULT ('0'),
	[order_type] [nvarchar](255) NOT NULL DEFAULT ('sale'),
	[order_partner_currency_id] [int] NOT NULL DEFAULT ('0'),
	[order_shipping_tax] [decimal](17, 5) NOT NULL DEFAULT ('0.00000'),
	[order_discount_tax] [decimal](17, 5) NOT NULL DEFAULT ('0.00000'),
	[order_number] [nvarchar](255) NOT NULL DEFAULT (''),
	[order_tax_info] [text] NOT NULL,
	[order_payment_price] [decimal](17, 5) NOT NULL DEFAULT ('0.00000'),
	[order_invoice_id] [int] NOT NULL DEFAULT ('0'),
	[order_invoice_number] [nvarchar](255) NOT NULL DEFAULT (''),
	[order_invoice_created] [int] NOT NULL DEFAULT ('0'),
	[order_shipping_params] [text] NOT NULL,
	[order_payment_params] [text] NOT NULL,
	[order_site_id] [nvarchar](255) NOT NULL DEFAULT (''),
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
