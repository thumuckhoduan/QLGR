
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

INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(1,1,1,N'352')
GO
INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[machuxe],[bienso]) VALUES(2,2,2,N'3522')
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

INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(1,1,'12/30/2017 00:00:00')
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
INSERT INTO [dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[email],[tienno]) VALUES(2,'nguyen tran hoang thanh','viet nam','28292782','ntht@gmail.com',200000)
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

INSERT INTO [dbo].[tblPhieuThuTien]([maphieuthu],[maxe],[ngaythu],[sotienthu]) VALUES(1,1,'12/30/2017 00:00:00','100000')
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

INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton]) VALUES(1,'A',10)
GO
INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton]) VALUES(2,'B',10)
GO
INSERT INTO [dbo].[tblPhuTung]([maphutung],[tenphutung],[soluongton]) VALUES(3,'C',10)
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
        [maxe]   [int] NOLL NULL, 
        [thanhtien] [int] NOLL NULL,
 CONSTRAINT [PK_tblPhuTung] PRIMARY KEY CLUSTERED 
(
	[masuachua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]






USE [QLGR]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietSuaChua](
	[machitietsuachua] [int] NOT NULL,
	[masuachua] [int] NOT NULL,
        [maphutung] [int] NOT NULL,
        [soluong] [int] NOT NULL,
        [dongia] [int] NOLL NULL.  
        [tiencong] [int] NOLL NULL, 
 CONSTRAINT [PK_tblPhuTung] PRIMARY KEY CLUSTERED 
(
	[machitietsuachua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


