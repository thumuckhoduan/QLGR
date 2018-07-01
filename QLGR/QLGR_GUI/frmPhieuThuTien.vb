Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility
Public Class frmPhieuThuTien
    Private phieuthutienBUS As PhieuThuTienBUS
    Private chuxeBUS As ChuXeBUS
    Private xeBUS As XeBUS

    Private Sub PhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSoTienThu.Text = 0
        cbEmail.Hide()
        cbDiaChi.Hide()
        cbDiaChi.Hide()
        cbDienThoai.Hide()
        cbMaChuXe.Hide()
        cbMaXe.Hide()
        cbTienNo.Hide()
        phieuthutienBUS = New PhieuThuTienBUS()
        xeBUS = New XeBUS()
        Dim listXe = New List(Of XeDTO)
        Dim result As Result
        Dim nextMPTT = 0

        result = phieuthutienBUS.buildMaPhieuThu(nextMPTT)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy mã phiếu thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If
        txtMaPhieuThuTien.Text = nextMPTT
        chuxeBUS = New ChuXeBUS()
        loadBienSo()
    End Sub

    Private Sub loadBienSo()

        Dim listXe = New List(Of XeDTO)
        Dim result As Result
        result = xeBUS.selectall_sortbybienso(listXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách xe theo chủ xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If
        cbBienSo.DataSource = New BindingSource(listXe, String.Empty)
        cbBienSo.DisplayMember = "bienso"
        cbBienSo.ValueMember = "bienso"
    End Sub
    Private Sub loaddata(bienso As String)
        Dim result As Result
        Dim listChuXe = New List(Of ChuXeDTO)
        result = chuxeBUS.selectAll_bybienso_sortbyTenChuXe(bienso, listChuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chủ xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If
        cbTenChuXe.DataSource = New BindingSource(listChuXe, String.Empty)
        cbTenChuXe.DisplayMember = "tenchuxe"
        cbTenChuXe.ValueMember = "tenchuxe"

        cbMaChuXe.DataSource = cbTenChuXe.DataSource
        cbTenChuXe.ValueMember = "machuxe"
        cbMaChuXe.DisplayMember = cbTenChuXe.ValueMember

        cbEmail.DataSource = cbTenChuXe.DataSource
        cbTenChuXe.ValueMember = "email"
        cbEmail.DisplayMember = cbTenChuXe.ValueMember

        cbDiaChi.DataSource = cbTenChuXe.DataSource
        cbTenChuXe.ValueMember = "diachi"
        cbDiaChi.DisplayMember = cbTenChuXe.ValueMember

        cbDienThoai.DataSource = cbTenChuXe.DataSource
        cbTenChuXe.ValueMember = "dienthoai"
        cbDienThoai.DisplayMember = cbTenChuXe.ValueMember

        cbTienNo.DataSource = cbTenChuXe.DataSource
        cbTenChuXe.ValueMember = "tienno"
        cbTienNo.DisplayMember = cbTenChuXe.ValueMember
    End Sub

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If ((IsNumeric(txtSoTienThu.Text) Or txtSoTienThu.Text = vbNullString) And txtSoTienThu.Text > "0") Then
        Else
            MessageBox.Show("Số Tiền Thu Phải Là Số Dương", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim phieuthuDTO As PhieuThuTienDTO
        phieuthuDTO = New PhieuThuTienDTO()
        Dim chuxeDTO As ChuXeDTO
        chuxeDTO = New ChuXeDTO()
        Dim result As Result
        If (kiemtrasotienthu()) Then
            Return
        End If
        result = xeBUS.getmaxe(cbTenChuXe.Text, cbBienSo.Text, cbMaXe.Text)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lỗi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        phieuthuDTO.maphieuthu = Convert.ToInt64(txtMaPhieuThuTien.Text)
        phieuthuDTO.maxe = Convert.ToInt64(cbMaXe.Text)
        phieuthuDTO.sotienthu = txtSoTienThu.Text
        phieuthuDTO.ngaythu = dtpNgayThuTien.Value
        chuxeDTO.machuxe = cbMaChuXe.Text
        chuxeDTO.tenchuxe = cbTenChuXe.Text
        chuxeDTO.diachi = txtDiaChi.Text
        chuxeDTO.dienthoai = txtDienThoai.Text
        chuxeDTO.tienno = Convert.ToInt64(cbTienNo.Text) - Convert.ToInt64(txtSoTienThu.Text)
        chuxeDTO.email = txtEmail.Text

        phieuthutienBUS = New PhieuThuTienBUS()
        result = phieuthutienBUS.insert(phieuthuDTO)
        If (result.FlagResult = True) Then
            Dim nextMPTT = "1"
            result = phieuthutienBUS.buildMaPhieuThu(nextMPTT)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động phiếu thu tiền không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            txtMaPhieuThuTien.Text = nextMPTT
        Else
            MessageBox.Show("Thêm phiếu thu tiền không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If


        chuxeBUS = New ChuXeBUS()
        result = chuxeBUS.update(chuxeDTO)
        If (result.FlagResult = True) Then
        Else
            MessageBox.Show("Cộng số tiền thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        MessageBox.Show("Thêm phiếu thu tiền thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        loadBienSo()
        txtSoTienThu.Text = 0
    End Sub

    Function kiemtrasotienthu() As Boolean
        If (Convert.ToInt64(txtSoTienThu.Text) > Convert.ToInt64(cbTienNo.Text)) Then
            MessageBox.Show("Số tiền thu vượt quá số tiền nợ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        Return False
    End Function


    Private Sub btDong_Click(sender As Object, e As EventArgs) Handles btDong.Click
        Me.Close()
    End Sub

    Private Sub cbBienSo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBienSo.SelectedIndexChanged
        Try
            Dim xeDTO = CType(cbBienSo.SelectedItem, XeDTO)
            loaddata(xeDTO.bienso)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
            Return
        End Try
    End Sub

    Private Sub cbEmail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmail.SelectedIndexChanged
        txtEmail.Text = cbEmail.Text
    End Sub

    Private Sub cbDiaChi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDiaChi.SelectedIndexChanged
        txtDiaChi.Text = cbDiaChi.Text

    End Sub

    Private Sub cbDienThoai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDienThoai.SelectedIndexChanged
        txtDienThoai.Text = cbDienThoai.Text
    End Sub

    Private Sub cbTienNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTienNo.SelectedIndexChanged
        txtSoTienNo.Text = cbTienNo.Text
    End Sub


    Private Sub cbMaChuXe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaChuXe.SelectedIndexChanged
        txtMaChuXe.Text = cbMaChuXe.Text
    End Sub
End Class