USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[Action_UpdateAccount]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Action_UpdateAccount](
	[internalid] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NULL,
	[ico] [nvarchar](max) NULL,
	[dic] [nvarchar](max) NULL,
	[externalid] [nvarchar](400) NULL,
	[email] [nvarchar](max) NULL,
	[PrimaryPhonenumber] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Street] [nvarchar](max) NULL,
	[Region] [nvarchar](max) NULL,
	[Postcode] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[internalid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
