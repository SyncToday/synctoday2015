drop Table Google_Contacts_Group

Create Table Google_Contacts_Group (
  id nvarchar(400) primary key,
  updated datetimeoffset,
  title nvarchar(max)
)