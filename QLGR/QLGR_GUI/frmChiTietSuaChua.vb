Imports QLGR_BUS
Imports Utility
Imports QLGR_DTO

Public Class frmChiTietSuaChua
    Private chitietsuachuaBUS As ChiTietSuaChuaBUS
    Private phieusuachuaBUS As PhieuSuaChuaBUS
    Private phutungBUS As PhuTungBUS
    Private listphutung As List(Of PhuTungDTO)
    Private listphieu As List(Of PhieuSuaChuaDTO)
    Private list As List(Of dgvChiTietSuaChua)
    Private Sub frmChiTietSuaChua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chitietsuachuaBUS = New ChiTietSuaChuaBUS()
        phutungBUS = New PhuTungBUS()
        listphutung = New List(Of PhuTungDTO)
        listphieu = New List(Of PhieuSuaChuaDTO)
        cbSoluongTon.Hide()
        cbDonGia.Hide()
        list = New List(Of dgvChiTietSuaChua)
        phieusuachuaBUS = New PhieuSuaChuaBUS()
        phieusuachuaBUS.selectAll(listphieu)
        cbMaPhieuSuaChua.DataSource = New BindingSource(listphieu, String.Empty)
        cbMaPhieuSuaChua.DisplayMember = "maphieusuachua"
        cbMaPhieuSuaChua.ValueMember = "maphieusuachua"

        loaddgv()

        loadcb()
    End Sub

    Private Sub loadcb()
        phutungBUS.selectAll(listphutung)
        cbMaPhuTung.DataSource = New BindingSource(listphutung, String.Empty)
        cbMaPhuTung.DisplayMember = "maphutung"
        cbMaPhuTung.ValueMember = "maphutung"

        cbTenPhuTung.DataSource = cbMaPhuTung.DataSource
        cbMaPhuTung.ValueMember = "tenphutung"
        cbTenPhuTung.DisplayMember = cbMaPhuTung.ValueMember

        cbSoluongTon.DataSource = cbMaPhuTung.DataSource
        cbMaPhuTung.ValueMember = "soluongton"
        cbSoluongTon.DisplayMember = cbMaPhuTung.ValueMember

        cbDonGia.DataSource = cbMaPhuTung.DataSource
        cbMaPhuTung.ValueMember = "dongia"
        cbDonGia.DisplayMember = cbMaPhuTung.ValueMember


        cbMaPhuTung.ValueMember = "maphutung"
    End Sub

    Private Sub cbSoluongTon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSoluongTon.SelectedIndexChanged
        txbSoLuongTon.Text = cbSoluongTon.Text
    End Sub



    Private Sub dgvChiTietSuaChua_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChiTietSuaChua.CellContentClick
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvChiTietSuaChua.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
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

    Private Sub loaddgv()
        Dim maphieu = Convert.ToInt32(cbMaPhieuSuaChua.SelectedValue)
        chitietsuachuaBUS.selectAll_bymaphieu(maphieu, list)


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

    Private Sub cbMaPhieuSuaChua_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaPhieuSuaChua.SelectedIndexChanged
        Try
            loaddgv()
            loaddata()
        Catch ex As Exception
        End Try
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
    Private Sub cbMaPhuTung_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaPhuTung.SelectedIndexChanged
        loaddata()
    End Sub

    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
        Dim test = True
        Dim chitiet = New ChiTietSuaChuaDTO
        Dim phutung = New PhuTungDTO()
        For Each item In list
            If (item.maphutung = cbMaPhuTung.Text) Then
                chitiet.machitietsuachua = item.machitietsuachua
                chitiet.maphieusuachua = item.maphieusuachua
                chitiet.maphutung = item.maphutung
                chitiet.soluong = txbSoLuong.Text
                chitiet.dongia = txbDonGia.Text
                chitiet.tiencong = txbTienCong.Text
                chitietsuachuaBUS.update(chitiet)

                phutung.maphutung = cbMaPhuTung.Text
                phutung.tenphutung = cbTenPhuTung.Text
                phutung.soluongton = cbSoluongTon.Text - txbSoLuong.Text + item.soluong
                phutung.dongia = cbDonGia.Text
                phutungBUS.update(phutung)
                test = False
            End If
        Next
        If (test) Then

            Dim ma = 0
            chitietsuachuaBUS.buildMaChiTietSuaChua(ma)
            chitiet.machitietsuachua = ma
            chitiet.maphieusuachua = cbMaPhieuSuaChua.Text
            chitiet.maphutung = cbMaPhuTung.Text
            chitiet.soluong = txbSoLuong.Text
            chitiet.dongia = txbDonGia.Text
            chitiet.tiencong = txbTienCong.Text
            chitietsuachuaBUS.insert(chitiet)

            phutung.maphutung = cbMaPhuTung.Text
            phutung.tenphutung = cbTenPhuTung.Text
            phutung.soluongton = cbSoluongTon.Text - txbSoLuong.Text
            phutung.dongia = cbDonGia.Text
            phutungBUS.update(phutung)
        End If
        loaddgv()
        loadcb()
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

                        maphieu = phutung.machitietsuachua
                        phutungDTO.maphutung = phutung.maphutung
                        phutungDTO.tenphutung = phutung.tenphutung
                        phutungDTO.soluongton = cbSoluongTon.Text + phutung.soluong
                        phutungDTO.dongia = phutung.dongia
                        phutungBUS.update(phutungDTO)

                        result = chitietsuachuaBUS.delete(maphieu)



                        If (result.FlagResult = True) Then
                            loadcb()
                            loaddgv()
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvChiTietSuaChua.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvChiTietSuaChua.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa chi tiết sữa chữa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


        End If
    End Sub

    Private Sub cbDonGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDonGia.SelectedIndexChanged
        txbDonGia.Text = cbDonGia.Text
    End Sub
End Class