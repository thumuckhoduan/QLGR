
USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLGR')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLGR') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLGR]
END
GO
 
CREATE DATABASE [QLGR]
GO


USE [QLGR]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblHieuXe](
	[mahieuxe] [int] NOT NULL,
	[tenhieuxe] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblHieuXe] PRIMARY KEY CLUSTERED 
(
	[mahieuxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[tblXe](
	[maxe] [int] NOT NULL,
	[mahieuxe] [int] NOT NULL,
	[machuxe] [int] NOT NULL,
	[bienso] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tblXe] PRIMARY KEY CLUSTERED 
(
	[maxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[tblChuXe](
	[machuxe] [int] NOT NULL,
	[tenchuxe] [nvarchar](50) NOT NULL,
    [diachi] [nvarchar](100)NOT NULL,   
	[dienthoai] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[tienno] [int] NOT NULL,
 CONSTRAINT [PK_tblChuXe] PRIMARY KEY CLUSTERED 
(
	[machuxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[tblTiepNhanSuaXe](
	[masuaxe] [int] NOT NULL,
	[maxe] [int] NOT NULL,
    [ngaytiepnhan] [datetime] NOT NULL,   
 CONSTRAINT [PK_tblTiepNhanSuaXe] PRIMARY KEY CLUSTERED 
(
	[masuaxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[tblPhuTung](
        [maphutung] [int] NOT NULL,  
	[tenphutung] [nvarchar](50) NOT NULL,
        [soluongton] [int] NOT NULL,
        [dongia] [int] NOT NULL,
 CONSTRAINT [PK_tblPhuTung] PRIMARY KEY CLUSTERED 
(
	[maphutung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[tblNhapPhuTung](
        [manhapphutung] [int] NOT NULL,
        [maphutung] [int] NOT NULL,  
        [soluong] [int] NOT NULL,
        [ngaytiepnhan] [datetime] NOT NULL, 
 CONSTRAINT [PK_tblNhapPhuTung] PRIMARY KEY CLUSTERED 
(
	[manhapphutung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[tblPhieuSuaChua](
    [maphieusuachua] [int] NOT NULL,
    [noidung] [nvarchar](1000) NOT NULL,
    [maxe]   [int] NOT NULL, 
    [thanhtien] [int] NOT NULL,
    [ngaysuachua] [datetime] NOT NULL,
 CONSTRAINT [PK_tblPhieuSuaChua] PRIMARY KEY CLUSTERED 
(
	[maphieusuachua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[tblChiTietSuaChua](
    [machitietsuachua] [int] NOT NULL,
    [maphieusuachua] [int] NOT NULL,
    [maphutung] [int] NOT NULL,
    [soluong] [int] NOT NULL,
    [dongia] [int] NOT NULL,
    [tiencong] [int] NOT NULL,
 CONSTRAINT [PK_tblChiTietSuaChua] PRIMARY KEY CLUSTERED 
(
	[machitietsuachua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[tblPhieuThuTien](
	[maphieuthu] [int] NOT NULL,
	[maxe] [int] NOT NULL,
        [ngaythu] [datetime] NOT NULL,   
	[sotienthu] [int]	NOT NULL,
 CONSTRAINT [PK_tblPhieuThuTien] PRIMARY KEY CLUSTERED 
(
	[maphieuthu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[tblBaoCaoDoanhSo](
	[madoanhso] [int] NOT NULL,
	[thang] [int] NOT NULL,
        [nam] [int] NOT NULL,
        [tongdoanhthu] [int] NOT NULL,
        [ngaytao] [datetime] NOT NULL,
 CONSTRAINT [PK_tblDoanhSo] PRIMARY KEY CLUSTERED 
(
	[madoanhso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[tblChiTietDoanhSo](
        [machitietdoanhso][int] NOT NULL,
        [madoanhso] [int] NOT NULL,
	[mahieuxe] [int] NOT NULL,
	[soluotsua] [int] NOT NULL,
        [thanhtien] [int] NOT NULL,
        [tile] [float] NOT NULL,
 CONSTRAINT [PK_tblChiTietDoanhSo] PRIMARY KEY CLUSTERED 
(
	[machitietdoanhso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[tblBaoCaoTon](
        [mabaocaoton][int] NOT NULL,
        [thang] [int] NOT NULL,
	[nam] [int] NOT NULL,
        [ngaytao] [datetime] NOT NULL,
 CONSTRAINT [PK_tblBaoCaoTon] PRIMARY KEY CLUSTERED 
(
	[mabaocaoton] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[tblChiTietBaoCaoTon](
      [machitietbaocaoton][int] NOT NULL,
    [mabaocaoton] [int] NOT NULL,
	[maphutung] [int] NOT NULL,
	[tondau] [int] NOT NULL,
	[nhapthem] [int] NOT NULL,
	[ban] [int] NOT NULL,
	[toncuoi] [int] NOT NULL,
 CONSTRAINT [PK_tblChiTietBaoCaoTon] PRIMARY KEY CLUSTERED 
(
	[machitietbaocaoton] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[tblTaiKhoan](
        [taikhoan][nvarchar](10) NOT NULL,
        [matkhau] [nvarchar](10) NOT NULL,
	 [quyen] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tblTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]




INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(1,'honda')
GO
INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(2,'suzuki')
GO
INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(3,'mercury')
GO
INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(4,'isuzu')
GO
INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(5,'subara')
GO
INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(6,'lancia')
GO



INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(1,1,1,'51A-138.83')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(2,2,1,'80C-167.23')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(3,5,1,'62A-112.74')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(4,3,2,'78D-64.123')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(5,4,3,'71A-258.93')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(6,4,3,'71C-947.58')
GO



INSERT INTO [dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[email],[tienno]) VALUES(1,'nguyen hoang vu','ca mau','0948928158','nhv@gmail.com',100000)
GO
INSERT INTO [dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[email],[tienno]) VALUES(2,'nguyen tran hoang thanh','soc trang','0967819571','ntht@gmail.com',200000)
GO
INSERT INTO [dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[email],[tienno]) VALUES(3,'nguyen phi long','long an','0948928158','npl@gmail.com',310000)
GO



INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(1,1,'1/1/2018 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(2,2,'1/15/2018 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(3,3,'3/21/2018 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(4,4,'2/19/2018 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(5,5,'5/20/2018 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(6,5,'12/18/2017 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(7,6,'11/1/2017 00:00:00')
GO



INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton],[dongia]) VALUES(1,'kinh chieu hau',100,30000)
GO
INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton],[dongia]) VALUES(2,'banh xe',100,30000)
GO
INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton],[dongia]) VALUES(3,'cabo',100,50000)
GO
INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton],[dongia]) VALUES(4,'tay lái',100,50000)
GO
INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton],[dongia]) VALUES(5,'mat na',100,160000)
GO



INSERT INTO [dbo].[tblNhapPhuTung]([manhapphutung] ,[maphutung],[soluong],[ngaytiepnhan]) VALUES(1,1,30,'1/1/2018 00:00:00')
GO
INSERT INTO [dbo].[tblNhapPhuTung]([manhapphutung] ,[maphutung],[soluong],[ngaytiepnhan]) VALUES(2,3,50,'2/1/2018 00:00:00')
GO
INSERT INTO [dbo].[tblNhapPhuTung]([manhapphutung] ,[maphutung],[soluong],[ngaytiepnhan]) VALUES(3,4,10,'5/14/2018 00:00:00')
GO
INSERT INTO [dbo].[tblNhapPhuTung]([manhapphutung] ,[maphutung],[soluong],[ngaytiepnhan]) VALUES(4,2,6,'2/1/2018 00:00:00')
GO
INSERT INTO [dbo].[tblNhapPhuTung]([manhapphutung] ,[maphutung],[soluong],[ngaytiepnhan]) VALUES(5,5,7,'7/18/2017 00:00:00')
GO
INSERT INTO [dbo].[tblNhapPhuTung]([manhapphutung] ,[maphutung],[soluong],[ngaytiepnhan]) VALUES(6,1,16,'12/17/2017 00:00:00')
GO



INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua],[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(1,'Thay Cabo',1,65000,'1/5/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(2,'Thay Kính Chiếu Hậu',3,40000,'4/1/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(3,'Thay Bánh xe Và Cabo',5,140000,'5/21/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(4,'Thay Toàn Bộ',6,450000,'11/20/2017 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(5,'Thay Mặt Nạ',4,178000,'2/21/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(6,'Sữa Bánh Xe',2,38000,'1/21/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(7,'Thay tay lái',5,65000,'1/1/2018 00:00:00')
GO



INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(1,1,3,1,50000,15000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(2,2,1,1,30000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(3,3,2,2,60000,20000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(4,3,3,1,50000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(5,4,1,1,30000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(6,4,2,2,30000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(7,4,3,1,50000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(8,4,4,2,50000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(9,4,5,1,160000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(10,5,5,1,160000,18000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(11,6,2,1,30000,8000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(12,7,4,1,50000,15000)
GO



INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(1,1,'1/10/2018 00:00:00',30000)
GO
INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(2,2,'2/5/2018 00:00:00',18000)
GO
INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(3,3,'2/14/2018 00:00:00',10000)
GO
INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(4,4,'2/30/2018 00:00:00',150000)
GO

INSERT INTO [dbo].[tblBaoCaoDoanhSo]([madoanhso] ,[thang] ,[nam] ,[tongdoanhthu] ,[ngaytao]) VALUES(1,4,2018,100000,'6/8/2017 00:00:00')
GO

INSERT INTO [dbo].[tblChiTietDoanhSo]([machitietdoanhso],[madoanhso] ,[mahieuxe] ,[soluotsua] ,[thanhtien] ,[tile] ) VALUES(1,1,1,1,100000,1)
GO


INSERT INTO [dbo].[tblBaoCaoTon]([mabaocaoton],[thang] ,[nam],[ngaytao]) VALUES(1,1,2018,'6/21/2018 00:00:00')
GO


INSERT INTO [dbo].[tblChiTietBaoCaoTon]([machitietbaocaoton] ,[mabaocaoton] ,[maphutung] ,[tondau] ,[nhapthem],[ban],[toncuoi] ) VALUES(1,1,1,100,10,10,100)
GO



INSERT INTO [dbo].[tblTaiKhoan] ([taikhoan] ,[matkhau] ,[quyen] ) VALUES('admin','admin','admin')
GO
INSERT INTO [dbo].[tblTaiKhoan]([taikhoan] ,[matkhau] ,[quyen] ) VALUES('hoangvu','16521454','user')
GO


