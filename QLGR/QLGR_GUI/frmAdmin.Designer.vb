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
        Me.pbDangXuat = New System.Windows.Forms.PictureBox()
        Me.pbQuanLyTaiKhoan = New System.Windows.Forms.PictureBox()
        Me.pbDangKyTaiKhoan = New System.Windows.Forms.PictureBox()
        CType(Me.pbDangXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbQuanLyTaiKhoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDangKyTaiKhoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbDangXuat
        '
        Me.pbDangXuat.ErrorImage = Global.QLGR.My.Resources.Resources.close
        Me.pbDangXuat.Image = Global.QLGR.My.Resources.Resources.close
        Me.pbDangXuat.Location = New System.Drawing.Point(87, 215)
        Me.pbDangXuat.Name = "pbDangXuat"
        Me.pbDangXuat.Size = New System.Drawing.Size(100, 97)
        Me.pbDangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDangXuat.TabIndex = 8
        Me.pbDangXuat.TabStop = False
        '
        'pbQuanLyTaiKhoan
        '
        Me.pbQuanLyTaiKhoan.ErrorImage = Global.QLGR.My.Resources.Resources.quanlytaikhoan
        Me.pbQuanLyTaiKhoan.Image = Global.QLGR.My.Resources.Resources.quanlytaikhoan
        Me.pbQuanLyTaiKhoan.Location = New System.Drawing.Point(87, 115)
        Me.pbQuanLyTaiKhoan.Name = "pbQuanLyTaiKhoan"
        Me.pbQuanLyTaiKhoan.Size = New System.Drawing.Size(100, 97)
        Me.pbQuanLyTaiKhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbQuanLyTaiKhoan.TabIndex = 7
        Me.pbQuanLyTaiKhoan.TabStop = False
        '
        'pbDangKyTaiKhoan
        '
        Me.pbDangKyTaiKhoan.ErrorImage = Global.QLGR.My.Resources.Resources.dangkytaikhoan
        Me.pbDangKyTaiKhoan.Image = Global.QLGR.My.Resources.Resources.dangkytaikhoan
        Me.pbDangKyTaiKhoan.Location = New System.Drawing.Point(87, 12)
        Me.pbDangKyTaiKhoan.Name = "pbDangKyTaiKhoan"
        Me.pbDangKyTaiKhoan.Size = New System.Drawing.Size(100, 97)
        Me.pbDangKyTaiKhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDangKyTaiKhoan.TabIndex = 6
        Me.pbDangKyTaiKhoan.TabStop = False
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 325)
        Me.Controls.Add(Me.pbDangXuat)
        Me.Controls.Add(Me.pbQuanLyTaiKhoan)
        Me.Controls.Add(Me.pbDangKyTaiKhoan)
        Me.Name = "frmAdmin"
        Me.Text = "Admin"
        CType(Me.pbDangXuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbQuanLyTaiKhoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDangKyTaiKhoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbDangXuat As PictureBox
    Friend WithEvents pbQuanLyTaiKhoan As PictureBox
    Friend WithEvents pbDangKyTaiKhoan As PictureBox
End Class
