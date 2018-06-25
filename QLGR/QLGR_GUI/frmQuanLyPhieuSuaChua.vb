Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility

Public Class frmQuanLyPhieuSuaChua
    Private phieusuachuaBUS As PhieuSuaChuaBUS
    Private phieusuachuaDTO As PhieuSuaChuaDTO
    Private col_index As Integer = 0
    Private row_index As Integer = 0
    Private Sub frmQuanLyPhieuSuaChua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMaPhieuSuaChua.Hide()
        txtMaXe.Hide()
        txtNoiDung.Hide()
        txtThanhTien.Hide()
        dtpNgaySuaChua.Hide()
        phieusuachuaBUS = New PhieuSuaChuaBUS()
        phieusuachuaDTO = New PhieuSuaChuaDTO()
        loadlistphieusuachua()

    End Sub

    Private Sub loadlistphieusuachua()
        Dim result As Result
        Dim listphieusuachua As List(Of PhieuSuaChuaDTO)
        listphieusuachua = New List(Of PhieuSuaChuaDTO)

        phieusuachuaBUS.selectAll(listphieusuachua)
        result = phieusuachuaBUS.selectAll(listphieusuachua)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu sửa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvPhieuSuaChua.Columns.Clear()
        dgvPhieuSuaChua.DataSource = Nothing
        dgvPhieuSuaChua.AllowUserToAddRows = False
        dgvPhieuSuaChua.AutoGenerateColumns = False
        dgvPhieuSuaChua.AllowUserToOrderColumns = True
        dgvPhieuSuaChua.DataSource = listphieusuachua

        Dim clMaPhieuSuaChua = New DataGridViewTextBoxColumn()
        clMaPhieuSuaChua.Name = "maphieusuachua"
        clMaPhieuSuaChua.HeaderText = "Mã Phiếu Sửa Chữa"
        clMaPhieuSuaChua.DataPropertyName = "maphieusuachua"
        dgvPhieuSuaChua.Columns.Add(clMaPhieuSuaChua)

        Dim clNoiDung = New DataGridViewTextBoxColumn()
        clNoiDung.Name = "noidung"
        clNoiDung.HeaderText = "Nội Dung"
        clNoiDung.DataPropertyName = "noidung"
        dgvPhieuSuaChua.Columns.Add(clNoiDung)

        Dim clMaXe = New DataGridViewTextBoxColumn()
        clMaXe.Name = "maxe"
        clMaXe.HeaderText = "Mã Xe"
        clMaXe.DataPropertyName = "maxe"
        dgvPhieuSuaChua.Columns.Add(clMaXe)

        Dim clThanhTien = New DataGridViewTextBoxColumn()
        clThanhTien.Name = "thanhtien"
        clThanhTien.HeaderText = "Thành Tiền"
        clThanhTien.DataPropertyName = "thanhtien"
        dgvPhieuSuaChua.Columns.Add(clThanhTien)

        Dim clNgaySuaChua = New DataGridViewTextBoxColumn()
        clNgaySuaChua.Name = "ngaysuachua"
        clNgaySuaChua.HeaderText = "Ngày Sửa Chữa"
        clNgaySuaChua.DataPropertyName = "ngaysuachua"
        dgvPhieuSuaChua.Columns.Add(clNgaySuaChua)



    End Sub

    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
        Dim currentRowIndex As Integer = dgvPhieuSuaChua.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvPhieuSuaChua.RowCount) Then
            Try
                phieusuachuaDTO.maphieusuachua = Convert.ToInt32(txtMaPhieuSuaChua.Text)
                phieusuachuaDTO.noidung = txtNoiDung.Text
                phieusuachuaDTO.maxe = Convert.ToInt32(txtMaXe.Text)
                phieusuachuaDTO.thanhtien = Convert.ToInt32(txtThanhTien.Text)
                phieusuachuaDTO.ngaysuachua = dtpNgaySuaChua.Value

                Dim result As Result
                result = phieusuachuaBUS.update(phieusuachuaDTO)
                If (result.FlagResult = True) Then
                    loadlistphieusuachua()
                    dgvPhieuSuaChua.Rows(currentRowIndex).Selected = True
                    Try
                        phieusuachuaDTO = CType(dgvPhieuSuaChua.Rows(currentRowIndex).DataBoundItem, PhieuSuaChuaDTO)
                        txtMaPhieuSuaChua.Text = phieusuachuaDTO.maphieusuachua
                        txtNoiDung.Text = phieusuachuaDTO.noidung
                        txtMaXe.Text = phieusuachuaDTO.maxe
                        txtThanhTien.Text = phieusuachuaDTO.thanhtien
                        dtpNgaySuaChua.Value = phieusuachuaDTO.ngaysuachua
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
        Dim currentRowIndex As Integer = dgvPhieuSuaChua.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvPhieuSuaChua.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa phiếu sửa chữa có mã: " + txtMaPhieuSuaChua.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        Dim result As Result
                        result = phieusuachuaBUS.delete(Convert.ToInt32(txtMaPhieuSuaChua.Text))
                        If (result.FlagResult = True) Then
                            loadlistphieusuachua()
                            If (currentRowIndex >= dgvPhieuSuaChua.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvPhieuSuaChua.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim phieusuachuaDTO = CType(dgvPhieuSuaChua.Rows(currentRowIndex).DataBoundItem, PhieuSuaChuaDTO)
                                    txtMaPhieuSuaChua.Text = phieusuachuaDTO.maphieusuachua
                                    txtNoiDung.Text = phieusuachuaDTO.noidung
                                    txtMaXe.Text = phieusuachuaDTO.maxe
                                    txtThanhTien.Text = phieusuachuaDTO.thanhtien
                                    dtpNgaySuaChua.Value = phieusuachuaDTO.ngaysuachua
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

    Private Sub dgvPhieuSuaChua_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPhieuSuaChua.SelectionChanged
        Dim currentRowIndex As Integer = dgvPhieuSuaChua.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgvPhieuSuaChua.RowCount) Then
            Try
                Dim phieusuachuaDTO = CType(dgvPhieuSuaChua.Rows(currentRowIndex).DataBoundItem, PhieuSuaChuaDTO)
                txtMaPhieuSuaChua.Text = phieusuachuaDTO.maphieusuachua
                txtNoiDung.Text = phieusuachuaDTO.noidung
                txtMaXe.Text = phieusuachuaDTO.maxe
                txtThanhTien.Text = phieusuachuaDTO.thanhtien
                dtpNgaySuaChua.Value = phieusuachuaDTO.ngaysuachua
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub
End Class