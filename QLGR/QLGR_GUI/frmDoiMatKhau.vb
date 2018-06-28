﻿Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmDoiMatKhau
    Private taikhoanBUS As TaiKhoanBUS
    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        Dim result As Result
        Dim taikhoanDTO = New TaiKhoanDTO()
        Dim test = True
        taikhoanDTO.taikhoan = txtTaiKhoan.Text
        taikhoanDTO.matkhau = txtMatKhauCu.Text
        result = taikhoanBUS.kiemtra(taikhoanDTO, test)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        If (test) Then
            MessageBox.Show("Tài Khoản Hoặc Mật Khẩu không chính xác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If (txtNhapLaiMatKhau.Text <> txtMatKhauMoi.Text) Then
            MessageBox.Show("Nhập Lại Mật Khẩu Mới không chính xác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        taikhoanDTO.matkhau = txtMatKhauMoi.Text
        result = taikhoanBUS.update_matkhau(taikhoanDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Bạn Đã Đổi Mật Khẩu Thành Công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        Else
            MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
    End Sub

    Private Sub frmDoiMatKhau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        taikhoanBUS = New TaiKhoanBUS()

    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class