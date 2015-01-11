USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.moneys4.PartialProduct]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.moneys4.PartialProduct](
	[PartialProductId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[product_code] [nvarchar](255) NOT NULL,
	[AdapterId] [uniqueidentifier] NULL,
	[ProductId] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[PartialProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[adapters.moneys4.PartialProduct]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
ALTER TABLE [dbo].[adapters.moneys4.PartialProduct]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[entities.Product] ([ProductId])
GO
