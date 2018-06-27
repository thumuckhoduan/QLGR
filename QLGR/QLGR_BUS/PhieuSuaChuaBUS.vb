Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class PhieuSuaChuaBUS
    Private phieusuachuaDAL As PhieuSuaChuaDAL
    Public Sub New()
        phieusuachuaDAL = New PhieuSuaChuaDAL()
    End Sub
    Public Sub New(connectionString As String)
        phieusuachuaDAL = New PhieuSuaChuaDAL(connectionString)
    End Sub
    Public Function insert(s As PhieuSuaChuaDTO) As Result
        Return phieusuachuaDAL.insert(s)
    End Function
    Public Function buildmaphieusuachua(ByRef nextMPSC As Integer) As Result
        Return phieusuachuaDAL.buildmaphieusuachua(nextMPSC)
    End Function
    Public Function selectAll(ByRef listphieusuachua As List(Of PhieuSuaChuaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieusuachuaDAL.selectALL(listphieusuachua)
    End Function
    Public Function update(phieusuachuaDTO As PhieuSuaChuaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieusuachuaDAL.update(phieusuachuaDTO)
    End Function
    Public Function delete(maphieusuachua As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieusuachuaDAL.delete(maphieusuachua)
    End Function
    Public Function tongthanhtien(thang As Integer, nam As Integer, ByRef tong As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieusuachuaDAL.tongthanhtien(thang, nam, tong)
    End Function
    Public Function select_thang(nam As Integer, ByRef listthang As List(Of Integer)) As Result
        Return phieusuachuaDAL.select_thang(nam, listthang)
    End Function
    Public Function select_nam(ByRef listnam As List(Of Integer)) As Result
        Return phieusuachuaDAL.select_nam(listnam)
    End Function
    Public Function update(maphieusuachua As Integer, thanhtien As Integer) As Result
        Return phieusuachuaDAL.update(maphieusuachua, thanhtien)
    End Function
End Class
