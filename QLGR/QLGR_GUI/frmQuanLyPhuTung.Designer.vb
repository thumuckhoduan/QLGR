<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyPhuTung
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvDanhSachPhuTung = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbMaPhuTung = New System.Windows.Forms.TextBox()
        Me.txbTenPhuTung = New System.Windows.Forms.TextBox()
        Me.txbSoLuongTon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.btDong = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSachPhuTung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Danh Sách Phụ Tùng"
        '
        'dgvDanhSachPhuTung
        '
        Me.dgvDanhSachPhuTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhuTung.Location = New System.Drawing.Point(155, 26)
        Me.dgvDanhSachPhuTung.Name = "dgvDanhSachPhuTung"
        Me.dgvDanhSachPhuTung.Size = New System.Drawing.Size(447, 213)
        Me.dgvDanhSachPhuTung.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Mã Phụ Tùng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tên Phụ Tùng"
        '
        'txbMaPhuTung
        '
        Me.txbMaPhuTung.Location = New System.Drawing.Point(325, 259)
        Me.txbMaPhuTung.Name = "txbMaPhuTung"
        Me.txbMaPhuTung.ReadOnly = True
        Me.txbMaPhuTung.Size = New System.Drawing.Size(237, 20)
        Me.txbMaPhuTung.TabIndex = 12
        '
        'txbTenPhuTung
        '
        Me.txbTenPhuTung.Location = New System.Drawing.Point(325, 302)
        Me.txbTenPhuTung.Name = "txbTenPhuTung"
        Me.txbTenPhuTung.Size = New System.Drawing.Size(237, 20)
        Me.txbTenPhuTung.TabIndex = 13
        '
        'txbSoLuongTon
        '
        Me.txbSoLuongTon.Location = New System.Drawing.Point(325, 353)
        Me.txbSoLuongTon.Name = "txbSoLuongTon"
        Me.txbSoLuongTon.Size = New System.Drawing.Size(237, 20)
        Me.txbSoLuongTon.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Số Lượng Tồn"
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(205, 403)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhat.TabIndex = 16
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'btDong
        '
        Me.btDong.Location = New System.Drawing.Point(490, 402)
        Me.btDong.Name = "btDong"
        Me.btDong.Size = New System.Drawing.Size(75, 23)
        Me.btDong.TabIndex = 17
        Me.btDong.Text = "Đóng"
        Me.btDong.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(351, 403)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 23)
        Me.btXoa.TabIndex = 18
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'frmQuanLyPhuTung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btDong)
        Me.Controls.Add(Me.btCapNhat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txbSoLuongTon)
        Me.Controls.Add(Me.txbTenPhuTung)
        Me.Controls.Add(Me.txbMaPhuTung)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachPhuTung)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmQuanLyPhuTung"
        Me.Text = "QuanLyPhuTung"
        CType(Me.dgvDanhSachPhuTung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents dgvDanhSachPhuTung As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbMaPhuTung As TextBox
    Friend WithEvents txbTenPhuTung As TextBox
    Friend WithEvents txbSoLuongTon As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btCapNhat As Button
    Friend WithEvents btDong As Button
    Friend WithEvents btXoa As Button
End Class
