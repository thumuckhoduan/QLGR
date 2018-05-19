
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
        [bienso] [nvarchar](20) NOT NULL,
        [chuxe] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[dienthoai] [nvarchar](12) NOT NULL,
 CONSTRAINT [PK_tblXe] PRIMARY KEY CLUSTERED 
(
	[maxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [QLGR]
GO

INSERT INTO [dbo].[tblXe]([maxe],[mahieuxe],[bienso],[chuxe],[diachi],[dienthoai]) VALUES(1,1,'352','AA','aaaaa','0126468')
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
    [ngaytiepnhan] [date] NOT NULL,   
 CONSTRAINT [PK_tblTiepNhanSuaXe] PRIMARY KEY CLUSTERED 
(
	[masuaxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


USE [QLGR]
GO

INSERT INTO [dbo].[tblTiepNhanSuaXe]([masuaxe],[maxe],[ngaytiepnhan]) VALUES(1,1,convert(date,'12/30/2017'))
GO
