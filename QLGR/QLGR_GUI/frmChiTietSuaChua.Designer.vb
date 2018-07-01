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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChiTietSuaChua))
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMaPhieuSuaChua = New System.Windows.Forms.ComboBox()
        Me.btThoat = New System.Windows.Forms.Button()
        CType(Me.dgvChiTietSuaChua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbSoLuongTon
        '
        Me.txbSoLuongTon.Location = New System.Drawing.Point(186, 127)
        Me.txbSoLuongTon.Name = "txbSoLuongTon"
        Me.txbSoLuongTon.ReadOnly = True
        Me.txbSoLuongTon.Size = New System.Drawing.Size(122, 20)
        Me.txbSoLuongTon.TabIndex = 64
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(66, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Còn Lại"
        '
        'txbSoLuong
        '
        Me.txbSoLuong.Location = New System.Drawing.Point(186, 163)
        Me.txbSoLuong.Name = "txbSoLuong"
        Me.txbSoLuong.Size = New System.Drawing.Size(122, 20)
        Me.txbSoLuong.TabIndex = 61
        '
        'txbDonGia
        '
        Me.txbDonGia.Location = New System.Drawing.Point(475, 118)
        Me.txbDonGia.Name = "txbDonGia"
        Me.txbDonGia.ReadOnly = True
        Me.txbDonGia.Size = New System.Drawing.Size(122, 20)
        Me.txbDonGia.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(354, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Đơn Giá"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Số Lượng"
        '
        'cbTenPhuTung
        '
        Me.cbTenPhuTung.FormattingEnabled = True
        Me.cbTenPhuTung.Location = New System.Drawing.Point(475, 82)
        Me.cbTenPhuTung.Name = "cbTenPhuTung"
        Me.cbTenPhuTung.Size = New System.Drawing.Size(122, 21)
        Me.cbTenPhuTung.TabIndex = 53
        '
        'cbMaPhuTung
        '
        Me.cbMaPhuTung.FormattingEnabled = True
        Me.cbMaPhuTung.Location = New System.Drawing.Point(186, 82)
        Me.cbMaPhuTung.Name = "cbMaPhuTung"
        Me.cbMaPhuTung.Size = New System.Drawing.Size(122, 21)
        Me.cbMaPhuTung.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Mã Phụ Tùng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(354, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Tên Phụ Tùng"
        '
        'dgvChiTietSuaChua
        '
        Me.dgvChiTietSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietSuaChua.Location = New System.Drawing.Point(69, 198)
        Me.dgvChiTietSuaChua.Name = "dgvChiTietSuaChua"
        Me.dgvChiTietSuaChua.ReadOnly = True
        Me.dgvChiTietSuaChua.Size = New System.Drawing.Size(544, 148)
        Me.dgvChiTietSuaChua.TabIndex = 65
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(69, 374)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhat.TabIndex = 66
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(335, 374)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 23)
        Me.btXoa.TabIndex = 67
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'txbTienCong
        '
        Me.txbTienCong.Location = New System.Drawing.Point(475, 163)
        Me.txbTienCong.Name = "txbTienCong"
        Me.txbTienCong.Size = New System.Drawing.Size(122, 20)
        Me.txbTienCong.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(354, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Tiền Công"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Mã Phiếu Sữa Chữa"
        '
        'cbMaPhieuSuaChua
        '
        Me.cbMaPhieuSuaChua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaPhieuSuaChua.FormattingEnabled = True
        Me.cbMaPhieuSuaChua.Location = New System.Drawing.Point(314, 36)
        Me.cbMaPhieuSuaChua.Name = "cbMaPhieuSuaChua"
        Me.cbMaPhieuSuaChua.Size = New System.Drawing.Size(161, 21)
        Me.cbMaPhieuSuaChua.TabIndex = 73
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(568, 374)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 23)
        Me.btThoat.TabIndex = 75
        Me.btThoat.Text = "Đóng"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'frmChiTietSuaChua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 409)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.cbMaPhieuSuaChua)
        Me.Controls.Add(Me.Label2)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents cbMaPhieuSuaChua As ComboBox
    Friend WithEvents btThoat As Button
End Class
