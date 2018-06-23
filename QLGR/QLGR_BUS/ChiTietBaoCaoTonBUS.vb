Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class ChiTietBaoCaoTonBUS
    Private chitietbaocaotonDAL As ChiTietBaoCaoTonDAL
    Public Sub New()
        chitietbaocaotonDAL = New ChiTietBaoCaoTonDAL()
    End Sub
    Public Sub New(connectionString As String)
        chitietbaocaotonDAL = New ChiTietBaoCaoTonDAL(connectionString)
    End Sub
    Public Function insert(s As ChiTietBaoCaoTonDTO) As Result
        Return chitietbaocaotonDAL.insert(s)
    End Function
    Public Function buildmachitiet(ByRef nextMCT As Integer) As Result
        Return chitietbaocaotonDAL.buildmachitietbaocaoton(nextMCT)
    End Function
End Class
