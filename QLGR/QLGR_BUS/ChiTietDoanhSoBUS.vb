Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class ChiTietDoanhSoBUS
    Private chitietdoanhsoDAL As ChiTietDoanhSoDAL
    Public Sub New()
        chitietdoanhsoDAL = New ChiTietDoanhSoDAL()
    End Sub
    Public Sub New(connectionString As String)
        chitietdoanhsoDAL = New ChiTietDoanhSoDAL(connectionString)
    End Sub
    Public Function insert(s As ChiTietDoanhSoDTO) As Result
        Return chitietdoanhsoDAL.insert(s)
    End Function
    Public Function buildmachitiet(ByRef nextMCT As Integer) As Result
        Return chitietdoanhsoDAL.buildmachitiet(nextMCT)
    End Function
End Class
