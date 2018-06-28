<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoiMatKhau
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDoiMatKhau))
        Me.btLuu = New System.Windows.Forms.Button()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.txtTaiKhoan = New System.Windows.Forms.TextBox()
        Me.txtMatKhauMoi = New System.Windows.Forms.TextBox()
        Me.txtMatKhauCu = New System.Windows.Forms.TextBox()
        Me.txtNhapLaiMatKhau = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btLuu
        '
        Me.btLuu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btLuu.Location = New System.Drawing.Point(46, 181)
        Me.btLuu.Name = "btLuu"
        Me.btLuu.Size = New System.Drawing.Size(75, 23)
        Me.btLuu.TabIndex = 0
        Me.btLuu.Text = "Lưu"
        Me.btLuu.UseVisualStyleBackColor = False
        '
        'btThoat
        '
        Me.btThoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btThoat.Location = New System.Drawing.Point(262, 181)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 23)
        Me.btThoat.TabIndex = 1
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = False
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.Location = New System.Drawing.Point(140, 29)
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(179, 20)
        Me.txtTaiKhoan.TabIndex = 2
        '
        'txtMatKhauMoi
        '
        Me.txtMatKhauMoi.Location = New System.Drawing.Point(140, 97)
        Me.txtMatKhauMoi.Name = "txtMatKhauMoi"
        Me.txtMatKhauMoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhauMoi.Size = New System.Drawing.Size(179, 20)
        Me.txtMatKhauMoi.TabIndex = 3
        '
        'txtMatKhauCu
        '
        Me.txtMatKhauCu.Location = New System.Drawing.Point(140, 58)
        Me.txtMatKhauCu.Name = "txtMatKhauCu"
        Me.txtMatKhauCu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhauCu.Size = New System.Drawing.Size(179, 20)
        Me.txtMatKhauCu.TabIndex = 4
        '
        'txtNhapLaiMatKhau
        '
        Me.txtNhapLaiMatKhau.Location = New System.Drawing.Point(140, 137)
        Me.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau"
        Me.txtNhapLaiMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNhapLaiMatKhau.Size = New System.Drawing.Size(179, 20)
        Me.txtNhapLaiMatKhau.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(26, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tài Khoản"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mật Khẩu Mới"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(26, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mật Khẩu Cũ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(22, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nhập Lại Mật Khẩu"
        '
        'frmDoiMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 229)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNhapLaiMatKhau)
        Me.Controls.Add(Me.txtMatKhauCu)
        Me.Controls.Add(Me.txtMatKhauMoi)
        Me.Controls.Add(Me.txtTaiKhoan)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btLuu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDoiMatKhau"
        Me.Text = "Đổi Mật Khẩu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btLuu As Button
    Friend WithEvents btThoat As Button
    Friend WithEvents txtTaiKhoan As TextBox
    Friend WithEvents txtMatKhauMoi As TextBox
    Friend WithEvents txtMatKhauCu As TextBox
    Friend WithEvents txtNhapLaiMatKhau As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
