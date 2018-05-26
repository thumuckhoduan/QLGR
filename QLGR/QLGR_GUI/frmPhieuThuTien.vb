﻿Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility
Public Class frmPhieuThuTien
    Private phieuthutienBUS As PhieuThuTienBUS
    Private chuxeBUS As ChuXeBUS
    Private xeBUS As XeBUS

    Private Sub PhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cbBienSo.ValueMember = "bienso"
    End Sub

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        Dim phieuthuDTO As PhieuThuTienDTO
        phieuthuDTO = New PhieuThuTienDTO()
        Dim chuxeDTO As ChuXeDTO
        chuxeDTO = New ChuXeDTO()

        '1. Mapping data from GUI control
        phieuthuDTO.maphieuthu = Convert.ToInt32(txtMaPhieuThuTien.Text)
        chuxeDTO.tenchuxe = cbTenChuXe.Text
        chuxeDTO.diachi = txtDiaChi.Text
        chuxeDTO.dienthoai = txtDienThoai.Text



        '3. Insert to DB
        Dim result As Result
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

    End Sub



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
End Class