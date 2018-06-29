Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility

Public Class frmQuanLyHieuXe
    Private hieuxeBUS As hieuxeBUS

    Private Sub QuanLyHieuXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hieuxeBUS = New HieuXeBUS()

        loadlisthieuxe()
    End Sub
    Private Sub loadlisthieuxe()
        Dim listhieuxe = New List(Of HieuXeDTO)
        Dim result As Result
        result = hieuxeBUS.selectAll(listhieuxe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachHieuXe.Columns.Clear()
        dgvDanhSachHieuXe.DataSource = Nothing

        dgvDanhSachHieuXe.AutoGenerateColumns = False
        dgvDanhSachHieuXe.AllowUserToAddRows = False
        dgvDanhSachHieuXe.DataSource = listhieuxe

        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "mahieuxe"
        clMaLoai.HeaderText = "Mã Hiệu Xe"
        clMaLoai.DataPropertyName = "mahieuxe"
        dgvDanhSachHieuXe.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "tenhieuxe"
        clTenLoai.HeaderText = "Tên Hiệu Xe"
        clTenLoai.DataPropertyName = "tenhieuxe"
        dgvDanhSachHieuXe.Columns.Add(clTenLoai)
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachHieuXe.DataSource)
        myCurrencyManager.Refresh()
    End Sub
    Private Sub dgvDanhSachHieuXe_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachHieuXe.SelectionChanged
        Dim currentRowIndex As Integer = dgvDanhSachHieuXe.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachHieuXe.RowCount) Then
            Try
                Dim hieuxe = CType(dgvDanhSachHieuXe.Rows(currentRowIndex).DataBoundItem, HieuXeDTO)
                txbMaHieuXe.Text = hieuxe.mahieuxe
                txbTenHieuXe.Text = hieuxe.tenhieuxe
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
        If (txbTenHieuXe.Text = vbNullString) Then
            MessageBox.Show("Không Được Để trống tên Phụ Tùng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim currentRowIndex As Integer = dgvDanhSachHieuXe.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachHieuXe.RowCount) Then
            Try
                Dim hieuxe As HieuXeDTO
                hieuxe = New HieuXeDTO()
                hieuxe.mahieuxe = Convert.ToInt32(txbMaHieuXe.Text)
                hieuxe.tenhieuxe = txbTenHieuXe.Text
                Dim result As Result
                result = hieuxeBUS.update(hieuxe)
                If (result.FlagResult = True) Then
                    loadlisthieuxe()
                    dgvDanhSachHieuXe.Rows(currentRowIndex).Selected = True
                    Try
                        hieuxe = CType(dgvDanhSachHieuXe.Rows(currentRowIndex).DataBoundItem, HieuXeDTO)
                        txbMaHieuXe.Text = hieuxe.mahieuxe
                        txbTenHieuXe.Text = hieuxe.tenhieuxe
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try

                    MessageBox.Show("Cập nhật Hiệu Xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Hiệu Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim currentRowIndex As Integer = dgvDanhSachHieuXe.CurrentCellAddress.Y 'current row selected
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachHieuXe.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa hiệu xe có mã: " + txbMaHieuXe.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        Dim result As Result
                        result = hieuxeBUS.delete(Convert.ToInt32(txbMaHieuXe.Text))
                        If (result.FlagResult = True) Then

                            loadlisthieuxe()
                            If (currentRowIndex >= dgvDanhSachHieuXe.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachHieuXe.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim hieuxe As HieuXeDTO
                                    hieuxe = New HieuXeDTO()
                                    hieuxe = CType(dgvDanhSachHieuXe.Rows(currentRowIndex).DataBoundItem, HieuXeDTO)
                                    txbMaHieuXe.Text = hieuxe.mahieuxe
                                    txbTenHieuXe.Text = hieuxe.tenhieuxe
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Hiệu Xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Hiệu Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class