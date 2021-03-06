USE [master]
GO
/****** Object:  Database [UserLoginSystem]    Script Date: 03/24/2016 22:58:07 ******/
CREATE DATABASE [UserLoginSystem] ON  PRIMARY 
( NAME = N'UserLoginSystem', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\UserLoginSystem.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UserLoginSystem_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\UserLoginSystem_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [UserLoginSystem] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UserLoginSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UserLoginSystem] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [UserLoginSystem] SET ANSI_NULLS OFF
GO
ALTER DATABASE [UserLoginSystem] SET ANSI_PADDING OFF
GO
ALTER DATABASE [UserLoginSystem] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [UserLoginSystem] SET ARITHABORT OFF
GO
ALTER DATABASE [UserLoginSystem] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [UserLoginSystem] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [UserLoginSystem] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [UserLoginSystem] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [UserLoginSystem] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [UserLoginSystem] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [UserLoginSystem] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [UserLoginSystem] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [UserLoginSystem] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [UserLoginSystem] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [UserLoginSystem] SET  DISABLE_BROKER
GO
ALTER DATABASE [UserLoginSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [UserLoginSystem] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [UserLoginSystem] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [UserLoginSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [UserLoginSystem] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [UserLoginSystem] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [UserLoginSystem] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [UserLoginSystem] SET  READ_WRITE
GO
ALTER DATABASE [UserLoginSystem] SET RECOVERY SIMPLE
GO
ALTER DATABASE [UserLoginSystem] SET  MULTI_USER
GO
ALTER DATABASE [UserLoginSystem] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [UserLoginSystem] SET DB_CHAINING OFF
GO
USE [UserLoginSystem]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 03/24/2016 22:58:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](50) NOT NULL,
	[LastName] [nchar](50) NULL,
	[FullName] [nchar](100) NOT NULL,
	[Email] [nchar](50) NOT NULL,
	[SecurityPassword] [nchar](200) NOT NULL,
	[SecurityQuestion] [nchar](50) NOT NULL,
	[SecurityAnswer] [nchar](50) NOT NULL,
	[ActivationStatus] [char](1) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [FullName], [Email], [SecurityPassword], [SecurityQuestion], [SecurityAnswer], [ActivationStatus]) VALUES (10, N'SUPER                                             ', N'ADMIN                                             ', N'SUPER ADMIN                                                                                         ', N'admin                                             ', N'xXPFxGE4IzXxrIhGCSLQKw==                                                                                                                                                                                ', N'Who?                                              ', N'Admin                                             ', N'Y')
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [FullName], [Email], [SecurityPassword], [SecurityQuestion], [SecurityAnswer], [ActivationStatus]) VALUES (12, N'Jeshad                                            ', N'Khan                                              ', N'Jeshad Khan                                                                                         ', N'jeshadkhan@gmail.com                              ', N'xXPFxGE4IzXxrIhGCSLQKw==                                                                                                                                                                                ', N'Who?                                              ', N'JK                                                ', N'Y')
SET IDENTITY_INSERT [dbo].[Users] OFF
