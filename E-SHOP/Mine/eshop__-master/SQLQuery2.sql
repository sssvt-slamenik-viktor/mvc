USE [master]
GO

/****** Object:  Database [dbEshop_Slamenik]    Script Date: 13.12.2021 1:03:04 ******/
CREATE DATABASE [dbEshop_Slamenik]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PetEShopDB', FILENAME = N'D:\Program Files (x86)\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PetEShopDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PetEShopDB_log', FILENAME = N'D:\Program Files (x86)\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PetEShopDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbEshop_Slamenik].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [dbEshop_Slamenik] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET ARITHABORT OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [dbEshop_Slamenik] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [dbEshop_Slamenik] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET  DISABLE_BROKER 
GO

ALTER DATABASE [dbEshop_Slamenik] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [dbEshop_Slamenik] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET RECOVERY FULL 
GO

ALTER DATABASE [dbEshop_Slamenik] SET  MULTI_USER 
GO

ALTER DATABASE [dbEshop_Slamenik] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [dbEshop_Slamenik] SET DB_CHAINING OFF 
GO

ALTER DATABASE [dbEshop_Slamenik] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [dbEshop_Slamenik] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [dbEshop_Slamenik] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [dbEshop_Slamenik] SET QUERY_STORE = OFF
GO

ALTER DATABASE [dbEshop_Slamenik] SET  READ_WRITE 
GO

