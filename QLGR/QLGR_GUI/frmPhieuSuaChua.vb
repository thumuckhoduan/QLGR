Imports QLGR_BUS
Imports Utility
Imports QLGR_DTO


Public Class frmPhieuSuaChua

    Private phieusuachuaBUS As PhieuSuaChuaBUS
    Private xeBUS As XeBUS
    Private chuxeBUS As ChuXeBUS
    Private phutungBUS As PhuTungBUS
    Private chitietsuachuaBUS As ChiTietSuaChuaBUS
    Private listchitietsuachua As List(Of dgvChiTietSuaChua)
    Private Sub frmPhieuSuaChua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieusuachuaBUS = New PhieuSuaChuaBUS()
        Dim result As Result
        Dim nextMPSC = 0
        cbMaChuXe.Hide()
        txtMaChiTietSuaChua.Hide()
        cbMaXe.Hide()
        cbSoLuongTon.Hide()
        cbDonGia.Hide()
        listchitietsuachua = New List(Of dgvChiTietSuaChua)

        txtThanhTien.Text = "0"
        txtTienCong.Text = "0"
        txtSoLuong.Text = "0"
        btLuu.Enabled = False
        result = phieusuachuaBUS.buildmaphieusuachua(nextMPSC)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tự động mã phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
        txtMaPhieuSuaChua.Text = nextMPSC

        chitietsuachuaBUS = New ChiTietSuaChuaBUS()
        Dim nextMCTSC = 0
        result = chitietsuachuaBUS.buildMaChiTietSuaChua(nextMCTSC)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động chi tiết sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        txtMaChiTietSuaChua.Text = nextMCTSC

        xeBUS = New XeBUS()
        Dim listXe = New List(Of XeDTO)
        result = xeBUS.selectAll(listXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbMaXe.DataSource = New BindingSource(listXe, String.Empty)
        cbBienSo.DataSource = cbMaXe.DataSource
        cbMaXe.DisplayMember = "maxe"
        cbMaXe.ValueMember = "bienso"
        cbBienSo.DisplayMember = cbMaXe.ValueMember

        cbMaChuXe.DataSource = cbMaXe.DataSource
        cbMaXe.ValueMember = "machuxe"
        cbMaChuXe.DisplayMember = cbMaXe.ValueMember

        chuxeBUS = New ChuXeBUS()
        Dim listChuXe = New List(Of ChuXeDTO)
        result = chuxeBUS.selectAll(listChuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chủ xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbMaChuXe.DataSource = New BindingSource(listChuXe, String.Empty)
        cbTenChuXe.DataSource = cbMaChuXe.DataSource
        cbMaChuXe.DisplayMember = "machuxe"
        cbMaChuXe.ValueMember = "tenchuxe"
        cbTenChuXe.DisplayMember = cbMaChuXe.ValueMember

        updatephutung()




        loadlistchitietsuachua(listchitietsuachua)

    End Sub

    Private Sub updatephutung()
        Dim result As Result
        phutungBUS = New PhuTungBUS()
        Dim listPhuTung = New List(Of PhuTungDTO)
        result = phutungBUS.selectAll(listPhuTung)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        cbMaPhuTung.DataSource = New BindingSource(listPhuTung, String.Empty)
        cbTenPhuTung.DataSource = cbMaPhuTung.DataSource
        cbMaPhuTung.DisplayMember = "maphutung"
        cbMaPhuTung.ValueMember = "tenphutung"
        cbTenPhuTung.DisplayMember = cbMaPhuTung.ValueMember


        cbSoLuongTon.DataSource = cbMaPhuTung.DataSource
        cbMaPhuTung.ValueMember = "soluongton"
        cbSoLuongTon.DisplayMember = cbMaPhuTung.ValueMember

        cbDonGia.DataSource = cbMaPhuTung.DataSource
        cbMaPhuTung.ValueMember = "dongia"
        cbDonGia.DisplayMember = cbMaPhuTung.ValueMember
    End Sub



    Private Sub loadBienSo(MaChuXe As Integer)

        Dim listXe = New List(Of XeDTO)
        Dim result As Result
        result = xeBUS.selectall_ByMaChuXe(MaChuXe, listXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách xe theo chủ xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbBienSo.DataSource = New BindingSource(listXe, String.Empty)
        cbBienSo.DisplayMember = "bienso"
        cbBienSo.ValueMember = "maxe"

        cbMaXe.DataSource = cbBienSo.DataSource
        cbMaXe.DisplayMember = cbBienSo.ValueMember

    End Sub

    Private Sub btLuu_Click(sender As Object, e As EventArgs) Handles btLuu.Click
        btnTaoMoi.Enabled = True
        Dim phieusuachuaDTO As PhieuSuaChuaDTO
        phieusuachuaDTO = New PhieuSuaChuaDTO()
        Dim chitietsuachuaDTO As ChiTietSuaChuaDTO
        chitietsuachuaDTO = New ChiTietSuaChuaDTO()
        Dim phutungDTO As PhuTungDTO
        phutungDTO = New PhuTungDTO()

        '1. Mapping data from GUI control


        chitietsuachuaDTO.machitietsuachua = Convert.ToInt32(txtMaChiTietSuaChua.Text)
        chitietsuachuaDTO.maphieusuachua = Convert.ToInt32(txtMaPhieuSuaChua.Text)
        chitietsuachuaDTO.maphutung = Convert.ToInt32(cbMaPhuTung.Text)
        chitietsuachuaDTO.soluong = txtSoLuong.Text
        chitietsuachuaDTO.tiencong = txtTienCong.Text
        chitietsuachuaDTO.dongia = txtDonGia.Text
        If (kiemtrasoluong()) Then
            Return
        End If
        phutungDTO.maphutung = cbMaPhuTung.Text
        phutungDTO.tenphutung = cbTenPhuTung.Text
        phutungDTO.soluongton = Convert.ToInt32(cbSoLuongTon.Text) - Convert.ToInt32(txtSoLuong.Text)
        phutungDTO.dongia = Convert.ToInt32(txtDonGia.Text)


        '3. Insert to DB

        Dim result As Result



        result = chitietsuachuaBUS.insert(chitietsuachuaDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm chi tiết sửa chữa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MCTSC auto
            Dim nextMCTSC = "1"
            result = chitietsuachuaBUS.buildMaChiTietSuaChua(nextMCTSC)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động chi tiết sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtMaChiTietSuaChua.Text = nextMCTSC
        Else
            MessageBox.Show("Thêm chi tiết sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If



        result = phutungBUS.update(phutungDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Cập nhật phụ tùng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Cập nhật phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        updatephutung()
        txtThanhTien.Text = Convert.ToInt32(txtThanhTien.Text) + Convert.ToInt32(txtTienCong.Text) + (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text))



        loadlistchitietsuachua(listchitietsuachua)

    End Sub




    Private Sub loadlistchitietsuachua(listchitietsuachua As List(Of dgvChiTietSuaChua))

        dgvPhieuChiTietSuaChua.Columns.Clear()
        dgvPhieuChiTietSuaChua.AutoGenerateColumns = False
        dgvPhieuChiTietSuaChua.AllowUserToAddRows = False
        dgvPhieuChiTietSuaChua.DataSource = listchitietsuachua



        Dim clTenPhuTung = New DataGridViewTextBoxColumn()
        clTenPhuTung.Name = "tenphutung"
        clTenPhuTung.HeaderText = "Tên Phụ Tùng"
        clTenPhuTung.DataPropertyName = "tenphutung"
        dgvPhieuChiTietSuaChua.Columns.Add(clTenPhuTung)

        Dim clSoLuong = New DataGridViewTextBoxColumn()
        clSoLuong.Name = "soluong"
        clSoLuong.HeaderText = "Số Lượng"
        clSoLuong.DataPropertyName = "soluong"
        dgvPhieuChiTietSuaChua.Columns.Add(clSoLuong)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "dongia"
        clDonGia.HeaderText = "Đơn Giá"
        clDonGia.DataPropertyName = "dongia"
        dgvPhieuChiTietSuaChua.Columns.Add(clDonGia)

        Dim clTienCong = New DataGridViewTextBoxColumn()
        clTienCong.Name = "tiencong"
        clTienCong.HeaderText = "Tiền Công"
        clTienCong.DataPropertyName = "tiencong"
        dgvPhieuChiTietSuaChua.Columns.Add(clTienCong)



        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvPhieuChiTietSuaChua.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub cbMaChuXe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaChuXe.SelectedIndexChanged
        Try
            Dim chuxeDTO = CType(cbMaChuXe.SelectedItem, ChuXeDTO)
            loadBienSo(chuxeDTO.machuxe)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
            Return
        End Try
    End Sub

    Private Sub cbTenChuXe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTenChuXe.SelectedIndexChanged
        Try
            Dim chuxeDTO = CType(cbMaChuXe.SelectedItem, ChuXeDTO)
            loadBienSo(chuxeDTO.machuxe)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
            Return
        End Try
    End Sub

    Function kiemtrasoluong() As Boolean
        If (txtSoLuong.Text <> vbNullString) Then

            If (Convert.ToInt32(txtSoLuong.Text) > Convert.ToInt32(cbSoLuongTon.Text)) Then
                MessageBox.Show("Số lượng còn lại của phụ tùng không đủ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine()
                Return True
            End If
            Return False
        End If
        Return True
    End Function

    Private Sub btXoa_Click_1(sender As Object, e As EventArgs)
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvPhieuChiTietSuaChua.CurrentCellAddress.Y 'current row selected
        Dim result As Result
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvPhieuChiTietSuaChua.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa chi tiết sửa chữa có mã: " + txtMaChiTietSuaChua.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        result = chitietsuachuaBUS.delete(Convert.ToInt32(txtMaChiTietSuaChua.Text))
                        If (result.FlagResult = True) Then
                            ' Re-Load chi tiet sua chua list
                            loadlistchitietsuachua(listchitietsuachua)
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvPhieuChiTietSuaChua.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                Dim phieusuachua As PhieuSuaChuaDTO
                                phieusuachua = New PhieuSuaChuaDTO()
                                phieusuachua.thanhtien = phieusuachua.thanhtien - Convert.ToInt32(txtTienCong.Text) - (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text))
                                dgvPhieuChiTietSuaChua.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim chitietsuachuaDTO = CType(dgvPhieuChiTietSuaChua.Rows(currentRowIndex).DataBoundItem, ChiTietSuaChuaDTO)
                                    txtMaChiTietSuaChua.Text = chitietsuachuaDTO.machitietsuachua
                                    txtMaPhieuSuaChua.Text = chitietsuachuaDTO.maphieusuachua
                                    cbMaPhuTung.Text = chitietsuachuaDTO.maphutung
                                    txtSoLuong.Text = chitietsuachuaDTO.soluong
                                    txtDonGia.Text = chitietsuachuaDTO.dongia
                                    txtTienCong.Text = chitietsuachuaDTO.tiencong

                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa chi tiết sửa chữa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa chi tiết sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select
        End If
        Dim phutungDTO As PhuTungDTO
        phutungDTO = New PhuTungDTO()
        phutungDTO.maphutung = Convert.ToInt32(cbMaPhuTung.Text)
        phutungDTO.tenphutung = cbTenPhuTung.Text
        phutungDTO.soluongton = Convert.ToInt32(cbSoLuongTon.Text) + Convert.ToInt32(txtSoLuong.Text)
        result = phutungBUS.update(phutungDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Cập nhật phụ tùng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Cập nhật phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub cbSoLuongTon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSoLuongTon.SelectedIndexChanged
        txtSoLuongTon.Text = cbSoLuongTon.Text
    End Sub

    Private Sub cbDonGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDonGia.SelectedIndexChanged
        txtDonGia.Text = cbDonGia.Text
    End Sub





    Private Sub cbMaPhieuSuaChua_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnTaoMoi_Click(sender As Object, e As EventArgs) Handles btnTaoMoi.Click
        Dim phieusuachuaDTO As PhieuSuaChuaDTO
        phieusuachuaDTO = New PhieuSuaChuaDTO()
        Dim chitietsuachuaDTO As ChiTietSuaChuaDTO
        chitietsuachuaDTO = New ChiTietSuaChuaDTO()
        Dim phutungDTO As PhuTungDTO
        phutungDTO = New PhuTungDTO()
        Dim result As Result
        btLuu.Enabled = True


        Dim nextPSC = "1"
        result = phieusuachuaBUS.buildmaphieusuachua(nextPSC)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động chi tiết sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        txtMaPhieuSuaChua.Text = nextPSC

        phieusuachuaDTO.maphieusuachua = Convert.ToInt32(txtMaPhieuSuaChua.Text)
        phieusuachuaDTO.maxe = Convert.ToInt32(cbMaXe.Text)
        phieusuachuaDTO.noidung = txtNoiDung.Text
        phieusuachuaDTO.thanhtien = Convert.ToInt32(txtThanhTien.Text) + Convert.ToInt32(txtTienCong.Text) + (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text))
        phieusuachuaDTO.ngaysuachua = dtpNgaySuaChua.Value



        result = phieusuachuaBUS.insert(phieusuachuaDTO)

        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phiếu sửa chữa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Thêm phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If


        btnTaoMoi.Enabled = False
    End Sub

    Private Sub txtMaChiTietSuaChua_TextChanged(sender As Object, e As EventArgs) Handles txtMaChiTietSuaChua.TextChanged

    End Sub



    Private Sub dgvPhieuChiTietSuaChua_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPhieuChiTietSuaChua.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvPhieuChiTietSuaChua.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvQuanLyXe.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvPhieuChiTietSuaChua.RowCount) Then
            Try
                Dim chitietsuachua = CType(dgvPhieuChiTietSuaChua.Rows(currentRowIndex).DataBoundItem, dgvChiTietSuaChua)
                cbMaPhuTung.Text = chitietsuachua.maphutung
                cbTenPhuTung.Text = chitietsuachua.tenphutung
                txtSoLuong.Text = chitietsuachua.soluong
                txtDonGia.Text = chitietsuachua.dongia
                txtTienCong.Text = chitietsuachua.tiencong

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub



    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvPhieuChiTietSuaChua.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvPhieuChiTietSuaChua.RowCount) Then
            Try
                Dim chitietsuachuaDTO As ChiTietSuaChuaDTO
                chitietsuachuaDTO = New ChiTietSuaChuaDTO()

                '1. Mapping data from GUI control
                chitietsuachuaDTO.machitietsuachua = Convert.ToInt32(txtMaChiTietSuaChua.Text)
                chitietsuachuaDTO.maphieusuachua = Convert.ToInt32(txtMaPhieuSuaChua.Text)
                chitietsuachuaDTO.maphutung = cbMaPhuTung.Text
                chitietsuachuaDTO.soluong = txtSoLuong.Text
                If (kiemtrasoluong()) Then
                End If
                chitietsuachuaDTO.dongia = txtDonGia.Text
                chitietsuachuaDTO.tiencong = txtTienCong.Text


                '3. Insert to DB

                Dim result As Result
                result = chitietsuachuaBUS.update(chitietsuachuaDTO)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadlistchitietsuachua(listchitietsuachua)
                    ' Hightlight the row has been updated on table
                    dgvPhieuChiTietSuaChua.Rows(currentRowIndex).Selected = True
                    Try
                        chitietsuachuaDTO = CType(dgvPhieuChiTietSuaChua.Rows(currentRowIndex).DataBoundItem, ChiTietSuaChuaDTO)
                        txtMaChiTietSuaChua.Text = chitietsuachuaDTO.machitietsuachua
                        txtMaPhieuSuaChua.Text = chitietsuachuaDTO.maphieusuachua
                        cbMaPhuTung.Text = chitietsuachuaDTO.maphutung
                        txtSoLuong.Text = chitietsuachuaDTO.soluong
                        txtDonGia.Text = chitietsuachuaDTO.dongia
                        txtTienCong.Text = chitietsuachuaDTO.tiencong


                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật chi tiet thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật chi tiet không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        If (Convert.ToInt32(txtSoLuong.Text) = 0) Then
            MessageBox.Show("Số lượng không được bỏ trống.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If (kiemtrasoluong()) Then
            MessageBox.Show("Số lượng còn lại không đủ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        txtThanhTien.Text = Convert.ToInt32(txtThanhTien.Text) + Convert.ToInt32(txtTienCong.Text) + (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text))

        listchitietsuachua.Add(New dgvChiTietSuaChua(Convert.ToInt32(cbMaPhuTung.Text), cbTenPhuTung.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTienCong.Text)))
        loadlistchitietsuachua(listchitietsuachua)
        Dim phutungDTO As PhuTungDTO
        phutungDTO = New PhuTungDTO()
        Dim phutungBUS As PhuTungBUS
        phutungBUS = New PhuTungBUS()
        phutungDTO.maphutung = cbMaPhuTung.Text
        phutungDTO.tenphutung = cbTenPhuTung.Text
        phutungDTO.dongia = txtDonGia.Text
        phutungDTO.soluongton = Convert.ToInt32(cbSoLuongTon.Text) - Convert.ToInt32(txtSoLuong.Text)

        phutungBUS.update(phutungDTO)
        updatephutung()

    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim currentRowIndex As Integer = dgvPhieuChiTietSuaChua.CurrentCellAddress.Y
        Dim phutungDTO As PhuTungDTO
        phutungDTO = New PhuTungDTO()
        Dim phutungBUS As PhuTungBUS
        phutungBUS = New PhuTungBUS()
        phutungDTO.maphutung = cbMaPhuTung.Text
        phutungDTO.tenphutung = cbTenPhuTung.Text
        phutungDTO.dongia = txtDonGia.Text
        phutungDTO.soluongton = Convert.ToInt32(cbSoLuongTon.Text) + Convert.ToInt32(txtSoLuong.Text)
        txtThanhTien.Text = Convert.ToInt32(txtThanhTien.Text) - Convert.ToInt32(txtTienCong.Text) - (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text))
        phutungBUS.update(phutungDTO)
        updatephutung()

        If (-1 < currentRowIndex And currentRowIndex < dgvPhieuChiTietSuaChua.RowCount) Then
            Try
                Dim chitietsuachua = CType(dgvPhieuChiTietSuaChua.Rows(currentRowIndex).DataBoundItem, dgvChiTietSuaChua)
                listchitietsuachua.Remove(chitietsuachua)
                loadlistchitietsuachua(listchitietsuachua)
                Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvPhieuChiTietSuaChua.DataSource)
                myCurrencyManager.Refresh()
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub dgvPhieuChiTietSuaChua_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvPhieuChiTietSuaChua.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString
        While (strRowNumber.Length < dgvPhieuChiTietSuaChua.RowCount.ToString.Length)
            strRowNumber = "0" & strRowNumber
        End While
        Dim Size As SizeF = e.Graphics.MeasureString(strRowNumber, MyBase.Font)
        If (dgvPhieuChiTietSuaChua.RowHeadersWidth < Size.Width + 20) Then
            dgvPhieuChiTietSuaChua.RowHeadersWidth = Size.Width + 20
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, MyBase.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - Size.Height) / 2))
    End Sub
End Class