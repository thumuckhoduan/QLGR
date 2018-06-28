<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManHinh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManHinh))
        Me.btManHinh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTaiKhoan = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.btDoiMatKhau = New System.Windows.Forms.Button()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btManHinh
        '
        Me.btManHinh.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btManHinh.Location = New System.Drawing.Point(47, 115)
        Me.btManHinh.Name = "btManHinh"
        Me.btManHinh.Size = New System.Drawing.Size(133, 23)
        Me.btManHinh.TabIndex = 0
        Me.btManHinh.Text = "Đăng Nhập"
        Me.btManHinh.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(85, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tài Khoản"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(88, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mật Khẩu"
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.Location = New System.Drawing.Point(192, 25)
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(170, 20)
        Me.txtTaiKhoan.TabIndex = 3
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(192, 72)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(170, 20)
        Me.txtMatKhau.TabIndex = 4
        '
        'btDoiMatKhau
        '
        Me.btDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btDoiMatKhau.Location = New System.Drawing.Point(289, 115)
        Me.btDoiMatKhau.Name = "btDoiMatKhau"
        Me.btDoiMatKhau.Size = New System.Drawing.Size(133, 23)
        Me.btDoiMatKhau.TabIndex = 5
        Me.btDoiMatKhau.Text = "Đổi Mật Khẩu"
        Me.btDoiMatKhau.UseVisualStyleBackColor = False
        '
        'btThoat
        '
        Me.btThoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btThoat.Location = New System.Drawing.Point(160, 157)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(133, 23)
        Me.btThoat.TabIndex = 6
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = False
        '
        'frmManHinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 197)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btDoiMatKhau)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtTaiKhoan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btManHinh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmManHinh"
        Me.Text = "Màn Hình"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btManHinh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTaiKhoan As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents btDoiMatKhau As Button
    Friend WithEvents btThoat As Button
End Class
