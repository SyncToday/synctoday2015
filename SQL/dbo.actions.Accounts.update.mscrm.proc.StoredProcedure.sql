USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[actions.Accounts.update.mscrm.proc]    Script Date: 11. 1. 2015 15:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[actions.Accounts.update.mscrm.proc]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DELETE [actions.Accounts.update] where [AdapterId] = '3A7E2EAC-3664-4404-9001-E40BA1CDFCC0'

INSERT INTO [dbo].[actions.Accounts.update]
           ([AccountId]
           ,[Name]
           ,[IC]
           ,[DIC]
           ,[ExternalId]
           ,[Email]
           ,[PrimaryPhonenumber]
           ,[City]
           ,[Street]
           ,[Region]
           ,[Postcode]
           ,[Country]
           ,[Note]
           ,[AdapterId]
           ,[UpdateAccountId]
           ,[ChangedOn])

select 
[AccountId]
           ,[Name]
           ,[IC]
           ,[DIC]
           ,[ExternalId]
           ,[Email]
           ,[PrimaryPhonenumber]
           ,[City]
           ,[Street]
           ,[Region]
           ,[Postcode]
           ,[Country]
           ,[Note]
           ,[AdapterId]
           ,[UpdateAccountId]
           ,[ChangedOn]
 
from
(
select *,
ISNULL((select top 1 ModifiedOn from [adapters.mscrm.PartialAccounts] PA where PA.AccountId = T.[AccountId]), '2001-01-01') as mscrmChangedOn,
ISNULL((select top 1 ChangedOn from [entities.Accounts] A where A.[AccountId] = T.[AccountId]),getdate()) as MasterChangedOn
 from (

select
      A.AccountId
      ,A.[Name]
      ,A.[IC]
      ,A.[DIC]
	  , GA.PartialAccountId as [ExternalId]
      ,A.[Email]
      ,A.[PrimaryPhonenumber]
      ,A.[City]
      ,A.[Street]
      ,A.[Region]
      ,A.[Postcode]
      ,A.[Country]
      ,A.[Note]
	  , GA.adapterid
	  , GA.PartialAccountId as [UpdateAccountId]
	  , A.ChangedOn

from [adapters.mscrm.PartialAccounts] GA
inner join [dbo].[entities.Accounts] A on ( GA.PartialAccountId = A.AccountId or GA.AccountId = A.AccountId )
except
select 
      GA.AccountId as [AccountId]
      ,GA.[Name]
      ,GA.[new_ic]
      ,GA.[new_dic]
	  , GA.PartialAccountId
      ,GA.[EMailAddress1]
      ,GA.[Telephone1]
      ,GA.address1_city
      ,GA.address1_line1
      ,A.[Region]
      ,GA.address1_postalcode
      ,GA.address1_country
      ,GA.Description
	  , GA.adapterid
	  , GA.PartialAccountId as [UpdateAccountId]
	  , A.ChangedOn

from [adapters.mscrm.PartialAccounts] GA
inner join [dbo].[entities.Accounts] A on ( GA.PartialAccountId = A.AccountId or GA.AccountId = A.AccountId )
) T
) U where 
mscrmChangedOn < MasterChangedOn 
-- and AccountId = '6F890194-3947-4231-A2AD-0017C39B5858'
order by Name

END


GO
