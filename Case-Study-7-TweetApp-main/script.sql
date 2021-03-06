USE [master]
GO
/****** Object:  Database [TweetDB]    Script Date: 7/23/2022 4:08:54 PM ******/
CREATE DATABASE [TweetDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TweetDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TweetDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TweetDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TweetDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TweetDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TweetDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TweetDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TweetDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TweetDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TweetDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TweetDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TweetDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TweetDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TweetDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TweetDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TweetDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TweetDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TweetDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TweetDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TweetDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TweetDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TweetDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TweetDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TweetDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TweetDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TweetDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TweetDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TweetDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TweetDB] SET RECOVERY FULL 
GO
ALTER DATABASE [TweetDB] SET  MULTI_USER 
GO
ALTER DATABASE [TweetDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TweetDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TweetDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TweetDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TweetDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TweetDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TweetDB', N'ON'
GO
ALTER DATABASE [TweetDB] SET QUERY_STORE = OFF
GO
USE [TweetDB]
GO
/****** Object:  Table [dbo].[TblLogin]    Script Date: 7/23/2022 4:08:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblLogin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[LoginId] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
	[ConfirmPassword] [nvarchar](100) NULL,
	[ContactNumber] [numeric](10, 0) NULL,
 CONSTRAINT [PK_TblLogin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblTweet]    Script Date: 7/23/2022 4:08:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTweet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AuthorEmail] [nvarchar](100) NULL,
	[AuthorLogo] [nvarchar](100) NULL,
	[AuthorSlug] [nvarchar](100) NULL,
	[TweetTime] [nvarchar](100) NULL,
	[TweetDescription] [nvarchar](1000) NULL,
	[TweetImage] [nvarchar](100) NULL,
 CONSTRAINT [PK_TblTweet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblLogin] ON 

INSERT [dbo].[TblLogin] ([Id], [FirstName], [LastName], [Email], [LoginId], [Password], [ConfirmPassword], [ContactNumber]) VALUES (1, N'Pragati', N'Tanpure', N'pragati@gmail.com', N'1234', N'1234567', N'1234567', CAST(9999999999 AS Numeric(10, 0)))
INSERT [dbo].[TblLogin] ([Id], [FirstName], [LastName], [Email], [LoginId], [Password], [ConfirmPassword], [ContactNumber]) VALUES (2, N'Anandi', N'Kale', N'anandi@gmail.com', N'12', N'121212', N'121212', CAST(7777777777 AS Numeric(10, 0)))
INSERT [dbo].[TblLogin] ([Id], [FirstName], [LastName], [Email], [LoginId], [Password], [ConfirmPassword], [ContactNumber]) VALUES (4, N'Priyanka', N'shete', N'priyanka@gmail.com', N'123', N'1234', N'1234', CAST(6666666666 AS Numeric(10, 0)))
INSERT [dbo].[TblLogin] ([Id], [FirstName], [LastName], [Email], [LoginId], [Password], [ConfirmPassword], [ContactNumber]) VALUES (5, N'Tanu', N'Shete', N'tanu@gmail.com', N'tanu123', N'tanu@123', N'tanu@123', CAST(7865434567 AS Numeric(10, 0)))
INSERT [dbo].[TblLogin] ([Id], [FirstName], [LastName], [Email], [LoginId], [Password], [ConfirmPassword], [ContactNumber]) VALUES (8, N'Narendra ', N'Modi', N'pmmodi@gmail.com', N'@PM', N'PM@123', N'PM@123', CAST(8976564534 AS Numeric(10, 0)))
INSERT [dbo].[TblLogin] ([Id], [FirstName], [LastName], [Email], [LoginId], [Password], [ConfirmPassword], [ContactNumber]) VALUES (9, N'Jamyang Tsering', N'Namgyal', N'jamyang@gmail.com', N'jam123', N'jamyang@123', N'jamyang@123', CAST(7654323456 AS Numeric(10, 0)))
INSERT [dbo].[TblLogin] ([Id], [FirstName], [LastName], [Email], [LoginId], [Password], [ConfirmPassword], [ContactNumber]) VALUES (10, N'NASA Webb', N'Telescope', N'NASAWeb@yahoo.com', N'NASAWeb@2323', N'@itiNasa', N'@itiNasa', CAST(9876543456 AS Numeric(10, 0)))
INSERT [dbo].[TblLogin] ([Id], [FirstName], [LastName], [Email], [LoginId], [Password], [ConfirmPassword], [ContactNumber]) VALUES (12, N'vaishnavi', N'Ingale', N'vaishu@gmail.com', N'1234', N'vaishu@123', N'vaishu@123', CAST(7654345678 AS Numeric(10, 0)))
INSERT [dbo].[TblLogin] ([Id], [FirstName], [LastName], [Email], [LoginId], [Password], [ConfirmPassword], [ContactNumber]) VALUES (15, N'Megha', N'Sarode', N'megh@gmail.com', N'123', N'megh@123', N'megh@123', CAST(7865456789 AS Numeric(10, 0)))
INSERT [dbo].[TblLogin] ([Id], [FirstName], [LastName], [Email], [LoginId], [Password], [ConfirmPassword], [ContactNumber]) VALUES (16, NULL, NULL, N'asd@asd', NULL, N'asdasd', NULL, CAST(0 AS Numeric(10, 0)))
SET IDENTITY_INSERT [dbo].[TblLogin] OFF
GO
SET IDENTITY_INSERT [dbo].[TblTweet] ON 

INSERT [dbo].[TblTweet] ([Id], [AuthorEmail], [AuthorLogo], [AuthorSlug], [TweetTime], [TweetDescription], [TweetImage]) VALUES (1, NULL, N'', N'@asdasd', N'7/23/2022 2:57:15 PM', N'Hi this is my first tweet', N'')
INSERT [dbo].[TblTweet] ([Id], [AuthorEmail], [AuthorLogo], [AuthorSlug], [TweetTime], [TweetDescription], [TweetImage]) VALUES (2, NULL, N'', N'asd', N'7/23/2022 2:58:30 PM', N'adsasd', N'')
INSERT [dbo].[TblTweet] ([Id], [AuthorEmail], [AuthorLogo], [AuthorSlug], [TweetTime], [TweetDescription], [TweetImage]) VALUES (3, N'pragati@gmail.com', N'', N'asd', N'7/23/2022 3:00:57 PM', N'asd', N'')
INSERT [dbo].[TblTweet] ([Id], [AuthorEmail], [AuthorLogo], [AuthorSlug], [TweetTime], [TweetDescription], [TweetImage]) VALUES (4, N'pragati@gmail.com', N'', N'@', N'7/23/2022 3:16:18 PM', N'', N'')
INSERT [dbo].[TblTweet] ([Id], [AuthorEmail], [AuthorLogo], [AuthorSlug], [TweetTime], [TweetDescription], [TweetImage]) VALUES (5, N'pragati@gmail.com', N'', N'@vikash', N'7/23/2022 3:41:03 PM', N'Hi this is my new tweet', N'C:\fakepath\snm.jpg')
INSERT [dbo].[TblTweet] ([Id], [AuthorEmail], [AuthorLogo], [AuthorSlug], [TweetTime], [TweetDescription], [TweetImage]) VALUES (6, N'pragati@gmail.com', N'', N'@asd', N'7/23/2022 3:45:35 PM', N'asd', N'C:\fakepath\download12.jpg')
INSERT [dbo].[TblTweet] ([Id], [AuthorEmail], [AuthorLogo], [AuthorSlug], [TweetTime], [TweetDescription], [TweetImage]) VALUES (7, N'pragati@gmail.com', N'', N'@asd', N'7/23/2022 3:50:06 PM', N'asd', N'C:\fakepath\adsasd.jpg')
INSERT [dbo].[TblTweet] ([Id], [AuthorEmail], [AuthorLogo], [AuthorSlug], [TweetTime], [TweetDescription], [TweetImage]) VALUES (8, N'pragati@gmail.com', N'', N'@asd', N'7/23/2022 3:51:55 PM', N'asd', N'https://testaccountimage007.blob.core.windows.net/images/asdasd.jpg')
SET IDENTITY_INSERT [dbo].[TblTweet] OFF
GO
USE [master]
GO
ALTER DATABASE [TweetDB] SET  READ_WRITE 
GO
