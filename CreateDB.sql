
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
        [maphutung] [nvarchar](10) NOT NULL,  
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
        [maphutung] [nvarchar](10) NOT NULL,  
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
    [maphutung] [nvarchar](10) NOT NULL,
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
	[maphutung] [nvarchar](10) NOT NULL,
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


CREATE TABLE [dbo].[tblThamSo]
(
        [tiepnhantoida][int]NOT NULL,
)




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
INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(7,'Hyundai')
GO
INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(8,'fsuzu')
GO
INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(9,'BMW')
GO
INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(10,'Ford')
GO


INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(1,1,1,'51A-138.83')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(2,2,1,'80C-167.23')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(3,5,1,'62A-112.74')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(4,3,2,'78D-64.123')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(5,8,3,'71A-258.93')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(6,6,4,'71C-947.58')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(7,5,5,'70C-687.71')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(8,4,6,'79B-177.38')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(9,9,6,'70C-987.82')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(10,10,6,'40A-787.28')
GO

INSERT INTO [dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[email],[tienno]) VALUES(1,'nguyen hoang vu','ca mau','0948928158','nhv@gmail.com',110000)
GO
INSERT INTO [dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[email],[tienno]) VALUES(2,'nguyen phi long','long an','0871892715','npl@gmail.com',160000)
GO
INSERT INTO [dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[email],[tienno]) VALUES(3,'tran phi anh','bac lieu','7194837408','tpa@gmail.com',40000)
GO
INSERT INTO [dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[email],[tienno]) VALUES(4,'truong long','phu quoc','1748690587','tl@gmail.com',30000)
GO
INSERT INTO [dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[email],[tienno]) VALUES(5,'nguyen tran hoang thanh','soc trang','0967819571','ntht@gmail.com',30000)
GO
INSERT INTO [dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[email],[tienno]) VALUES(6,'tieu nhi','can tho','0897241281','tn@gmail.com',40000)
GO

INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(1,1,'1/1/2018 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(2,2,'1/15/2018 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(3,3,'2/21/2018 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(4,4,'2/28/2018 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(5,5,'3/1/2018 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(6,5,'4/17/2017 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(7,7,'5/19/2017 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(8,8,'6/1/2017 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(9,9,'6/11/2017 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(10,10,'6/15/2017 00:00:00')
GO



INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton],[dongia]) VALUES('10000001','kinh chieu hau',100,30000)
GO
INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton],[dongia]) VALUES('10000002','banh xe',100,30000)
GO
INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton],[dongia]) VALUES('10000003','cabo',100,50000)
GO
INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton],[dongia]) VALUES('10000004','tay lái',100,50000)
GO
INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton],[dongia]) VALUES('10000005','mat na',100,160000)
GO



INSERT INTO [dbo].[tblNhapPhuTung]([manhapphutung] ,[maphutung],[soluong],[ngaytiepnhan]) VALUES(1,'10000001',52,'1/1/2018 00:00:00')
GO
INSERT INTO [dbo].[tblNhapPhuTung]([manhapphutung] ,[maphutung],[soluong],[ngaytiepnhan]) VALUES(2,'10000001',50,'5/2/2018 00:00:00')
GO
INSERT INTO [dbo].[tblNhapPhuTung]([manhapphutung] ,[maphutung],[soluong],[ngaytiepnhan]) VALUES(3,'10000002',103,'1/27/2018 00:00:00')
GO
INSERT INTO [dbo].[tblNhapPhuTung]([manhapphutung] ,[maphutung],[soluong],[ngaytiepnhan]) VALUES(4,'10000003',101,'3/1/2018 00:00:00')
GO
INSERT INTO [dbo].[tblNhapPhuTung]([manhapphutung] ,[maphutung],[soluong],[ngaytiepnhan]) VALUES(5,'10000004',102,'11/27/2017 00:00:00')
GO
INSERT INTO [dbo].[tblNhapPhuTung]([manhapphutung] ,[maphutung],[soluong],[ngaytiepnhan]) VALUES(6,'10000005',102,'12/17/2017 00:00:00')
GO


INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua],[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(1,'Sua Xe',1,40000,'1/25/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(2,'Sua Xe',2,40000,'2/1/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(3,'Sua Xe',3,40000,'2/27/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(4,'Sua Xe',4,170000,'3/1/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(5,'Sua Xe',5,60000,'3/5/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(6,'Sua Xe',6,60000,'4/21/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(7,'Sua Xe',7,40000,'5/21/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(8,'Sua Xe',8,40000,'6/3/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(9,'Sua Xe',9,170000,'6/15/2018 00:00:00')
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([maphieusuachua] ,[noidung],[maxe],[thanhtien],[ngaysuachua]) VALUES(10,'Sua Xe',10,60000,'6/21/2018 00:00:00')
GO


INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(1,1,'10000001',1,30000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(2,2,'10000002',1,30000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(3,3,'10000001',1,30000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(4,4,'10000005',1,160000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(5,5,'10000003',1,50000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(6,6,'10000004',1,50000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(7,7,'10000002',1,30000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(8,8,'10000002',1,30000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(9,9,'10000005',1,160000,10000)
GO
INSERT INTO [dbo].[tblChiTietSuaChua]([machitietsuachua],[maphieusuachua] ,[maphutung],[soluong],[dongia],[tiencong]) VALUES(10,10,'10000004',1,50000,10000)
GO




INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(1,1,'2/1/2018 00:00:00',10000)
GO
INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(2,2,'2/2/2018 00:00:00',10000)
GO
INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(3,3,'2/28/2018 00:00:00',20000)
GO
INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(4,4,'3/2/2018 00:00:00',30000)
GO
INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(5,5,'3/7/2018 00:00:00',10000)
GO
INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(6,6,'4/25/2018 00:00:00',20000)
GO





INSERT INTO [dbo].[tblTaiKhoan] ([taikhoan] ,[matkhau],[quyen] ) VALUES('admin','admin','admin')
GO
INSERT INTO [dbo].[tblTaiKhoan]([taikhoan] ,[matkhau] ,[quyen] ) VALUES('hoangvu','16521454','user')
GO
INSERT INTO [dbo].[tblTaiKhoan]([taikhoan] ,[matkhau] ,[quyen] ) VALUES('vuhoang','16521454','quan ly')
GO

INSERT INTO [dbo].[tblThamSo] ([tiepnhantoida] ) VALUES(30)
GO

