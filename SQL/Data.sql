USE [master]
GO
/****** Object:  Database [doan]    Script Date: 19-Jun-24 20:58:43 ******/

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [doan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [doan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [doan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [doan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [doan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [doan] SET ARITHABORT OFF 
GO
ALTER DATABASE [doan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [doan] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [doan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [doan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [doan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [doan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [doan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [doan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [doan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [doan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [doan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [doan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [doan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [doan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [doan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [doan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [doan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [doan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [doan] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [doan] SET  MULTI_USER 
GO
ALTER DATABASE [doan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [doan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [doan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [doan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [doan] SET  READ_WRITE 
GO
