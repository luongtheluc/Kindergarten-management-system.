USE [master]
GO
/****** Object:  Database [apptien]    Script Date: 10/26/2021 4:05:35 PM ******/
CREATE DATABASE [apptien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'apptien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\apptien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'apptien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\apptien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [apptien] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [apptien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [apptien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [apptien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [apptien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [apptien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [apptien] SET ARITHABORT OFF 
GO
ALTER DATABASE [apptien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [apptien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [apptien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [apptien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [apptien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [apptien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [apptien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [apptien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [apptien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [apptien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [apptien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [apptien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [apptien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [apptien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [apptien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [apptien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [apptien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [apptien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [apptien] SET  MULTI_USER 
GO
ALTER DATABASE [apptien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [apptien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [apptien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [apptien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [apptien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [apptien] SET QUERY_STORE = OFF
GO
USE [apptien]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 10/26/2021 4:05:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tentaikhoan] [varchar](50) NULL,
	[matkhau] [varchar](50) NULL,
	[SoDu] [int] NULL,
 CONSTRAINT [PK_taikhoan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[taikhoan] ON 
GO
INSERT [dbo].[taikhoan] ([id], [tentaikhoan], [matkhau], [SoDu]) VALUES (1, N'dohuykhanh', N'202cb962ac59075b964b07152d234b70', 9999982)
GO
SET IDENTITY_INSERT [dbo].[taikhoan] OFF
GO
USE [master]
GO
ALTER DATABASE [apptien] SET  READ_WRITE 
GO
s