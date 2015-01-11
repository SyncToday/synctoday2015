USE [SyncToday2015]
GO
/****** Object:  Table [dbo].[adapters.geis.Expeditions]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[adapters.geis.Expeditions](
	[ExpeditionId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[isCargo] [bit] NULL,
	[number] [int] IDENTITY(1,1) NOT NULL,
	[customerReference] [nvarchar](max) NULL,
	[sendName] [nvarchar](max) NULL,
	[sendStreet] [nvarchar](max) NULL,
	[sendStreetNumOri] [nvarchar](max) NULL,
	[sendStreetNumDesc] [nvarchar](max) NULL,
	[sendCity] [nvarchar](max) NULL,
	[sendZipCode] [nvarchar](max) NULL,
	[sendCountry] [nvarchar](max) NULL,
	[sendContactName] [nvarchar](max) NULL,
	[sendContactEmail] [nvarchar](max) NULL,
	[sendContactPhone] [nvarchar](max) NULL,
	[recName] [nvarchar](max) NULL,
	[recStreet] [nvarchar](max) NULL,
	[recStreetNumOri] [nvarchar](max) NULL,
	[recStreetNumDesc] [nvarchar](max) NULL,
	[recCity] [nvarchar](max) NULL,
	[recZipCode] [nvarchar](max) NULL,
	[recCountry] [nvarchar](max) NULL,
	[recNote] [nvarchar](max) NULL,
	[addrCode] [nvarchar](max) NULL,
	[recContactPhone] [nvarchar](max) NULL,
	[recContactEmail] [nvarchar](max) NULL,
	[pickUpDate] [nvarchar](max) NULL,
	[row_count] [nvarchar](max) NULL,
	[row_weight] [nvarchar](max) NULL,
	[AdapterId] [uniqueidentifier] NULL,
	[Fakturace_FakturaVydana_ID] [uniqueidentifier] NULL,
	[VariabilniSymbol] [varchar](20) NULL,
	[CisloRady] [int] NULL,
	[ExportId] [uniqueidentifier] NULL,
	[recContactName] [nvarchar](max) NULL,
	[ZpusobPlatby_ID] [uniqueidentifier] NULL,
	[SumaCelkem] [decimal](18, 4) NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpeditionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[adapters.geis.Expeditions]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
ALTER TABLE [dbo].[adapters.geis.Expeditions]  WITH CHECK ADD FOREIGN KEY([ExportId])
REFERENCES [dbo].[adapters.geis.Export] ([ExportId])
GO
