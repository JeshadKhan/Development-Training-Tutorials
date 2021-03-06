USE [master]
GO
/****** Object:  Database [DataCachingTest]    Script Date: 03/24/2016 23:21:17 ******/
CREATE DATABASE [DataCachingTest] ON  PRIMARY 
( NAME = N'DataCachingTest', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\DataCachingTest.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DataCachingTest_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\DataCachingTest_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DataCachingTest] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DataCachingTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DataCachingTest] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [DataCachingTest] SET ANSI_NULLS OFF
GO
ALTER DATABASE [DataCachingTest] SET ANSI_PADDING OFF
GO
ALTER DATABASE [DataCachingTest] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [DataCachingTest] SET ARITHABORT OFF
GO
ALTER DATABASE [DataCachingTest] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [DataCachingTest] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [DataCachingTest] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [DataCachingTest] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [DataCachingTest] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [DataCachingTest] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [DataCachingTest] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [DataCachingTest] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [DataCachingTest] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [DataCachingTest] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [DataCachingTest] SET  DISABLE_BROKER
GO
ALTER DATABASE [DataCachingTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [DataCachingTest] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [DataCachingTest] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [DataCachingTest] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [DataCachingTest] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [DataCachingTest] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [DataCachingTest] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [DataCachingTest] SET  READ_WRITE
GO
ALTER DATABASE [DataCachingTest] SET RECOVERY SIMPLE
GO
ALTER DATABASE [DataCachingTest] SET  MULTI_USER
GO
ALTER DATABASE [DataCachingTest] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [DataCachingTest] SET DB_CHAINING OFF
GO
USE [DataCachingTest]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 03/24/2016 23:21:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](50) NOT NULL,
	[FirstName] [nchar](50) NOT NULL,
	[LastName] [nchar](50) NULL,
	[Topic] [nchar](30) NOT NULL,
	[Publisher] [nchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Author] ON
INSERT [dbo].[Author] ([ID], [Title], [FirstName], [LastName], [Topic], [Publisher]) VALUES (1, N'Book 1                                            ', N'John                                              ', N'Johns                                             ', N'Programming                   ', N'Rayans                                            ')
INSERT [dbo].[Author] ([ID], [Title], [FirstName], [LastName], [Topic], [Publisher]) VALUES (2, N'Book 2                                            ', N'Jack                                              ', N'Walter                                            ', N'Philosophy                    ', N'MegaMind                                          ')
INSERT [dbo].[Author] ([ID], [Title], [FirstName], [LastName], [Topic], [Publisher]) VALUES (3, N'Book 3                                            ', N'Solo                                              ', N'America                                           ', N'War                           ', N'Unclee                                            ')
SET IDENTITY_INSERT [dbo].[Author] OFF
