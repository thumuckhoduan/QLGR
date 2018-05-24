Public Class frmManHinhChinh


    Private Sub frmManHinhChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuảnLýSữaXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSữaXeToolStripMenuItem.Click
        Dim frm As frmQuanLySuaXe = New frmQuanLySuaXe
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TiếpNhậnSữaXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiếpNhậnSữaXeToolStripMenuItem.Click
        Dim frm As frmTiepNhanSuaXe = New frmTiepNhanSuaXe
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýXeToolStripMenuItem.Click
        Dim frm As frmQuanLyXe = New frmQuanLyXe
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýChủXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýChủXeToolStripMenuItem.Click
        Dim frm As frmQuanLyChuXe = New frmQuanLyChuXe
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýHiệuXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýHiệuXeToolStripMenuItem.Click
        Dim frm As frmQuanLyHieuXe = New frmQuanLyHieuXe
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmHiệuXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmHiệuXeToolStripMenuItem.Click
        Dim frm As frmThemHieuXe = New frmThemHieuXe
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TìmKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmToolStripMenuItem.Click
        Dim frm As frmTimKiem = New frmTimKiem
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class