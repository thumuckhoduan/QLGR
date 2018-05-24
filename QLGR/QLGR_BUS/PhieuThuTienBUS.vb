Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class PhieuThuTienBUS
    Private PhieuThuTienDAL As PhieuThuTienDAL
    Public Sub New()
        PhieuThuTienDAL = New PhieuThuTienDAL()
    End Sub
    Public Sub New(connectionString As String)
        PhieuThuTienDAL = New PhieuThuTienDAL(connectionString)
    End Sub
    Public Function insert(s As PhieuThuTienDTO) As Result
        Return PhieuThuTienDAL.insert(s)
    End Function
    Public Function buildMaPhieuThu(ByRef nextMPT As Integer) As Result
        Return PhieuThuTienDAL.buildmaphieuthu(nextMPT)
    End Function
    Public Function selectAll(ByRef listPhieuThu As List(Of PhieuThuTienDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return PhieuThuTienDAL.selectALL(listPhieuThu)
    End Function
    Public Function update(PhieuThuTienDTO As PhieuThuTienDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return PhieuThuTienDAL.update(PhieuThuTienDTO)
    End Function
    Public Function delete(maphieuthu As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return PhieuThuTienDAL.delete(maphieuthu)
    End Function

End Class
