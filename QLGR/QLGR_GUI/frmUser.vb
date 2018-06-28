Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmUser

    Private Sub frmManHinhChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btTiepNhanSuaXe_Click(sender As Object, e As EventArgs) Handles btTiepNhanSuaXe.Click
        Dim frm As frmTiepNhanSuaXe = New frmTiepNhanSuaXe()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btPhieuSuaChua_Click(sender As Object, e As EventArgs) Handles btPhieuSuaChua.Click
        Dim frm As frmPhieuSuaChua = New frmPhieuSuaChua()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btChiTietSuaChua_Click(sender As Object, e As EventArgs) Handles btChiTietSuaChua.Click
        Dim frm As frmChiTietSuaChua = New frmChiTietSuaChua()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub



    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim frm As frmTimKiem = New frmTimKiem()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub



    Private Sub btPhieuThuTien_Click(sender As Object, e As EventArgs) Handles btPhieuThuTien.Click
        Dim frm As frmPhieuThuTien = New frmPhieuThuTien()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub



    Private Sub btNhapPhuTung_Click(sender As Object, e As EventArgs) Handles btNhapPhuTung.Click
        Dim frm As frmNhapPhuTung = New frmNhapPhuTung()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btDangXuat_Click(sender As Object, e As EventArgs) Handles btDangXuat.Click
        Me.Close()
    End Sub
End Class