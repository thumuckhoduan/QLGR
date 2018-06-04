
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

GO

USE [QLGR]
GO


INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(1,'honda')
GO

INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(2,'suzuki')
GO

INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(3,'mercury')
GO
INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(4,'isuzu')
GO
INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(6,'subara')
GO
INSERT INTO [dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(6,'lancia')
GO




USE [QLGR]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

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

GO

USE [QLGR]
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


USE [QLGR]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTiepNhanSuaXe](
	[masuaxe] [int] NOT NULL,
	[maxe] [int] NOT NULL,
        [ngaytiepnhan] [datetime] NOT NULL,   
 CONSTRAINT [PK_tblTiepNhanSuaXe] PRIMARY KEY CLUSTERED 
(
	[masuaxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


USE [QLGR]
GO

INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(1,1,'10/26/2018 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(2,2,'8/9/2018 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(3,3,'11/7/2018 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(4,4,'1/29/2017 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(5,5,'10/26/2017 00:00:00')
GO
INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(6,6,'10/26/2017 00:00:00')
GO

USE [QLGR]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
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

USE [QLGR]
GO

INSERT INTO [dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[email],[tienno]) VALUES(1,'nguyen hoang vu','ca mau','0948928158','nhv@gmail.com',100000)
GO
INSERT INTO [dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[email],[tienno]) VALUES(2,'nguyen tran hoang thanh','soc trang','0967819571','ntht@gmail.com',200000)
GO
INSERT INTO [dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[email],[tienno]) VALUES(3,'nguyen phi long','long an','0948928158','npl@gmail.com',310000)
GO

USE [QLGR]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuThuTien](
	[maphieuthu] [int] NOT NULL,
	[maxe] [int] NOT NULL,
        [ngaythu] [datetime] NOT NULL,   
	[sotienthu] [nvarchar](50)	NOT NULL,
 CONSTRAINT [PK_tblPhieuThuTien] PRIMARY KEY CLUSTERED 
(
	[maphieuthu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


USE [QLGR]
GO

INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(1,1,'10/27/2018 00:00:00','80000')
GO
INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(2,2,'9/9/2018 00:00:00','50000')
GO
INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(3,4,'2/1/2018 00:00:00','1000')
GO
INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(4,6,'12/30/2018 00:00:00','70000')
GO

USE [QLGR]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhuTung](
	[maphutung] [int] NOT NULL,
	[tenphutung] [nvarchar](50) NOT NULL,
    [soluongton] [int] NOT NULL,   
 CONSTRAINT [PK_tblPhuTung] PRIMARY KEY CLUSTERED 
(
	[maphutung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


USE [QLGR]
GO

INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton]) VALUES(1,'kinh chieu hau',100)
GO
INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton]) VALUES(2,'banh xe',10)
GO
INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton]) VALUES(3,'cabo',1)
GO



USE [QLGR]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuSuaChua](
	[masuachua] [int] NOT NULL,
	[noidung] [nvarchar](1000) NOT NULL,
        [maxe]   [int] NOT NULL, 
        [thanhtien] [int] NOT NULL,
 CONSTRAINT [PK_tblPhieuSuaChua] PRIMARY KEY CLUSTERED 
(
	[masuachua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



USE [QLGR]
GO

INSERT INTO [dbo].[tblPhieuSuaChua]([masuachua],[noidung],[maxe],[thanhtien]) VALUES(1,'thay cabo',3,200000)
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([masuachua] ,[noidung],[maxe],[thanhtien]) VALUES(2,'thay kinh chieu hau',1,100000)
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([masuachua] ,[noidung],[maxe],[thanhtien]) VALUES(3,'thay banh xe va cabo',4,340000)
GO



USE [QLGR]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietSuaChua](
	[masuachua] [int] NOT NULL,
	[machitietsuachua] [int] NOT NULL,
        [maphutung] [int] NOT NULL,
        [soluong] [int] NOT NULL,
        [dongia] [int] NOT NULL,
        [tiencong] [int] NOT NULL,
 CONSTRAINT [PK_tblChiTietSuaChua] PRIMARY KEY CLUSTERED 
(
	[machitietsuachua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


USE [QLGR]
GO

INSERT INTO [dbo].[tblPhieuSuaChua]([machitietsuachua],[masuachua] ,[maphutung],[soluong],[dongia],[thanhtien]) VALUES(1,1,3,1,200000,200000)
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([machitietsuachua],[masuachua] ,[maphutung],[soluong],[dongia],[thanhtien]) VALUES(2,2,1,1,100000,100000)
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([machitietsuachua],[masuachua] ,[maphutung],[soluong],[dongia],[thanhtien]) VALUES(3,3,2,4,50000,200000)
GO
INSERT INTO [dbo].[tblPhieuSuaChua]([machitietsuachua],[masuachua] ,[maphutung],[soluong],[dongia],[thanhtien]) VALUES(3,3,3,1,140000,100000)
GO