USE [master]
GO
/****** Object:  Database [IT_Telefaune]    Script Date: 18/01/2022 06:28:33 ******/
CREATE DATABASE [IT_Telefaune]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IT_Telefaune', FILENAME = N'H:\SQL Server Dev\MSSQL15.MSSQLSERVER\MSSQL\DATA\IT_Telefaune.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'IT_Telefaune_log', FILENAME = N'H:\SQL Server Dev\MSSQL15.MSSQLSERVER\MSSQL\DATA\IT_Telefaune_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [IT_Telefaune] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IT_Telefaune].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IT_Telefaune] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IT_Telefaune] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IT_Telefaune] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IT_Telefaune] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IT_Telefaune] SET ARITHABORT OFF 
GO
ALTER DATABASE [IT_Telefaune] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IT_Telefaune] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IT_Telefaune] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IT_Telefaune] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IT_Telefaune] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IT_Telefaune] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IT_Telefaune] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IT_Telefaune] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IT_Telefaune] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IT_Telefaune] SET  ENABLE_BROKER 
GO
ALTER DATABASE [IT_Telefaune] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IT_Telefaune] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IT_Telefaune] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IT_Telefaune] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IT_Telefaune] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IT_Telefaune] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [IT_Telefaune] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IT_Telefaune] SET RECOVERY FULL 
GO
ALTER DATABASE [IT_Telefaune] SET  MULTI_USER 
GO
ALTER DATABASE [IT_Telefaune] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IT_Telefaune] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IT_Telefaune] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IT_Telefaune] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [IT_Telefaune] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [IT_Telefaune] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'IT_Telefaune', N'ON'
GO
ALTER DATABASE [IT_Telefaune] SET QUERY_STORE = OFF
GO
USE [IT_Telefaune]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 18/01/2022 06:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 18/01/2022 06:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[ConfirmPasssword] [nvarchar](max) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salarie]    Script Date: 18/01/2022 06:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salarie](
	[SalarieId] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[Prenom] [nvarchar](max) NOT NULL,
	[TelephoneFixe] [int] NOT NULL,
	[TelephonePortable] [int] NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[TypeServiceWrong] [nvarchar](max) NOT NULL,
	[NomSiteWrong] [nvarchar](max) NOT NULL,
	[ServiceId] [int] NOT NULL,
	[TypeServiceServiceId] [int] NULL,
	[SiteId] [int] NOT NULL,
	[NomSiteSiteId] [int] NULL,
 CONSTRAINT [PK_Salarie] PRIMARY KEY CLUSTERED 
(
	[SalarieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 18/01/2022 06:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceId] [int] IDENTITY(1,1) NOT NULL,
	[TypeService] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Site]    Script Date: 18/01/2022 06:28:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Site](
	[SiteId] [int] IDENTITY(1,1) NOT NULL,
	[NomSite] [nvarchar](max) NOT NULL,
	[Ville] [nvarchar](max) NOT NULL,
	[TypeServiceWrong] [nvarchar](max) NULL,
	[ServiceId] [int] NOT NULL,
	[TypeServiceServiceId] [int] NULL,
 CONSTRAINT [PK_Site] PRIMARY KEY CLUSTERED 
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Salarie_NomSiteSiteId]    Script Date: 18/01/2022 06:28:33 ******/
CREATE NONCLUSTERED INDEX [IX_Salarie_NomSiteSiteId] ON [dbo].[Salarie]
(
	[NomSiteSiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Salarie_TypeServiceServiceId]    Script Date: 18/01/2022 06:28:33 ******/
CREATE NONCLUSTERED INDEX [IX_Salarie_TypeServiceServiceId] ON [dbo].[Salarie]
(
	[TypeServiceServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Site_TypeServiceServiceId]    Script Date: 18/01/2022 06:28:33 ******/
CREATE NONCLUSTERED INDEX [IX_Site_TypeServiceServiceId] ON [dbo].[Site]
(
	[TypeServiceServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Salarie]  WITH CHECK ADD  CONSTRAINT [FK_Salarie_Service_TypeServiceServiceId] FOREIGN KEY([TypeServiceServiceId])
REFERENCES [dbo].[Service] ([ServiceId])
GO
ALTER TABLE [dbo].[Salarie] CHECK CONSTRAINT [FK_Salarie_Service_TypeServiceServiceId]
GO
ALTER TABLE [dbo].[Salarie]  WITH CHECK ADD  CONSTRAINT [FK_Salarie_Site_NomSiteSiteId] FOREIGN KEY([NomSiteSiteId])
REFERENCES [dbo].[Site] ([SiteId])
GO
ALTER TABLE [dbo].[Salarie] CHECK CONSTRAINT [FK_Salarie_Site_NomSiteSiteId]
GO
ALTER TABLE [dbo].[Site]  WITH CHECK ADD  CONSTRAINT [FK_Site_Service_TypeServiceServiceId] FOREIGN KEY([TypeServiceServiceId])
REFERENCES [dbo].[Service] ([ServiceId])
GO
ALTER TABLE [dbo].[Site] CHECK CONSTRAINT [FK_Site_Service_TypeServiceServiceId]
GO
USE [master]
GO
ALTER DATABASE [IT_Telefaune] SET  READ_WRITE 
GO
