Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class BaoCaoDoanhSoBUS
    Private baocaodoanhsoDAL As BaoCaoDoanhSoDAL
    Public Sub New()
        baocaodoanhsoDAL = New BaoCaoDoanhSoDAL()
    End Sub
    Public Sub New(connectionString As String)
        baocaodoanhsoDAL = New BaoCaoDoanhSoDAL(connectionString)
    End Sub
    Public Function insert(s As BaoCaoDoanhSoDTO) As Result
        Return baocaodoanhsoDAL.insert(s)
    End Function
    Public Function buildmadoanhso(ByRef nextMDS As Integer) As Result
        Return baocaodoanhsoDAL.buildmadoanhso(nextMDS)
    End Function

End Class
