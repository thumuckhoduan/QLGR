Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmBaoCaoDoanhSo
    Private baocaodoanhsoBUS As BaoCaoDoanhSoBUS
    Private chitietdoanhsoBUS As ChiTietDoanhSoBUS
    Private phieusuachuaBUS As PhieuSuaChuaBUS
    Private hieuxeBUS As HieuXeBUS
    Private baocao As List(Of dgvbaocaodoanhso)

    Private Sub frmDoanhSo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        baocaodoanhsoBUS = New BaoCaoDoanhSoBUS()
        chitietdoanhsoBUS = New ChiTietDoanhSoBUS()
        phieusuachuaBUS = New PhieuSuaChuaBUS()
        hieuxeBUS = New HieuXeBUS()
        baocao = New List(Of dgvbaocaodoanhso)
        lbTongDoanhThu.Text = "0"
        Dim result As Result
        Dim listnam = New List(Of Integer)
        result = phieusuachuaBUS.select_nam(listnam)
        If (result.FlagResult = True) Then
        Else
            MessageBox.Show("Thêm list năm không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        cbNam.DataSource = New BindingSource(listnam, String.Empty)
        cbNam.DataSource = cbNam.DataSource
        cbNam.DisplayMember = cbNam.ValueMember

    End Sub
    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        Dim baocaodoanhsoDTO = New BaoCaoDoanhSoDTO()
        Dim result As Result
        Dim nextma = 0
        result = baocaodoanhsoBUS.buildmadoanhso(nextma)
        baocaodoanhsoDTO.madoanhso = nextma
        baocaodoanhsoDTO.thang = cbThang.Text
        baocaodoanhsoDTO.nam = cbNam.Text
        baocaodoanhsoDTO.tongdoanhthu = lbTongDoanhThu.Text
        baocaodoanhsoDTO.ngaytao = Now
        result = baocaodoanhsoBUS.insert(baocaodoanhsoDTO)
        If (result.FlagResult = True) Then
        Else
            MessageBox.Show("Thêm doanh số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        Dim chitiet = New ChiTietDoanhSoDTO()
        For Each item In baocao
            result = chitietdoanhsoBUS.buildmachitiet(nextma)
            If (result.FlagResult = True) Then
            Else
                MessageBox.Show("Thêm mã chi tiết doanh số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
            chitiet.machitiet = nextma
            chitiet.madoanhso = baocaodoanhsoDTO.madoanhso
            chitiet.mahieuxe = item.mahieuxe
            chitiet.soluotsua = item.soluotsua
            chitiet.thanhtien = item.thanhtien
            chitiet.tile = item.tile
            result = chitietdoanhsoBUS.insert(chitiet)
            If (result.FlagResult = True) Then
            Else
                MessageBox.Show("Thêm chi tiết không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Next
        MessageBox.Show("Lập Báo Cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btDong_Click(sender As Object, e As EventArgs) Handles btDong.Click
        Me.Close()
    End Sub
    Private Sub change()
        Dim result As Result
        result = chitietdoanhsoBUS.taochitietbaocao(cbThang.Text, cbNam.Text, baocao, lbTongDoanhThu.Text)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        dgvDoanhThu.DataSource = Nothing
        dgvDoanhThu.Columns.Clear()
        dgvDoanhThu.AutoGenerateColumns = False
        dgvDoanhThu.AllowUserToAddRows = False
        dgvDoanhThu.Enabled = True
        dgvDoanhThu.DataSource = baocao

        Dim clmahieuxe = New DataGridViewTextBoxColumn()
        clmahieuxe.Name = "mahieuxe"
        clmahieuxe.HeaderText = "Mã Hiệu Xe"
        clmahieuxe.DataPropertyName = "mahieuxe"
        dgvDoanhThu.Columns.Add(clmahieuxe)
        clmahieuxe.ReadOnly = True

        Dim cltenhieuxe = New DataGridViewTextBoxColumn()
        cltenhieuxe.Name = "tenhieuxe"
        cltenhieuxe.HeaderText = " Tên Hiệu Xe"
        cltenhieuxe.DataPropertyName = "tenhieuxe"
        dgvDoanhThu.Columns.Add(cltenhieuxe)
        cltenhieuxe.ReadOnly = True

        Dim clsoluotsua = New DataGridViewTextBoxColumn()
        clsoluotsua.Name = "soluotsua"
        clsoluotsua.HeaderText = "Số Lượt Sửa"
        clsoluotsua.DataPropertyName = "soluotsua"
        dgvDoanhThu.Columns.Add(clsoluotsua)
        clsoluotsua.ReadOnly = True

        Dim clthanhtien = New DataGridViewTextBoxColumn()
        clthanhtien.Name = "thanhtien"
        clthanhtien.HeaderText = "Tổng tiền"
        clthanhtien.DataPropertyName = "thanhtien"
        dgvDoanhThu.Columns.Add(clthanhtien)
        clthanhtien.ReadOnly = True

        Dim cltile = New DataGridViewTextBoxColumn()
        cltile.Name = "tile"
        cltile.HeaderText = "Tỉ Lệ"
        cltile.DataPropertyName = "tile"
        dgvDoanhThu.Columns.Add(cltile)
        cltile.ReadOnly = True

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDoanhThu.DataSource)
        myCurrencyManager.Refresh()
    End Sub
    Private Sub cbNam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNam.SelectedIndexChanged
        Dim result As Result
        Dim listthang = New List(Of Integer)

        result = phieusuachuaBUS.select_thang(cbNam.Text, listthang)
        If (result.FlagResult = True) Then
        Else
            MessageBox.Show("Thêm list tháng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        cbThang.DataSource = New BindingSource(listthang, String.Empty)
        cbThang.DataSource = cbThang.DataSource
        cbThang.DisplayMember = cbThang.ValueMember
        lbTongDoanhThu.Text = "0"
        result = phieusuachuaBUS.tongthanhtien(cbThang.Text, cbNam.Text, lbTongDoanhThu.Text)
        change()
    End Sub

    Private Sub cbThang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbThang.SelectedIndexChanged
        lbTongDoanhThu.Text = "0"
        Dim result As Result
        result = phieusuachuaBUS.tongthanhtien(cbThang.Text, cbNam.Text, lbTongDoanhThu.Text)
        If (result.FlagResult = True) Then
        Else
            MessageBox.Show("Tính Tổng Thành tiền không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        change()
    End Sub

End Class