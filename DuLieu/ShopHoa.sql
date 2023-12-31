USE [ShopHoa]
GO
ALTER TABLE [dbo].[HoaDon] DROP CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[CTBanHang] DROP CONSTRAINT [FK_CTBanHang_SanPham]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 21/06/2023 4:10:14 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaiKhoan]') AND type in (N'U'))
DROP TABLE [dbo].[TaiKhoan]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 21/06/2023 4:10:14 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SanPham]') AND type in (N'U'))
DROP TABLE [dbo].[SanPham]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 21/06/2023 4:10:14 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien]') AND type in (N'U'))
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 21/06/2023 4:10:14 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhachHang]') AND type in (N'U'))
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 21/06/2023 4:10:14 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HoaDon]') AND type in (N'U'))
DROP TABLE [dbo].[HoaDon]
GO
/****** Object:  Table [dbo].[CTBanHang]    Script Date: 21/06/2023 4:10:14 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CTBanHang]') AND type in (N'U'))
DROP TABLE [dbo].[CTBanHang]
GO
/****** Object:  Table [dbo].[CTBanHang]    Script Date: 21/06/2023 4:10:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTBanHang](
	[Masp] [nvarchar](50) NOT NULL,
	[Sohd] [int] NOT NULL,
	[Soluong] [int] NULL,
	[Dongia] [money] NULL,
 CONSTRAINT [PK_CTBanHang] PRIMARY KEY CLUSTERED 
(
	[Masp] ASC,
	[Sohd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 21/06/2023 4:10:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[Sohd] [int] NOT NULL,
	[Ngaylap] [date] NULL,
	[Nguoilap] [nvarchar](max) NULL,
	[Makh] [nvarchar](50) NULL,
	[Manv] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[Sohd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 21/06/2023 4:10:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Makh] [nvarchar](50) NOT NULL,
	[Tenkh] [nvarchar](max) NULL,
	[Gioitinh] [nvarchar](50) NULL,
	[Diachi] [nvarchar](max) NULL,
	[Sodt] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[Makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 21/06/2023 4:10:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Manv] [nvarchar](50) NOT NULL,
	[Tennv] [nvarchar](max) NULL,
	[Gioitinh] [nvarchar](50) NULL,
	[Diachi] [nvarchar](max) NULL,
	[Sodt] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 21/06/2023 4:10:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[Masp] [nvarchar](50) NOT NULL,
	[Tensp] [nvarchar](max) NULL,
	[Soluong] [int] NULL,
	[Dongia] [money] NULL,
	[NSX] [nvarchar](50) NULL,
	[Loaisp] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[Masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 21/06/2023 4:10:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Tendn] [nvarchar](max) NULL,
	[Matkhau] [nvarchar](max) NULL,
	[Quyen] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[CTBanHang] ([Masp], [Sohd], [Soluong], [Dongia]) VALUES (N'H001', 112416, 1, 150.0000)
INSERT [dbo].[CTBanHang] ([Masp], [Sohd], [Soluong], [Dongia]) VALUES (N'H01', 1122345, 1, 15.0000)
GO
INSERT [dbo].[HoaDon] ([Sohd], [Ngaylap], [Nguoilap], [Makh], [Manv]) VALUES (112345, CAST(N'2023-06-03' AS Date), N'Trần Văn A', N'KH01', N'NV01')
INSERT [dbo].[HoaDon] ([Sohd], [Ngaylap], [Nguoilap], [Makh], [Manv]) VALUES (112346, CAST(N'2023-06-04' AS Date), N'Nguyễn Thúy K', N'KH02', N'NV03')
INSERT [dbo].[HoaDon] ([Sohd], [Ngaylap], [Nguoilap], [Makh], [Manv]) VALUES (112347, CAST(N'2022-05-05' AS Date), N'Nguyễn Thúy K', N'KH02', N'NV03')
INSERT [dbo].[HoaDon] ([Sohd], [Ngaylap], [Nguoilap], [Makh], [Manv]) VALUES (112412, CAST(N'2006-06-06' AS Date), N'Trần Văn A', N'KH03', N'NV01')
INSERT [dbo].[HoaDon] ([Sohd], [Ngaylap], [Nguoilap], [Makh], [Manv]) VALUES (112413, CAST(N'2022-09-08' AS Date), N'Nguyễn Thúy K', N'KH03', N'NV03')
INSERT [dbo].[HoaDon] ([Sohd], [Ngaylap], [Nguoilap], [Makh], [Manv]) VALUES (112415, CAST(N'2021-07-06' AS Date), N'Trần Văn A', N'KH01', N'NV01')
GO
INSERT [dbo].[KhachHang] ([Makh], [Tenkh], [Gioitinh], [Diachi], [Sodt]) VALUES (N'KH01', N'Trần Văn H', N'Nam', N'Bình Khánh', N'0546988745')
INSERT [dbo].[KhachHang] ([Makh], [Tenkh], [Gioitinh], [Diachi], [Sodt]) VALUES (N'KH02', N'Nguyễn Không H', N'Nam', N'Long Xuyên', N'0655998855')
INSERT [dbo].[KhachHang] ([Makh], [Tenkh], [Gioitinh], [Diachi], [Sodt]) VALUES (N'KH03', N'Bùi Ngọc C', N'Nữ', N'Tịnh Biên', N'0354644484')
INSERT [dbo].[KhachHang] ([Makh], [Tenkh], [Gioitinh], [Diachi], [Sodt]) VALUES (N'KH04', N'Lăng Minh T', N'Nữ', N'Châu Đốc', N'0366695555')
GO
INSERT [dbo].[NhanVien] ([Manv], [Tennv], [Gioitinh], [Diachi], [Sodt]) VALUES (N'NV01', N'Trần Văn A', N'Nam', N'Long Xuyên', N'0354655987')
INSERT [dbo].[NhanVien] ([Manv], [Tennv], [Gioitinh], [Diachi], [Sodt]) VALUES (N'NV02', N'Nguyễn Minh B', N'Nam', N'Tri Tôn', N'0254468787')
INSERT [dbo].[NhanVien] ([Manv], [Tennv], [Gioitinh], [Diachi], [Sodt]) VALUES (N'NV03', N'Nguyễn Thúy K', N'Nữ', N'Long Xuyên', N'0366599985')
INSERT [dbo].[NhanVien] ([Manv], [Tennv], [Gioitinh], [Diachi], [Sodt]) VALUES (N'NV04', N'Nguyễn Châu H', N'Nữ', N'Châu Thành', N'0365499888')
GO
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Dongia], [NSX], [Loaisp]) VALUES (N'H0001', N'Bó Nhiều Hoa Sáp', 10, 250.0000, N'MTShop', 3)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Dongia], [NSX], [Loaisp]) VALUES (N'H0002', N'Bó Hoa Hồng Sáp Lớn ', 15, 255.0000, N'MTShop', 3)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Dongia], [NSX], [Loaisp]) VALUES (N'H0003', N'Bó Hoa Cúc Sáp Lớn', 10, 275.0000, N'MTShop', 3)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Dongia], [NSX], [Loaisp]) VALUES (N'H001', N'Bó Hoa TuLip Sáp', 20, 150.0000, N'MTShop', 2)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Dongia], [NSX], [Loaisp]) VALUES (N'H002', N'Bó Hoa Hướng Dương Sáp', 25, 155.0000, N'MTShop', 2)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Dongia], [NSX], [Loaisp]) VALUES (N'H003', N'Bó Hoa Cúc Sáp', 20, 175.0000, N'MTShop', 2)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Dongia], [NSX], [Loaisp]) VALUES (N'H01', N'Hoa Hồng Sáp', 10, 15.0000, N'MTShop', 1)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Dongia], [NSX], [Loaisp]) VALUES (N'H02', N'Hoa Cúc Sáp', 10, 15.0000, N'MTShop', 1)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Dongia], [NSX], [Loaisp]) VALUES (N'H03', N'Hoa Hướng Dương Sáp', 10, 15.0000, N'MTShop', 1)
GO
INSERT [dbo].[TaiKhoan] ([Tendn], [Matkhau], [Quyen]) VALUES (N'admin', N'admin', 1)
INSERT [dbo].[TaiKhoan] ([Tendn], [Matkhau], [Quyen]) VALUES (N'nhanvien', N'nhanvien', 2)
INSERT [dbo].[TaiKhoan] ([Tendn], [Matkhau], [Quyen]) VALUES (N'Khach1', N'khach1', 2)
INSERT [dbo].[TaiKhoan] ([Tendn], [Matkhau], [Quyen]) VALUES (N'NV28', N'321', 2)
INSERT [dbo].[TaiKhoan] ([Tendn], [Matkhau], [Quyen]) VALUES (N'nv5', N'nv6', 2)
INSERT [dbo].[TaiKhoan] ([Tendn], [Matkhau], [Quyen]) VALUES (N'khach01', N'k01', 2)
GO
ALTER TABLE [dbo].[CTBanHang]  WITH CHECK ADD  CONSTRAINT [FK_CTBanHang_SanPham] FOREIGN KEY([Masp])
REFERENCES [dbo].[SanPham] ([Masp])
GO
ALTER TABLE [dbo].[CTBanHang] CHECK CONSTRAINT [FK_CTBanHang_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([Makh])
REFERENCES [dbo].[KhachHang] ([Makh])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
