Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmBaoCaoTon
    Private baocaotonBUS As BaoCaoTonBUS
    Private chitietbaocaotonBUS As ChiTietBaoCaoTonDTO
    Private baocao As List(Of dgvBaoCaoTonDTO)
    Private chitietsuachuaBUS As ChiTietSuaChuaBUS
    Private phutungBUS As PhuTungBUS
    Private nhapphutung As NhapPhuTungBUS
    Private Sub frmBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        baocaotonBUS = New BaoCaoTonBUS()
        chitietbaocaotonBUS = New ChiTietBaoCaoTonDTO()
        baocao = New List(Of dgvBaoCaoTonDTO)
        chitietsuachuaBUS = New ChiTietSuaChuaBUS()
        phutungBUS = New PhuTungBUS()
        nhapphutung = New NhapPhuTungBUS()
        cbThang.Text = Now.Month
        cbNam.Text = Now.Year
    End Sub

    Private Sub tinhtondau(thang, nam, thang_now, nam_now)
        Dim result As Result
        Do
            result = chitietsuachuaBUS.ban(thang, nam, baocao)
            If (result.FlagResult = False) Then
                MessageBox.Show("Tính số lượng phụ tùng đã bán không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            result = nhapphutung.nhapthem(thang, nam, baocao)
            If (result.FlagResult = False) Then
                MessageBox.Show("Tính số lượng phụ tùng đã nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            thang = thang + 1
            If (thang = 13) Then
                thang = 1
                nam = nam + 1
            End If
        Loop While (thang <> thang_now Or nam <> nam_now)
    End Sub
    Private Sub loaddata()
        Dim result As Result
        Dim thang = cbThang.Text + 1
        Dim nam = cbNam.Text
        Dim thang_now = Now.Month + 1
        Dim nam_now = Now.Year
        baocao.Clear()
        If (thang = 13) Then
            thang = 1
            nam = nam + 1
        End If
        If (nam <= nam_now) Then
            If (nam = nam_now And thang > thang_now) Then
                MessageBox.Show("ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
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
                    itembaocao.tondau = item.soluongton
                    itembaocao.toncuoi = 0
                    baocao.Add(itembaocao)
                Next
                If ((nam = nam_now And thang < thang_now) Or nam < nam_now) Then
                    tinhtondau(thang, nam, thang_now, nam_now)
                End If
                For Each item In baocao
                    item.nhapthem = 0
                    item.ban = 0
                Next
                result = chitietsuachuaBUS.ban(cbThang.Text, cbNam.Text, baocao)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Tính số lượng phụ tùng đã bán không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If
                result = nhapphutung.nhapthem(cbThang.Text, cbNam.Text, baocao)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Tính số lượng phụ tùng đã nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If
                For Each item In baocao
                    item.toncuoi = item.tondau + item.nhapthem - item.ban
                Next
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
            End If
        Else
            MessageBox.Show("ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnLapBaoCao_Click(sender As Object, e As EventArgs) Handles btnLapBaoCao.Click

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        loaddata()
    End Sub

    Private Sub dgvBaoCaoTon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBaoCaoTon.CellContentClick

    End Sub
End Class