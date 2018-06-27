Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmManHinhChinh
    Private userBUS As UserBUS
    Private userDTO As UserDTO
    Dim X As Integer = 0

    Private Sub QuảnLýSữaXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSữaXeToolStripMenuItem.Click
        Dim frm As frmQuanLySuaXe = New frmQuanLySuaXe()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub TiếpNhậnSữaXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiếpNhậnSữaXeToolStripMenuItem.Click
        Dim frm As frmTiepNhanSuaXe = New frmTiepNhanSuaXe()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub QuảnLýXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýXeToolStripMenuItem.Click
        Dim frm As frmQuanLyXe = New frmQuanLyXe()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub QuảnLýChủXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýChủXeToolStripMenuItem.Click
        Dim frm As frmQuanLyChuXe = New frmQuanLyChuXe
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub QuảnLýHiệuXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýHiệuXeToolStripMenuItem.Click
        Dim frm As frmQuanLyHieuXe = New frmQuanLyHieuXe()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub ThêmHiệuXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmHiệuXeToolStripMenuItem.Click
        Dim frm As frmThemHieuXe = New frmThemHieuXe()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub TìmKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmToolStripMenuItem.Click
        Dim frm As frmTimKiem = New frmTimKiem()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub LậpPhiếuThuTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpPhiếuThuTiềnToolStripMenuItem.Click
        Dim frm As frmPhieuThuTien = New frmPhieuThuTien()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub ThêmPhụTùngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmPhụTùngToolStripMenuItem.Click
        Dim frm As frmThemPhuTung = New frmThemPhuTung()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub QuảnLýPhụTùngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhụTùngToolStripMenuItem.Click
        Dim frm As frmQuanLyPhuTung = New frmQuanLyPhuTung()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub PhiếuSửaXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuSửaXeToolStripMenuItem.Click
        Dim frm As frmPhieuSuaChua = New frmPhieuSuaChua()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub DoanhSốToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoanhSốToolStripMenuItem.Click
        Dim frm As frmBaoCaoDoanhSo = New frmBaoCaoDoanhSo()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub BáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoTồnToolStripMenuItem.Click
        Dim frm As frmBaoCaoTon = New frmBaoCaoTon()
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
    End Sub

    Private Sub NhậpPhụTùngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhậpPhụTùngToolStripMenuItem.Click
        Dim frm As frmNhapPhuTung = New frmNhapPhuTung()
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)

        frm.Show()
    End Sub

    Private Sub btDangNhap_Click(sender As Object, e As EventArgs) Handles btDangNhap.Click
        Dim result As Result
        userDTO.username = txbusername.Text
        userDTO.password = txbpassword.Text
        If (userDTO.permissions = -1) Then
            userBUS.get_permissions(userDTO)
        ElseIf (userDTO.permissions = 0) Then
            userDTO.permissions = Convert.ToInt32(cbpermissions.Text)
            result = userBUS.insert(userDTO)
            If (result.FlagResult = False) Then
                MessageBox.Show("Đăng Ký không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            userDTO.permissions = 0
        End If
        If (userDTO.permissions = -1) Then
            MessageBox.Show("Tên Hoặc Mật khẩu không đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If (userDTO.permissions = -2) Then
            MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If (userDTO.permissions = 1) Then
            MenuStrip1.Show()
            txbusername.Hide()
            txbpassword.Hide()
            btDangNhap.Hide()
            lbusername.Hide()
            lbpassword.Hide()
        End If
        If (userDTO.permissions = 0) Then
            btDangNhap.Text = "Đăng Ký"
            lbpermissions.Show()
            cbpermissions.Show()
        End If
    End Sub

    Private Sub frmManHinhChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        userDTO = New UserDTO()
        userBUS = New UserBUS()
        X = Me.Size.Height
        'MenuStrip1.Hide()
        userDTO.permissions = -1
        lbpermissions.Hide()
        cbpermissions.Hide()
        txbpassword.Hide()
        txbusername.Hide()
        lbpassword.Hide()
        lbusername.Hide()
        btDangNhap.Hide()
    End Sub

    Private Sub QuảnLýPhiếuSửaChữaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhiếuSửaChữaToolStripMenuItem.Click
        Dim frm As frmQuanLyPhieuSuaChua = New frmQuanLyPhieuSuaChua()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub



    Private Sub ChiTiếtSữaChữaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtSữaChữaToolStripMenuItem.Click
        Dim frm As frmChiTietSuaChua = New frmChiTietSuaChua()
        frm.MdiParent = Me
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub
End Class