USE [QuanLyKhoVatLieu]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/26/2021 8:08:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaCTHD] [nchar](50) NOT NULL,
	[MaSP] [nchar](50) NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [pk_ma_ct_va_msp] PRIMARY KEY CLUSTERED 
(
	[MaCTHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuNhapHang]    Script Date: 11/26/2021 8:08:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhapHang](
	[ThanhTien] [float] NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/26/2021 8:08:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nchar](50) NOT NULL,
	[MaNV] [nchar](50) NOT NULL,
	[SDT_KH] [nvarchar](20) NULL,
	[Ngay_GH] [nvarchar](50) NULL,
	[DiaChi_GH] [nvarchar](max) NULL,
	[TongTien_GH] [float] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/26/2021 8:08:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](50) NOT NULL,
	[TenKH] [nvarchar](max) NULL,
	[NgaySinh] [nvarchar](max) NULL,
	[SDT] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[Email] [nvarchar](500) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 11/26/2021 8:08:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoHang](
	[MaKhoHang] [nchar](50) NOT NULL,
	[MaNV] [nchar](50) NULL,
	[TenKhoHang] [nvarchar](max) NULL,
	[SDT] [nvarchar](20) NULL,
	[DiaChiKhoHang] [nvarchar](max) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaKhoHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 11/26/2021 8:08:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] [nchar](50) NOT NULL,
	[TenloaiSanPham] [nvarchar](max) NULL,
	[MaNV] [nchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 11/26/2021 8:08:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 11/26/2021 8:08:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapHang](
	[MaPhieuNhapHang] [nchar](50) NOT NULL,
	[MaNV] [nchar](50) NOT NULL,
	[NgayNhapHang] [nvarchar](max) NULL,
	[TongTien] [float] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_PhieuNhapHang] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhapHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/26/2021 8:08:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nchar](50) NOT NULL,
	[MaKhoHang] [nchar](50) NULL,
	[TenSP] [nvarchar](max) NULL,
	[MaLoaiSanPham] [nchar](50) NOT NULL,
	[TenNhaCungCap] [nvarchar](max) NULL,
	[DonGia] [float] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/26/2021 8:08:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [nchar](50) NOT NULL,
	[TenTK] [nvarchar](max) NULL,
	[NhanVien] [bigint] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[SDT] [nvarchar](20) NULL,
	[Email] [nvarchar](200) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[TaiKhoan] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[HinhAnh] [varbinary](50) NULL,
 CONSTRAINT [PK_NhanVien_1] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaSP], [SoLuong], [ThanhTien]) VALUES (N'M01                                               ', N'SP01                                              ', 10, 2200000)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaSP], [SoLuong], [ThanhTien]) VALUES (N'M02                                               ', N'SP02                                              ', 10, 2800000)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaSP], [SoLuong], [ThanhTien]) VALUES (N'M03                                               ', N'SP03                                              ', 10, 870000)
INSERT [dbo].[ChiTietPhieuNhapHang] ([ThanhTien], [SoLuong]) VALUES (2200000, 10)
INSERT [dbo].[ChiTietPhieuNhapHang] ([ThanhTien], [SoLuong]) VALUES (2800000, 10)
INSERT [dbo].[ChiTietPhieuNhapHang] ([ThanhTien], [SoLuong]) VALUES (870000, 10)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [SDT_KH], [Ngay_GH], [DiaChi_GH], [TongTien_GH]) VALUES (N'M01                                               ', N'TK1                                               ', N'0943000013', N'15/5/2020', N'Cần thơ', 2200000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [SDT_KH], [Ngay_GH], [DiaChi_GH], [TongTien_GH]) VALUES (N'M02                                               ', N'TK2                                               ', N'0939123465', N'10/6/2020', N'Sóc Trăng', 2800000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [SDT_KH], [Ngay_GH], [DiaChi_GH], [TongTien_GH]) VALUES (N'M03                                               ', N'TK2                                               ', N'0939123465', N'10/6/2020', N'Sóc Trăng', 870000)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [SDT], [DiaChi], [Email]) VALUES (N'KH1                                               ', N'Nguyễn Văn An', N'11/08/2001', N'0943000020', N'Cần Thơ', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [SDT], [DiaChi], [Email]) VALUES (N'KH2                                               ', N'Trần Thị B', N'01/01/1980', N'0939123465', N'Sóc Trăng', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [SDT], [DiaChi], [Email]) VALUES (N'KH3                                               ', N'a', N'11/4/2021', N'1', N'a', N'a')
INSERT [dbo].[KhoHang] ([MaKhoHang], [MaNV], [TenKhoHang], [SDT], [DiaChiKhoHang], [GhiChu]) VALUES (N'KH1                                               ', N'TK1                                               ', N'Kho 1', N'0332626318', N'Liên Tổ 5_6 Phường An Khánh Quận Ninh Kiều TP Cần Thơ', NULL)
INSERT [dbo].[KhoHang] ([MaKhoHang], [MaNV], [TenKhoHang], [SDT], [DiaChiKhoHang], [GhiChu]) VALUES (N'KH2                                               ', N'TK2                                               ', N'Kho 2', N'0332626319', N'Khu 1 Xã Thạnh Phú, Huyện Mỹ Xuyên Tỉnh Sóc Trăng', NULL)
INSERT [dbo].[KhoHang] ([MaKhoHang], [MaNV], [TenKhoHang], [SDT], [DiaChiKhoHang], [GhiChu]) VALUES (N'KH3                                               ', N'TK1                                               ', N'Kho 3 vinna', N'763836005', N'Cần thơ đường 30/4', N'Đang xây dựng')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenloaiSanPham], [MaNV]) VALUES (N'LS1                                               ', N'sat', N'TK1                                               ')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenloaiSanPham], [MaNV]) VALUES (N'LS2                                               ', N'Đá', N'TK2                                               ')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenloaiSanPham], [MaNV]) VALUES (N'LS3                                               ', N'Cát', N'TK1                                               ')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenloaiSanPham], [MaNV]) VALUES (N'LS4                                               ', N'Ván', N'TK1                                               ')
INSERT [dbo].[NguoiDung] ([TaiKhoan], [MatKhau]) VALUES (N'hoangphuc', N'hoangphuc')
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhapHang], [MaNV], [NgayNhapHang], [TongTien], [TinhTrang]) VALUES (N'PN01                                              ', N'TK1                                               ', N'01/01/2020', 2200000, NULL)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhapHang], [MaNV], [NgayNhapHang], [TongTien], [TinhTrang]) VALUES (N'PN02                                              ', N'TK2                                               ', N'01/01/2020', 2800000, NULL)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhapHang], [MaNV], [NgayNhapHang], [TongTien], [TinhTrang]) VALUES (N'PN03                                              ', N'TK1                                               ', N'01/01/2020', 870000, NULL)
INSERT [dbo].[SanPham] ([MaSP], [MaKhoHang], [TenSP], [MaLoaiSanPham], [TenNhaCungCap], [DonGia], [SoLuong]) VALUES (N'SP1                                               ', N'KH1                                               ', N'Cát', N'LS1                                               ', N'VLXD Minh Khải', 220, 10)
INSERT [dbo].[SanPham] ([MaSP], [MaKhoHang], [TenSP], [MaLoaiSanPham], [TenNhaCungCap], [DonGia], [SoLuong]) VALUES (N'SP2                                               ', N'KH2                                               ', N'Đá', N'LS2                                               ', N'VLXD Minh Khải', 280, 10)
INSERT [dbo].[SanPham] ([MaSP], [MaKhoHang], [TenSP], [MaLoaiSanPham], [TenNhaCungCap], [DonGia], [SoLuong]) VALUES (N'SP3                                               ', N'KH3                                               ', N'Xi-Măng', N'LS1                                               ', N'VLXD Minh Khải', 87, 10)
INSERT [dbo].[SanPham] ([MaSP], [MaKhoHang], [TenSP], [MaLoaiSanPham], [TenNhaCungCap], [DonGia], [SoLuong]) VALUES (N'SP4                                               ', N'KH3                                               ', N'ccc', N'LS3                                               ', N'cccc', 1, 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [NhanVien], [GioiTinh], [SDT], [Email], [DiaChi], [TaiKhoan], [MatKhau], [HinhAnh]) VALUES (N'TK1                                               ', N'Nguyễn Văn An', 0, N'Nam', N'0939521115', N'nguyenvanan@gmail.com', N'Ấp Sóc Bưng, Xã Thạnh Phú, Mỹ Xuyên,Sóc Trăng', N'antlt1', N'012210', NULL)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [NhanVien], [GioiTinh], [SDT], [Email], [DiaChi], [TaiKhoan], [MatKhau], [HinhAnh]) VALUES (N'TK2                                               ', N'Ngyễn Lâm Băng ', 1, N'Nữ', N'0379101816', N'nguyenlambang83@gmail.com', N'Khu 1, Huyện Kế Sách, Tỉnh Sóc Trăng', N'bang83', N'123456', NULL)
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_cthd_d_hd] FOREIGN KEY([MaCTHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [fk_cthd_d_hd]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[KhoHang]  WITH CHECK ADD  CONSTRAINT [FK_KhoHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KhoHang] CHECK CONSTRAINT [FK_KhoHang_NhanVien]
GO
ALTER TABLE [dbo].[LoaiSanPham]  WITH CHECK ADD  CONSTRAINT [FK_LoaiSanPham_LoaiSanPham] FOREIGN KEY([MaLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSanPham])
GO
ALTER TABLE [dbo].[LoaiSanPham] CHECK CONSTRAINT [FK_LoaiSanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuNhapHang] CHECK CONSTRAINT [FK_PhieuNhapHang_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([MaLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSanPham])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
