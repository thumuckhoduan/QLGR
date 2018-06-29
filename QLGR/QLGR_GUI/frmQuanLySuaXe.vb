Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility
Public Class frmQuanLySuaXe
    Private xeBUS As XeBUS
    Private chuxeBUS As ChuXeBUS
    Private hieuxeBUS As HieuXeBUS
    Private suaxeBUS As TiepNhanSuaXeBUS

    Private Sub QuanLySuaXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xeBUS = New XeBUS()
        chuxeBUS = New ChuXeBUS()
        hieuxeBUS = New HieuXeBUS()
        suaxeBUS = New TiepNhanSuaXeBUS()
        loadListsuaxe()
    End Sub
    Private Sub loadListsuaxe()
        Dim listsuaxe = New List(Of TiepNhanSuaXeDTO)
        Dim result As Result
        result = suaxeBUS.selectAll(listsuaxe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sửa xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        dgvDanhSachSuaXe.Columns.Clear()
        dgvDanhSachSuaXe.DataSource = Nothing

        dgvDanhSachSuaXe.AutoGenerateColumns = False
        dgvDanhSachSuaXe.AllowUserToAddRows = False
        dgvDanhSachSuaXe.DataSource = listsuaxe

        Dim clmasuaxe = New DataGridViewTextBoxColumn()
        clmasuaxe.Name = "masuaxe"
        clmasuaxe.HeaderText = "Mã Sửa Xe"
        clmasuaxe.DataPropertyName = "masuaxe"
        dgvDanhSachSuaXe.Columns.Add(clmasuaxe)

        Dim clmaxe = New DataGridViewTextBoxColumn()
        clmaxe.Name = "maxe"
        clmaxe.HeaderText = "Mã Xe"
        clmaxe.DataPropertyName = "maxe"
        dgvDanhSachSuaXe.Columns.Add(clmaxe)

        Dim clngaytiepnhan = New DataGridViewTextBoxColumn()
        clngaytiepnhan.Name = "ngaytiepnhan"
        clngaytiepnhan.HeaderText = "Ngày Tiếp Nhận"
        clngaytiepnhan.DataPropertyName = "ngaytiepnhan"
        dgvDanhSachSuaXe.Columns.Add(clngaytiepnhan)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachSuaXe.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
        Dim currentRowIndex As Integer = dgvDanhSachSuaXe.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachSuaXe.RowCount) Then
            Try
                Dim suaxeDTO As TiepNhanSuaXeDTO
                suaxeDTO = New TiepNhanSuaXeDTO()

                suaxeDTO.masuaxe = Convert.ToInt32(txbMaSuaXe.Text)
                suaxeDTO.maxe = Convert.ToInt32(txbMaXe.Text)
                suaxeDTO.ngaytiepnhan = dtpNgayTiepNhan.Value

                Dim result As Result
                result = suaxeBUS.update(suaxeDTO)
                If (result.FlagResult = True) Then
                    loadListsuaxe()
                    dgvDanhSachSuaXe.Rows(currentRowIndex).Selected = True
                    Try
                        suaxeDTO = CType(dgvDanhSachSuaXe.Rows(currentRowIndex).DataBoundItem, TiepNhanSuaXeDTO)
                        txbMaSuaXe.Text = suaxeDTO.masuaxe
                        txbMaXe.Text = suaxeDTO.maxe
                        dtpNgayTiepNhan.Value = suaxeDTO.ngaytiepnhan
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Sửa xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Sửa xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub dgvDanhSachSuaXe_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachSuaXe.SelectionChanged
        If (txbMaXe.Text <> vbNullString) Then
            Dim xeDTO = New XeDTO()
            Dim chuxeDTO = New ChuXeDTO()
            Dim hieuxeDTO = New HieuXeDTO()
            xeBUS.select_byMaXe(txbMaXe.Text, xeDTO)
            chuxeBUS.select_byMaChuXe(xeDTO.machuxe, chuxeDTO)
            hieuxeBUS.select_byMaHieuXe(xeDTO.mahieuxe, hieuxeDTO)
            txtTenChuXe.Text = chuxeDTO.tenchuxe
            txtDienThoai.Text = chuxeDTO.dienthoai
            txtDiaChi.Text = chuxeDTO.diachi
            txtEmail.Text = chuxeDTO.email
            txtHieuXe.Text = hieuxeDTO.tenhieuxe
        End If
        Dim currentRowIndex As Integer = dgvDanhSachSuaXe.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachSuaXe.RowCount) Then
            Try
                Dim suaxe = CType(dgvDanhSachSuaXe.Rows(currentRowIndex).DataBoundItem, TiepNhanSuaXeDTO)
                txbMaSuaXe.Text = suaxe.masuaxe
                txbMaXe.Text = suaxe.maxe
                dtpNgayTiepNhan.Value = suaxe.ngaytiepnhan
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim currentRowIndex As Integer = dgvDanhSachSuaXe.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachSuaXe.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa đơn Sửa xe có mã: " + txbMaSuaXe.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        Dim result As Result
                        result = suaxeBUS.delete(Convert.ToInt32(txbMaSuaXe.Text))
                        If (result.FlagResult = True) Then
                            loadListsuaxe()
                            If (currentRowIndex >= dgvDanhSachSuaXe.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachSuaXe.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim suaxe = CType(dgvDanhSachSuaXe.Rows(currentRowIndex).DataBoundItem, TiepNhanSuaXeDTO)
                                    txbMaSuaXe.Text = suaxe.masuaxe
                                    txbMaXe.Text = suaxe.maxe
                                    dtpNgayTiepNhan.Value = suaxe.ngaytiepnhan
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa đơn Sửa xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa đơn Sửa xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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