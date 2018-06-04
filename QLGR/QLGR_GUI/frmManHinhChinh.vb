Public Class frmManHinhChinh


    Private Sub frmManHinhChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuảnLýSữaXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSữaXeToolStripMenuItem.Click
        Dim frm As frmQuanLySuaXe = New frmQuanLySuaXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TiếpNhậnSữaXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiếpNhậnSữaXeToolStripMenuItem.Click
        Dim frm As frmTiepNhanSuaXe = New frmTiepNhanSuaXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýXeToolStripMenuItem.Click
        Dim frm As frmQuanLyXe = New frmQuanLyXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýChủXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýChủXeToolStripMenuItem.Click
        Dim frm As frmQuanLyChuXe = New frmQuanLyChuXe
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýHiệuXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýHiệuXeToolStripMenuItem.Click
        Dim frm As frmQuanLyHieuXe = New frmQuanLyHieuXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmHiệuXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmHiệuXeToolStripMenuItem.Click
        Dim frm As frmThemHieuXe = New frmThemHieuXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TìmKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmToolStripMenuItem.Click
        Dim frm As frmTimKiem = New frmTimKiem()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LậpPhiếuThuTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpPhiếuThuTiềnToolStripMenuItem.Click
        Dim frm As frmPhieuThuTien = New frmPhieuThuTien()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmPhụTùngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmPhụTùngToolStripMenuItem.Click
        Dim frm As frmThemPhuTung = New frmThemPhuTung()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýPhụTùngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhụTùngToolStripMenuItem.Click
        Dim frm As frmQuanLyPhuTung = New frmQuanLyPhuTung()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PhiếuSửaXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuSửaXeToolStripMenuItem.Click
        Dim frm As frmPhieuSuaChua = New frmPhieuSuaChua()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DoanhSốToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoanhSốToolStripMenuItem.Click
        Dim frm As frmDoanhSo = New frmDoanhSo()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class