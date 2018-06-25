Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility

Public Class frmQuanLyChiTietSuaChua
    Private ChiTietSuaChuaBUS As ChiTietSuaChuaBUS
    Private ChiTietSuaChuaDTO As ChiTietSuaChuaDTO
    Private col_index As Integer = 0
    Private row_index As Integer = 0
    Private Sub frmQuanLyChiTietSuaChua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMaChiTietSuaChua.Hide()
        txtMaPhieuSuaChua.Hide()
        txtMaPhuTung.Hide()
        txtSoLuong.Hide()
        txtDonGia.Hide()
        txtTienCong.Hide()
        ChiTietSuaChuaBUS = New ChiTietSuaChuaBUS()
        ChiTietSuaChuaDTO = New ChiTietSuaChuaDTO()
        loadlistChiTietSuaChua()


    End Sub

    Private Sub loadlistChiTietSuaChua()
        Dim result As Result
        Dim listChiTietSuaChua As List(Of ChiTietSuaChuaDTO)
        listChiTietSuaChua = New List(Of ChiTietSuaChuaDTO)

        ChiTietSuaChuaBUS.selectAll(listChiTietSuaChua)
        result = ChiTietSuaChuaBUS.selectAll(listChiTietSuaChua)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvChiTietSuaChua.Columns.Clear()
        dgvChiTietSuaChua.DataSource = Nothing
        dgvChiTietSuaChua.AllowUserToAddRows = False
        dgvChiTietSuaChua.AutoGenerateColumns = False
        dgvChiTietSuaChua.AllowUserToOrderColumns = True
        dgvChiTietSuaChua.DataSource = listChiTietSuaChua

        Dim clMaChiTietSuaChua = New DataGridViewTextBoxColumn()
        clMaChiTietSuaChua.Name = "machitietsuachua"
        clMaChiTietSuaChua.HeaderText = "Mã Chi Tiết Sửa Chữa"
        clMaChiTietSuaChua.DataPropertyName = "maChiTietSuaChua"
        dgvChiTietSuaChua.Columns.Add(clMaChiTietSuaChua)

        Dim clMaPhieuSuaChua = New DataGridViewTextBoxColumn()
        clMaPhieuSuaChua.Name = "maphieusuachua"
        clMaPhieuSuaChua.HeaderText = "Mã Phiếu Sửa Chửa"
        clMaPhieuSuaChua.DataPropertyName = "maphieusuachua"
        dgvChiTietSuaChua.Columns.Add(clMaPhieuSuaChua)

        Dim clMaPhuTung = New DataGridViewTextBoxColumn()
        clMaPhuTung.Name = "maphutung"
        clMaPhuTung.HeaderText = "Mã Phụ Tùng"
        clMaPhuTung.DataPropertyName = "maphutung"
        dgvChiTietSuaChua.Columns.Add(clMaPhuTung)

        Dim clSoLuong = New DataGridViewTextBoxColumn()
        clSoLuong.Name = "soluong"
        clSoLuong.HeaderText = "Số Lượng"
        clSoLuong.DataPropertyName = "soluong"
        dgvChiTietSuaChua.Columns.Add(clSoLuong)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "dongia"
        clDonGia.HeaderText = "Đơn Giá"
        clDonGia.DataPropertyName = "dongia"
        dgvChiTietSuaChua.Columns.Add(clDonGia)

        Dim clTienCong = New DataGridViewTextBoxColumn()
        clTienCong.Name = "tiencong"
        clTienCong.HeaderText = "Tiền Công"
        clTienCong.DataPropertyName = "tiencong"
        dgvChiTietSuaChua.Columns.Add(clTienCong)


    End Sub

    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
        Dim currentRowIndex As Integer = dgvChiTietSuaChua.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvChiTietSuaChua.RowCount) Then
            Try
                ChiTietSuaChuaDTO.machitietsuachua = Convert.ToInt32(txtMaChiTietSuaChua.Text)
                ChiTietSuaChuaDTO.maphieusuachua = txtMaPhieuSuaChua.Text
                ChiTietSuaChuaDTO.maphutung = Convert.ToInt32(txtMaPhuTung.Text)
                ChiTietSuaChuaDTO.soluong = Convert.ToInt32(txtSoLuong.Text)
                ChiTietSuaChuaDTO.dongia = txtDonGia.Text
                ChiTietSuaChuaDTO.tiencong = Convert.ToInt32(txtTienCong.Text)
                Dim result As Result
                result = ChiTietSuaChuaBUS.update(ChiTietSuaChuaDTO)
                If (result.FlagResult = True) Then
                    loadlistChiTietSuaChua()
                    dgvChiTietSuaChua.Rows(currentRowIndex).Selected = True
                    Try
                        ChiTietSuaChuaDTO = CType(dgvChiTietSuaChua.Rows(currentRowIndex).DataBoundItem, ChiTietSuaChuaDTO)
                        txtMaChiTietSuaChua.Text = ChiTietSuaChuaDTO.machitietsuachua
                        txtMaPhieuSuaChua.Text = ChiTietSuaChuaDTO.maphieusuachua
                        txtMaPhuTung.Text = ChiTietSuaChuaDTO.maphutung
                        txtSoLuong.Text = ChiTietSuaChuaDTO.soluong
                        txtDonGia.Text = ChiTietSuaChuaDTO.dongia
                        txtTienCong.Text = ChiTietSuaChuaDTO.tiencong
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật phiếu sửa chữa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim currentRowIndex As Integer = dgvChiTietSuaChua.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvChiTietSuaChua.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa phiếu sửa chữa có mã: " + txtMaChiTietSuaChua.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        Dim result As Result
                        result = ChiTietSuaChuaBUS.delete(Convert.ToInt32(txtMaChiTietSuaChua.Text))
                        If (result.FlagResult = True) Then
                            loadlistChiTietSuaChua()
                            If (currentRowIndex >= dgvChiTietSuaChua.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvChiTietSuaChua.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim ChiTietSuaChuaDTO = CType(dgvChiTietSuaChua.Rows(currentRowIndex).DataBoundItem, ChiTietSuaChuaDTO)
                                    txtMaChiTietSuaChua.Text = ChiTietSuaChuaDTO.machitietsuachua
                                    txtMaPhieuSuaChua.Text = ChiTietSuaChuaDTO.maphieusuachua
                                    txtMaPhuTung.Text = ChiTietSuaChuaDTO.maphutung
                                    txtSoLuong.Text = ChiTietSuaChuaDTO.soluong
                                    txtDonGia.Text = ChiTietSuaChuaDTO.dongia
                                    txtTienCong.Text = ChiTietSuaChuaDTO.tiencong
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa phiếu sửa chữa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dgvChiTietSuaChua_SelectionChanged(sender As Object, e As EventArgs) Handles dgvChiTietSuaChua.SelectionChanged
        Dim currentRowIndex As Integer = dgvChiTietSuaChua.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgvChiTietSuaChua.RowCount) Then
            Try
                Dim ChiTietSuaChuaDTO = CType(dgvChiTietSuaChua.Rows(currentRowIndex).DataBoundItem, ChiTietSuaChuaDTO)
                txtMaChiTietSuaChua.Text = ChiTietSuaChuaDTO.machitietsuachua
                txtMaPhieuSuaChua.Text = ChiTietSuaChuaDTO.maphieusuachua
                txtMaPhuTung.Text = ChiTietSuaChuaDTO.maphutung
                txtSoLuong.Text = ChiTietSuaChuaDTO.soluong
                txtDonGia.Text = ChiTietSuaChuaDTO.dongia
                txtTienCong.Text = ChiTietSuaChuaDTO.tiencong
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub
End Class