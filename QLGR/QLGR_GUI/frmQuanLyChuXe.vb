Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility


Public Class frmQuanLyChuXe

    Private chuxeBUS As ChuXeBUS

    Private Sub frmQuanLyChuXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chuxeBUS = New ChuXeBUS()
        loadListChuXe()
    End Sub

    Private Sub loadListChuXe()
        ' Load ChuXe list
        Dim listChuXe = New List(Of ChuXeDTO)
        Dim result As Result
        result = chuxeBUS.selectAll(listChuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        dgvDanhSachChuXe.Columns.Clear()
        dgvDanhSachChuXe.DataSource = Nothing

        dgvDanhSachChuXe.AutoGenerateColumns = False
        dgvDanhSachChuXe.AllowUserToAddRows = False
        dgvDanhSachChuXe.DataSource = listChuXe

        Dim clMaChuXe = New DataGridViewTextBoxColumn()
        clMaChuXe.Name = "machuxe"
        clMaChuXe.HeaderText = "Mã Chủ Xe"
        clMaChuXe.DataPropertyName = "machuxe"
        dgvDanhSachChuXe.Columns.Add(clMaChuXe)

        Dim clTenChuXe = New DataGridViewTextBoxColumn()
        clTenChuXe.Name = "tenchuxe"
        clTenChuXe.HeaderText = "Tên Chủ Xe"
        clTenChuXe.DataPropertyName = "tenchuxe"
        dgvDanhSachChuXe.Columns.Add(clTenChuXe)



        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "diachi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "diachi"
        dgvDanhSachChuXe.Columns.Add(clDiaChi)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "dienthoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "dienthoai"
        dgvDanhSachChuXe.Columns.Add(clDienThoai)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "email"
        dgvDanhSachChuXe.Columns.Add(clEmail)

        Dim clTienNo = New DataGridViewTextBoxColumn()
        clTienNo.Name = "tienno"
        clTienNo.HeaderText = "Tiền Nợ"
        clTienNo.DataPropertyName = "tienno"
        dgvDanhSachChuXe.Columns.Add(clTienNo)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachChuXe.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If (txtTenChuXe.Text = vbNullString) Then
            MessageBox.Show("Không Được Để trống tên chủ xe", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If


        If (IsNumeric(txtDienThoai.Text) Or txtDienThoai.Text = vbNullString) Then
        Else
            MessageBox.Show("Điện Thoại Phải Là Số", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If (txtDienThoai.Text = vbNullString And txtEmail.Text = vbNullString) Then
            MessageBox.Show("Không Được để trống điện thoại hoặc email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachChuXe.CurrentCellAddress.Y 'current row selected


        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachChuXe.RowCount) Then
            Try
                Dim chuXeDTO As ChuXeDTO
                chuXeDTO = New ChuXeDTO()

                chuXeDTO.machuxe = Convert.ToInt32(txtMaChuXe.Text)
                chuXeDTO.tenchuxe = txtTenChuXe.Text
                chuXeDTO.diachi = txtDiaChi.Text
                chuXeDTO.dienthoai = txtDienThoai.Text
                chuXeDTO.email = txtEmail.Text
                chuXeDTO.tienno = txtTienNo.Text



                Dim result As Result
                result = chuxeBUS.update(chuXeDTO)
                If (result.FlagResult = True) Then
                    loadListChuXe()
                    dgvDanhSachChuXe.Rows(currentRowIndex).Selected = True
                    Try
                        chuXeDTO = CType(dgvDanhSachChuXe.Rows(currentRowIndex).DataBoundItem, ChuXeDTO)
                        txtMaChuXe.Text = chuXeDTO.machuxe
                        txtTenChuXe.Text = chuXeDTO.tenchuxe
                        txtDiaChi.Text = chuXeDTO.diachi
                        txtDienThoai.Text = chuXeDTO.dienthoai
                        txtEmail.Text = chuXeDTO.email
                        txtTienNo.Text = chuXeDTO.tienno

                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật chủ xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật chủ xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim currentRowIndex As Integer = dgvDanhSachChuXe.CurrentCellAddress.Y 'current row selected


        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachChuXe.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa xe có mã: " + txtMaChuXe.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        Dim result As Result
                        result = chuxeBUS.delete(Convert.ToInt32(txtMaChuXe.Text))
                        If (result.FlagResult = True) Then

                            loadListChuXe()

                            If (currentRowIndex >= dgvDanhSachChuXe.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachChuXe.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim chuXeDTO = CType(dgvDanhSachChuXe.Rows(currentRowIndex).DataBoundItem, ChuXeDTO)
                                    txtMaChuXe.Text = chuXeDTO.machuxe
                                    txtTenChuXe.Text = chuXeDTO.tenchuxe
                                    txtDiaChi.Text = chuXeDTO.diachi
                                    txtDienThoai.Text = chuXeDTO.dienthoai
                                    txtEmail.Text = chuXeDTO.email
                                    txtTienNo.Text = chuXeDTO.tienno

                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa chủ xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa chủ xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dgvDanhSachChuXe_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachChuXe.SelectionChanged
        Dim currentRowIndex As Integer = dgvDanhSachChuXe.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachChuXe.RowCount) Then
            Try
                Dim chuxeDTO = CType(dgvDanhSachChuXe.Rows(currentRowIndex).DataBoundItem, ChuXeDTO)
                txtMaChuXe.Text = chuxeDTO.machuxe
                txtTenChuXe.Text = chuxeDTO.tenchuxe
                txtDiaChi.Text = chuxeDTO.diachi
                txtDienThoai.Text = chuxeDTO.dienthoai
                txtEmail.Text = chuxeDTO.email
                txtTienNo.Text = chuxeDTO.tienno
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
End Class