Imports QLGR_DTO
Imports QLGR_BUS
Imports Utility


Public Class frmManHinh
    Private taikhoanBUS As TaiKhoanBUS



    Private Sub frmManHinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTaiKhoan.Text = ""
        txtMatKhau.Text = ""
        taikhoanBUS = New TaiKhoanBUS()
        Me.Font = New Font("Times New Roman", 9, FontStyle.Regular)

    End Sub

    Private Sub btManHinh_Click(sender As Object, e As EventArgs) Handles btManHinh.Click
        Dim taikhoanDTO As New TaiKhoanDTO()
        taikhoanDTO.taikhoan = txtTaiKhoan.Text
        taikhoanDTO.matkhau = txtMatKhau.Text
        taikhoanBUS.get_quyen(taikhoanDTO)
        If (taikhoanDTO.quyen = "") Then
            MessageBox.Show("Tên Hoặc Mật Khẩu Sai")
            txtMatKhau.Text = ""
        ElseIf (taikhoanDTO.quyen = "user") Then
            Dim frm = New frmUser()
            txtMatKhau.Text = ""
            Me.Hide()
            frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog(Me)
            Me.Show()
        ElseIf (taikhoanDTO.quyen = "admin") Then
            Dim frm = New frmAdmin()
            txtMatKhau.Text = ""
            Me.Hide()
            frm.Font = New Font("Times New Roman", 15, FontStyle.Regular)
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog(Me)
            Me.Show()

        ElseIf (taikhoanDTO.quyen = "quan ly") Then
            Dim frm = New frmQuanLy()
            txtMatKhau.Text = ""
            Me.Hide()
            frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog(Me)
            Me.Show()
        End If

    End Sub

    Private Sub btDoiMatKhau_Click(sender As Object, e As EventArgs) Handles btDoiMatKhau.Click
        Dim frm = New frmDoiMatKhau()
        Me.Hide()
        frm.Font = New Font("Times New Roman", 9, FontStyle.Regular)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog(Me)
        Me.Show()
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub

    Private Sub frmManHinh_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub
End Class