Public Class frmManHinhChinh
    Private Sub ThêmHiệuXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmHiệuXeToolStripMenuItem.Click
        Dim frm As ThemHieuXe = New ThemHieuXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub



    Private Sub TiếpNhậnSữaXeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TiếpNhậnSữaXeToolStripMenuItem.Click
        Dim frm As frmTiepNhanSuaXe = New frmTiepNhanSuaXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýHiệuXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýHiệuXeToolStripMenuItem.Click
        Dim frm As frmQuanLyHieuXe = New frmQuanLyHieuXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub




    Private Sub ManHinhChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub QuảnLýXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýXeToolStripMenuItem.Click
        Dim frm As frmQuanLyXe = New frmQuanLyXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýSữaXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSữaXeToolStripMenuItem.Click
        Dim frm As frmQuanLySuaXe = New frmQuanLySuaXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
