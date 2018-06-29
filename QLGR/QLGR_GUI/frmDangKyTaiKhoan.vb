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
        If (txtTaiKhoan.Text.Length >= 6 And txtTaiKhoan.Text.Length <= 10) Then
            MessageBox.Show("Tên tài khoản chỉ từ 6 đến 10 kí tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
        End If
        If (txtMatKhau.Text.Length >= 6 And txtMatKhau.Text.Length <= 10) Then
        Else
            MessageBox.Show("Tên mật khẩu chỉ từ 6 đến 10 kí tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
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
        cbQuyen.Text = "admin"
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub

End Class