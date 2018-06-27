Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility

Public Class frmQuanLyPhuTung
    Private phutungBUS As PhuTungBUS

    Private Sub QuanLyHieuXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phutungBUS = New PhuTungBUS()
        loadlistphutung()
    End Sub
    Private Sub loadlistphutung()
        Dim listphutung = New List(Of PhuTungDTO)
        Dim result As Result
        result = phutungBUS.selectAll(listphutung)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachPhuTung.Columns.Clear()
        dgvDanhSachPhuTung.DataSource = Nothing

        dgvDanhSachPhuTung.AutoGenerateColumns = False
        dgvDanhSachPhuTung.AllowUserToAddRows = False
        dgvDanhSachPhuTung.DataSource = listphutung

        Dim clmaphutung = New DataGridViewTextBoxColumn()
        clmaphutung.Name = "maphutung"
        clmaphutung.HeaderText = "Mã Phụ Tùng"
        clmaphutung.DataPropertyName = "maphutung"
        dgvDanhSachPhuTung.Columns.Add(clmaphutung)

        Dim cltenphutung = New DataGridViewTextBoxColumn()
        cltenphutung.Name = "tenphutung"
        cltenphutung.HeaderText = "Tên Phụ Tùng"
        cltenphutung.DataPropertyName = "tenphutung"
        dgvDanhSachPhuTung.Columns.Add(cltenphutung)

        Dim clsoluongton = New DataGridViewTextBoxColumn()
        clsoluongton.Name = "soluongton"
        clsoluongton.HeaderText = "Số Lượng Tồn"
        clsoluongton.DataPropertyName = "soluongton"
        dgvDanhSachPhuTung.Columns.Add(clsoluongton)

        Dim cldongia = New DataGridViewTextBoxColumn()
        cldongia.Name = "dongia"
        cldongia.HeaderText = "Đơn Giá"
        cldongia.DataPropertyName = "dongia"
        dgvDanhSachPhuTung.Columns.Add(cldongia)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachPhuTung.DataSource)
        myCurrencyManager.Refresh()
    End Sub



    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim currentRowIndex As Integer = dgvDanhSachPhuTung.CurrentCellAddress.Y 'current row selected
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachPhuTung.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa phụ tùng có mã: " + txbMaPhuTung.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        Dim result As Result
                        result = phutungBUS.delete(Convert.ToInt32(txbMaPhuTung.Text))
                        If (result.FlagResult = True) Then

                            loadlistphutung()
                            If (currentRowIndex >= dgvDanhSachPhuTung.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachPhuTung.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim phutungDTO As PhuTungDTO
                                    phutungDTO = New PhuTungDTO()
                                    phutungDTO = CType(dgvDanhSachPhuTung.Rows(currentRowIndex).DataBoundItem, PhuTungDTO)
                                    txbMaPhuTung.Text = phutungDTO.maphutung
                                    txbTenPhuTung.Text = phutungDTO.tenphutung
                                    txbSoLuongTon.Text = phutungDTO.soluongton

                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Phụ Tùng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Phụ Tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btDong_Click(sender As Object, e As EventArgs) Handles btDong.Click
        Me.Close()
    End Sub

    Private Sub dgvDanhSachPhuTung_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachPhuTung.SelectionChanged
        Dim currentRowIndex As Integer = dgvDanhSachPhuTung.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachPhuTung.RowCount) Then
            Try
                Dim phutung = CType(dgvDanhSachPhuTung.Rows(currentRowIndex).DataBoundItem, PhuTungDTO)
                txbMaPhuTung.Text = phutung.maphutung
                txbTenPhuTung.Text = phutung.tenphutung
                txbSoLuongTon.Text = phutung.soluongton
                txtDonGia.Text = phutung.dongia
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
        Dim currentRowIndex As Integer = dgvDanhSachPhuTung.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachPhuTung.RowCount) Then
            Try
                Dim phutungDTO As PhuTungDTO
                phutungDTO = New PhuTungDTO()
                phutungDTO.maphutung = txbMaPhuTung.Text
                phutungDTO.tenphutung = txbTenPhuTung.Text
                phutungDTO.soluongton = txbSoLuongTon.Text
                phutungDTO.dongia = txtDonGia.Text
                Dim result As Result
                result = phutungBUS.update(phutungDTO)
                If (result.FlagResult = True) Then
                    loadlistphutung()
                    dgvDanhSachPhuTung.Rows(currentRowIndex).Selected = True
                    Try
                        phutungDTO = CType(dgvDanhSachPhuTung.Rows(currentRowIndex).DataBoundItem, PhuTungDTO)
                        txbMaPhuTung.Text = phutungDTO.maphutung
                        txbTenPhuTung.Text = phutungDTO.tenphutung
                        txbSoLuongTon.Text = phutungDTO.soluongton
                        txtDonGia.Text = phutungDTO.dongia
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try

                    MessageBox.Show("Cập nhật Phụ Tùng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Phụ Tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
End Class