Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmBaoCaoTon
    Private baocaotonBUS As BaoCaoTonBUS
    Private chitietbaocaotonBUS As ChiTietBaoCaoTonDTO
    Private baocao As List(Of dgvBaoCaoTonDTO)
    Private chitietsuachuaBUS As ChiTietSuaChuaBUS
    Private phutungBUS As PhuTungBUS
    Private Sub frmBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        baocaotonBUS = New BaoCaoTonBUS()
        chitietbaocaotonBUS = New ChiTietBaoCaoTonDTO()
        baocao = New List(Of dgvBaoCaoTonDTO)
        chitietsuachuaBUS = New ChiTietSuaChuaBUS()
        phutungBUS = New PhuTungBUS()
        cbThang.Text = Now.Month
        cbNam.Text = Now.Year
    End Sub
    Private Sub loaddata()
        Dim result As Result
        baocao.Clear()
        Dim list = New List(Of PhuTungDTO)
        result = phutungBUS.selectAll(list)
        If (result.FlagResult = True) Then
        Else
            MessageBox.Show("Lấy tất cả phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        For Each item In list
            Dim itembaocao = New dgvBaoCaoTonDTO
            itembaocao.maphutung = item.maphutung
            itembaocao.tenphutung = item.tenphutung
            itembaocao.tondau = 0
            itembaocao.nhapthem = 0
            itembaocao.ban = 0
            itembaocao.toncuoi = 0
            baocao.Add(itembaocao)
        Next
        result = chitietsuachuaBUS.ban(cbThang.Text, cbNam.Text, baocao)
        If (result.FlagResult = False) Then
            MessageBox.Show("Tính số lượng phụ tùng đã bán không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvBaoCaoTon.DataSource = Nothing
        dgvBaoCaoTon.Columns.Clear()
        dgvBaoCaoTon.AutoGenerateColumns = False
        dgvBaoCaoTon.AllowUserToAddRows = False
        dgvBaoCaoTon.Enabled = True
        dgvBaoCaoTon.DataSource = baocao

        Dim clmaphutung = New DataGridViewTextBoxColumn()
        clmaphutung.Name = "maphutung"
        clmaphutung.HeaderText = "Mã Phụ Tùng"
        clmaphutung.DataPropertyName = "maphutung"
        dgvBaoCaoTon.Columns.Add(clmaphutung)
        clmaphutung.ReadOnly = True

        Dim cltenphutung = New DataGridViewTextBoxColumn()
        cltenphutung.Name = "tenphutung"
        cltenphutung.HeaderText = " Tên Phụ Tùng"
        cltenphutung.DataPropertyName = "tenphutung"
        dgvBaoCaoTon.Columns.Add(cltenphutung)
        cltenphutung.ReadOnly = True

        Dim cltondau = New DataGridViewTextBoxColumn()
        cltondau.Name = "tondau"
        cltondau.HeaderText = "Tồn Đầu"
        cltondau.DataPropertyName = "tondau"
        dgvBaoCaoTon.Columns.Add(cltondau)
        cltondau.ReadOnly = True

        Dim clnhapthem = New DataGridViewTextBoxColumn()
        clnhapthem.Name = "nhapthem"
        clnhapthem.HeaderText = "Nhập Thêm"
        clnhapthem.DataPropertyName = "nhapthem"
        dgvBaoCaoTon.Columns.Add(clnhapthem)
        clnhapthem.ReadOnly = True

        Dim clban = New DataGridViewTextBoxColumn()
        clban.Name = "ban"
        clban.HeaderText = "Bán"
        clban.DataPropertyName = "ban"
        dgvBaoCaoTon.Columns.Add(clban)
        clban.ReadOnly = True

        Dim cltoncuoi = New DataGridViewTextBoxColumn()
        cltoncuoi.Name = "toncuoi"
        cltoncuoi.HeaderText = "Tồn Cuối"
        cltoncuoi.DataPropertyName = "toncuoi"
        dgvBaoCaoTon.Columns.Add(cltoncuoi)
        cltoncuoi.ReadOnly = True

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvBaoCaoTon.DataSource)
        myCurrencyManager.Refresh()
    End Sub
    Private Sub btnLapBaoCao_Click(sender As Object, e As EventArgs) Handles btnLapBaoCao.Click

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        loaddata()
    End Sub
End Class