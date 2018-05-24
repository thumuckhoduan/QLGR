Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility
Public Class frmTimKiem
    Private hieuxeBUS As HieuXeBUS
    Private chuxeBUS As ChuXeBUS
    Private xeBUS As XeBUS
    Private Sub frmTimKiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hieuxeBUS = New HieuXeBUS()
        chuxeBUS = New ChuXeBUS()
        xeBUS = New XeBUS()
        Dim result As Result

        Dim listHieuXe = New List(Of HieuXeDTO)
        Result = hieuxeBUS.selectAll(listHieuXe)
        If (Result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
            Me.Close()
            Return
        End If
        cbHieuXe.DataSource = New BindingSource(listHieuXe, String.Empty)
        cbHieuXe.DataSource = cbHieuXe.DataSource
        cbHieuXe.DisplayMember = "mahieuxe"
        cbHieuXe.ValueMember = "tenhieuxe"
        cbHieuXe.DisplayMember = cbHieuXe.ValueMember

    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim xeDTO As XeDTO
        xeDTO = New XeDTO()
        Dim hieuxeDTO As HieuXeDTO
        hieuxeDTO = New HieuXeDTO()
        Dim chuxeDTO As ChuXeDTO
        chuxeDTO = New ChuXeDTO()

    End Sub

    Private Sub txtChuXe_TextChanged(sender As Object, e As EventArgs) Handles txtChuXe.TextChanged

    End Sub
End Class