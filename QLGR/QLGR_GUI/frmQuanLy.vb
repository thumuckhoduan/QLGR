Public Class frmQuanLy

    Private Sub frmQuanLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hienghichu(pbThemHieuXe, "Thêm Hiệu Xe")
        hienghichu(pbThemPhuTung, "Thêm Phụ Tùng")
        hienghichu(pbTimKiem, "Tìm Kiếm")
        hienghichu(pbQuanLyChuXe, "Quản Lý Chủ Xe")
        hienghichu(pbQuanLyPhieuSuaChua, "Quản Lý Phiếu Sửa Chữa")
        hienghichu(pbQuanLyHieuXe, "Quản Lý Hiệu Xe")
        hienghichu(pbQuanLyPhuTung, "Quản Lý Phụ Tùng")
        hienghichu(pbQuanLyXe, "Quản Lý Xe")
        hienghichu(pbQuanLySuaXe, "Quản Lý Sửa Xe")
        hienghichu(pbDangXuat, "Đóng")
        hienghichu(pbBaoCaoDoanhSo, "Báo Cáo Doanh Số")
        hienghichu(pbBaoCaoTon, "Báo Cáo Tồn")
    End Sub

    Private Sub hienghichu(pb As PictureBox, str As String)
        Dim a As ToolTip
        a = New ToolTip()
        a.SetToolTip(pb, str)
    End Sub

    Private Sub pbQuanLyHieuXe_Click(sender As Object, e As EventArgs) Handles pbQuanLyHieuXe.Click
        Dim frm As frmQuanLyHieuXe = New frmQuanLyHieuXe()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbQuanLyChuXe_Click(sender As Object, e As EventArgs) Handles pbQuanLyChuXe.Click
        Dim frm As frmQuanLyChuXe = New frmQuanLyChuXe()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbQuanLyXe_Click(sender As Object, e As EventArgs) Handles pbQuanLyXe.Click
        Dim frm As frmQuanLyXe = New frmQuanLyXe()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbQuanLyPhieuSuaChua_Click(sender As Object, e As EventArgs) Handles pbQuanLyPhieuSuaChua.Click
        Dim frm As frmQuanLyPhieuSuaChua = New frmQuanLyPhieuSuaChua()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbThemHieuXe_Click(sender As Object, e As EventArgs) Handles pbThemHieuXe.Click
        Dim frm As frmThemHieuXe = New frmThemHieuXe()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbQuanLySuaXe_Click(sender As Object, e As EventArgs) Handles pbQuanLySuaXe.Click
        Dim frm As frmQuanLySuaXe = New frmQuanLySuaXe()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbThemPhuTung_Click(sender As Object, e As EventArgs) Handles pbThemPhuTung.Click
        Dim frm As frmThemPhuTung = New frmThemPhuTung()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbBaoCaoDoanhSo_Click(sender As Object, e As EventArgs) Handles pbBaoCaoDoanhSo.Click
        Dim frm As frmBaoCaoDoanhSo = New frmBaoCaoDoanhSo()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbBaoCaoTon_Click(sender As Object, e As EventArgs) Handles pbBaoCaoTon.Click
        Dim frm As frmBaoCaoTon = New frmBaoCaoTon()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbQuanLyPhuTung_Click(sender As Object, e As EventArgs) Handles pbQuanLyPhuTung.Click
        Dim frm As frmQuanLyPhuTung = New frmQuanLyPhuTung()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub pbDangXuat_Click(sender As Object, e As EventArgs) Handles pbDangXuat.Click
        Me.Close()
    End Sub

    Private Sub pbTimKiem_Click(sender As Object, e As EventArgs) Handles pbTimKiem.Click
        Dim frm As frmTimKiem = New frmTimKiem()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub
End Class