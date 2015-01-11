USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.hikashop.OrderProduct]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.hikashop.OrderProduct](
	[order_product_id] [int] NOT NULL,
	[order_id] [int] NOT NULL DEFAULT ('0'),
	[product_id] [int] NOT NULL DEFAULT ('0'),
	[order_product_quantity] [int] NOT NULL DEFAULT ('1'),
	[order_product_name] [nvarchar](255) NOT NULL DEFAULT (''),
	[order_product_code] [nvarchar](255) NOT NULL DEFAULT (''),
	[order_product_price] [decimal](17, 5) NOT NULL DEFAULT ('0.00000'),
	[order_product_tax] [decimal](17, 5) NOT NULL DEFAULT ('0.00000'),
	[order_product_options] [text] NOT NULL,
	[order_product_option_parent_id] [int] NULL DEFAULT ('0'),
	[order_product_tax_info] [text] NOT NULL,
	[order_product_wishlist_id] [int] NOT NULL DEFAULT ('0'),
	[order_product_shipping_id] [nvarchar](255) NOT NULL DEFAULT (''),
	[order_product_shipping_method] [nvarchar](255) NOT NULL DEFAULT (''),
	[order_product_shipping_price] [decimal](17, 5) NOT NULL DEFAULT ('0.00000'),
	[order_product_shipping_tax] [decimal](17, 5) NOT NULL DEFAULT ('0.00000'),
	[order_product_shipping_params] [nvarchar](255) NOT NULL DEFAULT (''),
PRIMARY KEY CLUSTERED 
(
	[order_product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
