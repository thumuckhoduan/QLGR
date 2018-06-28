<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyTaiKhoan
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
        Me.dgvQuanLyTaiKhoan = New System.Windows.Forms.DataGridView()
        Me.txtTaiKhoan = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.cbQuyen = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvQuanLyTaiKhoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvQuanLyTaiKhoan
        '
        Me.dgvQuanLyTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuanLyTaiKhoan.Location = New System.Drawing.Point(1, -2)
        Me.dgvQuanLyTaiKhoan.Name = "dgvQuanLyTaiKhoan"
        Me.dgvQuanLyTaiKhoan.Size = New System.Drawing.Size(405, 150)
        Me.dgvQuanLyTaiKhoan.TabIndex = 0
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.Location = New System.Drawing.Point(175, 164)
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(121, 20)
        Me.txtTaiKhoan.TabIndex = 1
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(175, 190)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(121, 20)
        Me.txtMatKhau.TabIndex = 2
        '
        'cbQuyen
        '
        Me.cbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbQuyen.FormattingEnabled = True
        Me.cbQuyen.Items.AddRange(New Object() {"admin", "user", "quan ly"})
        Me.cbQuyen.Location = New System.Drawing.Point(175, 216)
        Me.cbQuyen.Name = "cbQuyen"
        Me.cbQuyen.Size = New System.Drawing.Size(121, 21)
        Me.cbQuyen.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tài Khoản"
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(35, 257)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhat.TabIndex = 5
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(309, 257)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 23)
        Me.btThoat.TabIndex = 6
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(164, 257)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 23)
        Me.btXoa.TabIndex = 7
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mật Khẩu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quyền"
        '
        'frmQuanLyTaiKhoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 311)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btCapNhat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbQuyen)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtTaiKhoan)
        Me.Controls.Add(Me.dgvQuanLyTaiKhoan)
        Me.Name = "frmQuanLyTaiKhoan"
        Me.Text = "Quản Lý Tài Khoản"
        CType(Me.dgvQuanLyTaiKhoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvQuanLyTaiKhoan As DataGridView
    Friend WithEvents txtTaiKhoan As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents cbQuyen As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btCapNhat As Button
    Friend WithEvents btThoat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
