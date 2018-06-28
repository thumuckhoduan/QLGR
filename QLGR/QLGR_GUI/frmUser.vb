Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmUser

    Private Sub frmManHinhChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btTiepNhanSuaXe_Click(sender As Object, e As EventArgs) Handles btTiepNhanSuaXe.Click
        Dim frm As frmTiepNhanSuaXe = New frmTiepNhanSuaXe()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btPhieuSuaChua_Click(sender As Object, e As EventArgs) Handles btPhieuSuaChua.Click
        Dim frm As frmPhieuSuaChua = New frmPhieuSuaChua()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btChiTietSuaChua_Click(sender As Object, e As EventArgs) Handles btChiTietSuaChua.Click
        Dim frm As frmChiTietSuaChua = New frmChiTietSuaChua()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btQuanLySuaXe_Click(sender As Object, e As EventArgs) Handles btQuanLySuaXe.Click
        Dim frm As frmQuanLySuaXe = New frmQuanLySuaXe()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btQuanLyPhieuSuaChua_Click(sender As Object, e As EventArgs) Handles btQuanLyPhieuSuaChua.Click
        Dim frm As frmQuanLyPhieuSuaChua = New frmQuanLyPhieuSuaChua()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btQuanLyXe_Click(sender As Object, e As EventArgs) Handles btQuanLyXe.Click
        Dim frm As frmQuanLyXe = New frmQuanLyXe()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btQuanLyChuXe_Click(sender As Object, e As EventArgs) Handles btQuanLyChuXe.Click
        Dim frm As frmQuanLyChuXe = New frmQuanLyChuXe()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btThemHieuXe_Click(sender As Object, e As EventArgs) Handles btThemHieuXe.Click
        Dim frm As frmThemHieuXe = New frmThemHieuXe()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim frm As frmTimKiem = New frmTimKiem()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btQuanLyHieuXe_Click(sender As Object, e As EventArgs) Handles btQuanLyHieuXe.Click
        Dim frm As frmQuanLyHieuXe = New frmQuanLyHieuXe()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btPhieuThuTien_Click(sender As Object, e As EventArgs) Handles btPhieuThuTien.Click
        Dim frm As frmPhieuThuTien = New frmPhieuThuTien()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btThemPhuTung_Click(sender As Object, e As EventArgs) Handles btThemPhuTung.Click
        Dim frm As frmThemPhuTung = New frmThemPhuTung()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btQuanLyPhuTung_Click(sender As Object, e As EventArgs) Handles btQuanLyPhuTung.Click
        Dim frm As frmQuanLyPhuTung = New frmQuanLyPhuTung()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btNhapPhuTung_Click(sender As Object, e As EventArgs) Handles btNhapPhuTung.Click
        Dim frm As frmNhapPhuTung = New frmNhapPhuTung()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btBaoCaoTon_Click(sender As Object, e As EventArgs) Handles btBaoCaoTon.Click
        Dim frm As frmBaoCaoTon = New frmBaoCaoTon()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btBaoCaoDoanhsSo_Click(sender As Object, e As EventArgs) Handles btBaoCaoDoanhsSo.Click
        Dim frm As frmBaoCaoDoanhSo = New frmBaoCaoDoanhSo()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class