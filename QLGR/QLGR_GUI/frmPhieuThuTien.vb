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
            Return
        End If
        txtMaPhieuThuTien.Text = nextMPTT
        chuxeBUS = New ChuXeBUS()
        Dim listChuXe = New List(Of ChuXeDTO)
        result = chuxeBUS.selectAll(listChuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chủ xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbMaChuXe.DataSource = New BindingSource(listChuXe, String.Empty)
        cbTenChuXe.DataSource = cbMaChuXe.DataSource
        cbMaChuXe.DisplayMember = "machuxe"
        cbMaChuXe.ValueMember = "tenchuxe"
        cbTenChuXe.DisplayMember = cbMaChuXe.ValueMember

        cbEmail.DataSource = cbMaChuXe.DataSource
        cbMaChuXe.ValueMember = "email"
        cbEmail.DisplayMember = cbMaChuXe.ValueMember

        cbDiaChi.DataSource = cbMaChuXe.DataSource
        cbMaChuXe.ValueMember = "diachi"
        cbDiaChi.DisplayMember = cbMaChuXe.ValueMember

        cbDienThoai.DataSource = cbMaChuXe.DataSource
        cbMaChuXe.ValueMember = "dienthoai"
        cbDienThoai.DisplayMember = cbMaChuXe.ValueMember

        cbTienNo.DataSource = cbMaChuXe.DataSource
        cbMaChuXe.ValueMember = "tienno"
        cbTienNo.DisplayMember = cbMaChuXe.ValueMember

        txtEmail.Text = cbEmail.Text
        txtDiaChi.Text = cbDiaChi.Text
        txtDienThoai.Text = cbDienThoai.Text

    End Sub

    Private Sub loadBienSo(MaChuXe As Integer)

        Dim listXe = New List(Of XeDTO)
        Dim result As Result
        result = xeBUS.selectall_ByMaChuXe(MaChuXe, listXe)
        If (Result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách xe theo chủ xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
            Me.Close()
            Return
        End If
        cbBienSo.DataSource = New BindingSource(listXe, String.Empty)
        cbBienSo.DisplayMember = "bienso"
        cbBienSo.ValueMember = "maxe"

        cbMaXe.DataSource = cbBienSo.DataSource
        cbMaXe.DisplayMember = cbBienSo.ValueMember

    End Sub

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        Dim phieuthuDTO As PhieuThuTienDTO
        phieuthuDTO = New PhieuThuTienDTO()
        Dim chuxeDTO As ChuXeDTO
        chuxeDTO = New ChuXeDTO()
        If (kiemtrasotienthu()) Then
            Return
        End If
        '1. Mapping data from GUI control
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


        '3. Insert to DB
        Dim result As Result
        phieuthutienBUS = New PhieuThuTienBUS()
        result = phieuthutienBUS.insert(phieuthuDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phiếu thu tiền thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMPTT = "1"
            result = phieuthutienBUS.buildMaPhieuThu(nextMPTT)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động phiếu thu tiền không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtMaPhieuThuTien.Text = nextMPTT


        Else
            MessageBox.Show("Thêm phiếu thu tiền không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If


        chuxeBUS = New ChuXeBUS()
        result = chuxeBUS.update(chuxeDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Cộng số tiền thu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Cộng số tiền thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If


    End Sub

    Function kiemtrasotienthu() As Boolean
        If (Convert.ToInt64(txtSoTienThu.Text) > Convert.ToInt64(cbTienNo.Text)) Then
            MessageBox.Show("Số tiền thu vượt quá số tiền nợ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        Return False
    End Function

    Private Sub cbTenChuXe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTenChuXe.SelectedIndexChanged
        Try
            Dim chuxeDTO = CType(cbMaChuXe.SelectedItem, ChuXeDTO)
            loadBienSo(chuxeDTO.machuxe)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
            Return
        End Try
    End Sub

    Private Sub cbMaChuXe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaChuXe.SelectedIndexChanged
        Try
            Dim chuxeDTO = CType(cbMaChuXe.SelectedItem, ChuXeDTO)
            loadBienSo(chuxeDTO.machuxe)
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

    Private Sub btDong_Click(sender As Object, e As EventArgs) Handles btDong.Click
        Me.Close()
    End Sub

    Private Sub cbTienNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTienNo.SelectedIndexChanged
        txtSoTienNo.Text = cbTienNo.Text
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class