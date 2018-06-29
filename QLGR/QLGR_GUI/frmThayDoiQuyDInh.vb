Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility
Public Class frmThayDoiQuyDInh
    Private thamsoBUS As ThamSoBUS

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        Dim ThamSoDTO = New ThamSoDTO()
        Dim result As Result
        ThamSoDTO.tiepnhantoida = txtTiepNhanToiDa.Text
        result = thamsoBUS.update(ThamSoDTO)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thay Đổi Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        Else
            MessageBox.Show("Thay Đổi Quy Định thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmThayDoiQuyDInh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        thamsoBUS = New ThamSoBUS()
        Dim ThamSoDTO = New ThamSoDTO()
        Dim result As Result
        result = thamsoBUS.selectAll(ThamSoDTO)
        txtTiepNhanToiDa.Text = ThamSoDTO.tiepnhantoida
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy Tham Số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class