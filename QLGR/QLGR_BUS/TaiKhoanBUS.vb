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

    Public Function get_quyen(ByRef taikhoanDTO As TaiKhoanDTO) As Result
        Return taikhoanDAL.get_quyen(taikhoanDTO)
    End Function
    Public Function kiemtra(taikhoanDTO As TaiKhoanDTO, ByRef test As Boolean) As Result
        Return taikhoanDAL.kiemtra(taikhoanDTO, test)
    End Function
    Public Function update_matkhau(ByRef taikhoanDTO As TaiKhoanDTO) As Result
        Return taikhoanDAL.update_matkhau(taikhoanDTO)
    End Function
    Public Function update(ByRef taikhoanDTO As TaiKhoanDTO, taikhoan As String) As Result
        Return taikhoanDAL.update(taikhoanDTO, taikhoan)
    End Function
    Public Function delete(ByRef taikhoan As String) As Result
        Return taikhoanDAL.delete(taikhoan)
    End Function
    Public Function selectALL(ByRef listtaikhoan As List(Of TaiKhoanDTO)) As Result
        Return taikhoanDAL.selectALL(listtaikhoan)
    End Function
End Class
