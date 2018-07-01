Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility
Public Class frmThemPhuTung
    Private phutungBUS As PhuTungBUS

    Private Sub frmThemPhuTung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        phutungBUS = New PhuTungBUS()
        Dim ma As Integer
        lay_maphutung(ma)
        txbMaPhuTung.Text = ma
        txbTenPhuTung.Text = String.Empty
    End Sub
    Private Sub lay_maphutung(ByRef ma As Integer)
        Dim result As Result
        Dim test As Boolean
        Dim random = New Random()
        test = True
        Do
            ma = random.Next()
            ma = ma Mod 90000000 + 10000000
            result = phutungBUS.kiemtra(ma, test)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lỗi Kiểm tra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
        Loop While test
    End Sub
    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Dim result As Result
        Dim test As Boolean
        test = True
        result = phutungBUS.kiemtra(txbMaPhuTung.Text, test)
        If (Result.FlagResult = False) Then
            MessageBox.Show("Lỗi Kiểm tra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        If (test) Then
            MessageBox.Show("Mã Phụ Tùng đã tồn tại", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If (txbTenPhuTung.Text = vbNullString) Then
            MessageBox.Show("Không Được Để trống tên Phụ Tùng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim phutungDTO As PhuTungDTO
        phutungDTO = New PhuTungDTO
        phutungDTO.maphutung = txbMaPhuTung.Text
        phutungDTO.tenphutung = txbTenPhuTung.Text
        phutungDTO.soluongton = 0
        phutungDTO.dongia = txtDonGia.Text
        result = phutungBUS.insert(phutungDTO)
        If (Result.FlagResult = True) Then
            MessageBox.Show("Thêm phụ tùng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim ma As Integer
            lay_maphutung(ma)
            txbMaPhuTung.Text = ma
            txbTenPhuTung.Text = String.Empty
            txtDonGia.Text = String.Empty
        Else
            MessageBox.Show("Thêm phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
        End If

    End Sub
    Private Sub btDong_Click(sender As Object, e As EventArgs) Handles btDong.Click
        Me.Close()
    End Sub
End Class