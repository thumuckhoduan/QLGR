Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class HieuXeBUS
    Private hieuxeDAL As HieuXeDAL
    Public Sub New()
        hieuxeDAL = New HieuXeDAL()
    End Sub
    Public Sub New(connectionString As String)
        hieuxeDAL = New HieuXeDAL(connectionString)
    End Sub
    Public Function insert(s As HieuXeDTO) As Result
        Return hieuxeDAL.insert(s)
    End Function

    Public Function selectAll(ByRef listhieuxe As List(Of HieuXeDTO)) As Result

        Return hieuxeDAL.selectALL(listhieuxe)
    End Function
    Public Function select_byMaHieuXe(mahieuxe As Integer, ByRef hieuxeDTO As HieuXeDTO) As Result

        Return hieuxeDAL.select_byMaHieuXe(mahieuxe, hieuxeDTO)
    End Function
    Public Function buildMaHieuXe(ByRef nextMHX As Integer) As Result
        Return hieuxeDAL.buildMaHieuXe(nextMHX)
    End Function
    Public Function delete(mahieuxe As Integer) As Result
        Return hieuxeDAL.delete(mahieuxe)
    End Function
    Public Function update(hieuxe As HieuXeDTO) As Result
        Return hieuxeDAL.update(hieuxe)
    End Function
    Public Function change(hieuxe As HieuXeDTO) As Result
        Return hieuxeDAL.change(hieuxe)
    End Function
    Public Function kiemtra(hieuxeDTO As HieuXeDTO) As Result
        Return hieuxeDAL.kiemtra(hieuxeDTO)
    End Function
    Public Function selectAll_sortbytenhieuxe(ByRef listhieuxe As List(Of HieuXeDTO)) As Result

        Return hieuxeDAL.selectAll_sortbytenhieuxe(listhieuxe)
    End Function
End Class
