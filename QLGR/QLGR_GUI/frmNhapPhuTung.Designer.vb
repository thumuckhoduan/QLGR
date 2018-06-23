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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phụ Tùng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên Phụ Tùng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Số Lượng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ngày Tiếp Nhận"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(193, 186)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(229, 20)
        Me.txtSoLuong.TabIndex = 6
        '
        'cbMaPhuTung
        '
        Me.cbMaPhuTung.FormattingEnabled = True
        Me.cbMaPhuTung.Location = New System.Drawing.Point(193, 52)
        Me.cbMaPhuTung.Name = "cbMaPhuTung"
        Me.cbMaPhuTung.Size = New System.Drawing.Size(229, 21)
        Me.cbMaPhuTung.TabIndex = 8
        '
        'cbTenPhuTung
        '
        Me.cbTenPhuTung.FormattingEnabled = True
        Me.cbTenPhuTung.Location = New System.Drawing.Point(193, 124)
        Me.cbTenPhuTung.Name = "cbTenPhuTung"
        Me.cbTenPhuTung.Size = New System.Drawing.Size(229, 21)
        Me.cbTenPhuTung.TabIndex = 9
        '
        'btLuu
        '
        Me.btLuu.Location = New System.Drawing.Point(193, 310)
        Me.btLuu.Name = "btLuu"
        Me.btLuu.Size = New System.Drawing.Size(75, 23)
        Me.btLuu.TabIndex = 10
        Me.btLuu.Text = "Lưu"
        Me.btLuu.UseVisualStyleBackColor = True
        '
        'dtpNgayTiepNhan
        '
        Me.dtpNgayTiepNhan.Location = New System.Drawing.Point(193, 253)
        Me.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan"
        Me.dtpNgayTiepNhan.Size = New System.Drawing.Size(229, 20)
        Me.dtpNgayTiepNhan.TabIndex = 11
        '
        'txtMaNhapPhuTung
        '
        Me.txtMaNhapPhuTung.Location = New System.Drawing.Point(193, 12)
        Me.txtMaNhapPhuTung.Name = "txtMaNhapPhuTung"
        Me.txtMaNhapPhuTung.Size = New System.Drawing.Size(229, 20)
        Me.txtMaNhapPhuTung.TabIndex = 12
        '
        'cbSoLuongTon
        '
        Me.cbSoLuongTon.FormattingEnabled = True
        Me.cbSoLuongTon.Location = New System.Drawing.Point(446, 124)
        Me.cbSoLuongTon.Name = "cbSoLuongTon"
        Me.cbSoLuongTon.Size = New System.Drawing.Size(187, 21)
        Me.cbSoLuongTon.TabIndex = 13
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(347, 310)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 23)
        Me.btThoat.TabIndex = 14
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'frmNhapPhuTung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 383)
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
        Me.Name = "frmNhapPhuTung"
        Me.Text = "Nhập Vật Liệu"
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
End Class
