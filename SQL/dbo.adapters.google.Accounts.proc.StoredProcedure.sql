USE [SyncToday2015]
GO
/****** Object:  StoredProcedure [dbo].[adapters.google.Accounts.proc]    Script Date: 30. 12. 2014 0:06:34 ******/
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
