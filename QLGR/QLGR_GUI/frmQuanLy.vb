Public Class frmQuanLy

    Private Sub frmQuanLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btQuanLySuaXe_Click(sender As Object, e As EventArgs) Handles btQuanLySuaXe.Click
        Dim frm As frmQuanLySuaXe = New frmQuanLySuaXe()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btQuanLyPhieuSuaChua_Click(sender As Object, e As EventArgs) Handles btQuanLyPhieuSuaChua.Click
        Dim frm As frmQuanLyPhieuSuaChua = New frmQuanLyPhieuSuaChua()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btQuanLyXe_Click(sender As Object, e As EventArgs) Handles btQuanLyXe.Click
        Dim frm As frmQuanLyXe = New frmQuanLyXe()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btQuanLyChuXe_Click(sender As Object, e As EventArgs) Handles btQuanLyChuXe.Click
        Dim frm As frmQuanLyChuXe = New frmQuanLyChuXe()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btThemHieuXe_Click(sender As Object, e As EventArgs) Handles btThemHieuXe.Click
        Dim frm As frmThemHieuXe = New frmThemHieuXe()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btThemPhuTung_Click(sender As Object, e As EventArgs) Handles btThemPhuTung.Click
        Dim frm As frmThemPhuTung = New frmThemPhuTung()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btQuanLyPhuTung_Click(sender As Object, e As EventArgs) Handles btQuanLyPhuTung.Click
        Dim frm As frmQuanLyPhuTung = New frmQuanLyPhuTung()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btBaoCaoTon_Click(sender As Object, e As EventArgs) Handles btBaoCaoTon.Click
        Dim frm As frmBaoCaoTon = New frmBaoCaoTon()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btBaoCaoDoanhsSo_Click(sender As Object, e As EventArgs) Handles btBaoCaoDoanhsSo.Click
        Dim frm As frmBaoCaoDoanhSo = New frmBaoCaoDoanhSo()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btQuanLyHieuXe_Click(sender As Object, e As EventArgs) Handles btQuanLyHieuXe.Click
        Dim frm As frmQuanLyHieuXe = New frmQuanLyHieuXe()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btDangXuat_Click(sender As Object, e As EventArgs) Handles btDangXuat.Click
        Me.Close()
    End Sub
End Class