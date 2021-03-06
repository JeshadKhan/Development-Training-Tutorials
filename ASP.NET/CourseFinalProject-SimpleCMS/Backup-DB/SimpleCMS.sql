USE [master]
GO
/****** Object:  Database [SimpleCMS]    Script Date: 7/15/2016 1:55:45 AM ******/
CREATE DATABASE [SimpleCMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SimpleCMS', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.JESHADKHAN\MSSQL\DATA\SimpleCMS.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SimpleCMS_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.JESHADKHAN\MSSQL\DATA\SimpleCMS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SimpleCMS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SimpleCMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SimpleCMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SimpleCMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SimpleCMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SimpleCMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SimpleCMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [SimpleCMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SimpleCMS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SimpleCMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SimpleCMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SimpleCMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SimpleCMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SimpleCMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SimpleCMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SimpleCMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SimpleCMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SimpleCMS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SimpleCMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SimpleCMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SimpleCMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SimpleCMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SimpleCMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SimpleCMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SimpleCMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SimpleCMS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SimpleCMS] SET  MULTI_USER 
GO
ALTER DATABASE [SimpleCMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SimpleCMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SimpleCMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SimpleCMS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SimpleCMS]
GO
/****** Object:  Table [dbo].[Posts]    Script Date: 7/15/2016 1:55:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NOT NULL,
	[Content] [text] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DatePublished] [datetime] NULL,
	[AuthorId] [int] NOT NULL,
	[Slug] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PostsTagsMap]    Script Date: 7/15/2016 1:55:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostsTagsMap](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PostId] [int] NOT NULL,
	[TagId] [int] NOT NULL,
 CONSTRAINT [PK_PostsTagsMap] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Roles]    Script Date: 7/15/2016 1:55:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tags]    Script Date: 7/15/2016 1:55:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tags](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[UrlFriendlyName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/15/2016 1:55:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](250) NOT NULL,
	[Email] [nvarchar](75) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsersRolesMap]    Script Date: 7/15/2016 1:55:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersRolesMap](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_UsersRolesMap] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Posts] ON 

INSERT [dbo].[Posts] ([Id], [Title], [Content], [DateCreated], [DatePublished], [AuthorId], [Slug]) VALUES (2, N'title', N'title', CAST(0x0000A63B00DDDA40 AS DateTime), CAST(0x0000A65300000000 AS DateTime), 2, N'title')
INSERT [dbo].[Posts] ([Id], [Title], [Content], [DateCreated], [DatePublished], [AuthorId], [Slug]) VALUES (1005, N'third', N'post', CAST(0x0000A6420007B13E AS DateTime), CAST(0x0000A64000000000 AS DateTime), 2, N'third')
INSERT [dbo].[Posts] ([Id], [Title], [Content], [DateCreated], [DatePublished], [AuthorId], [Slug]) VALUES (1006, N'four', N'post', CAST(0x0000A6420007E24C AS DateTime), CAST(0x0000A64000000000 AS DateTime), 2, N'four')
INSERT [dbo].[Posts] ([Id], [Title], [Content], [DateCreated], [DatePublished], [AuthorId], [Slug]) VALUES (1007, N'six', N'six con', CAST(0x0000A6440010E7E4 AS DateTime), CAST(0x0000A64400000000 AS DateTime), 2, N'six')
SET IDENTITY_INSERT [dbo].[Posts] OFF
SET IDENTITY_INSERT [dbo].[PostsTagsMap] ON 

INSERT [dbo].[PostsTagsMap] ([Id], [PostId], [TagId]) VALUES (1, 1, 2)
INSERT [dbo].[PostsTagsMap] ([Id], [PostId], [TagId]) VALUES (2, 2, 3)
INSERT [dbo].[PostsTagsMap] ([Id], [PostId], [TagId]) VALUES (3, 1, 3)
INSERT [dbo].[PostsTagsMap] ([Id], [PostId], [TagId]) VALUES (4, 2, 1)
INSERT [dbo].[PostsTagsMap] ([Id], [PostId], [TagId]) VALUES (18, 1006, 4)
INSERT [dbo].[PostsTagsMap] ([Id], [PostId], [TagId]) VALUES (20, 1005, 2)
INSERT [dbo].[PostsTagsMap] ([Id], [PostId], [TagId]) VALUES (21, 1007, 2)
INSERT [dbo].[PostsTagsMap] ([Id], [PostId], [TagId]) VALUES (22, 1007, 3)
INSERT [dbo].[PostsTagsMap] ([Id], [PostId], [TagId]) VALUES (23, 1007, 4)
SET IDENTITY_INSERT [dbo].[PostsTagsMap] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Name]) VALUES (2, N'administrator')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (3, N'user')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (4, N'super administrator')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (5, N'editor')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (6, N'author')
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[Tags] ON 

INSERT [dbo].[Tags] ([Id], [Name], [UrlFriendlyName]) VALUES (1, N'Nice Sun', N'nice-sun')
INSERT [dbo].[Tags] ([Id], [Name], [UrlFriendlyName]) VALUES (2, N'wow moon', N'wow-moon')
INSERT [dbo].[Tags] ([Id], [Name], [UrlFriendlyName]) VALUES (3, N'green tree', N'green-tree')
INSERT [dbo].[Tags] ([Id], [Name], [UrlFriendlyName]) VALUES (4, N'dark night', N'dark-night')
SET IDENTITY_INSERT [dbo].[Tags] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [UserName], [Password], [Email]) VALUES (2, N'admin', N'AEQi6cbCoXHVnUtHqcx2PVR/fFUim0lvBYnJBHHDn7vQhlm9h2fij7Gm9qV65/sFCw==', N'admin@admin.in')
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Email]) VALUES (4, N'editor', N'AMMIbw1nwr96YrtbWfUnYfYszoQvz/8L+/MlNoKhg5jUZfSXT8xOTV6rarBhr0Rt4A==', N'editor@editor.editor')
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Email]) VALUES (5, N'author', N'AAlXGhjddJE+OFLKe8IQvim+Rs+UuOcAAONWV2zBb4KFCFExDSLOI57pz7vpTFxgxw==', N'author@author.author')
SET IDENTITY_INSERT [dbo].[Users] OFF
SET IDENTITY_INSERT [dbo].[UsersRolesMap] ON 

INSERT [dbo].[UsersRolesMap] ([Id], [UserId], [RoleId]) VALUES (7, 3, 3)
INSERT [dbo].[UsersRolesMap] ([Id], [UserId], [RoleId]) VALUES (9, 2, 4)
INSERT [dbo].[UsersRolesMap] ([Id], [UserId], [RoleId]) VALUES (10, 4, 5)
INSERT [dbo].[UsersRolesMap] ([Id], [UserId], [RoleId]) VALUES (11, 5, 6)
SET IDENTITY_INSERT [dbo].[UsersRolesMap] OFF
ALTER TABLE [dbo].[Posts] ADD  CONSTRAINT [DF_Posts_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
USE [master]
GO
ALTER DATABASE [SimpleCMS] SET  READ_WRITE 
GO
