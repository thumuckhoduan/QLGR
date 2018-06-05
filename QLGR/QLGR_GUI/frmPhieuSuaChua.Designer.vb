<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuSuaChua
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaPhieuSuaChua = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvPhieuSuaChua = New System.Windows.Forms.DataGridView()
        Me.cbMaPhuTung = New System.Windows.Forms.ComboBox()
        Me.cbTenPhuTung = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTienCong = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbMaChuXe = New System.Windows.Forms.ComboBox()
        Me.cbTenChuXe = New System.Windows.Forms.ComboBox()
        Me.btLuu = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.cbMaXe = New System.Windows.Forms.ComboBox()
        Me.cbBienSo = New System.Windows.Forms.ComboBox()
        Me.txtNoiDung = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbDonGia = New System.Windows.Forms.ComboBox()
        Me.txtMaChiTietSuaChua = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.cbSoLuongTon = New System.Windows.Forms.ComboBox()
        CType(Me.dgvPhieuSuaChua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu Sửa Chữa"
        '
        'txtMaPhieuSuaChua
        '
        Me.txtMaPhieuSuaChua.Location = New System.Drawing.Point(129, 32)
        Me.txtMaPhieuSuaChua.Name = "txtMaPhieuSuaChua"
        Me.txtMaPhieuSuaChua.ReadOnly = True
        Me.txtMaPhieuSuaChua.Size = New System.Drawing.Size(122, 20)
        Me.txtMaPhieuSuaChua.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã Xe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Biển Số"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tên Chủ Xe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mã Chủ Xe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(473, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tên Phụ Tùng"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(267, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Mã Phụ Tùng"
        '
        'dgvPhieuSuaChua
        '
        Me.dgvPhieuSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhieuSuaChua.Location = New System.Drawing.Point(280, 161)
        Me.dgvPhieuSuaChua.Name = "dgvPhieuSuaChua"
        Me.dgvPhieuSuaChua.Size = New System.Drawing.Size(397, 137)
        Me.dgvPhieuSuaChua.TabIndex = 14
        '
        'cbMaPhuTung
        '
        Me.cbMaPhuTung.FormattingEnabled = True
        Me.cbMaPhuTung.Location = New System.Drawing.Point(345, 56)
        Me.cbMaPhuTung.Name = "cbMaPhuTung"
        Me.cbMaPhuTung.Size = New System.Drawing.Size(122, 21)
        Me.cbMaPhuTung.TabIndex = 15
        '
        'cbTenPhuTung
        '
        Me.cbTenPhuTung.FormattingEnabled = True
        Me.cbTenPhuTung.Location = New System.Drawing.Point(555, 56)
        Me.cbTenPhuTung.Name = "cbTenPhuTung"
        Me.cbTenPhuTung.Size = New System.Drawing.Size(122, 21)
        Me.cbTenPhuTung.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(267, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Số Lượng"
        '
        'txtTienCong
        '
        Me.txtTienCong.Location = New System.Drawing.Point(345, 108)
        Me.txtTienCong.Name = "txtTienCong"
        Me.txtTienCong.Size = New System.Drawing.Size(122, 20)
        Me.txtTienCong.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(267, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Tiền Công"
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(555, 108)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.ReadOnly = True
        Me.txtThanhTien.Size = New System.Drawing.Size(122, 20)
        Me.txtThanhTien.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(473, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Thành Tiền"
        '
        'cbMaChuXe
        '
        Me.cbMaChuXe.FormattingEnabled = True
        Me.cbMaChuXe.Location = New System.Drawing.Point(129, 164)
        Me.cbMaChuXe.Name = "cbMaChuXe"
        Me.cbMaChuXe.Size = New System.Drawing.Size(122, 21)
        Me.cbMaChuXe.TabIndex = 23
        '
        'cbTenChuXe
        '
        Me.cbTenChuXe.FormattingEnabled = True
        Me.cbTenChuXe.Location = New System.Drawing.Point(129, 190)
        Me.cbTenChuXe.Name = "cbTenChuXe"
        Me.cbTenChuXe.Size = New System.Drawing.Size(122, 21)
        Me.cbTenChuXe.TabIndex = 24
        '
        'btLuu
        '
        Me.btLuu.Location = New System.Drawing.Point(140, 390)
        Me.btLuu.Name = "btLuu"
        Me.btLuu.Size = New System.Drawing.Size(66, 29)
        Me.btLuu.TabIndex = 25
        Me.btLuu.Text = "Lưu"
        Me.btLuu.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(276, 390)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(66, 29)
        Me.btXoa.TabIndex = 26
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(607, 390)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(66, 29)
        Me.btThoat.TabIndex = 27
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(436, 390)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(66, 29)
        Me.btCapNhat.TabIndex = 28
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'cbMaXe
        '
        Me.cbMaXe.FormattingEnabled = True
        Me.cbMaXe.Location = New System.Drawing.Point(129, 85)
        Me.cbMaXe.Name = "cbMaXe"
        Me.cbMaXe.Size = New System.Drawing.Size(122, 21)
        Me.cbMaXe.TabIndex = 29
        '
        'cbBienSo
        '
        Me.cbBienSo.FormattingEnabled = True
        Me.cbBienSo.Location = New System.Drawing.Point(129, 111)
        Me.cbBienSo.Name = "cbBienSo"
        Me.cbBienSo.Size = New System.Drawing.Size(122, 21)
        Me.cbBienSo.TabIndex = 30
        '
        'txtNoiDung
        '
        Me.txtNoiDung.Location = New System.Drawing.Point(129, 138)
        Me.txtNoiDung.Multiline = True
        Me.txtNoiDung.Name = "txtNoiDung"
        Me.txtNoiDung.Size = New System.Drawing.Size(548, 20)
        Me.txtNoiDung.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Nội Dung"
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(555, 82)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.ReadOnly = True
        Me.txtDonGia.Size = New System.Drawing.Size(122, 20)
        Me.txtDonGia.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(473, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Đơn Giá"
        '
        'cbDonGia
        '
        Me.cbDonGia.FormattingEnabled = True
        Me.cbDonGia.Location = New System.Drawing.Point(555, 29)
        Me.cbDonGia.Name = "cbDonGia"
        Me.cbDonGia.Size = New System.Drawing.Size(122, 21)
        Me.cbDonGia.TabIndex = 36
        '
        'txtMaChiTietSuaChua
        '
        Me.txtMaChiTietSuaChua.Location = New System.Drawing.Point(129, 59)
        Me.txtMaChiTietSuaChua.Name = "txtMaChiTietSuaChua"
        Me.txtMaChiTietSuaChua.ReadOnly = True
        Me.txtMaChiTietSuaChua.Size = New System.Drawing.Size(122, 20)
        Me.txtMaChiTietSuaChua.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Mã Chi Tiết Sửa Chữa"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(345, 82)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(122, 20)
        Me.txtSoLuong.TabIndex = 39
        '
        'cbSoLuongTon
        '
        Me.cbSoLuongTon.FormattingEnabled = True
        Me.cbSoLuongTon.Location = New System.Drawing.Point(345, 29)
        Me.cbSoLuongTon.Name = "cbSoLuongTon"
        Me.cbSoLuongTon.Size = New System.Drawing.Size(122, 21)
        Me.cbSoLuongTon.TabIndex = 40
        '
        'frmPhieuSuaChua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbSoLuongTon)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtMaChiTietSuaChua)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbDonGia)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNoiDung)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbBienSo)
        Me.Controls.Add(Me.cbMaXe)
        Me.Controls.Add(Me.btCapNhat)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btLuu)
        Me.Controls.Add(Me.cbTenChuXe)
        Me.Controls.Add(Me.cbMaChuXe)
        Me.Controls.Add(Me.txtThanhTien)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTienCong)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbTenPhuTung)
        Me.Controls.Add(Me.cbMaPhuTung)
        Me.Controls.Add(Me.dgvPhieuSuaChua)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaPhieuSuaChua)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPhieuSuaChua"
        Me.Text = "frmPhieuSuaChua"
        CType(Me.dgvPhieuSuaChua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaPhieuSuaChua As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvPhieuSuaChua As DataGridView
    Friend WithEvents cbMaPhuTung As ComboBox
    Friend WithEvents cbTenPhuTung As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTienCong As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtThanhTien As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbMaChuXe As ComboBox
    Friend WithEvents cbTenChuXe As ComboBox
    Friend WithEvents btLuu As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btThoat As Button
    Friend WithEvents btCapNhat As Button
    Friend WithEvents cbMaXe As ComboBox
    Friend WithEvents cbBienSo As ComboBox
    Friend WithEvents txtNoiDung As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbDonGia As ComboBox
    Friend WithEvents txtMaChiTietSuaChua As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents cbSoLuongTon As ComboBox
End Class
