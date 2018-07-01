<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhapPhuTung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhapPhuTung))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.cbMaPhuTung = New System.Windows.Forms.ComboBox()
        Me.cbTenPhuTung = New System.Windows.Forms.ComboBox()
        Me.btLuu = New System.Windows.Forms.Button()
        Me.dtpNgayTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.txtMaNhapPhuTung = New System.Windows.Forms.TextBox()
        Me.cbSoLuongTon = New System.Windows.Forms.ComboBox()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbDonGia = New System.Windows.Forms.ComboBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phụ Tùng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên Phụ Tùng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Số Lượng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ngày Tiếp Nhận"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(180, 196)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(266, 21)
        Me.txtSoLuong.TabIndex = 6
        '
        'cbMaPhuTung
        '
        Me.cbMaPhuTung.FormattingEnabled = True
        Me.cbMaPhuTung.Location = New System.Drawing.Point(180, 52)
        Me.cbMaPhuTung.Name = "cbMaPhuTung"
        Me.cbMaPhuTung.Size = New System.Drawing.Size(266, 23)
        Me.cbMaPhuTung.TabIndex = 8
        '
        'cbTenPhuTung
        '
        Me.cbTenPhuTung.FormattingEnabled = True
        Me.cbTenPhuTung.Location = New System.Drawing.Point(180, 99)
        Me.cbTenPhuTung.Name = "cbTenPhuTung"
        Me.cbTenPhuTung.Size = New System.Drawing.Size(266, 23)
        Me.cbTenPhuTung.TabIndex = 9
        '
        'btLuu
        '
        Me.btLuu.Location = New System.Drawing.Point(46, 297)
        Me.btLuu.Name = "btLuu"
        Me.btLuu.Size = New System.Drawing.Size(87, 27)
        Me.btLuu.TabIndex = 10
        Me.btLuu.Text = "Lưu"
        Me.btLuu.UseVisualStyleBackColor = True
        '
        'dtpNgayTiepNhan
        '
        Me.dtpNgayTiepNhan.Location = New System.Drawing.Point(180, 244)
        Me.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan"
        Me.dtpNgayTiepNhan.Size = New System.Drawing.Size(266, 21)
        Me.dtpNgayTiepNhan.TabIndex = 11
        '
        'txtMaNhapPhuTung
        '
        Me.txtMaNhapPhuTung.Location = New System.Drawing.Point(180, 12)
        Me.txtMaNhapPhuTung.Name = "txtMaNhapPhuTung"
        Me.txtMaNhapPhuTung.Size = New System.Drawing.Size(266, 21)
        Me.txtMaNhapPhuTung.TabIndex = 12
        '
        'cbSoLuongTon
        '
        Me.cbSoLuongTon.FormattingEnabled = True
        Me.cbSoLuongTon.Location = New System.Drawing.Point(468, 194)
        Me.cbSoLuongTon.Name = "cbSoLuongTon"
        Me.cbSoLuongTon.Size = New System.Drawing.Size(84, 23)
        Me.cbSoLuongTon.TabIndex = 13
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(443, 297)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(87, 27)
        Me.btThoat.TabIndex = 14
        Me.btThoat.Text = "Đóng"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Đơn Giá"
        '
        'cbDonGia
        '
        Me.cbDonGia.FormattingEnabled = True
        Me.cbDonGia.Location = New System.Drawing.Point(468, 148)
        Me.cbDonGia.Name = "cbDonGia"
        Me.cbDonGia.Size = New System.Drawing.Size(84, 23)
        Me.cbDonGia.TabIndex = 16
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(180, 153)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.ReadOnly = True
        Me.txtDonGia.Size = New System.Drawing.Size(266, 21)
        Me.txtDonGia.TabIndex = 17
        '
        'frmNhapPhuTung
        '
        Me.AcceptButton = Me.btLuu
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 347)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.cbDonGia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.cbSoLuongTon)
        Me.Controls.Add(Me.txtMaNhapPhuTung)
        Me.Controls.Add(Me.dtpNgayTiepNhan)
        Me.Controls.Add(Me.btLuu)
        Me.Controls.Add(Me.cbTenPhuTung)
        Me.Controls.Add(Me.cbMaPhuTung)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNhapPhuTung"
        Me.Text = "Nhập Phụ Tùng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents cbMaPhuTung As ComboBox
    Friend WithEvents cbTenPhuTung As ComboBox
    Friend WithEvents btLuu As Button
    Friend WithEvents dtpNgayTiepNhan As DateTimePicker
    Friend WithEvents txtMaNhapPhuTung As TextBox
    Friend WithEvents cbSoLuongTon As ComboBox
    Friend WithEvents btThoat As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbDonGia As ComboBox
    Friend WithEvents txtDonGia As TextBox
End Class
