USE [master]
GO
/****** Object:  Database [SyncToday2015]    Script Date: 26. 12. 2014 16:18:05 ******/
CREATE DATABASE [SyncToday2015]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SyncToday2015', FILENAME = N'C:\Users\david.podhola\SyncToday2015new.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SyncToday2015_log', FILENAME = N'C:\Users\david.podhola\SyncToday2015new.ldf' , SIZE = 12352KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
ALTER DATABASE [SyncToday2015] SET RECOVERY SIMPLE 
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
/****** Object:  Table [dbo].[adapters.google.Accounts]    Script Date: 26. 12. 2014 16:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Accounts](
	[AccountId] [uniqueidentifier] NOT NULL,
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
PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.google.Addresses]    Script Date: 26. 12. 2014 16:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Addresses](
	[AddressId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
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
/****** Object:  Table [dbo].[adapters.google.Contacts]    Script Date: 26. 12. 2014 16:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Contacts](
	[ContactId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[ChangedOn] [datetimeoffset](7) NULL,
	[ExternalId] [nvarchar](800) NULL,
	[AdapterId] [uniqueidentifier] NOT NULL,
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
PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.google.Emails]    Script Date: 26. 12. 2014 16:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Emails](
	[EmailId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
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
/****** Object:  Table [dbo].[adapters.google.GroupMemberships]    Script Date: 26. 12. 2014 16:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.GroupMemberships](
	[ContactId] [uniqueidentifier] NOT NULL,
	[GroupId] [uniqueidentifier] NOT NULL,
	[GroupMembershipId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
PRIMARY KEY CLUSTERED 
(
	[GroupMembershipId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.google.Groups]    Script Date: 26. 12. 2014 16:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.Groups](
	[GroupId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[ChangedOn] [datetimeoffset](7) NULL,
	[ExternalId] [nvarchar](max) NULL,
	[AdapterId] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adapters.google.PhoneNumbers]    Script Date: 26. 12. 2014 16:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adapters.google.PhoneNumbers](
	[PhoneNumberId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
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
/****** Object:  Table [dbo].[sync.Adapters]    Script Date: 26. 12. 2014 16:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sync.Adapters](
	[AdapterId] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[Name] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[AdapterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_ExternalId]    Script Date: 26. 12. 2014 16:18:05 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_ExternalId] ON [dbo].[adapters.google.Accounts]
(
	[ExternalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Name]    Script Date: 26. 12. 2014 16:18:05 ******/
CREATE NONCLUSTERED INDEX [IX_Name] ON [dbo].[adapters.google.Accounts]
(
	[AccountId] ASC
)
INCLUDE ( 	[Name]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_ExternalId]    Script Date: 26. 12. 2014 16:18:05 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_ExternalId] ON [dbo].[adapters.google.Contacts]
(
	[ExternalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Title]    Script Date: 26. 12. 2014 16:18:05 ******/
CREATE NONCLUSTERED INDEX [IX_Title] ON [dbo].[adapters.google.Contacts]
(
	[ContactId] ASC
)
INCLUDE ( 	[Title]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PK]    Script Date: 26. 12. 2014 16:18:05 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_PK] ON [dbo].[adapters.google.GroupMemberships]
(
	[ContactId] ASC,
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_ExternalId]    Script Date: 26. 12. 2014 16:18:05 ******/
CREATE NONCLUSTERED INDEX [IX_ExternalId] ON [dbo].[adapters.google.Groups]
(
	[GroupId] ASC
)
INCLUDE ( 	[ExternalId]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[adapters.google.Accounts] ADD  DEFAULT (newid()) FOR [AccountId]
GO
ALTER TABLE [dbo].[adapters.google.Accounts]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
ALTER TABLE [dbo].[adapters.google.Addresses]  WITH CHECK ADD FOREIGN KEY([ContactId])
REFERENCES [dbo].[adapters.google.Contacts] ([ContactId])
GO
ALTER TABLE [dbo].[adapters.google.Contacts]  WITH CHECK ADD FOREIGN KEY([AdapterId])
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
ALTER TABLE [dbo].[adapters.google.Groups]  WITH CHECK ADD FOREIGN KEY([AdapterId])
REFERENCES [dbo].[sync.Adapters] ([AdapterId])
GO
ALTER TABLE [dbo].[adapters.google.PhoneNumbers]  WITH CHECK ADD FOREIGN KEY([ContactId])
REFERENCES [dbo].[adapters.google.Contacts] ([ContactId])
GO
USE [master]
GO
ALTER DATABASE [SyncToday2015] SET  READ_WRITE 
GO
