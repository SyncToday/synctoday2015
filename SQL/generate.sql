USE [master]
GO
/****** Object:  Database [SyncToday2015]    Script Date: 30. 12. 2014 0:07:14 ******/
CREATE DATABASE [SyncToday2015]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SyncToday2015', FILENAME = N'E:\Microsoft SQL Server\MSSQL12.SYNCTODAY\MSSQL\DATA\SyncToday2015.mdf' , SIZE = 18432KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SyncToday2015_log', FILENAME = N'E:\Microsoft SQL Server\MSSQL12.SYNCTODAY\MSSQL\DATA\SyncToday2015_log.ldf' , SIZE = 164672KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SyncToday2015].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SyncToday2015] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SyncToday2015] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SyncToday2015] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SyncToday2015] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SyncToday2015] SET ARITHABORT OFF 
GO
ALTER DATABASE [SyncToday2015] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SyncToday2015] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SyncToday2015] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SyncToday2015] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SyncToday2015] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SyncToday2015] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SyncToday2015] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SyncToday2015] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SyncToday2015] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SyncToday2015] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SyncToday2015] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SyncToday2015] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SyncToday2015] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SyncToday2015] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SyncToday2015] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SyncToday2015] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SyncToday2015] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SyncToday2015] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SyncToday2015] SET RECOVERY FULL 
GO
ALTER DATABASE [SyncToday2015] SET  MULTI_USER 
GO
ALTER DATABASE [SyncToday2015] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SyncToday2015] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SyncToday2015] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SyncToday2015] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SyncToday2015]
GO
/****** Object:  User [ONCRM\Administrator]    Script Date: 30. 12. 2014 0:07:14 ******/
CREATE USER [ONCRM\Administrator] FOR LOGIN [ONCRM\Administrator] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [ON\administrator]    Script Date: 30. 12. 2014 0:07:14 ******/
CREATE USER [ON\administrator] FOR LOGIN [ON\administrator] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [ONCRM\Administrator]
GO
ALTER ROLE [db_owner] ADD MEMBER [ON\administrator]
GO
/****** Object:  StoredProcedure [dbo].[Action_CreateAccount_MSCRM]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Action_CreateAccount_MSCRM]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DELETE [Action_CreateAccount]

	INSERT INTO [dbo].[Action_CreateAccount]
			   ([internalid]
			   ,[name]
			   ,[ico]
			   ,[dic]
			   ,[externalid]
			   ,[email]
			   ,[PrimaryPhonenumber]
			   ,[City]
			   ,[Street]
			   ,[Region]
			   ,[Postcode]
			   ,[Country])


	SELECT [internalid]
		  ,[name]
		  ,[ico]
		  ,[dic]
		  ,[externalid]
		  ,[email]
		  ,[PrimaryPhonenumber]
		  ,[City]
		  ,[Street]
		  ,[Region]
		  ,[Postcode]
		  ,[Country]
	  FROM [Account]
	where [externalid] in 
	(
		SELECT 
			  [externalid]
		  from [Account]
		except
		select cast(accountId as nvarchar(max) ) from [dbo].[MSCRM_Companies_Account]
		except
		select externalid from Account where internalid in
		(
		SELECT [OriginalInternalId]
		  FROM [MSCRM_Companies_Account] WHERE [OriginalInternalId] is not null
		  )
	)
	order by name
END


GO
/****** Object:  StoredProcedure [dbo].[Action_UpdateAccount_MSCRM]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Action_UpdateAccount_MSCRM]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DELETE [Action_UpdateAccount]

	INSERT INTO [dbo].[Action_UpdateAccount]
			   ([internalid]
			   ,[name]
			   ,[ico]
			   ,[dic]
			   ,[externalid]
			   ,[email]
			   ,[PrimaryPhonenumber]
			   ,[City]
			   ,[Street]
			   ,[Region]
			   ,[Postcode]
			   ,[Country]
			   ,[Note]
			   )


		select [internalid]
			   ,[name]
			   ,[ico]
			   ,[dic]
			   ,[externalid]
			   ,[email]
			   ,[PrimaryPhonenumber]
			   ,[City]
			   ,[Street]
			   ,[Region]
			   ,[Postcode]
			   ,[Country]
			   ,[Note]
			    from
	(
	select *,
	( select ISNULL([LastModified], /**/ getdate() ) from Account A where A.internalid = T.internalid ) as Account_LastModified_A
	,ISNULL(( select [ModifiedOn] from [dbo].[MSCRM_Companies_Account] M where cast(M.accountId as nvarchar(max) )  = T.externalid ), datefromparts(1975,12,22) ) as Account_LastModified_M
	 from 
	(
	SELECT [internalid]
		  ,ISNULL(A.[name], '') as name
		  ,ISNULL(A.[ico], '') as ico
		  ,ISNULL(A.[dic], '') as dic
		  ,( case when M.OriginalInternalId is null then A.externalid else 
		     M.AccountId
		  end ) as externalid
		  ,ISNULL(A.[email], '') as email
		  ,ISNULL(A.[PrimaryPhonenumber], '') as [PrimaryPhonenumber]
		  ,ISNULL(A.[City], '') as [City]
		  ,ISNULL(A.[Street], '') as [Street]
		  ,ISNULL(A.[Region], '') as [Region]
		  ,ISNULL(A.[Postcode], '') as [Postcode]
		  ,ISNULL(A.[Country], '') as [Country]
		  ,ISNULL(A.[FormattedAddress], '') as [FormattedAddress]
		  ,ISNULL(A.[note], '') as [note]
	FROM [dbo].[Account] A inner join [dbo].[MSCRM_Companies_Account] M on 
	  ( cast(M.accountId as nvarchar(max) )  = A.externalid ) OR
	  ( M.OriginalInternalId is not null AND ( A.internalid = M.OriginalInternalId  ) )
	  except
	SELECT [internalid]
		  ,ISNULL(M.[name],'') as name
		  ,ISNULL(M.[new_ico],'') as ico
		  ,ISNULL(M.[new_dic],'') as dic
		  ,cast(M.accountId as nvarchar(max) )  as externalid
		  ,ISNULL(M.[EMailAddress1],'') as email
		  ,ISNULL(M.[Telephone1],'') as [PrimaryPhonenumber]
		  ,ISNULL(M.address1_city,'') as [City]
		  ,ISNULL(M.address1_line1,'') as [Street]
		  ,ISNULL(A.Region,'') as [Region]
		  ,ISNULL(M.address1_postalcode,'') as [Postcode]
		  ,ISNULL(M.address1_country,'') as [Country]
		  ,ISNULL(A.[FormattedAddress],'') as [FormattedAddress]
		  ,ISNULL(M.Description,'') as [note]
	  FROM [dbo].[Account] A inner join [dbo].[MSCRM_Companies_Account] M on 
	  ( cast(M.accountId as nvarchar(max) )  = A.externalid ) OR
	  ( M.OriginalInternalId is not null AND ( A.internalid = M.OriginalInternalId  ) )
	) T
	) U where Account_LastModified_M < Account_LastModified_A

END


GO
/****** Object:  StoredProcedure [dbo].[actions.Accounts.create.mscrm.proc]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[actions.Accounts.create.mscrm.proc] as 

delete [actions.Accounts.create] where [AdapterId] = '3A7E2EAC-3664-4404-9001-E40BA1CDFCC0'
INSERT INTO [dbo].[actions.Accounts.create]
           ([AccountId]
           ,[ChangedOn]
           ,[ExternalId]
           ,[AdapterId]
           ,[Name]
           ,[IC]
           ,[DIC]
           ,[Email]
           ,[PrimaryPhonenumber]
           ,[City]
           ,[Street]
           ,[Region]
           ,[Postcode]
           ,[Country]
           ,[FormattedAddress]
           ,[Note]
		   ,CreateAccountId)

SELECT 
           [AccountId]
           ,[ChangedOn]
           ,[ExternalId]
           ,'3A7E2EAC-3664-4404-9001-E40BA1CDFCC0'
           ,[Name]
           ,[IC]
           ,[DIC]
           ,[Email]
           ,[PrimaryPhonenumber]
           ,[City]
           ,[Street]
           ,[Region]
           ,[Postcode]
           ,[Country]
           ,[FormattedAddress]
		              ,[Note], newid()
  FROM [dbo].[entities.Accounts]
  WHERE AccountId IN
  ( select AccountId from (
  (
select * from [dbo].[entities.Accounts] A 
except
(
select A.* from [dbo].[entities.Accounts] A 
inner join [dbo].[adapters.mscrm.PartialAccounts] PA
on ( A.AccountId = PA.PartialAccountId )
union
select A.* from [dbo].[entities.Accounts] A 
inner join [dbo].[adapters.mscrm.PartialAccounts] PA
on ( PA.AccountId is not null and A.AccountId = PA.AccountId )
)  )
) T
)

GO
/****** Object:  StoredProcedure [dbo].[actions.Accounts.update.mscrm.proc]    Script Date: 30. 12. 2014 0:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[adapters.google.Accounts.proc]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[adapters.google.Accounts.proc] as
begin
merge [dbo].[adapters.google.PartialAccounts] as Target
	using [dbo].[adapters.google.Contacts.changes] as Source
		on Target.[ExternalId] = Source.[ExternalId]
		and Target.[AdapterId] = Source.AdapterId
		and [TransformTag]='FO'
	when matched 
 then update set
		[Name] = RTRIM(LTRIM(ISNULL(source.GivenName, '') + ' ' + ISNULL(source.FamilyName, '' ))),
		[ChangedOn] = Source.[ChangedOn] ,
		Email = (select top 1 [Address] from [adapters.google.Emails] E where 
	       E.ContactId = Source.ContactId and len(address)>0 order by [Address]),
		[PrimaryPhonenumber] = (select top 1 Value from [adapters.google.PhoneNumbers] E where 
	       E.ContactId = Source.ContactId and len(Value)>0 order by [Value]),
		Telephone2 = (
		select Value From (
		select Value, ROW_NUMBER() OVER (ORDER BY [Value]) as PhoneOrder from [adapters.google.PhoneNumbers] E where 
			E.ContactId = Source.ContactId and len(Value)>0 ) T where PhoneOrder = 2
		),
		Telephone3 = (
		select Value From (
		select Value, ROW_NUMBER() OVER (ORDER BY [Value]) as PhoneOrder from [adapters.google.PhoneNumbers] E where 
			E.ContactId = Source.ContactId and len(Value)>0 ) T where PhoneOrder = 3
		),
		City = (select top 1 City from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		Street = (select top 1 Street from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		Region = (select top 1 Region from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		Postcode = (select top 1 Postcode from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		Country = (select top 1 Country from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		FormattedAddress = (select top 1 FormattedAddress from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		Note = Source.Content
	when not matched then
	insert ([ExternalId], ChangedOn, Name, [TransformTag], [AdapterId], Email, [PrimaryPhonenumber],  
	Telephone2, Telephone3, City,
	Street, Region, Postcode, Country, FormattedAddress, Note)
	values (Source.[ExternalId], Source.ChangedOn, RTRIM(LTRIM(ISNULL(source.GivenName, '') + ' ' + ISNULL(source.FamilyName, '' ))),'FO', Source.[AdapterId],
	(select top 1 [Address] from [adapters.google.Emails] E where 
	    E.ContactId = Source.ContactId and len(address)>0 order by [Address]),
	(
	select Value From (
	select Value, ROW_NUMBER() OVER (ORDER BY [Value]) as PhoneOrder from [adapters.google.PhoneNumbers] E where 
		E.ContactId = Source.ContactId and len(Value)>0 ) T where PhoneOrder = 2
	),
	(
	select Value From (
	select Value, ROW_NUMBER() OVER (ORDER BY [Value]) as PhoneOrder from [adapters.google.PhoneNumbers] E where 
		E.ContactId = Source.ContactId and len(Value)>0 ) T where PhoneOrder = 3
	),
	(select top 1 Value from [adapters.google.PhoneNumbers] E where 
	    E.ContactId = Source.ContactId and len(Value)>0 order by [Value]),
	(select top 1 City from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		(select top 1 Street from [adapters.google.Addresses] E where 
	    E.ContactId = Source.ContactId order by AddressId),
(select top 1 Region from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
 (select top 1 Postcode from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
(select top 1 Country from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
			Source.postalAddressFormattedAddress, 
		   Source.Content
	)
;

merge [dbo].[adapters.google.PartialAccounts] as Target
	using [dbo].[adapters.google.Contacts.changes] as Source
		on Target.[ExternalId] = Source.[ExternalId]
		and Target.[AdapterId] = Source.AdapterId
		and [TransformTag]='PO'
	when matched 
 then update set
		[Name] = RTRIM(LTRIM(ISNULL(source.GivenName, '') + ' ' + ISNULL(source.FamilyName, '' ))),
		[ChangedOn] = Source.[ChangedOn] ,
		Email = (select top 1 [Address] from [adapters.google.Emails] E where 
	       E.ContactId = Source.ContactId and len(address)>0 order by [Address]),
		[PrimaryPhonenumber] = (select top 1 Value from [adapters.google.PhoneNumbers] E where 
	       E.ContactId = Source.ContactId and len(Value)>0 order by [Value]),
		Telephone2 = (
		select Value From (
		select Value, ROW_NUMBER() OVER (ORDER BY [Value]) as PhoneOrder from [adapters.google.PhoneNumbers] E where 
			E.ContactId = Source.ContactId and len(Value)>0 ) T where PhoneOrder = 2
		),
		Telephone3 = (
		select Value From (
		select Value, ROW_NUMBER() OVER (ORDER BY [Value]) as PhoneOrder from [adapters.google.PhoneNumbers] E where 
			E.ContactId = Source.ContactId and len(Value)>0 ) T where PhoneOrder = 3
		),
		City = (select top 1 City from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		Street = (select top 1 Street from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		Region = (select top 1 Region from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		Postcode = (select top 1 Postcode from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		Country = (select top 1 Country from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		FormattedAddress = (select top 1 FormattedAddress from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		Note = Source.Content
	when not matched then
	insert ([ExternalId], ChangedOn, Name, [TransformTag], [AdapterId], Email, [PrimaryPhonenumber],  
	Telephone2, Telephone3, City,
	Street, Region, Postcode, Country, FormattedAddress, Note)
	values (Source.[ExternalId], Source.ChangedOn, Source.OrgName,'PO', Source.[AdapterId],
	(select top 1 [Address] from [adapters.google.Emails] E where 
	    E.ContactId = Source.ContactId and len(address)>0 order by [Address]),
	(
	select Value From (
	select Value, ROW_NUMBER() OVER (ORDER BY [Value]) as PhoneOrder from [adapters.google.PhoneNumbers] E where 
		E.ContactId = Source.ContactId and len(Value)>0 ) T where PhoneOrder = 2
	),
	(
	select Value From (
	select Value, ROW_NUMBER() OVER (ORDER BY [Value]) as PhoneOrder from [adapters.google.PhoneNumbers] E where 
		E.ContactId = Source.ContactId and len(Value)>0 ) T where PhoneOrder = 3
	),
	(select top 1 Value from [adapters.google.PhoneNumbers] E where 
	    E.ContactId = Source.ContactId and len(Value)>0 order by [Value]),
	(select top 1 City from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
		(select top 1 Street from [adapters.google.Addresses] E where 
	    E.ContactId = Source.ContactId order by AddressId),
(select top 1 Region from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
 (select top 1 Postcode from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
(select top 1 Country from [adapters.google.Addresses] E where 
	       E.ContactId = Source.ContactId order by AddressId),
			Source.postalAddressFormattedAddress, 
		   Source.Content
	)
;

delete from [adapters.google.PartialAccounts] where len(name)=0 or name is null

end
GO
/****** Object:  StoredProcedure [dbo].[adapters.google.Contacts.changes.proc]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[adapters.google.Contacts.changes.proc] as
delete [adapters.google.Contacts.changes]
INSERT INTO [dbo].[adapters.google.Contacts.changes]
           ([ContactId]
           ,[ChangedOn]
           ,[ExternalId]
           ,[AdapterId]
           ,[Content]
           ,[Title]
           ,[Email]
           ,[GivenName]
           ,[FamilyName]
           ,[OrgDepartment]
           ,[OrgJobDescription]
           ,[OrgName]
           ,[OrgTitle]
           ,[PrimaryPhonenumber]
           ,[postalAddressCity]
           ,[postalAddressStreet]
           ,[postalAddressRegion]
           ,[postalAddressPostcode]
           ,[postalAddressCountry]
           ,[postalAddressFormattedAddress])
select T.[ContactId]
           ,T.[ChangedOn]
           ,T.[ExternalId]
           ,T.[AdapterId]
           ,[Content]
           ,T.[Title]
           ,[Email]
           ,[GivenName]
           ,[FamilyName]
           ,[OrgDepartment]
           ,[OrgJobDescription]
           ,[OrgName]
           ,[OrgTitle]
           ,[PrimaryPhonenumber]
           ,[postalAddressCity]
           ,[postalAddressStreet]
           ,[postalAddressRegion]
           ,[postalAddressPostcode]
           ,[postalAddressCountry]
           ,[postalAddressFormattedAddress] from [dbo].[adapters.google.Contacts] T
inner join [dbo].[adapters.google.GroupMemberships] GM on T.ContactId = GM.ContactId 
inner join [dbo].[adapters.google.Groups] G on G.GroupId = GM.GroupId
where G.Title = 'CERIA'


GO
/****** Object:  StoredProcedure [dbo].[adapters.hikashop.Accounts.proc]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[adapters.hikashop.Accounts.proc] as 

INSERT INTO [dbo].[adapters.hikashop.PartialAccounts]
           ([PartialAccountId]
           ,Name
           ,IC
           ,[dic]
           ,[externalid]
           ,[email]
           ,[PrimaryPhonenumber]
           ,[City]
           ,[Street]
           ,[Region]
           ,[Postcode]
           ,[Country]
		   ,AdapterId
           )

-- osoby
select 
isnull((select AccountID from [dbo].[entities.Accounts] where AdapterId = '18077449-4CB9-4FE2-BE4C-B5AD34AD5AC2' and
ExternalId = address_id and Name = rtrim(ltrim(isnull([address_firstname], '') + ' ' + isnull([address_lastname], '')))
),newid()),

      rtrim(ltrim(isnull([address_firstname], '') + ' ' + isnull([address_lastname], ''))), --,[name]
           NULL, --,[ico]
           address_vat, --,[dic]
           address_id, --,[externalid]
           (select [user_email] from [dbo].[adapters.hikashop.User] U where U.user_id = address_user_id ),--[email]
           address_telephone, --,[PrimaryPhonenumber]
           address_city, --,[City]
           address_street, --,[Street]
           address_state, --,[Region]
           address_post_code, --,[Postcode]
           address_country --,[Country
		   , '18077449-4CB9-4FE2-BE4C-B5AD34AD5AC2'
FROM [dbo].[adapters.hikashop.Address]
where rtrim(ltrim(isnull([address_firstname], '') + ' ' + isnull([address_lastname], ''))) <> ''
UNION


select 
isnull((select AccountID from [dbo].[entities.Accounts] where AdapterId = '18077449-4CB9-4FE2-BE4C-B5AD34AD5AC2' and
ExternalId = address_id and Name = ([address_company])
),newid()),

      [address_company], --,[name]
           NULL, --,[ico]
           address_vat, --,[dic]
           address_id, --,[externalid]
           (select [user_email] from [dbo].[adapters.hikashop.User] U where U.user_id = address_user_id ),--[email]
           address_telephone, --,[PrimaryPhonenumber]
           address_city, --,[City]
           address_street, --,[Street]
           address_state, --,[Region]
           address_post_code, --,[Postcode]
           address_country --,[Country]
		   , '18077449-4CB9-4FE2-BE4C-B5AD34AD5AC2'
		   FROM [dbo].[adapters.hikashop.Address]
where address_company is not null and LEN(address_company) > 0

GO
/****** Object:  StoredProcedure [dbo].[entities.Accounts.google.proc]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[entities.Accounts.google.proc] as 

INSERT INTO [dbo].[entities.Accounts]
           ([AccountId]
           ,[ChangedOn]
           ,[ExternalId]
           ,[AdapterId]
           ,[Name]
           ,[IC]
           ,[DIC]
           ,[Email]
           ,[PrimaryPhonenumber]
           ,[City]
           ,[Street]
           ,[Region]
           ,[Postcode]
           ,[Country]
           ,[FormattedAddress]
           ,[Note]
		   ,[Telephone2]
		   ,[Telephone3]
		   )

SELECT [PartialAccountId]
      ,[ChangedOn]
      ,[ExternalId]
      ,[AdapterId]
      ,[Name]
      ,[IC]
      ,[DIC]
      ,[Email]
      ,[PrimaryPhonenumber]
      ,[City]
      ,[Street]
      ,[Region]
      ,[Postcode]
      ,[Country]
      ,[FormattedAddress]
      ,[Note]
		   ,[Telephone2]
		   ,[Telephone3]
  FROM [dbo].[adapters.google.PartialAccounts]
  WHERE PartialAccountId NOT IN
  (
  select accountid from [entities.Accounts]
  )

GO
/****** Object:  StoredProcedure [dbo].[entities.Accounts.hikashop.proc]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[entities.Accounts.hikashop.proc] as 

INSERT INTO [dbo].[entities.Accounts]
           ([AccountId]
           ,[ChangedOn]
           ,[ExternalId]
           ,[AdapterId]
           ,[Name]
           ,[IC]
           ,[DIC]
           ,[Email]
           ,[PrimaryPhonenumber]
           ,[City]
           ,[Street]
           ,[Region]
           ,[Postcode]
           ,[Country]
           ,[FormattedAddress]
           ,[Note])

SELECT [PartialAccountId]
      ,[ChangedOn]
      ,[ExternalId]
      ,[AdapterId]
      ,[Name]
      ,[IC]
      ,[DIC]
      ,[Email]
      ,[PrimaryPhonenumber]
      ,[City]
      ,[Street]
      ,[Region]
      ,[Postcode]
      ,[Country]
      ,[FormattedAddress]
      ,[Note]
  FROM [dbo].[adapters.hikashop.PartialAccounts]
  WHERE PartialAccountId NOT IN
  (
  select accountid from [entities.Accounts]
  )
  and len(Name)>0 and name is not null

GO
/****** Object:  Table [dbo].[Action_UpdateAccount]    Script Date: 30. 12. 2014 0:07:14 ******/
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
/****** Object:  Table [dbo].[actions.Accounts.create]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[actions.Accounts.create](
	[AccountId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IC] [nvarchar](max) NULL,
	[DIC] [nvarchar](max) NULL,
	[ExternalId] [nvarchar](400) NULL,
	[Email] [nvarchar](max) NULL,
	[PrimaryPhonenumber] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Street] [nvarchar](max) NULL,
	[Region] [nvarchar](max) NULL,
	[Postcode] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateAccountId] [uniqueidentifier] NOT NULL,
	[ChangedOn] [datetimeoffset](7) NULL,
	[AdapterId] [uniqueidentifier] NOT NULL,
	[FormattedAddress] [nvarchar](max) NULL,
 CONSTRAINT [PK_CreateAccountId] PRIMARY KEY CLUSTERED 
(
	[CreateAccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[actions.Accounts.update]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[actions.Accounts.update](
	[AccountId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IC] [nvarchar](max) NULL,
	[DIC] [nvarchar](max) NULL,
	[ExternalId] [nvarchar](400) NULL,
	[Email] [nvarchar](max) NULL,
	[PrimaryPhonenumber] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Street] [nvarchar](max) NULL,
	[Region] [nvarchar](max) NULL,
	[Postcode] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[AdapterId] [uniqueidentifier] NOT NULL,
	[UpdateAccountId] [uniqueidentifier] NOT NULL,
	[ChangedOn] [datetimeoffset](7) NULL,
 CONSTRAINT [PK_UpdateAccountId] PRIMARY KEY CLUSTERED 
(
	[UpdateAccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.google.Addresses]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Addresses](
	[AddressId] [uniqueidentifier] NOT NULL,
	[City] [nvarchar](max) NULL,
	[Street] [nvarchar](max) NULL,
	[Region] [nvarchar](max) NULL,
	[Postcode] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Formatted] [nvarchar](max) NULL,
	[Label] [nvarchar](max) NULL,
	[ContactId] [uniqueidentifier] NOT NULL,
	[Usage] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.google.Contacts]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Contacts](
	[ExternalId] [nvarchar](400) NOT NULL,
	[ChangedOn] [datetimeoffset](7) NULL,
	[Content] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[GivenName] [nvarchar](max) NULL,
	[FamilyName] [nvarchar](max) NULL,
	[OrgDepartment] [nvarchar](max) NULL,
	[OrgJobDescription] [nvarchar](max) NULL,
	[OrgName] [nvarchar](max) NULL,
	[OrgTitle] [nvarchar](max) NULL,
	[PrimaryPhonenumber] [nvarchar](max) NULL,
	[postalAddressCity] [nvarchar](max) NULL,
	[postalAddressStreet] [nvarchar](max) NULL,
	[postalAddressRegion] [nvarchar](max) NULL,
	[postalAddressPostcode] [nvarchar](max) NULL,
	[postalAddressCountry] [nvarchar](max) NULL,
	[postalAddressFormattedAddress] [nvarchar](max) NULL,
	[ContactId] [uniqueidentifier] NOT NULL,
	[AdapterId] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.google.Contacts.changes]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Contacts.changes](
	[ExternalId] [nvarchar](400) NOT NULL,
	[ChangedOn] [datetimeoffset](7) NULL,
	[Content] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[GivenName] [nvarchar](max) NULL,
	[FamilyName] [nvarchar](max) NULL,
	[OrgDepartment] [nvarchar](max) NULL,
	[OrgJobDescription] [nvarchar](max) NULL,
	[OrgName] [nvarchar](max) NULL,
	[OrgTitle] [nvarchar](max) NULL,
	[PrimaryPhonenumber] [nvarchar](max) NULL,
	[postalAddressCity] [nvarchar](max) NULL,
	[postalAddressStreet] [nvarchar](max) NULL,
	[postalAddressRegion] [nvarchar](max) NULL,
	[postalAddressPostcode] [nvarchar](max) NULL,
	[postalAddressCountry] [nvarchar](max) NULL,
	[postalAddressFormattedAddress] [nvarchar](max) NULL,
	[ContactId] [uniqueidentifier] NOT NULL,
	[AdapterId] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.google.Emails]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Emails](
	[EmailId] [uniqueidentifier] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Label] [nvarchar](max) NULL,
	[Home] [bit] NULL,
	[Other] [bit] NULL,
	[Work] [bit] NULL,
	[ContactId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.google.GroupMemberships]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.GroupMemberships](
	[ContactId] [uniqueidentifier] NOT NULL,
	[GroupId] [uniqueidentifier] NOT NULL,
	[GroupMembershipId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupMembershipId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.google.Groups]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Groups](
	[ExternalId] [nvarchar](400) NOT NULL,
	[ChangedOn] [datetimeoffset](7) NULL,
	[Title] [nvarchar](max) NULL,
	[GroupId] [uniqueidentifier] NOT NULL,
	[AdapterId] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.google.PartialAccounts]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.PartialAccounts](
	[PartialAccountId] [uniqueidentifier] NOT NULL,
	[ChangedOn] [datetimeoffset](7) NULL,
	[ExternalId] [nvarchar](800) NULL,
	[AdapterId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IC] [nvarchar](max) NULL,
	[DIC] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[PrimaryPhonenumber] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Street] [nvarchar](max) NULL,
	[Region] [nvarchar](max) NULL,
	[Postcode] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[FormattedAddress] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[TransformTag] [nvarchar](100) NULL,
	[AccountId] [uniqueidentifier] NULL,
	[Telephone2] [nvarchar](max) NULL,
	[Telephone3] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[PartialAccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.google.PhoneNumbers]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.PhoneNumbers](
	[PhoneNumberId] [uniqueidentifier] NOT NULL,
	[Value] [nvarchar](max) NULL,
	[Label] [nvarchar](max) NULL,
	[Home] [bit] NULL,
	[Other] [bit] NULL,
	[Work] [bit] NULL,
	[ContactId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PhoneNumberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.hikashop.Address]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.hikashop.Address](
	[address_id] [int] NOT NULL,
	[address_user_id] [int] NULL,
	[address_title] [nvarchar](max) NULL,
	[address_firstname] [nvarchar](max) NULL,
	[address_middle_name] [nvarchar](max) NULL,
	[address_lastname] [nvarchar](max) NULL,
	[address_company] [nvarchar](max) NULL,
	[address_street] [nvarchar](max) NULL,
	[address_post_code] [nvarchar](max) NULL,
	[address_city] [nvarchar](max) NULL,
	[address_telephone] [nvarchar](max) NULL,
	[address_telephone2] [nvarchar](max) NULL,
	[address_fax] [nvarchar](max) NULL,
	[address_state] [nvarchar](max) NULL,
	[address_country] [nvarchar](max) NULL,
	[address_published] [int] NULL,
	[address_vat] [nvarchar](max) NULL,
	[address_default] [int] NULL,
	[address_street2] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[address_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.hikashop.PartialAccounts]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.hikashop.PartialAccounts](
	[PartialAccountId] [uniqueidentifier] NOT NULL,
	[ChangedOn] [datetimeoffset](7) NULL,
	[ExternalId] [nvarchar](800) NULL,
	[AdapterId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IC] [nvarchar](max) NULL,
	[DIC] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[PrimaryPhonenumber] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Street] [nvarchar](max) NULL,
	[Region] [nvarchar](max) NULL,
	[Postcode] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[FormattedAddress] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[TransformTag] [nvarchar](100) NULL,
	[AccountId] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[PartialAccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.hikashop.User]    Script Date: 30. 12. 2014 0:07:14 ******/
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
/****** Object:  Table [dbo].[adapters.mscrm.PartialAccounts]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.mscrm.PartialAccounts](
	[PartialAccountId] [uniqueidentifier] NOT NULL,
	[AccountCategoryCode] [int] NULL,
	[TerritoryId] [uniqueidentifier] NULL,
	[DefaultPriceLevelId] [uniqueidentifier] NULL,
	[CustomerSizeCode] [int] NULL,
	[PreferredContactMethodCode] [int] NULL,
	[CustomerTypeCode] [int] NULL,
	[AccountRatingCode] [int] NULL,
	[IndustryCode] [int] NULL,
	[TerritoryCode] [int] NULL,
	[AccountClassificationCode] [int] NULL,
	[BusinessTypeCode] [int] NULL,
	[OwningBusinessUnit] [uniqueidentifier] NULL,
	[OriginatingLeadId] [uniqueidentifier] NULL,
	[PaymentTermsCode] [int] NULL,
	[ShippingMethodCode] [int] NULL,
	[PrimaryContactId] [uniqueidentifier] NULL,
	[Name] [nvarchar](160) NULL,
	[AccountNumber] [nvarchar](20) NULL,
	[Revenue] [money] NULL,
	[NumberOfEmployees] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[SIC] [nvarchar](20) NULL,
	[OwnershipCode] [int] NULL,
	[MarketCap] [money] NULL,
	[SharesOutstanding] [int] NULL,
	[TickerSymbol] [nvarchar](10) NULL,
	[StockExchange] [nvarchar](20) NULL,
	[WebSiteURL] [nvarchar](200) NULL,
	[FtpSiteURL] [nvarchar](200) NULL,
	[EMailAddress1] [nvarchar](100) NULL,
	[EMailAddress2] [nvarchar](100) NULL,
	[EMailAddress3] [nvarchar](100) NULL,
	[DoNotPhone] [bit] NULL,
	[DoNotFax] [bit] NULL,
	[Telephone1] [nvarchar](50) NULL,
	[DoNotEMail] [bit] NULL,
	[Telephone2] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[Telephone3] [nvarchar](50) NULL,
	[DoNotPostalMail] [bit] NULL,
	[DoNotBulkEMail] [bit] NULL,
	[DoNotBulkPostalMail] [bit] NULL,
	[CreditLimit] [money] NULL,
	[CreditOnHold] [bit] NULL,
	[IsPrivate] [bit] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[VersionNumber] [timestamp] NULL,
	[ParentAccountId] [uniqueidentifier] NULL,
	[Aging30] [money] NULL,
	[StateCode] [int] NOT NULL,
	[Aging60] [money] NULL,
	[StatusCode] [int] NULL,
	[Aging90] [money] NULL,
	[PreferredAppointmentDayCode] [int] NULL,
	[PreferredSystemUserId] [uniqueidentifier] NULL,
	[PreferredAppointmentTimeCode] [int] NULL,
	[Merged] [bit] NULL,
	[DoNotSendMM] [bit] NULL,
	[MasterId] [uniqueidentifier] NULL,
	[LastUsedInCampaign] [datetime] NULL,
	[PreferredServiceId] [uniqueidentifier] NULL,
	[PreferredEquipmentId] [uniqueidentifier] NULL,
	[ExchangeRate] [decimal](23, 10) NULL,
	[UTCConversionTimeZoneCode] [int] NULL,
	[OverriddenCreatedOn] [datetime] NULL,
	[TimeZoneRuleVersionNumber] [int] NULL,
	[ImportSequenceNumber] [int] NULL,
	[TransactionCurrencyId] [uniqueidentifier] NULL,
	[CreditLimit_Base] [money] NULL,
	[Aging30_Base] [money] NULL,
	[Revenue_Base] [money] NULL,
	[Aging90_Base] [money] NULL,
	[MarketCap_Base] [money] NULL,
	[Aging60_Base] [money] NULL,
	[YomiName] [nvarchar](160) NULL,
	[OwnerId] [uniqueidentifier] NOT NULL,
	[ModifiedOnBehalfBy] [uniqueidentifier] NULL,
	[CreatedOnBehalfBy] [uniqueidentifier] NULL,
	[OwnerIdType] [int] NOT NULL,
	[StageId] [uniqueidentifier] NULL,
	[ProcessId] [uniqueidentifier] NULL,
	[EntityImageId] [uniqueidentifier] NULL,
	[new_dic] [nvarchar](100) NULL,
	[new_ic] [nvarchar](10) NULL,
	[AccountId] [uniqueidentifier] NULL,
	[address1_city] [nvarchar](max) NULL,
	[address1_country] [nvarchar](max) NULL,
	[address1_line1] [nvarchar](max) NULL,
	[address1_postalcode] [nvarchar](max) NULL,
	[address1_telephone1] [nvarchar](max) NULL,
	[adapterid] [uniqueidentifier] NULL,
	[new_Zdroj] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[PartialAccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[entities.Accounts]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entities.Accounts](
	[AccountId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IC] [nvarchar](max) NULL,
	[DIC] [nvarchar](max) NULL,
	[ExternalId] [nvarchar](400) NULL,
	[Email] [nvarchar](max) NULL,
	[PrimaryPhonenumber] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Street] [nvarchar](max) NULL,
	[Region] [nvarchar](max) NULL,
	[Postcode] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[FormattedAddress] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[ChangedOn] [datetimeoffset](7) NULL,
	[AdapterId] [uniqueidentifier] NULL,
	[OldAccountId] [uniqueidentifier] NULL,
	[Telephone2] [nvarchar](max) NULL,
	[Telephone3] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sync.Adapters]    Script Date: 30. 12. 2014 0:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sync.Adapters](
	[AdapterId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[AdapterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Index [IX_ContactId]    Script Date: 30. 12. 2014 0:07:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContactId] ON [dbo].[adapters.google.Addresses]
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContactId]    Script Date: 30. 12. 2014 0:07:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContactId] ON [dbo].[adapters.google.PhoneNumbers]
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Value]    Script Date: 30. 12. 2014 0:07:14 ******/
CREATE NONCLUSTERED INDEX [IX_Value] ON [dbo].[adapters.google.PhoneNumbers]
(
	[PhoneNumberId] ASC
)
INCLUDE ( 	[Value]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[adapters.google.Addresses] ADD  DEFAULT (newid()) FOR [AddressId]
GO
ALTER TABLE [dbo].[adapters.google.Emails] ADD  DEFAULT (newid()) FOR [EmailId]
GO
ALTER TABLE [dbo].[adapters.google.GroupMemberships] ADD  DEFAULT (newid()) FOR [GroupMembershipId]
GO
ALTER TABLE [dbo].[adapters.google.Groups] ADD  DEFAULT (newid()) FOR [GroupId]
GO
ALTER TABLE [dbo].[adapters.google.PartialAccounts] ADD  DEFAULT (newid()) FOR [PartialAccountId]
GO
ALTER TABLE [dbo].[adapters.google.PhoneNumbers] ADD  DEFAULT (newid()) FOR [PhoneNumberId]
GO
ALTER TABLE [dbo].[adapters.hikashop.PartialAccounts] ADD  DEFAULT (newid()) FOR [PartialAccountId]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [DF_AccountBase_DoNotPhone]  DEFAULT ((0)) FOR [DoNotPhone]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [DF_AccountBase_DoNotFax]  DEFAULT ((0)) FOR [DoNotFax]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [DF_AccountBase_DoNotEMail]  DEFAULT ((0)) FOR [DoNotEMail]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [DF_AccountBase_DoNotPostalMail]  DEFAULT ((0)) FOR [DoNotPostalMail]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [DF_AccountBase_DoNotBulkEMail]  DEFAULT ((0)) FOR [DoNotBulkEMail]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [DF_AccountBase_DoNotBulkPostalMail]  DEFAULT ((0)) FOR [DoNotBulkPostalMail]
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] ADD  CONSTRAINT [Set_To_Zero94]  DEFAULT ((0)) FOR [IsPrivate]
GO
ALTER TABLE [dbo].[sync.Adapters] ADD  DEFAULT (newid()) FOR [AdapterId]
GO
ALTER TABLE [dbo].[actions.Accounts.create]  WITH CHECK ADD FOREIGN KEY([AccountId])
REFERENCES [dbo].[entities.Accounts] ([AccountId])
GO
ALTER TABLE [dbo].[actions.Accounts.create]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
ALTER TABLE [dbo].[actions.Accounts.update]  WITH CHECK ADD FOREIGN KEY([AccountId])
REFERENCES [dbo].[entities.Accounts] ([AccountId])
GO
ALTER TABLE [dbo].[actions.Accounts.update]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
ALTER TABLE [dbo].[adapters.google.Emails]  WITH CHECK ADD FOREIGN KEY([ContactId])
REFERENCES [dbo].[adapters.google.Contacts] ([ContactId])
GO
ALTER TABLE [dbo].[adapters.google.GroupMemberships]  WITH CHECK ADD FOREIGN KEY([ContactId])
REFERENCES [dbo].[adapters.google.Contacts] ([ContactId])
GO
ALTER TABLE [dbo].[adapters.google.GroupMemberships]  WITH CHECK ADD FOREIGN KEY([GroupId])
REFERENCES [dbo].[adapters.google.Groups] ([GroupId])
GO
ALTER TABLE [dbo].[adapters.google.PartialAccounts]  WITH CHECK ADD FOREIGN KEY([AccountId])
REFERENCES [dbo].[entities.Accounts] ([AccountId])
GO
ALTER TABLE [dbo].[adapters.google.PartialAccounts]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
ALTER TABLE [dbo].[adapters.google.PhoneNumbers]  WITH CHECK ADD FOREIGN KEY([ContactId])
REFERENCES [dbo].[adapters.google.Contacts] ([ContactId])
GO
ALTER TABLE [dbo].[adapters.hikashop.PartialAccounts]  WITH CHECK ADD FOREIGN KEY([AccountId])
REFERENCES [dbo].[entities.Accounts] ([AccountId])
GO
ALTER TABLE [dbo].[adapters.hikashop.PartialAccounts]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts]  WITH CHECK ADD  CONSTRAINT [fk_AccountId] FOREIGN KEY([AccountId])
REFERENCES [dbo].[entities.Accounts] ([AccountId])
GO
ALTER TABLE [dbo].[adapters.mscrm.PartialAccounts] CHECK CONSTRAINT [fk_AccountId]
GO
ALTER TABLE [dbo].[entities.Accounts]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
USE [master]
GO
ALTER DATABASE [SyncToday2015] SET  READ_WRITE 
GO
