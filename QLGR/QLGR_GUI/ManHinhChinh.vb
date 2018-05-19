Public Class ManHinhChinh
    Private Sub ThêmHiệuXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmHiệuXeToolStripMenuItem.Click
        Dim frm As ThemHieuXe = New ThemHieuXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub



    Private Sub TiếpNhậnSữaXeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TiếpNhậnSữaXeToolStripMenuItem.Click
        Dim frm As TiepNhanSuaXe = New TiepNhanSuaXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýHiệuXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýHiệuXeToolStripMenuItem.Click
        Dim frm As QuanLyHieuXe = New QuanLyHieuXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýSữaXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSữaXeToolStripMenuItem.Click
        Dim frm As QuanLySuaXe = New QuanLySuaXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýXeToolStripMenuItem.Click
        Dim frm As frmQuanLyXe = New frmQuanLyXe()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ManHinhChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
