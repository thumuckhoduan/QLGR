
Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility
Public Class frmTimKiem
    Private hieuxeBUS As HieuXeBUS
    Private xeBUS As XeBUS
    Private Sub frmTimKiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTienNoMax.Text = "2000000000"
        txtTienNoMin.Text = "0"

        hieuxeBUS = New HieuXeBUS()
        xeBUS = New XeBUS()
        Dim result As Result

        Dim listHieuXe = New List(Of HieuXeDTO)
        result = hieuxeBUS.selectAll(listHieuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lay danh sách hieu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
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
        cbHieuXe.Text = String.Empty
    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim xeDTO As XeDTO
        xeDTO = New XeDTO()
        loadlisttimkiem()
    End Sub
    Private Sub loadlisttimkiem()
        Dim chuxe As String
        Dim hieuxe As String
        Dim bienso As String
        Dim tiennomin As Integer
        Dim tiennomax As Integer
        Dim listtimkiem = New List(Of TimKiemDTO)

        chuxe = txtChuXe.Text
        hieuxe = cbHieuXe.Text
        bienso = txtBienSo.Text
        tiennomin = txtTienNoMin.Text
        tiennomax = txtTienNoMax.Text

        xeBUS.tracuu(chuxe, hieuxe, bienso, tiennomin, tiennomax, listtimkiem)

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

    Private Sub btDong_Click(sender As Object, e As EventArgs) Handles btDong.Click
        Me.Close()
    End Sub
End Class