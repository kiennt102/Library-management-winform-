USE [master]
GO
/****** Object:  Database [libraryMng]    Script Date: 1/10/2024 8:15:41 AM ******/
CREATE DATABASE [libraryMng]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'libraryMng', FILENAME = N'D:\SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\libraryMng.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'libraryMng_log', FILENAME = N'D:\SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\libraryMng_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [libraryMng] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [libraryMng].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [libraryMng] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [libraryMng] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [libraryMng] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [libraryMng] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [libraryMng] SET ARITHABORT OFF 
GO
ALTER DATABASE [libraryMng] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [libraryMng] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [libraryMng] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [libraryMng] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [libraryMng] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [libraryMng] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [libraryMng] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [libraryMng] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [libraryMng] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [libraryMng] SET  DISABLE_BROKER 
GO
ALTER DATABASE [libraryMng] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [libraryMng] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [libraryMng] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [libraryMng] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [libraryMng] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [libraryMng] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [libraryMng] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [libraryMng] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [libraryMng] SET  MULTI_USER 
GO
ALTER DATABASE [libraryMng] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [libraryMng] SET DB_CHAINING OFF 
GO
ALTER DATABASE [libraryMng] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [libraryMng] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [libraryMng] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [libraryMng] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [libraryMng] SET QUERY_STORE = ON
GO
ALTER DATABASE [libraryMng] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [libraryMng]
GO
/****** Object:  Table [dbo].[tblCTMuon]    Script Date: 1/10/2024 8:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTMuon](
	[mamuon] [nchar](50) NOT NULL,
	[masach] [nchar](50) NOT NULL,
	[trangthai] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCTThem]    Script Date: 1/10/2024 8:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTThem](
	[mathem] [nchar](50) NOT NULL,
	[masach] [nchar](50) NOT NULL,
	[tensach] [nvarchar](100) NOT NULL,
	[tentacgia] [nvarchar](50) NULL,
	[tenloai] [nvarchar](20) NULL,
	[gia] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCTTra]    Script Date: 1/10/2024 8:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTTra](
	[matra] [nchar](50) NOT NULL,
	[masach] [nchar](50) NOT NULL,
	[ghichu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDocgia]    Script Date: 1/10/2024 8:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDocgia](
	[madocgia] [nchar](100) NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[ngaysinh] [nchar](10) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[gmail] [nchar](100) NOT NULL,
	[matkhau] [nchar](50) NOT NULL,
	[sdt] [nchar](10) NULL,
	[gt] [nvarchar](10) NULL,
	[ghichu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMuonSach]    Script Date: 1/10/2024 8:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMuonSach](
	[mamuon] [nchar](50) NOT NULL,
	[manv] [nchar](100) NOT NULL,
	[madocgia] [nchar](100) NOT NULL,
	[ngaymuon] [date] NULL,
 CONSTRAINT [PK_tblMuonSach] PRIMARY KEY CLUSTERED 
(
	[mamuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanvien]    Script Date: 1/10/2024 8:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanvien](
	[manv] [nchar](100) NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[ngaysinh] [nchar](10) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[gmail] [nchar](100) NOT NULL,
	[matkhau] [nchar](50) NOT NULL,
	[phone_number] [nchar](15) NULL,
	[gt] [nvarchar](10) NULL,
	[ghichu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSach]    Script Date: 1/10/2024 8:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSach](
	[id] [nchar](50) NOT NULL,
	[tensach] [nvarchar](100) NOT NULL,
	[matacgia] [nchar](10) NOT NULL,
	[maloai] [nchar](10) NOT NULL,
	[trangthai] [nvarchar](100) NOT NULL,
	[gia] [int] NOT NULL,
	[ghichu] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblSachh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTacGia]    Script Date: 1/10/2024 8:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTacGia](
	[matacgia] [nchar](10) NOT NULL,
	[tentacgia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTacGia] PRIMARY KEY CLUSTERED 
(
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTaiKhoan]    Script Date: 1/10/2024 8:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTaiKhoan](
	[id] [nchar](100) NOT NULL,
	[tentaikhoan] [nchar](50) NOT NULL,
	[matkhau] [nchar](50) NOT NULL,
	[rolee] [nchar](10) NULL,
	[trangthai] [nchar](10) NULL,
 CONSTRAINT [PK_tblTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTheLoai]    Script Date: 1/10/2024 8:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTheLoai](
	[maloai] [nchar](10) NOT NULL,
	[tenloai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTheLoai] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThemSach]    Script Date: 1/10/2024 8:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThemSach](
	[mathem] [nchar](50) NOT NULL,
	[manhanvien] [nchar](100) NOT NULL,
	[ngaythem] [date] NULL,
	[mota] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblThemSach] PRIMARY KEY CLUSTERED 
(
	[mathem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTraSach]    Script Date: 1/10/2024 8:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTraSach](
	[matra] [nchar](50) NOT NULL,
	[manv] [nchar](100) NOT NULL,
	[mamuon] [nchar](50) NOT NULL,
	[ngaytra] [date] NULL,
 CONSTRAINT [PK_tblTraSach] PRIMARY KEY CLUSTERED 
(
	[matra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblCTMuon] ([mamuon], [masach], [trangthai]) VALUES (N'1                                                 ', N'110                                               ', N'false')
INSERT [dbo].[tblCTMuon] ([mamuon], [masach], [trangthai]) VALUES (N'1                                                 ', N'123                                               ', N'false')
INSERT [dbo].[tblCTMuon] ([mamuon], [masach], [trangthai]) VALUES (N'2                                                 ', N'7773                                              ', N'true')
INSERT [dbo].[tblCTMuon] ([mamuon], [masach], [trangthai]) VALUES (N'5                                                 ', N'6383                                              ', N'true')
INSERT [dbo].[tblCTMuon] ([mamuon], [masach], [trangthai]) VALUES (N'5                                                 ', N'8594                                              ', N'false')
INSERT [dbo].[tblCTMuon] ([mamuon], [masach], [trangthai]) VALUES (N'3                                                 ', N'2242                                              ', N'true')
INSERT [dbo].[tblCTMuon] ([mamuon], [masach], [trangthai]) VALUES (N'4                                                 ', N'110                                               ', N'false')
INSERT [dbo].[tblCTMuon] ([mamuon], [masach], [trangthai]) VALUES (N'4                                                 ', N'9720                                              ', N'true')
GO
INSERT [dbo].[tblCTThem] ([mathem], [masach], [tensach], [tentacgia], [tenloai], [gia]) VALUES (N'1                                                 ', N'6550                                              ', N'5 ae', N'Xuân Diệu', N'văn học', 13000)
INSERT [dbo].[tblCTThem] ([mathem], [masach], [tensach], [tentacgia], [tenloai], [gia]) VALUES (N'2                                                 ', N'7350                                              ', N'Làng', N'Kim Lân', N'văn học', 18000)
INSERT [dbo].[tblCTThem] ([mathem], [masach], [tensach], [tentacgia], [tenloai], [gia]) VALUES (N'2                                                 ', N'6921                                              ', N'Làng', N'Kim Lân', N'văn học', 18000)
INSERT [dbo].[tblCTThem] ([mathem], [masach], [tensach], [tentacgia], [tenloai], [gia]) VALUES (N'2                                                 ', N'1002                                              ', N'Làng', N'Kim Lân', N'văn học', 18000)
INSERT [dbo].[tblCTThem] ([mathem], [masach], [tensach], [tentacgia], [tenloai], [gia]) VALUES (N'3                                                 ', N'1360                                              ', N'Chí Phèo', N'Nam Cao', N'văn học', 45000)
INSERT [dbo].[tblCTThem] ([mathem], [masach], [tensach], [tentacgia], [tenloai], [gia]) VALUES (N'3                                                 ', N'9751                                              ', N'Chí Phèo', N'Nam Cao', N'văn học', 45000)
INSERT [dbo].[tblCTThem] ([mathem], [masach], [tensach], [tentacgia], [tenloai], [gia]) VALUES (N'3                                                 ', N'972                                               ', N'Chí Phèo', N'Nam Cao', N'văn học', 45000)
INSERT [dbo].[tblCTThem] ([mathem], [masach], [tensach], [tentacgia], [tenloai], [gia]) VALUES (N'3                                                 ', N'6383                                              ', N'Chí Phèo', N'Nam Cao', N'văn học', 45000)
INSERT [dbo].[tblCTThem] ([mathem], [masach], [tensach], [tentacgia], [tenloai], [gia]) VALUES (N'3                                                 ', N'7254                                              ', N'Chí Phèo', N'Nam Cao', N'văn học', 45000)
INSERT [dbo].[tblCTThem] ([mathem], [masach], [tensach], [tentacgia], [tenloai], [gia]) VALUES (N'4                                                 ', N'9940                                              ', N'abc', N'Xuân Diệu', N'văn học', 120000)
INSERT [dbo].[tblCTThem] ([mathem], [masach], [tensach], [tentacgia], [tenloai], [gia]) VALUES (N'4                                                 ', N'8090                                              ', N'abc', N'Xuân Diệu', N'văn học', 12000)
INSERT [dbo].[tblCTThem] ([mathem], [masach], [tensach], [tentacgia], [tenloai], [gia]) VALUES (N'1                                                 ', N'110                                               ', N'1 ong gia', N'Xuân Diệu', N'văn học', 11000)
GO
INSERT [dbo].[tblCTTra] ([matra], [masach], [ghichu]) VALUES (N'1                                                 ', N'123                                               ', N'')
INSERT [dbo].[tblCTTra] ([matra], [masach], [ghichu]) VALUES (N'1                                                 ', N'110                                               ', N'')
INSERT [dbo].[tblCTTra] ([matra], [masach], [ghichu]) VALUES (N'3                                                 ', N'8594                                              ', N'không')
INSERT [dbo].[tblCTTra] ([matra], [masach], [ghichu]) VALUES (N'2                                                 ', N'110                                               ', N'qua han')
GO
INSERT [dbo].[tblDocgia] ([madocgia], [hoten], [ngaysinh], [diachi], [gmail], [matkhau], [sdt], [gt], [ghichu]) VALUES (N'074561239870                                                                                        ', N'nguyen van a', N'12/16/2004', N'hy', N'thf@123.com                                                                                         ', N'074561239870@123                                  ', N'0321654789', N'Nữ', N'')
INSERT [dbo].[tblDocgia] ([madocgia], [hoten], [ngaysinh], [diachi], [gmail], [matkhau], [sdt], [gt], [ghichu]) VALUES (N'092817265141                                                                                        ', N'abc', N'07/01/2024', N'ny', N'dsa@gmail.com                                                                                       ', N'092817265141@123                                  ', N'0987654321', N'Nam', N'')
INSERT [dbo].[tblDocgia] ([madocgia], [hoten], [ngaysinh], [diachi], [gmail], [matkhau], [sdt], [gt], [ghichu]) VALUES (N'033333333333                                                                                        ', N'abc', N'38/12/2023', N'hy', N'abc@gg.vn                                                                                           ', N'033333333333@123                                  ', N'0741852963', N'Nam', N'')
INSERT [dbo].[tblDocgia] ([madocgia], [hoten], [ngaysinh], [diachi], [gmail], [matkhau], [sdt], [gt], [ghichu]) VALUES (N'012345678101                                                                                        ', N'asdasdas', N'07/01/2024', N'Chicago', N'asdc@dfsfa.f                                                                                        ', N'012345678101@123                                  ', N'0987654321', N'Khác', N'not available')
GO
INSERT [dbo].[tblMuonSach] ([mamuon], [manv], [madocgia], [ngaymuon]) VALUES (N'1                                                 ', N'095959595979                                                                                        ', N'074561239870                                                                                        ', CAST(N'2024-01-06' AS Date))
INSERT [dbo].[tblMuonSach] ([mamuon], [manv], [madocgia], [ngaymuon]) VALUES (N'2                                                 ', N'095959595979                                                                                        ', N'033333333333                                                                                        ', CAST(N'2023-11-01' AS Date))
INSERT [dbo].[tblMuonSach] ([mamuon], [manv], [madocgia], [ngaymuon]) VALUES (N'3                                                 ', N'095959595979                                                                                        ', N'033333333333                                                                                        ', CAST(N'2023-12-29' AS Date))
INSERT [dbo].[tblMuonSach] ([mamuon], [manv], [madocgia], [ngaymuon]) VALUES (N'4                                                 ', N'095959595979                                                                                        ', N'074561239870                                                                                        ', CAST(N'2024-01-07' AS Date))
INSERT [dbo].[tblMuonSach] ([mamuon], [manv], [madocgia], [ngaymuon]) VALUES (N'5                                                 ', N'098989898989                                                                                        ', N'074561239870                                                                                        ', CAST(N'2024-01-08' AS Date))
GO
INSERT [dbo].[tblNhanvien] ([manv], [hoten], [ngaysinh], [diachi], [gmail], [matkhau], [phone_number], [gt], [ghichu]) VALUES (N'098888888888                                                                                        ', N'ferg', N'05/01/2024', N'fef', N'abc1@gg.vn                                                                                          ', N'098888888888@123                                  ', N'0987654321     ', N'Nam', N'')
INSERT [dbo].[tblNhanvien] ([manv], [hoten], [ngaysinh], [diachi], [gmail], [matkhau], [phone_number], [gt], [ghichu]) VALUES (N'011111111111                                                                                        ', N'cyz', N'05/01/2024', N'hy', N'abcegm@gmail.com                                                                                    ', N'011111111111@123                                  ', N'0987654321     ', N'Khác', NULL)
INSERT [dbo].[tblNhanvien] ([manv], [hoten], [ngaysinh], [diachi], [gmail], [matkhau], [phone_number], [gt], [ghichu]) VALUES (N'098989898989                                                                                        ', N'efq', N'07/01/2024', N'LA', N'dsa@gmail.com                                                                                       ', N'098989898989@123                                  ', N'0987654321     ', N'Nữ', N'not available')
INSERT [dbo].[tblNhanvien] ([manv], [hoten], [ngaysinh], [diachi], [gmail], [matkhau], [phone_number], [gt], [ghichu]) VALUES (N'029812121212                                                                                        ', N'hfgh', N'08/01/2024', N'fa', N'asda@gsg.vs                                                                                         ', N'029812121212@123                                  ', N'0987654321     ', N'Nam', N'')
INSERT [dbo].[tblNhanvien] ([manv], [hoten], [ngaysinh], [diachi], [gmail], [matkhau], [phone_number], [gt], [ghichu]) VALUES (N'034343434343                                                                                        ', N'super', N'07/01/2024', N'london', N'sp123@gm.com                                                                                        ', N'034343434343@123                                  ', N'0999999999     ', N'Nam', N'')
INSERT [dbo].[tblNhanvien] ([manv], [hoten], [ngaysinh], [diachi], [gmail], [matkhau], [phone_number], [gt], [ghichu]) VALUES (N'033204005959                                                                                        ', N'Nguyen TRung Kien', N'10/01/2024', N'HY', N'trungkien302004@gmail.com                                                                           ', N'033204005959@123                                  ', N'0366897718     ', N'Nam', N'not available')
INSERT [dbo].[tblNhanvien] ([manv], [hoten], [ngaysinh], [diachi], [gmail], [matkhau], [phone_number], [gt], [ghichu]) VALUES (N'000000000012                                                                                        ', N'thdr', N'05/01/2024', N'sht', N'fdhgsg@gm.com                                                                                       ', N'000000000012@123                                  ', N'0987654321     ', N'Nam', N'not available')
INSERT [dbo].[tblNhanvien] ([manv], [hoten], [ngaysinh], [diachi], [gmail], [matkhau], [phone_number], [gt], [ghichu]) VALUES (N'095959595979                                                                                        ', N'bac', N'01/22/2023', N'hy', N'abc@gg.vn                                                                                           ', N'095959595979@123                                  ', N'0741236589     ', N'Nữ', N'')
INSERT [dbo].[tblNhanvien] ([manv], [hoten], [ngaysinh], [diachi], [gmail], [matkhau], [phone_number], [gt], [ghichu]) VALUES (N'000000000099                                                                                        ', N'rsths', N'05/01/2024', N'hdryh', N'gdhs@gg.com                                                                                         ', N'000000000099@123                                  ', N'0987654321     ', N'Nam', N'not available')
GO
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'1002                                              ', N'Làng', N'6         ', N'1         ', N'available', 18000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'110                                               ', N'1 ong gia', N'1         ', N'1         ', N'available', 11000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'123                                               ', N'Dế Mèn phiêu lưu ký', N'4         ', N'1         ', N'available', 2024, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'1360                                              ', N'Chí Phèo', N'7         ', N'1         ', N'available', 45000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'2242                                              ', N'Địa lí Hà Nội', N'14        ', N'5         ', N'taken', 57000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'2461                                              ', N'Lược sử thời gian', N'16        ', N'6         ', N'available', 99999, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'4163                                              ', N'Shin cậu bé bút chì ', N'9         ', N'7         ', N'available', 21000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'458                                               ', N'Lập trình window form', N'13        ', N'3         ', N'available', 89000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'5187                                              ', N'Lịch sử nước ta ', N'17        ', N'4         ', N'available', 100000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'5297                                              ', N'Lập trình window form', N'13        ', N'3         ', N'available', 89000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'5394                                              ', N'Cẩm nang địa lý thế giới', N'15        ', N'5         ', N'available', 29000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'5451                                              ', N'Clean code', N'10        ', N'3         ', N'available', 347000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'5496                                              ', N'17 phương trình thay đổi thế giới', N'12        ', N'2         ', N'available', 123000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'5753                                              ', N'Lược sử thời gian', N'16        ', N'6         ', N'available', 99999, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'5852                                              ', N'Cơ sở dữ liệu lập trình', N'13        ', N'3         ', N'available', 51000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'590                                               ', N'Lập trình window form', N'13        ', N'3         ', N'available', 89000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'5914                                              ', N'Cơ sở dữ liệu lập trình', N'13        ', N'3         ', N'available', 51000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'6383                                              ', N'Chí Phèo', N'7         ', N'1         ', N'taken', 45000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'6550                                              ', N'5 ae', N'1         ', N'1         ', N'available', 13000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'6752                                              ', N'Cẩm nang địa lý thế giới', N'15        ', N'5         ', N'available', 29000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'6921                                              ', N'Làng', N'6         ', N'1         ', N'available', 18000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'6997                                              ', N'doraemon', N'8         ', N'7         ', N'available', 2024, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'7102                                              ', N'Lược sử thời gian', N'16        ', N'6         ', N'available', 99999, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'7254                                              ', N'Chí Phèo', N'7         ', N'1         ', N'available', 45000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'7350                                              ', N'Làng', N'6         ', N'1         ', N'available', 18000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'7773                                              ', N'Toán học, một thiên tiểu thuyết', N'11        ', N'2         ', N'taken', 88000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'7928                                              ', N'Lược sử thời gian', N'16        ', N'6         ', N'available', 99999, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'7950                                              ', N'Cẩm nang địa lý thế giới', N'15        ', N'5         ', N'available', 29000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'8090                                              ', N'abc', N'1         ', N'1         ', N'available', 12000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'8147                                              ', N'Lược sử thời gian', N'16        ', N'6         ', N'available', 99999, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'8155                                              ', N'Lược sử thời gian', N'16        ', N'6         ', N'available', 99999, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'843                                               ', N'7 viên ngọc rồng', N'5         ', N'7         ', N'available', 16000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'8444                                              ', N'Lược sử thời gian', N'16        ', N'6         ', N'available', 99999, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'8560                                              ', N'Toán học, một thiên tiểu thuyết', N'11        ', N'2         ', N'available', 88000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'8594                                              ', N'17 phương trình thay đổi thế giới', N'12        ', N'2         ', N'available', 123000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'875                                               ', N'Toán học, một thiên tiểu thuyết', N'11        ', N'2         ', N'available', 88000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'926                                               ', N'doraemon', N'8         ', N'7         ', N'available', 2024, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'9562                                              ', N'Shin cậu bé bút chì ', N'9         ', N'7         ', N'available', 21000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'9579                                              ', N'Vũ trụ trong vỏ hạt dẻ', N'16        ', N'6         ', N'available', 98000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'9616                                              ', N'Vũ trụ trong vỏ hạt dẻ', N'16        ', N'6         ', N'available', 98000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'972                                               ', N'Chí Phèo', N'7         ', N'1         ', N'available', 45000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'9720                                              ', N'Lịch sử nước ta ', N'17        ', N'4         ', N'taken', 100000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'9751                                              ', N'Chí Phèo', N'7         ', N'1         ', N'available', 45000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'9780                                              ', N'7 viên ngọc rồng', N'5         ', N'7         ', N'available', 16000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'994                                               ', N'Địa lí Hà Nội', N'14        ', N'5         ', N'available', 57000, N'')
INSERT [dbo].[tblSach] ([id], [tensach], [matacgia], [maloai], [trangthai], [gia], [ghichu]) VALUES (N'9940                                              ', N'Địa lí Hà Nội', N'14        ', N'5         ', N'available', 57000, N'')
GO
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'1         ', N'Xuân Diệu')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'10        ', N'Simon Singh')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'11        ', N'Mickael Launay')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'12        ', N'Ian Stewart')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'13        ', N'Nhóm tác giả Utehy')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'14        ', N'Nguyễn Viết Thịnh')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'15        ', N'Lưu Văn Hy')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'16        ', N'Stephen Hawking')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'17        ', N'Hồ Chí Minh')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'2         ', N'Xuân Quỳnh')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'3         ', N'Hàn Mạc Tử')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'4         ', N'Tô Hoài')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'5         ', N'Toriyama Akira')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'6         ', N'Kim Lân')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'7         ', N'Nam Cao')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'8         ', N'Fujiko Fujio')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (N'9         ', N'Usui Yoshito')
GO
INSERT [dbo].[tblTaiKhoan] ([id], [tentaikhoan], [matkhau], [rolee], [trangthai]) VALUES (N'000000000012                                                                                        ', N'admin3                                            ', N'123                                               ', N'manager   ', N'false     ')
INSERT [dbo].[tblTaiKhoan] ([id], [tentaikhoan], [matkhau], [rolee], [trangthai]) VALUES (N'000000000099                                                                                        ', N'000000000099                                      ', N'000000000099@123                                  ', N'manager   ', N'false     ')
INSERT [dbo].[tblTaiKhoan] ([id], [tentaikhoan], [matkhau], [rolee], [trangthai]) VALUES (N'011111111111                                                                                        ', N'011111111111                                      ', N'011111111111@123                                  ', N'manager   ', NULL)
INSERT [dbo].[tblTaiKhoan] ([id], [tentaikhoan], [matkhau], [rolee], [trangthai]) VALUES (N'012345678101                                                                                        ', N'user                                              ', N'123                                               ', N'reader    ', N'false     ')
INSERT [dbo].[tblTaiKhoan] ([id], [tentaikhoan], [matkhau], [rolee], [trangthai]) VALUES (N'029812121212                                                                                        ', N'029812121212                                      ', N'029812121212@123                                  ', N'manager   ', N'true      ')
INSERT [dbo].[tblTaiKhoan] ([id], [tentaikhoan], [matkhau], [rolee], [trangthai]) VALUES (N'033204005959                                                                                        ', N'admin17                                           ', N'123                                               ', N'manager   ', N'false     ')
INSERT [dbo].[tblTaiKhoan] ([id], [tentaikhoan], [matkhau], [rolee], [trangthai]) VALUES (N'033333333333                                                                                        ', N'user3                                             ', N'123                                               ', N'reader    ', NULL)
INSERT [dbo].[tblTaiKhoan] ([id], [tentaikhoan], [matkhau], [rolee], [trangthai]) VALUES (N'034343434343                                                                                        ', N'admin                                             ', N'123                                               ', N'manager   ', N'true      ')
INSERT [dbo].[tblTaiKhoan] ([id], [tentaikhoan], [matkhau], [rolee], [trangthai]) VALUES (N'074561239870                                                                                        ', N'user1                                             ', N'123                                               ', N'reader    ', NULL)
INSERT [dbo].[tblTaiKhoan] ([id], [tentaikhoan], [matkhau], [rolee], [trangthai]) VALUES (N'092817265141                                                                                        ', N'user2                                             ', N'123                                               ', N'reader    ', NULL)
INSERT [dbo].[tblTaiKhoan] ([id], [tentaikhoan], [matkhau], [rolee], [trangthai]) VALUES (N'095959595979                                                                                        ', N'admin2                                            ', N'123                                               ', N'manager   ', NULL)
INSERT [dbo].[tblTaiKhoan] ([id], [tentaikhoan], [matkhau], [rolee], [trangthai]) VALUES (N'098888888888                                                                                        ', N'admindelete                                       ', N'123                                               ', N'manager   ', N'false     ')
INSERT [dbo].[tblTaiKhoan] ([id], [tentaikhoan], [matkhau], [rolee], [trangthai]) VALUES (N'098989898989                                                                                        ', N'admin1                                            ', N'123                                               ', N'manager   ', N'true      ')
GO
INSERT [dbo].[tblTheLoai] ([maloai], [tenloai]) VALUES (N'1         ', N'văn học')
INSERT [dbo].[tblTheLoai] ([maloai], [tenloai]) VALUES (N'2         ', N'toán ')
INSERT [dbo].[tblTheLoai] ([maloai], [tenloai]) VALUES (N'3         ', N'công nghệ ')
INSERT [dbo].[tblTheLoai] ([maloai], [tenloai]) VALUES (N'4         ', N'lịch sử')
INSERT [dbo].[tblTheLoai] ([maloai], [tenloai]) VALUES (N'5         ', N'địa lý')
INSERT [dbo].[tblTheLoai] ([maloai], [tenloai]) VALUES (N'6         ', N'vật lý')
INSERT [dbo].[tblTheLoai] ([maloai], [tenloai]) VALUES (N'7         ', N'truyện tranh')
GO
INSERT [dbo].[tblThemSach] ([mathem], [manhanvien], [ngaythem], [mota]) VALUES (N'1                                                 ', N'095959595979                                                                                        ', CAST(N'2024-01-06' AS Date), NULL)
INSERT [dbo].[tblThemSach] ([mathem], [manhanvien], [ngaythem], [mota]) VALUES (N'2                                                 ', N'095959595979                                                                                        ', CAST(N'2023-12-31' AS Date), NULL)
INSERT [dbo].[tblThemSach] ([mathem], [manhanvien], [ngaythem], [mota]) VALUES (N'3                                                 ', N'034343434343                                                                                        ', CAST(N'2024-01-08' AS Date), NULL)
INSERT [dbo].[tblThemSach] ([mathem], [manhanvien], [ngaythem], [mota]) VALUES (N'4                                                 ', N'098989898989                                                                                        ', CAST(N'2024-01-10' AS Date), N'khong')
GO
INSERT [dbo].[tblTraSach] ([matra], [manv], [mamuon], [ngaytra]) VALUES (N'1                                                 ', N'095959595979                                                                                        ', N'1                                                 ', CAST(N'2024-01-07' AS Date))
INSERT [dbo].[tblTraSach] ([matra], [manv], [mamuon], [ngaytra]) VALUES (N'2                                                 ', N'095959595979                                                                                        ', N'1                                                 ', CAST(N'2024-01-06' AS Date))
INSERT [dbo].[tblTraSach] ([matra], [manv], [mamuon], [ngaytra]) VALUES (N'3                                                 ', N'095959595979                                                                                        ', N'5                                                 ', CAST(N'2024-01-08' AS Date))
GO
USE [master]
GO
ALTER DATABASE [libraryMng] SET  READ_WRITE 
GO
