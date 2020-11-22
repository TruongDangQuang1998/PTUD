USE [DangKyHocPhan]
GO
/****** Object:  Table [dbo].[CanBoDaoTao]    Script Date: 2020-11-18 8:04:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CanBoDaoTao](
	[Id] [int] NOT NULL,
	[TaiKhoanId] [int] NOT NULL,
	[MaCBDT] [int] NOT NULL,
	[ChucVu] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CanBoDaoTao_LopHocPhan]    Script Date: 2020-11-18 8:04:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CanBoDaoTao_LopHocPhan](
	[Id] [int] NOT NULL,
	[CanBoId] [int] NULL,
	[LopHocPhanId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuongTrinhKhung]    Script Date: 2020-11-18 8:04:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuongTrinhKhung](
	[Id] [int] NOT NULL,
	[MaChuongTrinhKhung] [nvarchar](255) NULL,
	[HocKy] [int] NOT NULL,
	[MonHocId] [int] NOT NULL,
	[HocPhan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 2020-11-18 8:04:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[Id] [int] NOT NULL,
	[MaGiangVien] [int] NOT NULL,
	[TaiKhoanId] [int] NOT NULL,
	[ChuyenNganh] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHocPhan]    Script Date: 2020-11-18 8:04:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHocPhan](
	[Id] [int] NOT NULL,
	[MaLopHocPhan] [nvarchar](255) NULL,
	[MaMonHoc] [int] NULL,
	[GiangVienId] [int] NULL,
	[SiSoDaDangKy] [int] NOT NULL,
	[SiSoToiDa] [int] NOT NULL,
	[TrangThai] [int] NULL,
	[HocKy] [int] NULL,
	[NamHoc] [int] NULL,
	[PhongHocId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 2020-11-18 8:04:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[Id] [int] NOT NULL,
	[MaMonHoc] [int] NOT NULL,
	[TenMonHoc] [nvarchar](255) NOT NULL,
	[SoTinChi] [int] NOT NULL,
	[SoTinChiLyThuyet] [int] NOT NULL,
	[SoTinChiThucHanh] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHocHP]    Script Date: 2020-11-18 8:04:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHocHP](
	[Id] [int] NOT NULL,
	[MaMonHocPhan] [nvarchar](255) NULL,
	[MonHocId] [int] NOT NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongHoc]    Script Date: 2020-11-18 8:04:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongHoc](
	[Id] [int] NOT NULL,
	[TenPH] [nvarchar](255) NOT NULL,
	[SoLuongChua] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 2020-11-18 8:04:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[Id] [int] NOT NULL,
	[TaiKhoanId] [int] NOT NULL,
	[MSSV] [nvarchar](10) NOT NULL,
	[Khoa] [nvarchar](255) NULL,
	[NamHoc] [nvarchar](255) NULL,
	[He] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien_LopHocPhan]    Script Date: 2020-11-18 8:04:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien_LopHocPhan](
	[Id] [int] NOT NULL,
	[SinhVienId] [int] NOT NULL,
	[LopHocPhanId] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien_MonHocHP]    Script Date: 2020-11-18 8:04:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien_MonHocHP](
	[SinhVienId] [int] NOT NULL,
	[LopHocPhanId] [int] NOT NULL,
	[TrangThai] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2020-11-18 8:04:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Id] [int] NOT NULL,
	[UserName] [nvarchar](255) NOT NULL,
	[UserPassWord] [nvarchar](255) NOT NULL,
	[Role] [int] NULL,
	[Ten] [nvarchar](255) NOT NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [int] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[SoDienThoai] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CanBoDaoTao]  WITH CHECK ADD FOREIGN KEY([TaiKhoanId])
REFERENCES [dbo].[TaiKhoan] ([Id])
GO
ALTER TABLE [dbo].[CanBoDaoTao_LopHocPhan]  WITH CHECK ADD FOREIGN KEY([CanBoId])
REFERENCES [dbo].[CanBoDaoTao] ([Id])
GO
ALTER TABLE [dbo].[CanBoDaoTao_LopHocPhan]  WITH CHECK ADD FOREIGN KEY([LopHocPhanId])
REFERENCES [dbo].[LopHocPhan] ([Id])
GO
ALTER TABLE [dbo].[ChuongTrinhKhung]  WITH CHECK ADD FOREIGN KEY([MonHocId])
REFERENCES [dbo].[MonHoc] ([Id])
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD FOREIGN KEY([TaiKhoanId])
REFERENCES [dbo].[TaiKhoan] ([Id])
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD FOREIGN KEY([GiangVienId])
REFERENCES [dbo].[GiangVien] ([Id])
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHocHP] ([Id])
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD FOREIGN KEY([PhongHocId])
REFERENCES [dbo].[PhongHoc] ([Id])
GO
ALTER TABLE [dbo].[MonHocHP]  WITH CHECK ADD FOREIGN KEY([MonHocId])
REFERENCES [dbo].[MonHoc] ([Id])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([TaiKhoanId])
REFERENCES [dbo].[TaiKhoan] ([Id])
GO
ALTER TABLE [dbo].[SinhVien_LopHocPhan]  WITH CHECK ADD FOREIGN KEY([LopHocPhanId])
REFERENCES [dbo].[LopHocPhan] ([Id])
GO
ALTER TABLE [dbo].[SinhVien_LopHocPhan]  WITH CHECK ADD FOREIGN KEY([SinhVienId])
REFERENCES [dbo].[SinhVien] ([Id])
GO
ALTER TABLE [dbo].[SinhVien_MonHocHP]  WITH CHECK ADD FOREIGN KEY([LopHocPhanId])
REFERENCES [dbo].[LopHocPhan] ([Id])
GO
ALTER TABLE [dbo].[SinhVien_MonHocHP]  WITH CHECK ADD FOREIGN KEY([SinhVienId])
REFERENCES [dbo].[SinhVien] ([Id])
GO
