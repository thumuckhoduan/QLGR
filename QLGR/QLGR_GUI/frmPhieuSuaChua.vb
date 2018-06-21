Imports QLGR_BUS
Imports Utility
Imports QLGR_DTO

Public Class frmPhieuSuaChua

    Private phieusuachuaBUS As PhieuSuaChuaBUS
    Private xeBUS As XeBUS
    Private chuxeBUS As ChuXeBUS
    Private phutungBUS As PhuTungBUS
    Private chitietsuachuaBUS As ChiTietSuaChuaBUS
    Private Sub frmPhieuSuaChua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieusuachuaBUS = New PhieuSuaChuaBUS()
        Dim result As Result
        Dim nextMPSC = 0
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
        Dim phieusuachuaDTO As PhieuSuaChuaDTO
        phieusuachuaDTO = New PhieuSuaChuaDTO()
        Dim chitietsuachuaDTO As ChiTietSuaChuaDTO
        chitietsuachuaDTO = New ChiTietSuaChuaDTO()
        Dim phutungDTO As PhuTungDTO
        phutungDTO = New PhuTungDTO()

        '1. Mapping data from GUI control
        phieusuachuaDTO.maphieusuachua = Convert.ToInt32(txtMaPhieuSuaChua.Text)
        phieusuachuaDTO.masuaxe = Convert.ToInt32(cbMaXe.Text)
        phieusuachuaDTO.noidung = txtNoiDung.Text
        phieusuachuaDTO.masuaxe = cbMaXe.Text
        phieusuachuaDTO.thanhtien = Convert.ToInt32(txtThanhTien.Text) + Convert.ToInt32(txtTienCong.Text) + (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text))

        chitietsuachuaDTO.machitietsuachua = Convert.ToInt32(txtMaChiTietSuaChua.Text)
        chitietsuachuaDTO.maphieusuachua = Convert.ToInt32(txtMaPhieuSuaChua.Text)
        chitietsuachuaDTO.maphutung = Convert.ToInt32(cbMaPhuTung.Text)
        chitietsuachuaDTO.soluong = txtSoLuong.Text
        chitietsuachuaDTO.tiencong = txtTienCong.Text
        chitietsuachuaDTO.dongia = txtDonGia.Text

        phutungDTO.maphutung = Convert.ToInt32(cbMaPhuTung.Text)
        phutungDTO.tenphutung = cbTenPhuTung.Text
        phutungDTO.soluongton = Convert.ToInt32(cbSoLuongTon.Text) - Convert.ToInt32(txtSoLuong.Text)



        '3. Insert to DB

        Dim result As Result

        result = phieusuachuaBUS.insert(phieusuachuaDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phiếu sửa chữa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MPSC auto
            Dim nextMPSC = "1"
            result = phieusuachuaBUS.buildmaphieusuachua(nextMPSC)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtMaPhieuSuaChua.Text = nextMPSC
        Else
            MessageBox.Show("Thêm phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If


        result = chitietsuachuaBUS.insert(chitietsuachuaDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm chi tiết sửa chữa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MPSC auto
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



    End Sub

    Private Sub loadlistchitietsuachua()

        Dim listPhieuSuaChua = New List(Of PhieuSuaChuaDTO)
        Dim result As Result
        result = phieusuachuaBUS.selectAll(listPhieuSuaChua)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvPhieuSuaChua.Columns.Clear()
        dgvPhieuSuaChua.DataSource = Nothing

        dgvPhieuSuaChua.AutoGenerateColumns = False
        dgvPhieuSuaChua.AllowUserToAddRows = False
        dgvPhieuSuaChua.DataSource = listPhieuSuaChua

        Dim clMaXe = New DataGridViewTextBoxColumn()
        clMaXe.Name = "maxe"
        clMaXe.HeaderText = "Mã Xe"
        clMaXe.DataPropertyName = "maxe"
        dgvPhieuSuaChua.Columns.Add(clMaXe)

        Dim clBienSo = New DataGridViewTextBoxColumn()
        clBienSo.Name = "bienso"
        clBienSo.HeaderText = "Biển Số"
        clBienSo.DataPropertyName = "bienso"
        dgvPhieuSuaChua.Columns.Add(clBienSo)

        Dim clTenChuXe = New DataGridViewTextBoxColumn()
        clTenChuXe.Name = "tenchuxe"
        clTenChuXe.HeaderText = "Tên Chủ Xe"
        clTenChuXe.DataPropertyName = "tenchuxe"
        dgvPhieuSuaChua.Columns.Add(clTenChuXe)

        Dim clTenPhuTung = New DataGridViewTextBoxColumn()
        clTenPhuTung.Name = "tenphutung"
        clTenPhuTung.HeaderText = "Tên Phụ Tùng"
        clTenPhuTung.DataPropertyName = "tenphutung"
        dgvPhieuSuaChua.Columns.Add(clTenPhuTung)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "dongia"
        clDonGia.HeaderText = "Đơn Giá"
        clDonGia.DataPropertyName = "dongia"
        dgvPhieuSuaChua.Columns.Add(clDonGia)

        Dim clTienCong = New DataGridViewTextBoxColumn()
        clTienCong.Name = "tiencong"
        clTienCong.HeaderText = "Tiền Công"
        clTienCong.DataPropertyName = "tiencong"
        dgvPhieuSuaChua.Columns.Add(clTienCong)


        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvPhieuSuaChua.DataSource)
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

    Private Sub txtSoLuong_TextChanged(sender As Object, e As EventArgs) Handles txtSoLuong.TextChanged

        If (Convert.ToInt32(txtSoLuong.Text) > Convert.ToInt32(cbSoLuongTon.Text)) Then
            MessageBox.Show("Số lượng còn lại của phụ tùng không đủ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine()
        End If
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvPhieuSuaChua.CurrentCellAddress.Y 'current row selected
        Dim result As Result

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvPhieuSuaChua.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa chi tiết sửa chữa có mã: " + txtMaChiTietSuaChua.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB

                        Result = chitietsuachuaBUS.delete(Convert.ToInt32(txtMaChiTietSuaChua.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load chi tiet sua chua list
                            loadlistchitietsuachua()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvPhieuSuaChua.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvPhieuSuaChua.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim chitietsuachuaDTO = CType(dgvPhieuSuaChua.Rows(currentRowIndex).DataBoundItem, ChiTietSuaChuaDTO)
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
            System.Console.WriteLine(Result.SystemMessage)
        End If


    End Sub
End Class