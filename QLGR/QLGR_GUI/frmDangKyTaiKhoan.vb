Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmDangKyTaiKhoan
    Private taikhoanBUS As TaiKhoanBUS
    Private Sub btDangKy_Click(sender As Object, e As EventArgs) Handles btDangKy.Click
        Dim taikhoanDTO = New TaiKhoanDTO()
        Dim result As Result
        taikhoanDTO.taikhoan = txtTaiKhoan.Text
        taikhoanDTO.matkhau = txtMatKhau.Text
        taikhoanDTO.quyen = cbQuyen.Text
        result = taikhoanBUS.insert(taikhoanDTO)
        If (result.FlagResult = False) Then
            MessageBox.Show("Đăng Ký không thành công thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        Else
            MessageBox.Show("Đăng Ký thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub frmDangKyTaiKhoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        taikhoanBUS = New TaiKhoanBUS()
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub
End Class