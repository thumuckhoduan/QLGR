Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmUser

    Private Sub frmManHinhChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hienghichu(pbChiTietSuaChua, "Chi Tiết Sửa Chữa")
        hienghichu(pbDangXuat, "Đóng")
        hienghichu(pbNhapPhuTung, "Nhập Phụ Tùng")
        hienghichu(pbPhieuSuaChua, "Phiếu Sửa Chữa")
        hienghichu(pbPhieuThuTien, "Phiếu Thu Tiền")
        hienghichu(pbTiepNhanSuaXe, "Tiếp Nhận Sửa Xe")
    End Sub

    Private Sub hienghichu(pb As PictureBox, str As String)
        Dim a As ToolTip
        a = New ToolTip()
        a.SetToolTip(pb, str)
    End Sub


    Private Sub pbPhieuThuTien_Click(sender As Object, e As EventArgs) Handles pbPhieuThuTien.Click
        Dim frm As frmPhieuThuTien = New frmPhieuThuTien()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbPhieuSuaChua_Click(sender As Object, e As EventArgs) Handles pbPhieuSuaChua.Click
        Dim frm As frmPhieuSuaChua = New frmPhieuSuaChua()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbDangXuat_Click(sender As Object, e As EventArgs) Handles pbDangXuat.Click
        Me.Close()
    End Sub

    Private Sub pbChiTietSuaChua_Click(sender As Object, e As EventArgs) Handles pbChiTietSuaChua.Click
        Dim frm As frmChiTietSuaChua = New frmChiTietSuaChua()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbTiepNhanSuaXe_Click(sender As Object, e As EventArgs) Handles pbTiepNhanSuaXe.Click
        Dim frm As frmTiepNhanSuaXe = New frmTiepNhanSuaXe()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbNhapPhuTung_Click(sender As Object, e As EventArgs) Handles pbNhapPhuTung.Click
        Dim frm As frmNhapPhuTung = New frmNhapPhuTung()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub frmUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class