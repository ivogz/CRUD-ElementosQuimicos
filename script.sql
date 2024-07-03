USE [master]
GO
/****** Object:  Database [CRUD_DB]    Script Date: 3/7/2024 08:23:49 ******/
CREATE DATABASE [CRUD_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CRUD_DB', FILENAME = N'O:\SQLData\CRUD_DB.mdf' , SIZE = 8192KB , MAXSIZE = 20480KB , FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CRUD_DB_log', FILENAME = N'O:\SQLData\CRUD_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 20480KB , FILEGROWTH = 1024KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CRUD_DB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CRUD_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CRUD_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CRUD_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CRUD_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CRUD_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CRUD_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CRUD_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CRUD_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CRUD_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CRUD_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CRUD_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CRUD_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CRUD_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CRUD_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CRUD_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CRUD_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CRUD_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CRUD_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CRUD_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CRUD_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CRUD_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CRUD_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CRUD_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CRUD_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CRUD_DB] SET  MULTI_USER 
GO
ALTER DATABASE [CRUD_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CRUD_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CRUD_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CRUD_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CRUD_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CRUD_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CRUD_DB] SET QUERY_STORE = ON
GO
ALTER DATABASE [CRUD_DB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CRUD_DB]
GO
/****** Object:  Table [dbo].[Elementos]    Script Date: 3/7/2024 08:23:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Elementos](
	[nAtomico] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[simbolo] [varchar](50) NOT NULL,
	[grupo] [int] NOT NULL,
	[periodo] [int] NOT NULL,
	[masaAtomica] [float] NOT NULL,
	[protones] [int] NOT NULL,
	[neutrones] [int] NOT NULL,
	[subcategoria] [nchar](10) NOT NULL,
	[tipoElemento] [nchar](10) NOT NULL,
	[lugarDeObtencion] [varchar](50) NULL,
	[UsoPrincipal] [varchar](50) NULL,
	[cantidadRadioactividad] [int] NULL,
	[color] [varchar](50) NULL,
	[estadoNatural] [nchar](10) NULL,
	[puntoEbullicion] [float] NULL,
	[puntoFusion] [float] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Elementos] ([nAtomico], [nombre], [simbolo], [grupo], [periodo], [masaAtomica], [protones], [neutrones], [subcategoria], [tipoElemento], [lugarDeObtencion], [UsoPrincipal], [cantidadRadioactividad], [color], [estadoNatural], [puntoEbullicion], [puntoFusion]) VALUES (29, N'NoMetalBasico', N'NB', 10, 8, 7955, 4773, 3182, N'0         ', N'NM        ', NULL, NULL, NULL, NULL, N'0         ', 789, 544)
INSERT [dbo].[Elementos] ([nAtomico], [nombre], [simbolo], [grupo], [periodo], [masaAtomica], [protones], [neutrones], [subcategoria], [tipoElemento], [lugarDeObtencion], [UsoPrincipal], [cantidadRadioactividad], [color], [estadoNatural], [puntoEbullicion], [puntoFusion]) VALUES (99, N'Awa', N'AW', 12, 2, 789, 473, 315, N'0         ', N'NM        ', NULL, NULL, NULL, NULL, N'2         ', 100, 50)
INSERT [dbo].[Elementos] ([nAtomico], [nombre], [simbolo], [grupo], [periodo], [masaAtomica], [protones], [neutrones], [subcategoria], [tipoElemento], [lugarDeObtencion], [UsoPrincipal], [cantidadRadioactividad], [color], [estadoNatural], [puntoEbullicion], [puntoFusion]) VALUES (17, N'roca', N'RK', 3, 7, 60, 30, 30, N'2         ', N'M         ', NULL, NULL, 10, N'marroncito', NULL, NULL, NULL)
INSERT [dbo].[Elementos] ([nAtomico], [nombre], [simbolo], [grupo], [periodo], [masaAtomica], [protones], [neutrones], [subcategoria], [tipoElemento], [lugarDeObtencion], [UsoPrincipal], [cantidadRadioactividad], [color], [estadoNatural], [puntoEbullicion], [puntoFusion]) VALUES (132, N'rocka', N'ad', 4, 2, 13212, 6606, 6606, N'0         ', N'M         ', NULL, NULL, 4333, N'marron', NULL, NULL, NULL)
INSERT [dbo].[Elementos] ([nAtomico], [nombre], [simbolo], [grupo], [periodo], [masaAtomica], [protones], [neutrones], [subcategoria], [tipoElemento], [lugarDeObtencion], [UsoPrincipal], [cantidadRadioactividad], [color], [estadoNatural], [puntoEbullicion], [puntoFusion]) VALUES (18, N'GAS', N'GS', 6, 7, 23, 16, 6, N'0         ', N'G         ', N'alla', N'explosivos', NULL, NULL, NULL, NULL, NULL)
GO
USE [master]
GO
ALTER DATABASE [CRUD_DB] SET  READ_WRITE 
GO
