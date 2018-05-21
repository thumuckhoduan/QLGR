Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmTiepNhanSuaXe
    Private SuaXeBUS As TiepNhanSuaXeBUS
    Private xeBUS As XeBUS
    Private hieuxeBUS As HieuXeBUS
    Private Sub TiepNhanSuaXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SuaXeBUS = New TiepNhanSuaXeBUS()
        xeBUS = New XeBUS()
        Dim nextMSX = 0
        Dim result As Result
        result = SuaXeBUS.buildMaSuaXe(nextMSX)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy mã sữa xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaSuaXe.Text = nextMSX
        Dim hieuxeBUS As HieuXeBUS
        Dim listHieuXe = New List(Of HieuXeDTO)
        hieuxeBUS = New HieuXeBUS()
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
        If (SuaXeBUS.isfull(dtpNgayTiepNhan.Value) = False) Then
            Dim xeDTO As XeDTO
            xeDTO = New XeDTO()
            Dim SuaXeDTO As TiepNhanSuaXeDTO
            SuaXeDTO = New TiepNhanSuaXeDTO()


            SuaXeDTO.masuaxe = txtMaSuaXe.Text
            SuaXeDTO.maxe = txtMaHieuXe.Text
            SuaXeDTO.ngaytiepnhan = dtpNgayTiepNhan.Value





            Dim result1 As Result

            result1 = SuaXeBUS.insert(SuaXeDTO)

            If (result1.FlagResult = True) Then
                MessageBox.Show("Thêm đơn sữa xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim nextMSX = 0
                result1 = SuaXeBUS.buildMaSuaXe(nextMSX)
                If (result1.FlagResult = False) Then
                    MessageBox.Show("Lấy danh tự động mã sữa xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Return
                End If
                txtMaSuaXe.Text = nextMSX
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