Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmBaoCaoTon
    Private baocaotonBUS As BaoCaoTonBUS
    Private chitietbaocaotonBUS As ChiTietBaoCaoTonBUS
    Private baocao As List(Of dgvBaoCaoTonDTO)
    Private chitietsuachuaBUS As ChiTietSuaChuaBUS
    Private phutungBUS As PhuTungBUS
    Private nhapphutung As NhapPhuTungBUS
    Private Sub frmBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        baocaotonBUS = New BaoCaoTonBUS()
        chitietbaocaotonBUS = New ChiTietBaoCaoTonBUS()
        baocao = New List(Of dgvBaoCaoTonDTO)
        chitietsuachuaBUS = New ChiTietSuaChuaBUS()
        phutungBUS = New PhuTungBUS()
        nhapphutung = New NhapPhuTungBUS()

        Dim listnam = New List(Of Integer)
        Dim result As Result
        result = nhapphutung.tinhlist(listnam)
        cbNam.DataSource = New BindingSource(listnam, String.Empty)
        cbNam.DataSource = cbNam.DataSource
        cbNam.DisplayMember = cbNam.ValueMember
        cbNam.Text = Now.Year
        cbThang.Text = Now.Month
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
        If (nam <> nam_now Or thang <> thang_now) Then
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
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub changelistthang()
        Dim listthang = New List(Of Integer)
        If (cbNam.Text = Now.Year) Then
            For i = 1 To Now.Month
                listthang.Add(i)
            Next
        Else
            For i = 1 To 12
                listthang.Add(i)
            Next
        End If
        cbThang.DataSource = New BindingSource(listthang, String.Empty)
        cbThang.DataSource = cbThang.DataSource
        cbThang.DisplayMember = cbThang.ValueMember
    End Sub

    Private Sub cbNam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNam.SelectedIndexChanged
        changelistthang()
        loaddata()
    End Sub

    Private Sub cbThang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbThang.SelectedIndexChanged
        loaddata()
    End Sub

    Private Sub btnLapBaoCao_Click(sender As Object, e As EventArgs) Handles btnLapBaoCao.Click
        Dim baocaotonDTO = New BaoCaoTonDTO()
        Dim result As Result
        Dim nextma = 0
        result = baocaotonBUS.buildmabaocaoton(nextma)
        baocaotonDTO.mabaocaoton = nextma
        baocaotonDTO.thang = cbThang.Text
        baocaotonDTO.nam = cbNam.Text
        baocaotonDTO.ngaytao = Now
        result = baocaotonBUS.insert(baocaotonDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Lập báo cáo thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Lập báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        Dim chitiet = New ChiTietBaoCaoTonDTO()
        For Each item In baocao
            result = chitietbaocaotonBUS.buildmachitiet(nextma)
            If (result.FlagResult = True) Then
            Else
                MessageBox.Show("Thêm mã chi tiết báo cáo tồn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
            chitiet.mabaocaoton = nextma
            chitiet.mabaocaoton = baocaotonDTO.mabaocaoton
            chitiet.maphutung = item.maphutung
            chitiet.tondau = item.tondau
            chitiet.nhapthem = item.nhapthem
            chitiet.ban = item.ban
            chitiet.toncuoi = item.toncuoi
            result = chitietbaocaotonBUS.insert(chitiet)
            If (result.FlagResult = True) Then
            Else
                MessageBox.Show("Lập Báo Cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Next

    End Sub
End Class