<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChiTietSuaChua
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txbSoLuongTon = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txbSoLuong = New System.Windows.Forms.TextBox()
        Me.txbDonGia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbTenPhuTung = New System.Windows.Forms.ComboBox()
        Me.cbMaPhuTung = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvChiTietSuaChua = New System.Windows.Forms.DataGridView()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.txbTienCong = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSoluongTon = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMaPhieuSuaChua = New System.Windows.Forms.ComboBox()
        Me.cbDonGia = New System.Windows.Forms.ComboBox()
        CType(Me.dgvChiTietSuaChua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbSoLuongTon
        '
        Me.txbSoLuongTon.Location = New System.Drawing.Point(186, 91)
        Me.txbSoLuongTon.Name = "txbSoLuongTon"
        Me.txbSoLuongTon.ReadOnly = True
        Me.txbSoLuongTon.Size = New System.Drawing.Size(122, 20)
        Me.txbSoLuongTon.TabIndex = 64
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(66, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Còn Lại"
        '
        'txbSoLuong
        '
        Me.txbSoLuong.Location = New System.Drawing.Point(186, 140)
        Me.txbSoLuong.Name = "txbSoLuong"
        Me.txbSoLuong.Size = New System.Drawing.Size(122, 20)
        Me.txbSoLuong.TabIndex = 61
        '
        'txbDonGia
        '
        Me.txbDonGia.Location = New System.Drawing.Point(475, 92)
        Me.txbDonGia.Name = "txbDonGia"
        Me.txbDonGia.ReadOnly = True
        Me.txbDonGia.Size = New System.Drawing.Size(122, 20)
        Me.txbDonGia.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(354, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Đơn Giá"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Số Lượng"
        '
        'cbTenPhuTung
        '
        Me.cbTenPhuTung.FormattingEnabled = True
        Me.cbTenPhuTung.Location = New System.Drawing.Point(475, 48)
        Me.cbTenPhuTung.Name = "cbTenPhuTung"
        Me.cbTenPhuTung.Size = New System.Drawing.Size(122, 21)
        Me.cbTenPhuTung.TabIndex = 53
        '
        'cbMaPhuTung
        '
        Me.cbMaPhuTung.FormattingEnabled = True
        Me.cbMaPhuTung.Location = New System.Drawing.Point(186, 40)
        Me.cbMaPhuTung.Name = "cbMaPhuTung"
        Me.cbMaPhuTung.Size = New System.Drawing.Size(122, 21)
        Me.cbMaPhuTung.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Mã Phụ Tùng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(354, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Tên Phụ Tùng"
        '
        'dgvChiTietSuaChua
        '
        Me.dgvChiTietSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietSuaChua.Location = New System.Drawing.Point(122, 198)
        Me.dgvChiTietSuaChua.Name = "dgvChiTietSuaChua"
        Me.dgvChiTietSuaChua.Size = New System.Drawing.Size(466, 148)
        Me.dgvChiTietSuaChua.TabIndex = 65
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(122, 374)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhat.TabIndex = 66
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(513, 374)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 23)
        Me.btXoa.TabIndex = 67
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'txbTienCong
        '
        Me.txbTienCong.Location = New System.Drawing.Point(475, 144)
        Me.txbTienCong.Name = "txbTienCong"
        Me.txbTienCong.Size = New System.Drawing.Size(122, 20)
        Me.txbTienCong.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(354, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Tiền Công"
        '
        'cbSoluongTon
        '
        Me.cbSoluongTon.FormattingEnabled = True
        Me.cbSoluongTon.Location = New System.Drawing.Point(186, 90)
        Me.cbSoluongTon.Name = "cbSoluongTon"
        Me.cbSoluongTon.Size = New System.Drawing.Size(122, 21)
        Me.cbSoluongTon.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Mã Phiếu Sữa Chữa"
        '
        'cbMaPhieuSuaChua
        '
        Me.cbMaPhieuSuaChua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaPhieuSuaChua.FormattingEnabled = True
        Me.cbMaPhieuSuaChua.Location = New System.Drawing.Point(343, 10)
        Me.cbMaPhieuSuaChua.Name = "cbMaPhieuSuaChua"
        Me.cbMaPhieuSuaChua.Size = New System.Drawing.Size(161, 21)
        Me.cbMaPhieuSuaChua.TabIndex = 73
        '
        'cbDonGia
        '
        Me.cbDonGia.FormattingEnabled = True
        Me.cbDonGia.Location = New System.Drawing.Point(475, 91)
        Me.cbDonGia.Name = "cbDonGia"
        Me.cbDonGia.Size = New System.Drawing.Size(122, 21)
        Me.cbDonGia.TabIndex = 74
        '
        'frmChiTietSuaChua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 409)
        Me.Controls.Add(Me.cbDonGia)
        Me.Controls.Add(Me.cbMaPhieuSuaChua)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbSoluongTon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbTienCong)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btCapNhat)
        Me.Controls.Add(Me.dgvChiTietSuaChua)
        Me.Controls.Add(Me.txbSoLuongTon)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txbSoLuong)
        Me.Controls.Add(Me.txbDonGia)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbTenPhuTung)
        Me.Controls.Add(Me.cbMaPhuTung)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmChiTietSuaChua"
        Me.Text = "Chi Tiết Sữa Chữa"
        CType(Me.dgvChiTietSuaChua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbSoLuongTon As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txbSoLuong As TextBox
    Friend WithEvents txbDonGia As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbTenPhuTung As ComboBox
    Friend WithEvents cbMaPhuTung As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvChiTietSuaChua As DataGridView
    Friend WithEvents btCapNhat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents txbTienCong As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbSoluongTon As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbMaPhieuSuaChua As ComboBox
    Friend WithEvents cbDonGia As ComboBox
End Class
