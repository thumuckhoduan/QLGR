Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility

Public Class frmQuanLyTaiKhoan
    Private taikhoanBUS As TaiKhoanBUS

    Private Sub frmQuanLyXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        taikhoanBUS = New TaiKhoanBUS()
        loadlisttaikhoan()
    End Sub
    Private Sub loadlisttaikhoan()
        ' Load LoaiXe list
        Dim listtaikhoan = New List(Of TaiKhoanDTO)
        Dim result As Result
        result = taikhoanBUS.selectALL(listtaikhoan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tai khoan không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        dgvQuanLyTaiKhoan.Columns.Clear()
        dgvQuanLyTaiKhoan.DataSource = Nothing

        dgvQuanLyTaiKhoan.AutoGenerateColumns = False
        dgvQuanLyTaiKhoan.AllowUserToAddRows = False
        dgvQuanLyTaiKhoan.DataSource = listtaikhoan
        dgvQuanLyTaiKhoan.ReadOnly = True

        Dim cltaikhoan = New DataGridViewTextBoxColumn()
        cltaikhoan.Name = "taikhoan"
        cltaikhoan.HeaderText = "Tài Khoản"
        cltaikhoan.DataPropertyName = "taikhoan"
        dgvQuanLyTaiKhoan.Columns.Add(cltaikhoan)

        Dim clmatkhau = New DataGridViewTextBoxColumn()
        clmatkhau.Name = "matkhau"
        clmatkhau.HeaderText = "Mật Khẩu"
        clmatkhau.DataPropertyName = "matkhau"
        dgvQuanLyTaiKhoan.Columns.Add(clmatkhau)

        Dim clquyen = New DataGridViewTextBoxColumn()
        clquyen.Name = "quyen"
        clquyen.HeaderText = "Quyền"
        clquyen.DataPropertyName = "quyen"
        dgvQuanLyTaiKhoan.Columns.Add(clquyen)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvQuanLyTaiKhoan.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
        Dim test = False
        If (txtTaiKhoan.Text.Length >= 5 And txtTaiKhoan.Text.Length <= 10) Then
            test = True
        End If
        If (test) Then
        Else
            MessageBox.Show("Tên tài khoản chỉ từ 5 đến 10 kí tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        test = False
        If (txtMatKhau.Text.Length >= 5 And txtMatKhau.Text.Length <= 10) Then
            test = True
        End If
        If (test) Then
        Else
            MessageBox.Show("Tên mật khẩu chỉ từ 5 đến 10 kí tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim currentRowIndex As Integer = dgvQuanLyTaiKhoan.CurrentCellAddress.Y
        Dim taikhoan = CType(dgvQuanLyTaiKhoan.Rows(currentRowIndex).DataBoundItem, TaiKhoanDTO)

        If (-1 < currentRowIndex And currentRowIndex < dgvQuanLyTaiKhoan.RowCount) Then
            Try
                Dim taikhoanDTO As TaiKhoanDTO
                taikhoanDTO = New TaiKhoanDTO()
                taikhoanDTO.taikhoan = txtTaiKhoan.Text
                taikhoanDTO.matkhau = txtMatKhau.Text
                taikhoanDTO.quyen = cbQuyen.Text
                Dim result As Result
                result = taikhoanBUS.update(taikhoanDTO, taikhoan.taikhoan)
                If (result.FlagResult = True) Then
                    loadlisttaikhoan()
                    dgvQuanLyTaiKhoan.Rows(currentRowIndex).Selected = True
                    Try
                        txtTaiKhoan.Text = taikhoan.taikhoan
                        txtMatKhau.Text = taikhoan.matkhau
                        cbQuyen.Text = taikhoan.quyen

                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Tài Khoản thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Tài Khoản không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub dgvQuanLyXe_SelectionChanged(sender As Object, e As EventArgs) Handles dgvQuanLyTaiKhoan.SelectionChanged
        Dim currentRowIndex As Integer = dgvQuanLyTaiKhoan.CurrentCellAddress.Y 'current row selected
        If (-1 < currentRowIndex And currentRowIndex < dgvQuanLyTaiKhoan.RowCount) Then
            Try
                Dim taikhoan = CType(dgvQuanLyTaiKhoan.Rows(currentRowIndex).DataBoundItem, TaiKhoanDTO)
                txtTaiKhoan.Text = taikhoan.taikhoan
                txtMatKhau.Text = taikhoan.matkhau
                cbQuyen.Text = taikhoan.quyen
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim currentRowIndex As Integer = dgvQuanLyTaiKhoan.CurrentCellAddress.Y 'current row selected
        If (-1 < currentRowIndex And currentRowIndex < dgvQuanLyTaiKhoan.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn Tài Khoản: " + txtTaiKhoan.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        Dim result As Result
                        result = taikhoanBUS.delete(txtTaiKhoan.Text)
                        If (result.FlagResult = True) Then
                            loadlisttaikhoan()
                            If (currentRowIndex >= dgvQuanLyTaiKhoan.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvQuanLyTaiKhoan.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim taikhoan = CType(dgvQuanLyTaiKhoan.Rows(currentRowIndex).DataBoundItem, TaiKhoanDTO)
                                    txtTaiKhoan.Text = taikhoan.taikhoan
                                    txtMatKhau.Text = taikhoan.matkhau
                                    cbQuyen.Text = taikhoan.quyen

                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa tài khoản thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa tài khoản không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub
End Class