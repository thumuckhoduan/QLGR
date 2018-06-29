Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmTiepNhanSuaXe
    Private suaxeBUS As TiepNhanSuaXeBUS
    Private xeBUS As XeBUS
    Private hieuxeBUS As HieuXeBUS
    Private chuxeBUS As ChuXeBUS
    Private thamsoBUS As ThamSoBUS
    Private Sub TiepNhanSuaXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        suaxeBUS = New TiepNhanSuaXeBUS()
        xeBUS = New XeBUS()
        chuxeBUS = New ChuXeBUS()
        hieuxeBUS = New HieuXeBUS()
        thamsoBUS = New ThamSoBUS()
        Dim nextMSX = 0
        Dim result As Result
        result = suaxeBUS.buildMaSuaXe(nextMSX)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy mã sữa xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        txtMaSuaXe.Text = nextMSX

        loadlisthieuxe()

    End Sub
    Private Sub loadlisthieuxe()
        Dim result As Result
        Dim listHieuXe = New List(Of HieuXeDTO)
        Result = hieuxeBUS.selectAll(listHieuXe)
        If (Result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
        End If
        cbHieuXe.DataSource = New BindingSource(listHieuXe, String.Empty)
        cbHieuXe.DataSource = cbHieuXe.DataSource
        cbHieuXe.DisplayMember = "mahieuxe"
        cbHieuXe.ValueMember = "tenhieuxe"
        cbHieuXe.DisplayMember = cbHieuXe.ValueMember
    End Sub
    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click

        Dim result As Result
        If (txtChuXe.Text = vbNullString) Then
            MessageBox.Show("Không Được Để trống chủ xe", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If (IsNumeric(txtDienThoai.Text) Or txtDienThoai.Text = vbNullString) Then
        Else
            MessageBox.Show("Điện Thoại Phải Là Số", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If (txtDienThoai.Text = vbNullString And txtEmail.Text = vbNullString) Then
            MessageBox.Show("Không Được để trống điện thoại hoặc email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If (txtMaHieuXe.Text = "") Then
            Dim hieuxeDTO = New HieuXeDTO()
            Dim mahieuxe As Integer
            result = hieuxeBUS.buildMaHieuXe(mahieuxe)
            If (result.FlagResult = False) Then
                MessageBox.Show("Thêm Mã hiệu xe không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                System.Console.WriteLine(result.SystemMessage)
            End If
            txtMaHieuXe.Text = mahieuxe
            hieuxeDTO.mahieuxe = txtMaHieuXe.Text
            hieuxeDTO.tenhieuxe = cbHieuXe.Text
            result = hieuxeBUS.insert(hieuxeDTO)
            If (result.FlagResult = False) Then
                MessageBox.Show("Thêm Hiệu xe không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                System.Console.WriteLine(result.SystemMessage)
            End If
            loadlisthieuxe()
        End If
        Dim thamsoDTO = New ThamSoDTO()
        result = thamsoBUS.selectAll(thamsoDTO)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy Tham Số không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            System.Console.WriteLine(result.SystemMessage)
        End If
        If (suaxeBUS.isfull(dtpNgayTiepNhan.Value, thamsoDTO.tiepnhantoida) = False) Then

            Dim xeDTO As XeDTO
            xeDTO = New XeDTO()
            Dim SuaXeDTO As TiepNhanSuaXeDTO
            SuaXeDTO = New TiepNhanSuaXeDTO()
            Dim chuxeDTO As ChuXeDTO
            chuxeDTO = New ChuXeDTO()

            SuaXeDTO.masuaxe = txtMaSuaXe.Text
            SuaXeDTO.maxe = txtMaHieuXe.Text
            SuaXeDTO.ngaytiepnhan = dtpNgayTiepNhan.Value

            Dim nextma = 0

            chuxeDTO.diachi = txtDiaChi.Text
            chuxeDTO.dienthoai = txtDienThoai.Text
            chuxeDTO.email = txtEmail.Text
            chuxeDTO.tenchuxe = txtChuXe.Text
            chuxeDTO.tienno = "0"
            result = chuxeBUS.buildMaChuXe(nextma)
            If (result.FlagResult = False) Then
                MessageBox.Show("Thêm Mã Chủ Xe không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                System.Console.WriteLine(result.SystemMessage)
            End If
            chuxeDTO.machuxe = nextma

            xeDTO.machuxe = nextma
            result = xeBUS.buildMaXe(nextma)
            xeDTO.maxe = nextma
            xeDTO.mahieuxe = txtMaHieuXe.Text
            xeDTO.bienso = txtBienSo.Text

            result = chuxeBUS.insert(chuxeDTO)
            If (result.FlagResult = False) Then
                MessageBox.Show("Thêm Chủ Xe không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                System.Console.WriteLine(result.SystemMessage)
            End If
            result = xeBUS.insert(xeDTO)
            If (result.FlagResult = False) Then
                MessageBox.Show("Thêm Xe không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                System.Console.WriteLine(result.SystemMessage)
            End If
            result = suaxeBUS.insert(SuaXeDTO)
            If (result.FlagResult = False) Then
                MessageBox.Show("Thêm Sữa Xe không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                System.Console.WriteLine(result.SystemMessage)
            End If
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm đơn sữa xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                result = suaxeBUS.buildMaSuaXe(nextma)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Lấy danh tự động mã sữa xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
                txtMaSuaXe.Text = nextma
            Else
                MessageBox.Show("Thêm đơn sữa xe không thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Đã Full")
        End If
    End Sub
    Private Sub btDong_Click(sender As Object, e As EventArgs) Handles btDong.Click
        Me.Close()
    End Sub

    Private Sub cbHieuXe_TextChanged(sender As Object, e As EventArgs) Handles cbHieuXe.TextChanged
        hieuxeBUS = New HieuXeBUS()
        Dim hieuxeDTO As HieuXeDTO
        hieuxeDTO = New HieuXeDTO()
        Dim result As Result
        hieuxeDTO.tenhieuxe = cbHieuXe.Text
        hieuxeBUS.change(hieuxeDTO)
        txtMaHieuXe.Text = hieuxeDTO.mahieuxe
        Result = hieuxeBUS.kiemtra(hieuxeDTO)
        If (result.FlagResult = False) Then
            MessageBox.Show("Kiểm Tra không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        If (hieuxeDTO.mahieuxe = 0) Then
            txtMaHieuXe.Text = ""
        End If
    End Sub
End Class