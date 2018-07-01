Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmDangKyTaiKhoan
    Private taikhoanBUS As TaiKhoanBUS
    Private Sub btDangKy_Click(sender As Object, e As EventArgs) Handles btDangKy.Click
        Dim taikhoanDTO = New TaiKhoanDTO()
        Dim result As Result
        Dim test = False
        result = taikhoanBUS.kiemtra(txtTaiKhoan.Text, test)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        If (test) Then
            MessageBox.Show("Tên Tài Khoản Đã Có Người Đặt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If (txtTaiKhoan.Text.Length >= 5 And txtTaiKhoan.Text.Length <= 10) Then
        Else
            MessageBox.Show("Tên tài khoản chỉ từ 5 đến 10 kí tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If (txtMatKhau.Text.Length >= 5 And txtMatKhau.Text.Length <= 10) Then
        Else
            MessageBox.Show("Tên mật khẩu chỉ từ 5 đến 10 kí tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        taikhoanDTO.taikhoan = txtTaiKhoan.Text
        taikhoanDTO.matkhau = txtMatKhau.Text
        taikhoanDTO.quyen = cbQuyen.Text
        result = taikhoanBUS.insert(taikhoanDTO)
        If (result.FlagResult = False) Then
            MessageBox.Show("Đăng Ký không thành công ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        Else
            MessageBox.Show("Đăng Ký Tài Khoản thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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