Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility


Public Class frmNhapPhuTung
    Private phutungBUS As PhuTungBUS
    Private nhapphutungBUS As NhapPhuTungBUS


    Private Sub frmNhapVatLieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nhapphutungBUS = New NhapPhuTungBUS()
        phutungBUS = New PhuTungBUS()
        txtSoLuongTon.Hide()
        txtMaNhapPhuTung.Hide()

        txtSoLuong.Text = 0
        Dim result As Result
        Dim nextMNPT = 0

        result = nhapphutungBUS.buildmanhapphutung(nextMNPT)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tự động mã phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txtMaNhapPhuTung.Text = nextMNPT
        loadcombobox()



    End Sub
    Private Sub loadcombobox()
        Dim listmaphutung As List(Of PhuTungDTO)
        listmaphutung = New List(Of PhuTungDTO)

        phutungBUS.selectAll(listmaphutung)
        cbMaPhuTung.DataSource = New BindingSource(listmaphutung, String.Empty)
        cbMaPhuTung.DisplayMember = "maphutung"
        cbMaPhuTung.ValueMember = "maphutung"

        Dim listtenphutung As List(Of PhuTungDTO)
        listtenphutung = New List(Of PhuTungDTO)

        phutungBUS.selectAll_sorttenphutung(listtenphutung)
        cbTenPhuTung.DataSource = New BindingSource(listtenphutung, String.Empty)
        cbTenPhuTung.DisplayMember = "tenphutung"
        cbTenPhuTung.ValueMember = "tenphutung"


    End Sub


    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If ((IsNumeric(txtSoLuong.Text) Or txtSoLuong.Text = vbNullString) And txtSoLuong.Text > "0") Then
        Else
            MessageBox.Show("Số Lượng Phải Là Số Dương", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If (cbMaPhuTung.Text = vbNullString Or cbTenPhuTung.Text = vbNullString) Then
            MessageBox.Show("Không Tồn Tại Phụ Tùng bạn nhập", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim result As Result
        Dim nhapphutungDTO As NhapPhuTungDTO
        nhapphutungDTO = New NhapPhuTungDTO()

        nhapphutungDTO.manhapphutung = txtMaNhapPhuTung.Text
        nhapphutungDTO.maphutung = cbMaPhuTung.Text
        nhapphutungDTO.soluong = txtSoLuong.Text
        nhapphutungDTO.ngaytiepnhan = dtpNgayTiepNhan.Value
        nhapphutungDTO.dongia = txtDonGia.Text
        result = nhapphutungBUS.insert(nhapphutungDTO)
        If (result.FlagResult = True) Then
            Dim nextMNPT = "1"
            result = nhapphutungBUS.buildmanhapphutung(nextMNPT)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động nhập phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            txtMaNhapPhuTung.Text = nextMNPT
        Else
            MessageBox.Show("Thêm nhập phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        Dim phutungDTO As PhuTungDTO
        phutungDTO = New PhuTungDTO()

        phutungDTO.maphutung = cbMaPhuTung.Text
        phutungDTO.tenphutung = cbTenPhuTung.Text
        phutungDTO.soluongton = Convert.ToInt32(txtSoLuong.Text) + Convert.ToInt32(txtSoLuongTon.Text)
        phutungDTO.dongia = txtDonGia.Text
        result = PhuTungBUS.update(phutungDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phụ tùng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Nhập phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        loadcombobox()
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub



    Private Sub cbMaPhuTung_TextChanged(sender As Object, e As EventArgs) Handles cbMaPhuTung.TextChanged
        Try
            Dim phutung = New PhuTungDTO()
            PhuTungBUS.select_bymaphutung(cbMaPhuTung.Text, phutung)
            cbTenPhuTung.Text = phutung.tenphutung
            txtDonGia.Text = phutung.dongia
            txtSoLuongTon.Text = phutung.soluongton
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
            Return
        End Try
    End Sub

    Private Sub cbTenPhuTung_TextChanged(sender As Object, e As EventArgs) Handles cbTenPhuTung.TextChanged
        Try
            Dim phutung = New PhuTungDTO()
            PhuTungBUS.select_bytenphutung(cbTenPhuTung.Text, phutung)
            cbMaPhuTung.Text = phutung.maphutung
            txtDonGia.Text = phutung.dongia
            txtSoLuongTon.Text = phutung.soluongton
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
            Return
        End Try
    End Sub
End Class