Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility
Public Class frmThemHieuXe
    Private hieuxeBUS As HieuXeBUS

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If (txbTenHieuXe.Text = vbNullString) Then
            MessageBox.Show("Không Được Để trống tên hiệu xe", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim hieuxeDTO As HieuXeDTO
        hieuxeDTO = New HieuXeDTO
        hieuxeDTO.mahieuxe = txbMaHieuXe.Text
        hieuxeDTO.tenhieuxe = txbTenHieuXe.Text
        Dim result As Result
        result = hieuxeBUS.insert(hieuxeDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm hiệu xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMHX = 0
            result = hieuxeBUS.buildMaHieuXe(nextMHX)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Hiệu Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txbMaHieuXe.Text = nextMHX
            txbTenHieuXe.Text = String.Empty
        Else
            MessageBox.Show("Thêm Hiệu Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub ThemHieuXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hieuxeBUS = New HieuXeBUS()
        Dim nextMHX = 0
        Dim result As Result
        result = hieuxeBUS.buildMaHieuXe(nextMHX)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã nhập sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txbMaHieuXe.Text = nextMHX
        txbTenHieuXe.Text = String.Empty
    End Sub

    Private Sub btDong_Click(sender As Object, e As EventArgs) Handles btDong.Click
        Me.Close()
    End Sub


End Class