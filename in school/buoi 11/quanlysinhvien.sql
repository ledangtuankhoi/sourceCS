USE [master]
GO
/****** Object:  Database [QuanLyBanHang]    Script Date: 28/12/2020 8:43:55 SA ******/
CREATE DATABASE [QuanLyBanHang]
 
USE [QuanLyBanHang]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 28/12/2020 8:43:56 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[MaSP] [nchar](10) NOT NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 28/12/2020 8:43:56 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL,
	[NgayLapHD] [date] NULL,
	[NgayNH] [date] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 28/12/2020 8:43:56 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[TenCty] [nchar](10) NULL,
	[DiaChi] [nchar](10) NULL,
	[ThanhPho] [nvarchar](50) NULL,
	[DienThoai] [nchar](10) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 28/12/2020 8:43:56 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[Ho] [varchar](50) NULL,
	[Ten] [varchar](50) NULL,
	[Nu] [char](10) NULL,
	[NgayVL] [date] NULL,
	[DiaChi] [nchar](10) NULL,
	[DienThoai] [nchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 28/12/2020 8:43:56 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nchar](10) NOT NULL,
	[TenSP] [nchar](10) NULL,
	[DonViTinh] [nchar](10) NULL,
	[DonGia] [int] NULL,
	[Hinh] [image] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThanhPho]    Script Date: 28/12/2020 8:43:56 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhPho](
	[ThanhPho] [nvarchar](50) NOT NULL,
	[TenThanhPho] [nvarchar](50) NULL,
 CONSTRAINT [PK_ThanhPho] PRIMARY KEY CLUSTERED 
(
	[ThanhPho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

