Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class TiepNhanSuaXeBUS
    Private TiepNhanSuaXeDAL As TiepNhanSuaXeDAL
    Public Sub New()
        TiepNhanSuaXeDAL = New TiepNhanSuaXeDAL()
    End Sub
    Public Sub New(connectionString As String)
        TiepNhanSuaXeDAL = New TiepNhanSuaXeDAL(connectionString)
    End Sub
    Public Function isfull(ngaytiepnhan As DateTime) As Boolean
        Dim dem As Integer
        demdonsuaxe(ngaytiepnhan, dem)
        If (dem >= 1) Then
            Return True
        End If
        Return False
    End Function
    Public Function insert(s As TiepNhanSuaXeDTO) As Result
        Return TiepNhanSuaXeDAL.insert(s)
    End Function
    Public Function buildMaSuaXe(ByRef nextMSX As Integer) As Result
        Return TiepNhanSuaXeDAL.buildMaSuaXe(nextMSX)
    End Function
    Public Function selectAll(ByRef listsuaxe As List(Of TiepNhanSuaXeDTO)) As Result

        Return TiepNhanSuaXeDAL.selectALL(listsuaxe)
    End Function
    Public Function update(s As TiepNhanSuaXeDTO) As Result
        Return TiepNhanSuaXeDAL.update(s)
    End Function
    Public Function delete(masuaxe As Integer) As Result
        Return TiepNhanSuaXeDAL.delete(masuaxe)
    End Function
    Public Function demdonsuaxe(ngaytiepnhan As DateTime, dem As Integer) As Result
        Return TiepNhanSuaXeDAL.demdonsuaxe(ngaytiepnhan, dem)
    End Function
End Class
