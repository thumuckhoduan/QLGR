Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility
Public Class frmThemPhuTung
    Private phutungBUS As PhuTungBUS

    Private Sub frmThemPhuTung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        phutungBUS = New PhuTungBUS()
        Dim nextMPT = 0
        Dim result As Result
        result = phutungBUS.buildmaphutung(nextMPT)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        txbMaPhuTung.Text = nextMPT
        txbTenPhuTung.Text = String.Empty
    End Sub
    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        If (txbTenPhuTung.Text = vbNullString) Then
            MessageBox.Show("Không Được Để trống tên Phụ Tùng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim phutungDTO As PhuTungDTO
        phutungDTO = New PhuTungDTO
        phutungDTO.maphutung = txbMaPhuTung.Text
        phutungDTO.tenphutung = txbTenPhuTung.Text
        phutungDTO.soluongton = 0
        Dim result As Result
        result = phutungBUS.insert(phutungDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phụ tùng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMHX = 0
            result = phutungBUS.buildmaphutung(nextMHX)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txbMaPhuTung.Text = nextMHX
            txbTenPhuTung.Text = String.Empty
        Else
            MessageBox.Show("Thêm phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub btDong_Click(sender As Object, e As EventArgs) Handles btDong.Click
        Me.Close()
    End Sub
End Class