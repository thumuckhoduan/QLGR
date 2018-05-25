Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility
Public Class frmPhieuThuTien
    Private phieuthutienBUS As PhieuThuTienBUS
    Private Sub PhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuthutienBUS = New PhieuThuTienBUS()

        Dim result As Result
        Dim nextMPTT = 0

        result = phieuthutienBUS.buildMaPhieuThu(nextMPTT)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy mã phiếu thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaPhieuThuTien.Text = nextMPTT
    End Sub

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        Dim PhieuThuTienDTO = New PhieuThuTienDTO()
        PhieuThuTienDTO.ngaythu = dtpNgayThuTien.Value
        PhieuThuTienDTO.sotienthu = txtSoTienThu.Text

    End Sub
End Class