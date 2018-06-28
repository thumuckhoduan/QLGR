<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
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
        Me.btDangKyTaiKhoan = New System.Windows.Forms.Button()
        Me.btQuanLyTaiKhoan = New System.Windows.Forms.Button()
        Me.btDangXuat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btDangKyTaiKhoan
        '
        Me.btDangKyTaiKhoan.Location = New System.Drawing.Point(68, 46)
        Me.btDangKyTaiKhoan.Name = "btDangKyTaiKhoan"
        Me.btDangKyTaiKhoan.Size = New System.Drawing.Size(118, 23)
        Me.btDangKyTaiKhoan.TabIndex = 0
        Me.btDangKyTaiKhoan.Text = "Đăng Ký Tài Khoản"
        Me.btDangKyTaiKhoan.UseVisualStyleBackColor = True
        '
        'btQuanLyTaiKhoan
        '
        Me.btQuanLyTaiKhoan.Location = New System.Drawing.Point(68, 90)
        Me.btQuanLyTaiKhoan.Name = "btQuanLyTaiKhoan"
        Me.btQuanLyTaiKhoan.Size = New System.Drawing.Size(118, 23)
        Me.btQuanLyTaiKhoan.TabIndex = 1
        Me.btQuanLyTaiKhoan.Text = "Quản Lý Tài Khoản"
        Me.btQuanLyTaiKhoan.UseVisualStyleBackColor = True
        '
        'btDangXuat
        '
        Me.btDangXuat.Location = New System.Drawing.Point(68, 139)
        Me.btDangXuat.Name = "btDangXuat"
        Me.btDangXuat.Size = New System.Drawing.Size(118, 23)
        Me.btDangXuat.TabIndex = 2
        Me.btDangXuat.Text = "Đăng Xuất"
        Me.btDangXuat.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 206)
        Me.Controls.Add(Me.btDangXuat)
        Me.Controls.Add(Me.btQuanLyTaiKhoan)
        Me.Controls.Add(Me.btDangKyTaiKhoan)
        Me.Name = "frmAdmin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btDangKyTaiKhoan As Button
    Friend WithEvents btQuanLyTaiKhoan As Button
    Friend WithEvents btDangXuat As Button
End Class
