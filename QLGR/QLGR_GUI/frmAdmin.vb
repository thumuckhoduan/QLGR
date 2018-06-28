Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmAdmin

    Private Sub pbDangKyTaiKhoan_Click(sender As Object, e As EventArgs) Handles pbDangKyTaiKhoan.Click
        Dim frm = New frmDangKyTaiKhoan()
        frm.ShowDialog(Me)
    End Sub

    Private Sub pbDangXuat_Click(sender As Object, e As EventArgs) Handles pbDangXuat.Click
        Me.Close()
    End Sub

    Private Sub pbQuanLyTaiKhoan_Click(sender As Object, e As EventArgs) Handles pbQuanLyTaiKhoan.Click
        Dim frm = New frmQuanLyTaiKhoan()
        frm.ShowDialog(Me)
    End Sub

    Private Sub hienghichu(pb As PictureBox, str As String)
        Dim a As ToolTip
        a = New ToolTip()
        a.SetToolTip(pb, str)
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hienghichu(pbDangKyTaiKhoan, "Đăng Ký Tài Khoản")
        hienghichu(pbQuanLyTaiKhoan, "Quản Lý Tài Khoản")
        hienghichu(pbDangXuat, "Đóng")
    End Sub
End Class