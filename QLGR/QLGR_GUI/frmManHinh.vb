Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility


Public Class frmManHinh
    Private taikhoanBUS As TaiKhoanBUS



    Private Sub frmManHinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTaiKhoan.Text = ""
        txtMatKhau.Text = ""
        taikhoanBUS = New TaiKhoanBUS()
    End Sub

    Private Sub btManHinh_Click(sender As Object, e As EventArgs) Handles btManHinh.Click
        Dim taikhoanDTO As New TaiKhoanDTO()
        taikhoanDTO.taikhoan = txtTaiKhoan.Text
        taikhoanDTO.matkhau = txtMatKhau.Text
        taikhoanBUS.get_quyen(taikhoanDTO)
        If (taikhoanDTO.quyen = "") Then
            MessageBox.Show("Tên Hoặc Mật Khẩu Sai")
        ElseIf (taikhoanDTO.quyen = "user") Then
            Dim frm = New frmUser()
            frm.ShowDialog(Me)
        ElseIf (taikhoanDTO.quyen = "admin") Then
            Dim frm = New frmAdmin()
            frm.ShowDialog(Me)
        ElseIf (taikhoanDTO.quyen = "quan ly") Then
            Dim frm = New frmQuanLy()
            frm.ShowDialog(Me)
        End If
    End Sub

    Private Sub btDoiMatKhau_Click(sender As Object, e As EventArgs) Handles btDoiMatKhau.Click
        Dim frm = New frmDoiMatKhau()
        frm.ShowDialog(Me)
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub
End Class