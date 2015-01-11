USE [SyncToday2015]
GO

INSERT INTO [dbo].[adapters.moneys4.PartialProduct]
           ([PartialProductId]
           ,[Name]
           ,[Description]
           ,[product_code]
           ,[AdapterId]           )
select newid(),
[Nazev],
[Popis],
[Kod],
'E5FFBB10-EBA1-403A-BAAF-863780461DF3'
from [S4_Agenda_CERIA].[dbo].[Artikly_Artikl]
