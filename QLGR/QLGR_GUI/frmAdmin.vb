Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility
Public Class frmAdmin

    Private Sub btQuanLyTaiKhoan_Click(sender As Object, e As EventArgs) Handles btQuanLyTaiKhoan.Click
        Dim frm = New frmQuanLyTaiKhoan()
        frm.ShowDialog(Me)
    End Sub

    Private Sub btDangKyTaiKhoan_Click(sender As Object, e As EventArgs) Handles btDangKyTaiKhoan.Click
        Dim frm = New frmDangKyTaiKhoan()
        frm.ShowDialog(Me)

    End Sub

    Private Sub btDangXuat_Click(sender As Object, e As EventArgs) Handles btDangXuat.Click
        Me.Close()
    End Sub
End Class