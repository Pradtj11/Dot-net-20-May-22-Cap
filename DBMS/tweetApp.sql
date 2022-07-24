USE [master]
GO
/****** Object:  Database [TweetDB]    Script Date: 7/24/2022 2:46:05 PM ******/
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
/****** Object:  Table [dbo].[TblLogin]    Script Date: 7/24/2022 2:46:05 PM ******/
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
	[ContactNumber] [int] NULL,
 CONSTRAINT [PK_TblLogin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblTweet]    Script Date: 7/24/2022 2:46:05 PM ******/
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

INSERT [dbo].[TblLogin] ([Id], [FirstName], [LastName], [Email], [LoginId], [Password], [ConfirmPassword], [ContactNumber]) VALUES (1, N'Amruta', N'Musale', N'amruta@gmail.com', N'amruta16', N'123456', N'123456', 837809388)
INSERT [dbo].[TblLogin] ([Id], [FirstName], [LastName], [Email], [LoginId], [Password], [ConfirmPassword], [ContactNumber]) VALUES (2, N'Priya', N'Musale', N'priya@gmail.com', N'piyu', N'123456', N'123456', 787878789)
SET IDENTITY_INSERT [dbo].[TblLogin] OFF
GO
SET IDENTITY_INSERT [dbo].[TblTweet] ON 

INSERT [dbo].[TblTweet] ([Id], [AuthorEmail], [AuthorLogo], [AuthorSlug], [TweetTime], [TweetDescription], [TweetImage]) VALUES (17, N'amruta@gmail.com', N'jyamyang.jpg', N'@Jamyang Tsering Namgyal', N'7/24/2022 1:13:34 AM', N'New India 🇮🇳
@Narendramodi
@BJP4INDIA', N'https://tweetapp.blob.core.windows.net/images/img20220724011332448.jpg')
INSERT [dbo].[TblTweet] ([Id], [AuthorEmail], [AuthorLogo], [AuthorSlug], [TweetTime], [TweetDescription], [TweetImage]) VALUES (18, N'amruta@gmail.com', N'nasa-logo.jpg', N'@NASA Webb telescope', N'7/24/2022 1:15:05 AM', N'Hey 
              @NASASolarSystem
              , ready for your close-up? As part of Webb’s prep for science, we tested how the telescope tracks solar system 
              objects like Jupiter. Webb worked better than expected, and even caught Jupiter’s moon Europa: https://blogs.nasa.gov/webb/2022/07/14/webb-images-of-jupiter-and-more-now-available-in-commissioning-data', N'https://tweetapp.blob.core.windows.net/images/nasa20220724011505297.jpg')
INSERT [dbo].[TblTweet] ([Id], [AuthorEmail], [AuthorLogo], [AuthorSlug], [TweetTime], [TweetDescription], [TweetImage]) VALUES (19, N'amruta@gmail.com', N'Suresh.jpg', N'@Suresh Raina', N'7/24/2022 1:17:00 AM', N' Cricket my world.Love to Cricket', N'https://tweetapp.blob.core.windows.net/images/suresh120220724011659989.jpg')
INSERT [dbo].[TblTweet] ([Id], [AuthorEmail], [AuthorLogo], [AuthorSlug], [TweetTime], [TweetDescription], [TweetImage]) VALUES (20, N'amruta@gmail.com', N'virat.png', N'@Virat Kohli', N'7/24/2022 1:18:05 AM', N'King of Cricket. Thanks for eveything you have done for Indian Cricket.', N'https://tweetapp.blob.core.windows.net/images/viratk20220724011805046.jpg')
SET IDENTITY_INSERT [dbo].[TblTweet] OFF
GO
USE [master]
GO
ALTER DATABASE [TweetDB] SET  READ_WRITE 
GO