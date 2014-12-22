USE [SyncToday2015]
GO

select * from
(
select *,
( select ISNULL([LastModified], /*DATEFROMPARTS(1975,12,22)*/ getdate() ) from Account A where A.internalid = T.internalid ) as Account_LastModified_A
,( select [ModifiedOn] from [dbo].[MSCRM_Companies_Account] M where cast(M.accountId as nvarchar(max) )  = T.externalid ) as Account_LastModified_M
 from 
(
SELECT [internalid]
      ,ISNULL(A.[name], '') as name
      ,ISNULL(A.[ico], '') as ico
      ,ISNULL(A.[dic], '') as dic
      ,ISNULL(A.[externalid], '') as externalid
      ,ISNULL(A.[email], '') as email
      ,ISNULL(A.[PrimaryPhonenumber], '') as [PrimaryPhonenumber]
      ,ISNULL(A.[City], '') as [City]
      ,ISNULL(A.[Street], '') as [Street]
      ,ISNULL(A.[Region], '') as [Region]
      ,ISNULL(A.[Postcode], '') as [Postcode]
      ,ISNULL(A.[Country], '') as [Country]
      ,ISNULL(A.[FormattedAddress], '') as [FormattedAddress]
      ,ISNULL(A.[note], '') as [note]
FROM [dbo].[Account] A inner join [dbo].[MSCRM_Companies_Account] M on cast(M.accountId as nvarchar(max) )  = A.externalid
except
SELECT [internalid]
      ,ISNULL(M.[name],'')
      ,ISNULL(M.[new_ico],'')
      ,ISNULL(M.[new_dic],'')
      ,cast(M.accountId as nvarchar(max) ) 
      ,ISNULL(M.[EMailAddress1],'')
      ,ISNULL(M.[Telephone1],'')
      ,ISNULL(M.address1_city,'')
      ,ISNULL(M.address1_line1,'')
      ,ISNULL(A.Region,'')
      ,ISNULL(M.address1_postalcode,'')
      ,ISNULL(M.address1_country,'')
      ,ISNULL(A.[FormattedAddress],'')
      ,ISNULL(M.Description,'')
  FROM [dbo].[Account] A inner join [dbo].[MSCRM_Companies_Account] M on cast(M.accountId as nvarchar(max) )  = A.externalid
) T
) U where Account_LastModified_M < Account_LastModified_A