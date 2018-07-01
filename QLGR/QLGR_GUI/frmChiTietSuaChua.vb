Imports QLGR_BUS
Imports Utility
Imports QLGR_DTO

Public Class frmChiTietSuaChua
    Private chitietsuachuaBUS As ChiTietSuaChuaBUS
    Private phieusuachuaBUS As PhieuSuaChuaBUS
    Private phutungBUS As PhuTungBUS
    Private listphieu As List(Of PhieuSuaChuaDTO)
    Private list As List(Of dgvChiTietSuaChua)
    Private Sub frmChiTietSuaChua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chitietsuachuaBUS = New ChiTietSuaChuaBUS()
        phutungBUS = New PhuTungBUS()
        listphieu = New List(Of PhieuSuaChuaDTO)
        Dim result As Result
        list = New List(Of dgvChiTietSuaChua)
        phieusuachuaBUS = New PhieuSuaChuaBUS()
        result = phieusuachuaBUS.selectAll(listphieu)
        If (result.FlagResult = True) Then
        Else
            MessageBox.Show("Thêm list phiếu sữa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        cbMaPhieuSuaChua.DataSource = New BindingSource(listphieu, String.Empty)
        cbMaPhieuSuaChua.DisplayMember = "maphieusuachua"
        cbMaPhieuSuaChua.ValueMember = "maphieusuachua"

        loaddgv()

        loadcombobox()
    End Sub

    Private Sub loadcombobox()
        Dim listmaphutung As List(Of PhuTungDTO)
        listmaphutung = New List(Of PhuTungDTO)

        phutungBUS.selectAll(listmaphutung)
        cbMaPhuTung.DataSource = New BindingSource(listmaphutung, String.Empty)
        cbMaPhuTung.DisplayMember = "maphutung"
        cbMaPhuTung.ValueMember = "maphutung"

        Dim listtenphutung As List(Of PhuTungDTO)
        listtenphutung = New List(Of PhuTungDTO)

        phutungBUS.selectAll_sorttenphutung(listtenphutung)
        cbTenPhuTung.DataSource = New BindingSource(listtenphutung, String.Empty)
        cbTenPhuTung.DisplayMember = "tenphutung"
        cbTenPhuTung.ValueMember = "tenphutung"


    End Sub




    Private Sub loaddgv()
        Dim maphieu = Convert.ToInt32(cbMaPhieuSuaChua.SelectedValue)
        Dim result As Result
        result = chitietsuachuaBUS.selectAll_bymaphieu(maphieu, list)
        If (result.FlagResult = True) Then
        Else
            MessageBox.Show("Thêm list phiếu sữa chữa theo mã phiếu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        dgvChiTietSuaChua.Columns.Clear()
        dgvChiTietSuaChua.DataSource = Nothing

        dgvChiTietSuaChua.AutoGenerateColumns = False
        dgvChiTietSuaChua.AllowUserToAddRows = False
        dgvChiTietSuaChua.DataSource = list

        Dim clmaphutung = New DataGridViewTextBoxColumn()
        clmaphutung.Name = "maphutung"
        clmaphutung.HeaderText = "Mã Phụ Tùng"
        clmaphutung.DataPropertyName = "maphutung"
        dgvChiTietSuaChua.Columns.Add(clmaphutung)

        Dim cltenphutung = New DataGridViewTextBoxColumn()
        cltenphutung.Name = "tenphutung"
        cltenphutung.HeaderText = " Tên Phụ Tùng"
        cltenphutung.DataPropertyName = "tenphutung"
        dgvChiTietSuaChua.Columns.Add(cltenphutung)

        Dim clsoluong = New DataGridViewTextBoxColumn()
        clsoluong.Name = "soluong"
        clsoluong.HeaderText = "Số Lượng"
        clsoluong.DataPropertyName = "soluong"
        dgvChiTietSuaChua.Columns.Add(clsoluong)

        Dim cldongia = New DataGridViewTextBoxColumn()
        cldongia.Name = "dongia"
        cldongia.HeaderText = "Đơn Giá"
        cldongia.DataPropertyName = "dongia"
        dgvChiTietSuaChua.Columns.Add(cldongia)

        Dim cltiencong = New DataGridViewTextBoxColumn()
        cltiencong.Name = "tiencong"
        cltiencong.HeaderText = "Tiền Công"
        cltiencong.DataPropertyName = "tiencong"
        dgvChiTietSuaChua.Columns.Add(cltiencong)
    End Sub


    Private Sub loaddata()
        Dim test = True
        Try
            Dim x = Convert.ToInt32(cbMaPhuTung.SelectedValue)
            For Each item In list
                If (item.maphutung = x) Then
                    txbDonGia.Text = item.dongia
                    txbSoLuong.Text = item.soluong
                    txbTienCong.Text = item.tiencong
                    test = False
                End If
            Next
        Catch ex As Exception
        End Try
        If (test) Then
            txbTienCong.Text = "0"
            txbSoLuong.Text = "0"
        End If
    End Sub

    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click

        If ((IsNumeric(txbSoLuong.Text) Or txbSoLuong.Text = vbNullString) And txbSoLuong.Text > "0") Then
        Else
            MessageBox.Show("Số Lượng Phải Là Dương", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If ((IsNumeric(txbTienCong.Text) Or txbTienCong.Text = vbNullString) And txbTienCong.Text >= "0") Then
        Else
            MessageBox.Show("Tiền Công Phải Là Số Không Âm", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim test = True
        Dim chitiet = New ChiTietSuaChuaDTO
        Dim phutung = New PhuTungDTO()
        Dim thanhtien As Integer
        Dim result As Result
        thanhtien = 0
        For Each item In list
            If (item.maphutung = cbMaPhuTung.Text) Then
                If (txbSoLuongTon.Text - txbSoLuong.Text + item.soluong < 0) Then
                    MessageBox.Show("Không đủ phụ tùng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
                chitiet.machitietsuachua = item.machitietsuachua
                chitiet.maphieusuachua = item.maphieusuachua
                chitiet.maphutung = item.maphutung
                chitiet.soluong = txbSoLuong.Text
                chitiet.dongia = txbDonGia.Text
                chitiet.tiencong = txbTienCong.Text
                result = chitietsuachuaBUS.update(chitiet)
                If (result.FlagResult = True) Then
                Else
                    MessageBox.Show("Cập Nhật chi tiết sữa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
                phutung.maphutung = cbMaPhuTung.Text
                phutung.tenphutung = cbTenPhuTung.Text
                phutung.soluongton = txbSoLuongTon.Text - txbSoLuong.Text + item.soluong
                phutung.dongia = txbDonGia.Text
                result = phutungBUS.update(phutung)
                If (result.FlagResult = True) Then
                Else
                    MessageBox.Show("Cập Nhật phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
                test = False
            End If
        Next
        If (test) Then
            If (txbSoLuongTon.Text - txbSoLuong.Text < 0) Then
                MessageBox.Show("Không đủ phụ tùng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim ma = 0
            chitietsuachuaBUS.buildMaChiTietSuaChua(ma)
            chitiet.machitietsuachua = ma
            chitiet.maphieusuachua = cbMaPhieuSuaChua.Text
            chitiet.maphutung = cbMaPhuTung.Text
            chitiet.soluong = txbSoLuong.Text
            chitiet.dongia = txbDonGia.Text
            chitiet.tiencong = txbTienCong.Text
            result = chitietsuachuaBUS.insert(chitiet)
            If (result.FlagResult = True) Then
            Else
                MessageBox.Show("Thêm chi tiết sữa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
            phutung.maphutung = cbMaPhuTung.Text
            phutung.tenphutung = cbTenPhuTung.Text
            phutung.soluongton = txbSoLuongTon.Text - txbSoLuong.Text
            phutung.dongia = txbDonGia.Text
            result = phutungBUS.update(phutung)
            If (result.FlagResult = True) Then
            Else
                MessageBox.Show("Cập Nhật phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        End If

        loaddgv()
        loadcombobox()
        txbTienCong.Text = "0"
        txbSoLuong.Text = "0"
        For Each item In list
            thanhtien = thanhtien + item.soluong * item.dongia + item.tiencong
        Next
        result = phieusuachuaBUS.update(cbMaPhieuSuaChua.Text, thanhtien)
        If (result.FlagResult = True) Then
        Else
            MessageBox.Show("Cập Nhật phiếu sữa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvChiTietSuaChua.CurrentCellAddress.Y 'current row selected

        Dim phutung = CType(dgvChiTietSuaChua.Rows(currentRowIndex).DataBoundItem, dgvChiTietSuaChua)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvChiTietSuaChua.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa phụ tùng có mã số: " + Convert.ToString(phutung.maphutung), MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        Dim result As Result
                        Dim maphieu As Integer
                        Dim phutungDTO = New PhuTungDTO()
                        Dim thanhtien As Integer
                        thanhtien = 0


                        maphieu = phutung.machitietsuachua
                        phutungDTO.maphutung = phutung.maphutung
                        phutungDTO.tenphutung = phutung.tenphutung
                        phutungDTO.soluongton = txbSoLuongTon.Text + phutung.soluong
                        phutungDTO.dongia = phutung.dongia
                        result = phutungBUS.update(phutungDTO)
                        If (result.FlagResult = True) Then
                        Else
                            MessageBox.Show("Cập Nhật phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                        result = chitietsuachuaBUS.delete(maphieu)


                        If (result.FlagResult = True) Then
                            loadcombobox()
                            loaddgv()
                            For Each item In list
                                thanhtien = thanhtien + item.soluong * item.dongia + item.tiencong
                                phieusuachuaBUS.update(cbMaPhieuSuaChua.Text, thanhtien)
                            Next
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvChiTietSuaChua.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvChiTietSuaChua.Rows(currentRowIndex).Selected = True
                            End If

                        Else
                            MessageBox.Show("Xóa chi tiết sữa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select
            MessageBox.Show("Xóa chi tiết sữa chữa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub txbThanhTien_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvChiTietSuaChua_SelectionChanged(sender As Object, e As EventArgs) Handles dgvChiTietSuaChua.SelectionChanged
        Dim currentRowIndex As Integer = dgvChiTietSuaChua.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgvChiTietSuaChua.RowCount) Then
            Try
                Dim phutung = CType(dgvChiTietSuaChua.Rows(currentRowIndex).DataBoundItem, dgvChiTietSuaChua)
                cbMaPhuTung.Text = phutung.maphutung
                cbTenPhuTung.Text = phutung.tenphutung
                txbSoLuong.Text = phutung.soluong
                txbDonGia.Text = phutung.dongia
                txbTienCong.Text = phutung.tiencong
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub



    Private Sub cbMaPhuTung_TextChanged(sender As Object, e As EventArgs) Handles cbMaPhuTung.TextChanged
        Try
            Dim phutung = New PhuTungDTO()
            phutungBUS.select_bymaphutung(cbMaPhuTung.Text, phutung)
            cbTenPhuTung.Text = phutung.tenphutung
            txbSoLuongTon.Text = phutung.soluongton
            txbDonGia.Text = phutung.dongia
            loaddata()
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
            Return
        End Try
    End Sub

    Private Sub cbTenPhuTung_TextChanged(sender As Object, e As EventArgs) Handles cbTenPhuTung.TextChanged
        Try
            Dim phutung = New PhuTungDTO()
            phutungBUS.select_bytenphutung(cbTenPhuTung.Text, phutung)
            cbMaPhuTung.Text = phutung.maphutung
            txbSoLuongTon.Text = phutung.soluongton
            txbDonGia.Text = phutung.dongia
            loaddata()
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
            Return
        End Try
    End Sub

    Private Sub cbMaPhieuSuaChua_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaPhieuSuaChua.SelectedIndexChanged
        Try
            loaddgv()
            loaddata()
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        Return
        End Try
    End Sub


End Class