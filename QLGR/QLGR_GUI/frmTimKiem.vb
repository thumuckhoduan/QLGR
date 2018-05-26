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

        txtChuXe.Text = String.Empty
        txtBienSo.Text = String.Empty
        txtTienNoMin.Text = 0
        txtTienNoMax.Text = 0

    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim xeDTO As XeDTO
        xeDTO = New XeDTO()
        Dim hieuxeDTO As HieuXeDTO
        hieuxeDTO = New HieuXeDTO()
        Dim chuxeDTO As ChuXeDTO
        chuxeDTO = New ChuXeDTO()

        loadlisttimkiem()
    End Sub
    Private Sub loadlisttimkiem()

        Dim listtimkiem = New List(Of TimKiemDTO)

        dgvTimKiem.Columns.Clear()
        dgvTimKiem.DataSource = Nothing

        dgvTimKiem.AutoGenerateColumns = False
        dgvTimKiem.AllowUserToAddRows = False
        dgvTimKiem.DataSource = listtimkiem

        Dim clchuxe = New DataGridViewTextBoxColumn()
        clchuxe.Name = "tenchuxe"
        clchuxe.HeaderText = "Tên Chủ Xe"
        clchuxe.DataPropertyName = "chuxe"
        dgvTimKiem.Columns.Add(clchuxe)

        Dim clhieuxe = New DataGridViewTextBoxColumn()
        clhieuxe.Name = "hieuxe"
        clhieuxe.HeaderText = "Hiệu Xe"
        clhieuxe.DataPropertyName = "hieuxe"
        dgvTimKiem.Columns.Add(clhieuxe)

        Dim clbienso = New DataGridViewTextBoxColumn()
        clbienso.Name = "bienso"
        clbienso.HeaderText = "Biển số"
        clbienso.DataPropertyName = "bienso"
        dgvTimKiem.Columns.Add(clbienso)

        Dim cltienno = New DataGridViewTextBoxColumn()
        cltienno.Name = "tienno"
        cltienno.HeaderText = "Tiền Nợ"
        cltienno.DataPropertyName = "tienno"
        dgvTimKiem.Columns.Add(cltienno)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvTimKiem.DataSource)
        myCurrencyManager.Refresh()
    End Sub
End Class