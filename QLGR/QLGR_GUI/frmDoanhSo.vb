Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility
Public Class frmDoanhSo
    Private doanhsoBUS As DoanhSoBUS
    Private chitietdoanhsoBUS As ChiTietDoanhSoBUS
    'Private phieusuchuaBUS As phieusuachuaBUS
    Private Sub frmDoanhSo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        doanhsoBUS = New DoanhSoBUS()
        chitietdoanhsoBUS = New ChiTietDoanhSoBUS()
        'phieusuachuaBUS = New phieusuachuaBUS()

    End Sub
    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        Dim doanhsoDTO As DoanhSoDTO
        doanhsoDTO = New DoanhSoDTO()
        Dim result As Result
        Dim nextMDS = "1"
        result = doanhsoBUS.buildmadoanhso(nextMDS)
        doanhsoDTO.madoanhso = nextMDS
        doanhsoDTO.thang = cbThang.Text
        doanhsoDTO.nam = txtNam.Text
        'doanhsoDTO.tongdoanhthu = phieusuachuaBUS.tongthanhtien(cbThang.Text, txtNam.Text)

        result = doanhsoBUS.insert(doanhsoDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm doanh số thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Thêm doanh số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub btDong_Click(sender As Object, e As EventArgs) Handles btDong.Click
        Me.Close()
    End Sub

    Private Sub cbThang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbThang.SelectedIndexChanged
        Dim listdoanhso = New List(Of ChiTietDoanhSoBUS)
        Dim listhieuxe = New List(Of HieuXeBUS)
        dgvDoanhThu.Columns.Clear()
        dgvDoanhThu.DataSource = Nothing

        dgvDoanhThu.AutoGenerateColumns = False
        dgvDoanhThu.AllowUserToAddRows = False
        dgvDoanhThu.DataSource = listhieuxe

        Dim cltenhieuxe = New DataGridViewTextBoxColumn()
        cltenhieuxe.Name = "hieuxe"
        cltenhieuxe.HeaderText = "Tên Hiệu Xe"
        cltenhieuxe.DataPropertyName = "tenhieuxe"
        dgvDoanhThu.Columns.Add(cltenhieuxe)

        dgvDoanhThu.AutoGenerateColumns = False
        dgvDoanhThu.AllowUserToAddRows = False
        dgvDoanhThu.DataSource = listdoanhso
        Dim clsoluotsua = New DataGridViewTextBoxColumn()
        clsoluotsua.Name = "soluotsua"
        clsoluotsua.HeaderText = "Số Lượt sữa"
        clsoluotsua.DataPropertyName = "soluotsua"
        dgvDoanhThu.Columns.Add(clsoluotsua)

        Dim clthanhtien = New DataGridViewTextBoxColumn()
        clthanhtien.Name = "thanhtien"
        clthanhtien.HeaderText = "Thành Tiền"
        clthanhtien.DataPropertyName = "thanhtien"
        dgvDoanhThu.Columns.Add(clthanhtien)

        Dim cltile = New DataGridViewTextBoxColumn()
        cltile.Name = "tile"
        cltile.HeaderText = "Tỉ Lệ"
        cltile.DataPropertyName = "tile"
        dgvDoanhThu.Columns.Add(cltile)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDoanhThu.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub txtNam_TextChanged(sender As Object, e As EventArgs) Handles txtNam.TextChanged
        Dim listdoanhso = New List(Of ChiTietDoanhSoBUS)
        Dim listhieuxe = New List(Of HieuXeBUS)
        dgvDoanhThu.Columns.Clear()
        dgvDoanhThu.DataSource = Nothing

        dgvDoanhThu.AutoGenerateColumns = False
        dgvDoanhThu.AllowUserToAddRows = False
        dgvDoanhThu.DataSource = listhieuxe

        Dim cltenhieuxe = New DataGridViewTextBoxColumn()
        cltenhieuxe.Name = "hieuxe"
        cltenhieuxe.HeaderText = "Tên Hiệu Xe"
        cltenhieuxe.DataPropertyName = "tenhieuxe"
        dgvDoanhThu.Columns.Add(cltenhieuxe)

        dgvDoanhThu.AutoGenerateColumns = False
        dgvDoanhThu.AllowUserToAddRows = False
        dgvDoanhThu.DataSource = listdoanhso
        Dim clsoluotsua = New DataGridViewTextBoxColumn()
        clsoluotsua.Name = "soluotsua"
        clsoluotsua.HeaderText = "Số Lượt sữa"
        clsoluotsua.DataPropertyName = "soluotsua"
        dgvDoanhThu.Columns.Add(clsoluotsua)

        Dim clthanhtien = New DataGridViewTextBoxColumn()
        clthanhtien.Name = "thanhtien"
        clthanhtien.HeaderText = "Thành Tiền"
        clthanhtien.DataPropertyName = "thanhtien"
        dgvDoanhThu.Columns.Add(clthanhtien)

        Dim cltile = New DataGridViewTextBoxColumn()
        cltile.Name = "tile"
        cltile.HeaderText = "Tỉ Lệ"
        cltile.DataPropertyName = "tile"
        dgvDoanhThu.Columns.Add(cltile)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDoanhThu.DataSource)
        myCurrencyManager.Refresh()
    End Sub
End Class