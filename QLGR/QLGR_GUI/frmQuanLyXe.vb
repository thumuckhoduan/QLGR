Imports QLGR_BUS
Imports Utility
Imports QLGR_DTO

Public Class frmQuanLyXe
    Private xeBUS As XeBUS
    Private chuxeBUS As ChuXeBUS

    Private Sub frmQuanLyXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbDiaChi.Hide()
        cbDienThoai.Hide()

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
        End If
        cbMaHieuXe.DataSource = New BindingSource(listHieuXe, String.Empty)
        cbHieuXe.DataSource = cbMaHieuXe.DataSource
        cbMaHieuXe.DisplayMember = "mahieuxe"
        cbMaHieuXe.ValueMember = "tenhieuxe"
        cbHieuXe.DisplayMember = cbMaHieuXe.ValueMember


        Dim listChuXe = New List(Of ChuXeDTO)
        chuxeBUS = New ChuXeBUS()
        result = chuxeBUS.selectAll(listChuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        cbMaChuXe.DataSource = New BindingSource(listChuXe, String.Empty)
        cbChuXe.DataSource = cbMaChuXe.DataSource
        cbMaChuXe.DisplayMember = "machuxe"
        cbMaChuXe.ValueMember = "tenchuxe"
        cbChuXe.DisplayMember = cbMaChuXe.ValueMember



        cbDiaChi.DataSource = cbMaChuXe.DataSource
        cbDiaChi.DisplayMember = "diachi"

        cbDienThoai.DataSource = cbMaChuXe.DataSource
        cbDienThoai.DisplayMember = "dienthoai"



    End Sub

    Private Sub loadListXe()

        Dim listXe = New List(Of XeDTO)
        Dim result As Result
        result = xeBUS.selectAll(listXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
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



        Dim clMaChuXe = New DataGridViewTextBoxColumn()
        clMaChuXe.Name = "machuxe"
        clMaChuXe.HeaderText = "Mã Chủ Xe"
        clMaChuXe.DataPropertyName = "machuxe"
        dgvQuanLyXe.Columns.Add(clMaChuXe)

        Dim clBienSo = New DataGridViewTextBoxColumn()
        clBienSo.Name = "bienso"
        clBienSo.HeaderText = "Biển Số"
        clBienSo.DataPropertyName = "bienso"
        dgvQuanLyXe.Columns.Add(clBienSo)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvQuanLyXe.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim currentRowIndex As Integer = dgvQuanLyXe.CurrentCellAddress.Y 'current row selected


        If (-1 < currentRowIndex And currentRowIndex < dgvQuanLyXe.RowCount) Then
            Try
                Dim xeDTO As XeDTO
                xeDTO = New XeDTO()

                xeDTO.maxe = Convert.ToInt32(txtMaXe.Text)
                xeDTO.mahieuxe = Convert.ToInt32(cbMaHieuXe.Text)
                xeDTO.machuxe = Convert.ToInt32(cbMaChuXe.Text)
                xeDTO.bienso = txtBienSo.Text


                Dim result As Result
                result = xeBUS.update(xeDTO)
                If (result.FlagResult = True) Then

                    loadListXe()

                    dgvQuanLyXe.Rows(currentRowIndex).Selected = True
                    Try
                        xeDTO = CType(dgvQuanLyXe.Rows(currentRowIndex).DataBoundItem, XeDTO)
                        txtMaXe.Text = xeDTO.maxe
                        cbMaHieuXe.Text = xeDTO.mahieuxe
                        cbMaChuXe.Text = xeDTO.machuxe
                        txtBienSo.Text = xeDTO.bienso

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
        Dim currentRowIndex As Integer = dgvQuanLyXe.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < dgvQuanLyXe.RowCount) Then
            Try
                Dim xeDTO = CType(dgvQuanLyXe.Rows(currentRowIndex).DataBoundItem, XeDTO)
                txtMaXe.Text = xeDTO.maxe
                cbMaHieuXe.Text = xeDTO.mahieuxe
                cbMaChuXe.Text = xeDTO.machuxe

                txtBienSo.Text = xeDTO.bienso
                txtDienThoai.Text = cbDienThoai.Text
                txtDiaChi.Text = cbDiaChi.Text

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim currentRowIndex As Integer = dgvQuanLyXe.CurrentCellAddress.Y 'current row selected


        If (-1 < currentRowIndex And currentRowIndex < dgvQuanLyXe.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa xe có mã: " + txtMaXe.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        Dim result As Result
                        result = xeBUS.delete(Convert.ToInt32(txtMaXe.Text))
                        If (result.FlagResult = True) Then

                            loadListXe()

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
                                    cbChuXe.Text = xeDTO.machuxe

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


    Private Sub cbDienThoai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDienThoai.SelectedIndexChanged
        txtDienThoai.Text = cbDienThoai.Text

    End Sub

    Private Sub cbDiaChi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDiaChi.SelectedIndexChanged
        txtDiaChi.Text = cbDiaChi.Text
    End Sub

End Class