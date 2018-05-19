Imports QLGR_BUS
Imports Utility
Imports QLGR_DTO

Public Class frmQuanLyXe
    Private xeBUS As XeBUS

    Private Sub frmQuanLyXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbHieuXe.Hide()
        xeBUS = New XeBUS()
        loadListXe()
        Dim result As Result
        Dim hieuxeBUS As HieuXeBUS
        Dim listHieuXe = New List(Of HieuXeDTO)
        hieuxeBUS = New HieuXeBUS()
        result = hieuxeBUS.selectAll(listHieuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbMaHieuXe.DataSource = New BindingSource(listHieuXe, String.Empty)
        cbHieuXe.DataSource = cbMaHieuXe.DataSource
        cbMaHieuXe.DisplayMember = "mahieuxe"
        cbMaHieuXe.ValueMember = "tenhieuxe"
        cbHieuXe.DisplayMember = cbMaHieuXe.ValueMember
    End Sub

    Private Sub loadListXe()
        ' Load LoaiHocSinh list
        Dim listXe = New List(Of XeDTO)
        Dim result As Result
        result = xeBUS.selectAll(listXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvQuanLyXe.Columns.Clear()
        dgvQuanLyXe.DataSource = Nothing

        dgvQuanLyXe.AutoGenerateColumns = False
        dgvQuanLyXe.AllowUserToAddRows = False
        dgvQuanLyXe.DataSource = listXe

        Dim clMaXe = New DataGridViewTextBoxColumn()
        clMaXe.Name = "maxe"
        clMaXe.HeaderText = "Mã Xe"
        clMaXe.DataPropertyName = "maxe"
        dgvQuanLyXe.Columns.Add(clMaXe)

        Dim clMaHieuXe = New DataGridViewTextBoxColumn()
        clMaHieuXe.Name = "mahieuxe"
        clMaHieuXe.HeaderText = "Mã Hiệu Xe"
        clMaHieuXe.DataPropertyName = "mahieuxe"
        dgvQuanLyXe.Columns.Add(clMaHieuXe)

        Dim clBienSo = New DataGridViewTextBoxColumn()
        clBienSo.Name = "bienso"
        clBienSo.HeaderText = "Biển Số"
        clBienSo.DataPropertyName = "bienso"
        dgvQuanLyXe.Columns.Add(clBienSo)

        Dim clChuXe = New DataGridViewTextBoxColumn()
        clChuXe.Name = "chuxe"
        clChuXe.HeaderText = "Chủ Xe"
        clChuXe.DataPropertyName = "chuxe"
        dgvQuanLyXe.Columns.Add(clChuXe)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "diachi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "diachi"
        dgvQuanLyXe.Columns.Add(clDiaChi)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "dienthoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "dienthoai"
        dgvQuanLyXe.Columns.Add(clDienThoai)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvQuanLyXe.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvQuanLyXe.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvQuanLyXe.RowCount) Then
            Try
                Dim xeDTO As XeDTO
                xeDTO = New XeDTO()

                '1. Mapping data from GUI control
                xeDTO.maxe = Convert.ToInt32(txtMaXe.Text)
                xeDTO.dienthoai = txtDienThoai.Text
                xeDTO.chuxe = txtChuXe.Text
                xeDTO.diachi = txtDiaChi.Text
                xeDTO.bienso = txtBienSo.Text
                xeDTO.mahieuxe = Convert.ToInt32(cbMaHieuXe.Text)



                '3. Insert to DB

                Dim result As Result
                result = xeBUS.update(xeDTO)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListXe()
                    ' Hightlight the row has been updated on table
                    dgvQuanLyXe.Rows(currentRowIndex).Selected = True
                    Try
                        xeDTO = CType(dgvQuanLyXe.Rows(currentRowIndex).DataBoundItem, XeDTO)
                        txtMaXe.Text = xeDTO.maxe
                        cbMaHieuXe.Text = xeDTO.mahieuxe
                        txtBienSo.Text = xeDTO.bienso
                        txtChuXe.Text = xeDTO.chuxe
                        txtDiaChi.Text = xeDTO.diachi
                        txtDienThoai.Text = xeDTO.dienthoai

                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub dgvQuanLyXe_SelectionChanged(sender As Object, e As EventArgs) Handles dgvQuanLyXe.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvQuanLyXe.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvQuanLyXe.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvQuanLyXe.RowCount) Then
            Try
                Dim xeDTO = CType(dgvQuanLyXe.Rows(currentRowIndex).DataBoundItem, XeDTO)
                txtMaXe.Text = xeDTO.maxe
                cbMaHieuXe.Text = xeDTO.mahieuxe
                txtBienSo.Text = xeDTO.bienso
                txtChuXe.Text = xeDTO.chuxe
                txtDiaChi.Text = xeDTO.diachi
                txtDienThoai.Text = xeDTO.dienthoai
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub cbHieuXe_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbHieuXe.SelectedValueChanged
        txtHieuXe.Text = cbHieuXe.Text
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvQuanLyXe.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvQuanLyXe.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa xe có mã: " + txtMaXe.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = xeBUS.delete(Convert.ToInt32(txtMaXe.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListXe()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvQuanLyXe.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvQuanLyXe.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim xeDTO = CType(dgvQuanLyXe.Rows(currentRowIndex).DataBoundItem, XeDTO)
                                    txtMaXe.Text = xeDTO.maxe
                                    cbMaHieuXe.Text = xeDTO.mahieuxe
                                    txtBienSo.Text = xeDTO.bienso
                                    txtChuXe.Text = xeDTO.chuxe
                                    txtDiaChi.Text = xeDTO.diachi
                                    txtDienThoai.Text = xeDTO.dienthoai
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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