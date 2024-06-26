USE [master]
GO
/****** Object:  Database [Entrance_test]    Script Date: 6/11/2024 10:58:06 AM ******/
CREATE DATABASE [Entrance_test]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Entrance_test', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Entrance_test.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Entrance_test_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Entrance_test_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Entrance_test] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Entrance_test].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Entrance_test] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Entrance_test] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Entrance_test] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Entrance_test] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Entrance_test] SET ARITHABORT OFF 
GO
ALTER DATABASE [Entrance_test] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Entrance_test] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Entrance_test] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Entrance_test] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Entrance_test] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Entrance_test] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Entrance_test] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Entrance_test] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Entrance_test] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Entrance_test] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Entrance_test] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Entrance_test] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Entrance_test] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Entrance_test] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Entrance_test] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Entrance_test] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Entrance_test] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Entrance_test] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Entrance_test] SET  MULTI_USER 
GO
ALTER DATABASE [Entrance_test] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Entrance_test] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Entrance_test] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Entrance_test] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Entrance_test] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Entrance_test] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Entrance_test] SET QUERY_STORE = ON
GO
ALTER DATABASE [Entrance_test] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Entrance_test]
GO
/****** Object:  Table [dbo].[student_record]    Script Date: 6/11/2024 10:58:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_record](
	[student_id] [int] IDENTITY(1000,1) NOT NULL,
	[student_firstname] [nvarchar](200) NOT NULL,
	[student_middlename] [nvarchar](200) NULL,
	[student_lastname] [nvarchar](200) NOT NULL,
	[student_contact] [nvarchar](200) NOT NULL,
	[student_address] [nvarchar](200) NOT NULL,
	[student_faculty] [nvarchar](200) NOT NULL,
	[student_gender] [nvarchar](200) NOT NULL,
	[student_dob] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_admin]    Script Date: 6/11/2024 10:58:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_admin](
	[admin_userid] [nvarchar](200) NOT NULL,
	[admin_password] [nvarchar](8) NOT NULL,
	[security_question] [nvarchar](200) NOT NULL,
	[security_answer] [nvarchar](200) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_answer]    Script Date: 6/11/2024 10:58:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_answer](
	[answer_id] [int] IDENTITY(1,1) NOT NULL,
	[selected_answer] [nvarchar](200) NOT NULL,
	[marks] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[answer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_bba_question]    Script Date: 6/11/2024 10:58:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_bba_question](
	[question_id] [int] IDENTITY(1,1) NOT NULL,
	[question] [nvarchar](200) NOT NULL,
	[option_1] [nvarchar](200) NOT NULL,
	[option_2] [nvarchar](200) NOT NULL,
	[option_3] [nvarchar](200) NOT NULL,
	[option_4] [nvarchar](200) NOT NULL,
	[answer] [nvarchar](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[question_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_bca_question]    Script Date: 6/11/2024 10:58:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_bca_question](
	[question_id] [int] IDENTITY(1,1) NOT NULL,
	[question] [nvarchar](200) NOT NULL,
	[option_1] [nvarchar](200) NOT NULL,
	[option_2] [nvarchar](200) NOT NULL,
	[option_3] [nvarchar](200) NOT NULL,
	[option_4] [nvarchar](200) NOT NULL,
	[answer] [nvarchar](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[question_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_bph_question]    Script Date: 6/11/2024 10:58:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_bph_question](
	[question_id] [int] IDENTITY(1,1) NOT NULL,
	[question] [nvarchar](200) NOT NULL,
	[option_1] [nvarchar](200) NOT NULL,
	[option_2] [nvarchar](200) NOT NULL,
	[option_3] [nvarchar](200) NOT NULL,
	[option_4] [nvarchar](200) NOT NULL,
	[answer] [nvarchar](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[question_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_login_student]    Script Date: 6/11/2024 10:58:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_login_student](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login_id] [int] NOT NULL,
	[student_name] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[login_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_report]    Script Date: 6/11/2024 10:58:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_report](
	[s_no] [int] IDENTITY(1,1) NOT NULL,
	[login_id] [int] NULL,
	[result] [nvarchar](4) NOT NULL,
	[faculty] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[s_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_report]  WITH CHECK ADD FOREIGN KEY([login_id])
REFERENCES [dbo].[tbl_login_student] ([login_id])
GO
USE [master]
GO
ALTER DATABASE [Entrance_test] SET  READ_WRITE 
GO
