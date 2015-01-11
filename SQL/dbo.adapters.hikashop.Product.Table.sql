USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.hikashop.Product]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.hikashop.Product](
	[product_id] [int] NOT NULL,
	[product_parent_id] [int] NOT NULL DEFAULT ('0'),
	[product_name] [nvarchar](255) NOT NULL,
	[product_description] [nvarchar](max) NOT NULL,
	[product_quantity] [int] NOT NULL DEFAULT ('-1'),
	[product_code] [nvarchar](255) NOT NULL,
	[product_published] [int] NOT NULL DEFAULT ('0'),
	[product_hit] [int] NOT NULL DEFAULT ('0'),
	[product_created] [int] NOT NULL DEFAULT ('0'),
	[product_sale_start] [int] NOT NULL DEFAULT ('0'),
	[product_sale_end] [int] NOT NULL DEFAULT ('0'),
	[product_delay_id] [int] NOT NULL DEFAULT ('0'),
	[product_tax_id] [int] NOT NULL DEFAULT ('0'),
	[product_type] [nvarchar](255) NOT NULL DEFAULT (''),
	[product_vendor_id] [int] NOT NULL DEFAULT ('0'),
	[product_manufacturer_id] [int] NOT NULL DEFAULT ('0'),
	[product_url] [nvarchar](255) NOT NULL,
	[product_weight] [decimal](12, 3) NOT NULL DEFAULT ('0.000'),
	[product_keywords] [nvarchar](255) NOT NULL,
	[product_weight_unit] [nvarchar](255) NOT NULL DEFAULT ('kg'),
	[product_modified] [int] NOT NULL DEFAULT ('0'),
	[product_meta_description] [nvarchar](155) NOT NULL DEFAULT (''),
	[product_dimension_unit] [nvarchar](255) NOT NULL DEFAULT ('m'),
	[product_width] [decimal](12, 3) NOT NULL DEFAULT ('0.000'),
	[product_length] [decimal](12, 3) NOT NULL DEFAULT ('0.000'),
	[product_height] [decimal](12, 3) NOT NULL DEFAULT ('0.000'),
	[product_max_per_order] [int] NULL DEFAULT ('0'),
	[product_access] [nvarchar](255) NOT NULL DEFAULT ('all'),
	[product_group_after_purchase] [nvarchar](255) NOT NULL DEFAULT (''),
	[product_min_per_order] [int] NULL DEFAULT ('0'),
	[product_contact] [int] NOT NULL DEFAULT ('0'),
	[product_last_seen_date] [int] NULL DEFAULT ('0'),
	[product_sales] [int] NULL DEFAULT ('0'),
	[product_waitlist] [int] NOT NULL DEFAULT ('0'),
	[product_layout] [nvarchar](255) NOT NULL DEFAULT (''),
	[product_average_score] [float] NOT NULL,
	[product_total_vote] [int] NOT NULL DEFAULT ('0'),
	[product_page_title] [nvarchar](255) NOT NULL DEFAULT (''),
	[product_alias] [nvarchar](255) NOT NULL DEFAULT (''),
	[product_price_percentage] [decimal](15, 7) NOT NULL DEFAULT ('0.0000000'),
	[product_canonical] [nvarchar](255) NOT NULL DEFAULT (''),
	[product_msrp] [decimal](15, 7) NULL DEFAULT ('0.0000000'),
	[product_display_quantity_field] [int] NULL DEFAULT ('0'),
	[product_warehouse_id] [int] NOT NULL DEFAULT ('0'),
	[product_quantity_layout] [nvarchar](255) NOT NULL DEFAULT (''),
	[PartialProductId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[PartialProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
