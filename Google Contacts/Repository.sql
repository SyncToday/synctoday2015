drop Table Google_Contacts_Group

Create Table Google_Contacts_Group (
  id nvarchar(400) primary key,
  updated datetimeoffset,
  title nvarchar(max)
)

CREATE TABLE [dbo].[Google_Contacts_Contact](
	[id] [nvarchar](400) primary key,
	[updated] [datetimeoffset](7) NULL,
	content [nvarchar](max) NULL,
	title [nvarchar](max) NULL,
	email [nvarchar](max) NULL,
	givenName [nvarchar](max) NULL,
	familyName [nvarchar](max) NULL,
	orgDepartment [nvarchar](max) NULL,
	orgJobDescription [nvarchar](max) NULL,
	orgName [nvarchar](max) NULL,
	orgTitle [nvarchar](max) NULL,
	GroupID [nvarchar](400) references [Google_Contacts_Group]([id])
)
