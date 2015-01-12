USE [SyncToday2015]
GO

--delete [adapters.moneys4.PartialProduct]

begin tran

INSERT INTO [dbo].[adapters.moneys4.PartialProduct]
           ([PartialProductId]
           ,[Name]
           ,[Description]
           ,[product_code]
           ,[AdapterId]           )
select [ID],
[Nazev],
[Popis],
[Kod],
'E5FFBB10-EBA1-403A-BAAF-863780461DF3'
from [S4_Agenda_CERIA].[dbo].[Artikly_Artikl]

commit

