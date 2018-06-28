<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangKyTaiKhoan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangKyTaiKhoan))
        Me.txtTaiKhoan = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.cbQuyen = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btDangKy = New System.Windows.Forms.Button()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.Location = New System.Drawing.Point(167, 66)
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(121, 20)
        Me.txtTaiKhoan.TabIndex = 0
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(167, 114)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(121, 20)
        Me.txtMatKhau.TabIndex = 1
        '
        'cbQuyen
        '
        Me.cbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbQuyen.FormattingEnabled = True
        Me.cbQuyen.Items.AddRange(New Object() {"admin", "user", "quan ly"})
        Me.cbQuyen.Location = New System.Drawing.Point(167, 165)
        Me.cbQuyen.Name = "cbQuyen"
        Me.cbQuyen.Size = New System.Drawing.Size(121, 21)
        Me.cbQuyen.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tài Khoản"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mật Khẩu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quyền"
        '
        'btDangKy
        '
        Me.btDangKy.Location = New System.Drawing.Point(96, 216)
        Me.btDangKy.Name = "btDangKy"
        Me.btDangKy.Size = New System.Drawing.Size(75, 23)
        Me.btDangKy.TabIndex = 6
        Me.btDangKy.Text = "Đăng Ký"
        Me.btDangKy.UseVisualStyleBackColor = True
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(255, 216)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 23)
        Me.btThoat.TabIndex = 7
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'frmDangKyTaiKhoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 261)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btDangKy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbQuyen)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtTaiKhoan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDangKyTaiKhoan"
        Me.Text = "Đăng Ký Tài Khoản"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTaiKhoan As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents cbQuyen As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btDangKy As Button
    Friend WithEvents btThoat As Button
End Class
