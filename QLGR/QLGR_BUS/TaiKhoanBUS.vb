Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class TaiKhoanBUS
    Private taikhoanDAL As QLGR_DAL.TaiKhoanDAL

    Public Sub New()
        taikhoanDAL = New QLGR_DAL.TaiKhoanDAL()
    End Sub

    Public Sub New(connectionString As String)
        taikhoanDAL = New QLGR_DAL.TaiKhoanDAL(connectionString)
    End Sub

    Public Function insert(taikhoanDTO As TaiKhoanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return taikhoanDAL.insert(taikhoanDTO)
    End Function

    Public Function get_maquyen(ByRef taikhoanDTO As TaiKhoanDTO) As Result
        Return taikhoanDAL.get_maquyen(taikhoanDTO)
    End Function
End Class
