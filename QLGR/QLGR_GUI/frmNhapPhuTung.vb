Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility


Public Class frmNhapPhuTung
    Private Sub frmNhapVatLieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMaNhapPhuTung.Hide()
        cbSoLuongTon.Hide()
        cbDonGia.Hide()
        txtSoLuong.Text = 0
        Dim result As Result
        Dim nextMNPT = 0
        Dim nhapphutungBUS As NhapPhuTungBUS
        nhapphutungBUS = New NhapPhuTungBUS()
        result = nhapphutungBUS.buildmanhapphutung(nextMNPT)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tự động mã phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txtMaNhapPhuTung.Text = nextMNPT
        loadphutung()



    End Sub

    Function loadphutung()
        Dim result As Result
        Dim phutungBUS As PhuTungBUS
        phutungBUS = New PhuTungBUS()
        Dim listPhuTung = New List(Of PhuTungDTO)
        result = phutungBUS.selectAll(listPhuTung)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phụ Tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If
        cbMaPhuTung.DataSource = New BindingSource(listPhuTung, String.Empty)
        cbTenPhuTung.DataSource = cbMaPhuTung.DataSource
        cbMaPhuTung.DisplayMember = "maphutung"
        cbMaPhuTung.ValueMember = "tenphutung"
        cbTenPhuTung.DisplayMember = cbMaPhuTung.ValueMember

        cbSoLuongTon.DataSource = cbMaPhuTung.DataSource
        cbMaPhuTung.ValueMember = "soluongton"
        cbSoLuongTon.DisplayMember = cbMaPhuTung.ValueMember

        cbDonGia.DataSource = cbMaPhuTung.DataSource
        cbMaPhuTung.ValueMember = "dongia"
        cbDonGia.DisplayMember = cbMaPhuTung.ValueMember
    End Function

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If ((IsNumeric(txtSoLuong.Text) Or txtSoLuong.Text = vbNullString) And txtSoLuong.Text > "0") Then
        Else
            MessageBox.Show("Số Lượng Phải Là Số Dương", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim result As Result
        Dim nhapphutungBUS As NhapPhuTungBUS
        nhapphutungBUS = New NhapPhuTungBUS()
        Dim nhapphutungDTO As NhapPhuTungDTO
        nhapphutungDTO = New NhapPhuTungDTO()

        nhapphutungDTO.manhapphutung = txtMaNhapPhuTung.Text
        nhapphutungDTO.maphutung = cbMaPhuTung.Text
        nhapphutungDTO.soluong = txtSoLuong.Text
        nhapphutungDTO.ngaytiepnhan = dtpNgayTiepNhan.Value
        nhapphutungDTO.dongia = cbDonGia.Text
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

        Dim phutungBUS As PhuTungBUS
        phutungBUS = New PhuTungBUS()
        Dim phutungDTO As PhuTungDTO
        phutungDTO = New PhuTungDTO()

        phutungDTO.maphutung = cbMaPhuTung.Text
        phutungDTO.tenphutung = cbTenPhuTung.Text
        phutungDTO.soluongton = Convert.ToInt32(txtSoLuong.Text) + Convert.ToInt32(cbSoLuongTon.Text)
        phutungDTO.dongia = cbDonGia.Text
        result = phutungBUS.update(phutungDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phụ tùng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Nhập phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        loadphutung()
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub

    Private Sub cbDonGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDonGia.SelectedIndexChanged
        txtDonGia.Text = cbDonGia.Text
    End Sub
End Class