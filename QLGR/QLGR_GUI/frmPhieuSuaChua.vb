Imports QLGR_BUS
Imports Utility
Imports QLGR_DTO


Public Class frmPhieuSuaChua

    Private phieusuachuaBUS As PhieuSuaChuaBUS
    Private xeBUS As XeBUS
    Private chuxeBUS As ChuXeBUS
    Private Sub frmPhieuSuaChua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbMaChuXe.Hide()
        cbMaXe.Hide()
        phieusuachuaBUS = New PhieuSuaChuaBUS()
        Dim result As Result
        Dim nextMPSC = 0

        result = phieusuachuaBUS.buildmaphieusuachua(nextMPSC)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tự động mã phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txtMaPhieuSuaChua.Text = nextMPSC



        xeBUS = New XeBUS()
        Dim listXe = New List(Of XeDTO)
        result = xeBUS.selectAll(listXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If
        cbMaXe.DataSource = New BindingSource(listXe, String.Empty)
        cbBienSo.DataSource = cbMaXe.DataSource
        cbMaXe.DisplayMember = "maxe"
        cbMaXe.ValueMember = "bienso"
        cbBienSo.DisplayMember = cbMaXe.ValueMember



        chuxeBUS = New ChuXeBUS()
        Dim listChuXe = New List(Of ChuXeDTO)
        result = chuxeBUS.selectAll(listChuXe)
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

    End Sub


    Private Sub loadBienSo(MaChuXe As Integer)

        Dim listXe = New List(Of XeDTO)
        Dim result As Result
        result = xeBUS.selectall_ByMaChuXe(MaChuXe, listXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách xe theo chủ xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If
        cbBienSo.DataSource = New BindingSource(listXe, String.Empty)
        cbBienSo.DisplayMember = "bienso"
        cbBienSo.ValueMember = "maxe"

        cbMaXe.DataSource = cbBienSo.DataSource
        cbMaXe.DisplayMember = cbBienSo.ValueMember

    End Sub

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        Dim result As Result
        Dim phieusuachuaDTO As PhieuSuaChuaDTO
        phieusuachuaDTO = New PhieuSuaChuaDTO()

        phieusuachuaDTO.maphieusuachua = Convert.ToInt64(txtMaPhieuSuaChua.Text)
        phieusuachuaDTO.noidung = txtNoiDung.Text
        phieusuachuaDTO.maxe = Convert.ToInt64(cbMaXe.Text)
        phieusuachuaDTO.thanhtien = 0
        phieusuachuaDTO.ngaysuachua = dtpNgaySuaChua.Value

        result = phieusuachuaBUS.insert(phieusuachuaDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phiếu sửa chữa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim nextMPSC = "1"
            result = phieusuachuaBUS.buildmaphieusuachua(nextMPSC)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            txtMaPhieuSuaChua.Text = nextMPSC
        Else
            MessageBox.Show("Thêm phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
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

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub
    Private Sub btChiTietSuaChua_Click_1(sender As Object, e As EventArgs) Handles btChiTietSuaChua.Click
        Me.Hide()
        Dim frm As frmChiTietSuaChua
        frm = New frmChiTietSuaChua()
        frm.ShowDialog()
        Me.Show()
    End Sub
End Class