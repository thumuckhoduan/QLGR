<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyChiTietSuaChua
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
        Me.txtMaPhieuSuaChua = New System.Windows.Forms.TextBox()
        Me.txtMaChiTietSuaChua = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtMaPhuTung = New System.Windows.Forms.TextBox()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.dgvChiTietSuaChua = New System.Windows.Forms.DataGridView()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtTienCong = New System.Windows.Forms.TextBox()
        CType(Me.dgvChiTietSuaChua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMaPhieuSuaChua
        '
        Me.txtMaPhieuSuaChua.Location = New System.Drawing.Point(213, 244)
        Me.txtMaPhieuSuaChua.Name = "txtMaPhieuSuaChua"
        Me.txtMaPhieuSuaChua.Size = New System.Drawing.Size(93, 20)
        Me.txtMaPhieuSuaChua.TabIndex = 13
        '
        'txtMaChiTietSuaChua
        '
        Me.txtMaChiTietSuaChua.Location = New System.Drawing.Point(106, 244)
        Me.txtMaChiTietSuaChua.Name = "txtMaChiTietSuaChua"
        Me.txtMaChiTietSuaChua.Size = New System.Drawing.Size(101, 20)
        Me.txtMaChiTietSuaChua.TabIndex = 11
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(418, 244)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(100, 20)
        Me.txtSoLuong.TabIndex = 14
        '
        'txtMaPhuTung
        '
        Me.txtMaPhuTung.Location = New System.Drawing.Point(312, 244)
        Me.txtMaPhuTung.Name = "txtMaPhuTung"
        Me.txtMaPhuTung.Size = New System.Drawing.Size(100, 20)
        Me.txtMaPhuTung.TabIndex = 12
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(549, 290)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 23)
        Me.btThoat.TabIndex = 10
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(366, 290)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 23)
        Me.btXoa.TabIndex = 9
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(175, 290)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhat.TabIndex = 8
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'dgvChiTietSuaChua
        '
        Me.dgvChiTietSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietSuaChua.Location = New System.Drawing.Point(129, 63)
        Me.dgvChiTietSuaChua.Name = "dgvChiTietSuaChua"
        Me.dgvChiTietSuaChua.Size = New System.Drawing.Size(567, 175)
        Me.dgvChiTietSuaChua.TabIndex = 7
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(526, 244)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(100, 20)
        Me.txtDonGia.TabIndex = 15
        '
        'txtTienCong
        '
        Me.txtTienCong.Location = New System.Drawing.Point(632, 244)
        Me.txtTienCong.Name = "txtTienCong"
        Me.txtTienCong.Size = New System.Drawing.Size(100, 20)
        Me.txtTienCong.TabIndex = 16
        '
        'frmQuanLyChiTietSuaChua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 355)
        Me.Controls.Add(Me.txtTienCong)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtMaPhieuSuaChua)
        Me.Controls.Add(Me.txtMaChiTietSuaChua)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtMaPhuTung)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btCapNhat)
        Me.Controls.Add(Me.dgvChiTietSuaChua)
        Me.Name = "frmQuanLyChiTietSuaChua"
        Me.Text = "frmQuanLyChiTietSuaChua"
        CType(Me.dgvChiTietSuaChua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMaPhieuSuaChua As TextBox
    Friend WithEvents txtMaChiTietSuaChua As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents txtMaPhuTung As TextBox
    Friend WithEvents btThoat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btCapNhat As Button
    Friend WithEvents dgvChiTietSuaChua As DataGridView
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents txtTienCong As TextBox
End Class
