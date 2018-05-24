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
        Dim tenchuxe As String
        Dim tiennomin As Integer
        Dim tiennomax As Integer

        tenchuxe = txtChuXe.Text
        tiennomin = Convert.ToInt32(txtTienNoMin.Text)
        tiennomax = Convert.ToInt32(txtTienNoMax.Text)

        Dim listtienno = New List(Of ChuXeDTO)
        Dim listchuxe = New List(Of ChuXeDTO)
        Dim listhieuxe = New List(Of XeDTO)
        Dim listbienso = New List(Of XeDTO)
        Dim result As Result

        result = chuxeBUS.selectallby_tienno(tiennomin, tiennomax, listtienno)
        If (result.FlagResult = False) Then
            MessageBox.Show("Tìm Kiếm với tiền nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        result = chuxeBUS.selectallby_chuxe(tenchuxe, listchuxe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Tìm Kiếm với tiền nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvTimKiem.Columns.Clear()
        dgvTimKiem.DataSource = Nothing

        dgvTimKiem.AutoGenerateColumns = False
        dgvTimKiem.AllowUserToAddRows = False
        dgvTimKiem.DataSource = listchuxe

        Dim clmachuxe = New DataGridViewTextBoxColumn()
        clmachuxe.Name = "machuxe"
        clmachuxe.HeaderText = "Mã Chủ Xe"
        clmachuxe.DataPropertyName = "machuxe"
        dgvTimKiem.Columns.Add(clmachuxe)

        Dim clMaHieuXe = New DataGridViewTextBoxColumn()
        clMaHieuXe.Name = "tenchuxe"
        clMaHieuXe.HeaderText = "Tên Chủ Xe"
        clMaHieuXe.DataPropertyName = "tenchuxe"
        dgvTimKiem.Columns.Add(clMaHieuXe)

        Dim cltienno = New DataGridViewTextBoxColumn()
        cltienno.Name = "tienno"
        cltienno.HeaderText = "Tiền Nợ"
        cltienno.DataPropertyName = "tienno"
        dgvTimKiem.Columns.Add(cltienno)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvTimKiem.DataSource)
        myCurrencyManager.Refresh()
    End Sub


End Class