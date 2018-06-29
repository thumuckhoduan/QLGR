<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyXe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyXe))
        Me.dgvQuanLyXe = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.txtMaXe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtChuXe = New System.Windows.Forms.TextBox()
        Me.txtBienSo = New System.Windows.Forms.TextBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHieuXe = New System.Windows.Forms.TextBox()
        Me.cbMaHieuXe = New System.Windows.Forms.ComboBox()
        Me.cbHieuXe = New System.Windows.Forms.ComboBox()
        Me.btDong = New System.Windows.Forms.Button()
        Me.cbMaChuXe = New System.Windows.Forms.ComboBox()
        Me.cbDiaChi = New System.Windows.Forms.ComboBox()
        Me.cbDienThoai = New System.Windows.Forms.ComboBox()
        Me.cbChuXe = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgvQuanLyXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvQuanLyXe
        '
        Me.dgvQuanLyXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuanLyXe.Location = New System.Drawing.Point(231, 37)
        Me.dgvQuanLyXe.Name = "dgvQuanLyXe"
        Me.dgvQuanLyXe.ReadOnly = True
        Me.dgvQuanLyXe.Size = New System.Drawing.Size(380, 194)
        Me.dgvQuanLyXe.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quản Lý Xe"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(371, 480)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 35
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(156, 480)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 34
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'txtMaXe
        '
        Me.txtMaXe.Location = New System.Drawing.Point(348, 253)
        Me.txtMaXe.Name = "txtMaXe"
        Me.txtMaXe.ReadOnly = True
        Me.txtMaXe.Size = New System.Drawing.Size(184, 20)
        Me.txtMaXe.TabIndex = 33
        Me.txtMaXe.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Mã Xe"
        '
        'txtChuXe
        '
        Me.txtChuXe.Location = New System.Drawing.Point(348, 361)
        Me.txtChuXe.Name = "txtChuXe"
        Me.txtChuXe.ReadOnly = True
        Me.txtChuXe.Size = New System.Drawing.Size(184, 20)
        Me.txtChuXe.TabIndex = 47
        '
        'txtBienSo
        '
        Me.txtBienSo.Location = New System.Drawing.Point(348, 391)
        Me.txtBienSo.Name = "txtBienSo"
        Me.txtBienSo.Size = New System.Drawing.Size(184, 20)
        Me.txtBienSo.TabIndex = 46
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(348, 452)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.ReadOnly = True
        Me.txtDienThoai.Size = New System.Drawing.Size(184, 20)
        Me.txtDienThoai.TabIndex = 45
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(348, 419)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(184, 20)
        Me.txtDiaChi.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(249, 394)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Biển Số"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(249, 455)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Điện Thoại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 422)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Địa Chỉ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Chủ Xe"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(249, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Mã Hiệu Xe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Hiệu Xe"
        '
        'txtHieuXe
        '
        Me.txtHieuXe.Location = New System.Drawing.Point(348, 305)
        Me.txtHieuXe.Name = "txtHieuXe"
        Me.txtHieuXe.ReadOnly = True
        Me.txtHieuXe.Size = New System.Drawing.Size(184, 20)
        Me.txtHieuXe.TabIndex = 48
        '
        'cbMaHieuXe
        '
        Me.cbMaHieuXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaHieuXe.FormattingEnabled = True
        Me.cbMaHieuXe.Location = New System.Drawing.Point(348, 279)
        Me.cbMaHieuXe.Name = "cbMaHieuXe"
        Me.cbMaHieuXe.Size = New System.Drawing.Size(184, 21)
        Me.cbMaHieuXe.TabIndex = 49
        '
        'cbHieuXe
        '
        Me.cbHieuXe.FormattingEnabled = True
        Me.cbHieuXe.Location = New System.Drawing.Point(538, 305)
        Me.cbHieuXe.Name = "cbHieuXe"
        Me.cbHieuXe.Size = New System.Drawing.Size(175, 21)
        Me.cbHieuXe.TabIndex = 50
        '
        'btDong
        '
        Me.btDong.Location = New System.Drawing.Point(615, 480)
        Me.btDong.Name = "btDong"
        Me.btDong.Size = New System.Drawing.Size(75, 23)
        Me.btDong.TabIndex = 51
        Me.btDong.Text = "Đóng"
        Me.btDong.UseVisualStyleBackColor = True
        '
        'cbMaChuXe
        '
        Me.cbMaChuXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaChuXe.FormattingEnabled = True
        Me.cbMaChuXe.Location = New System.Drawing.Point(348, 331)
        Me.cbMaChuXe.Name = "cbMaChuXe"
        Me.cbMaChuXe.Size = New System.Drawing.Size(184, 21)
        Me.cbMaChuXe.TabIndex = 52
        '
        'cbDiaChi
        '
        Me.cbDiaChi.FormattingEnabled = True
        Me.cbDiaChi.Location = New System.Drawing.Point(538, 419)
        Me.cbDiaChi.Name = "cbDiaChi"
        Me.cbDiaChi.Size = New System.Drawing.Size(175, 21)
        Me.cbDiaChi.TabIndex = 54
        '
        'cbDienThoai
        '
        Me.cbDienThoai.FormattingEnabled = True
        Me.cbDienThoai.Location = New System.Drawing.Point(538, 452)
        Me.cbDienThoai.Name = "cbDienThoai"
        Me.cbDienThoai.Size = New System.Drawing.Size(175, 21)
        Me.cbDienThoai.TabIndex = 55
        '
        'cbChuXe
        '
        Me.cbChuXe.FormattingEnabled = True
        Me.cbChuXe.Location = New System.Drawing.Point(538, 361)
        Me.cbChuXe.Name = "cbChuXe"
        Me.cbChuXe.Size = New System.Drawing.Size(175, 21)
        Me.cbChuXe.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(249, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Mã Chủ Xe"
        '
        'frmQuanLyXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 524)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbChuXe)
        Me.Controls.Add(Me.cbDienThoai)
        Me.Controls.Add(Me.cbDiaChi)
        Me.Controls.Add(Me.cbMaChuXe)
        Me.Controls.Add(Me.btDong)
        Me.Controls.Add(Me.cbHieuXe)
        Me.Controls.Add(Me.cbMaHieuXe)
        Me.Controls.Add(Me.txtHieuXe)
        Me.Controls.Add(Me.txtChuXe)
        Me.Controls.Add(Me.txtBienSo)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtMaXe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvQuanLyXe)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuanLyXe"
        Me.Text = "Quản Lý Xe"
        CType(Me.dgvQuanLyXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvQuanLyXe As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents txtMaXe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtChuXe As TextBox
    Friend WithEvents txtBienSo As TextBox
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHieuXe As TextBox
    Friend WithEvents cbMaHieuXe As ComboBox
    Friend WithEvents cbHieuXe As ComboBox
    Friend WithEvents btDong As Button
    Friend WithEvents cbMaChuXe As ComboBox
    Friend WithEvents cbDiaChi As ComboBox
    Friend WithEvents cbDienThoai As ComboBox
    Friend WithEvents cbChuXe As ComboBox
    Friend WithEvents Label9 As Label
End Class
