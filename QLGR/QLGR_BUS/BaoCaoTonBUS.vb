Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class BaoCaoTonBUS
    Private baocaotonDAL As BaoCaoTonDAL
    Public Sub New()
        baocaotonDAL = New BaoCaoTonDAL()
    End Sub
    Public Sub New(connectionString As String)
        baocaotonDAL = New BaoCaoTonDAL(connectionString)
    End Sub
    Public Function insert(s As BaoCaoTonDTO) As Result
        Return baocaotonDAL.insert(s)
    End Function
    Public Function buildmabaocaoton(ByRef nextMBCT As Integer) As Result
        Return baocaotonDAL.buildmabaocaoton(nextMBCT)
    End Function
End Class
