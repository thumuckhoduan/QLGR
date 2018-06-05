Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmTiepNhanSuaXe
    Private suaxeBUS As TiepNhanSuaXeBUS
    Private xeBUS As XeBUS
    Private hieuxeBUS As HieuXeBUS
    Private chuxeBUS As ChuXeBUS
    Private Sub TiepNhanSuaXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        suaxeBUS = New TiepNhanSuaXeBUS()
        xeBUS = New XeBUS()
        chuxeBUS = New ChuXeBUS()
        hieuxeBUS = New HieuXeBUS()

        Dim nextMSX = 0
        Dim result As Result
        result = suaxeBUS.buildMaSuaXe(nextMSX)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy mã sữa xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaSuaXe.Text = nextMSX

        Dim listHieuXe = New List(Of HieuXeDTO)
        result = hieuxeBUS.selectAll(listHieuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbHieuXe.DataSource = New BindingSource(listHieuXe, String.Empty)
        cbHieuXe.DataSource = cbHieuXe.DataSource
        cbHieuXe.DisplayMember = "mahieuxe"
        cbHieuXe.ValueMember = "tenhieuxe"
        cbHieuXe.DisplayMember = cbHieuXe.ValueMember

    End Sub
    Private Sub cbHieuXe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHieuXe.SelectedIndexChanged
        hieuxeBUS = New HieuXeBUS()
        Dim hieuxeDTO As HieuXeDTO
        hieuxeDTO = New HieuXeDTO()
        hieuxeDTO.tenhieuxe = cbHieuXe.Text
        hieuxeBUS.change(hieuxeDTO)
        txtMaHieuXe.Text = hieuxeDTO.mahieuxe
    End Sub
    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        If (suaxeBUS.isfull(dtpNgayTiepNhan.Value) = False) Then
            Dim result1 As Result

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
            result1 = chuxeBUS.buildMaChuXe(nextma)
            chuxeDTO.machuxe = nextma

            xeDTO.machuxe = nextma
            result1 = xeBUS.buildMaXe(nextma)
            xeDTO.maxe = nextma
            xeDTO.mahieuxe = txtMaHieuXe.Text
            xeDTO.bienso = txtBienSo.Text

            result1 = chuxeBUS.insert(chuxeDTO)
            result1 = xeBUS.insert(xeDTO)
            result1 = suaxeBUS.insert(SuaXeDTO)

            If (result1.FlagResult = True) Then
                MessageBox.Show("Thêm đơn sữa xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                result1 = suaxeBUS.buildMaSuaXe(nextma)
                If (result1.FlagResult = False) Then
                    MessageBox.Show("Lấy danh tự động mã sữa xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Return
                End If
                txtMaSuaXe.Text = nextma
            Else
                MessageBox.Show("Thêm đơn sữa xe không thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Đã Full")
        End If
    End Sub
    Private Sub btDong_Click(sender As Object, e As EventArgs) Handles btDong.Click
        Me.Close()
    End Sub
End Class