Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class DoanhSoBUS
    Private doanhsoDAL As DoanhSoDAL
    Public Sub New()
        doanhsoDAL = New DoanhSoDAL()
    End Sub
    Public Sub New(connectionString As String)
        doanhsoDAL = New DoanhSoDAL(connectionString)
    End Sub
    Public Function insert(s As DoanhSoDTO) As Result
        Return doanhsoDAL.insert(s)
    End Function
    Public Function buildmadoanhso(ByRef nextMDS As Integer) As Result
        Return doanhsoDAL.buildmadoanhso(nextMDS)
    End Function
End Class
