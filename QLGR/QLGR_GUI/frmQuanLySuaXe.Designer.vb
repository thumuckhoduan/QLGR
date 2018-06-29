<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySuaXe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLySuaXe))
        Me.txbMaSuaXe = New System.Windows.Forms.TextBox()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbMaXe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvDanhSachSuaXe = New System.Windows.Forms.DataGridView()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btDong = New System.Windows.Forms.Button()
        Me.dtpNgayTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.txtTenChuXe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHieuXe = New System.Windows.Forms.TextBox()
        CType(Me.dgvDanhSachSuaXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbMaSuaXe
        '
        Me.txbMaSuaXe.Location = New System.Drawing.Point(281, 243)
        Me.txbMaSuaXe.Name = "txbMaSuaXe"
        Me.txbMaSuaXe.ReadOnly = True
        Me.txbMaSuaXe.Size = New System.Drawing.Size(195, 20)
        Me.txbMaSuaXe.TabIndex = 0
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(108, 467)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhat.TabIndex = 1
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã Sữa Xe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mã Xe"
        '
        'txbMaXe
        '
        Me.txbMaXe.Location = New System.Drawing.Point(281, 273)
        Me.txbMaXe.Name = "txbMaXe"
        Me.txbMaXe.ReadOnly = True
        Me.txbMaXe.Size = New System.Drawing.Size(195, 20)
        Me.txbMaXe.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(381, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mã Xe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 441)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ngày Tiếp Nhận"
        '
        'dgvDanhSachSuaXe
        '
        Me.dgvDanhSachSuaXe.AllowUserToAddRows = False
        Me.dgvDanhSachSuaXe.AllowUserToDeleteRows = False
        Me.dgvDanhSachSuaXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachSuaXe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachSuaXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachSuaXe.Location = New System.Drawing.Point(12, 12)
        Me.dgvDanhSachSuaXe.MultiSelect = False
        Me.dgvDanhSachSuaXe.Name = "dgvDanhSachSuaXe"
        Me.dgvDanhSachSuaXe.ReadOnly = True
        Me.dgvDanhSachSuaXe.RowHeadersVisible = False
        Me.dgvDanhSachSuaXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachSuaXe.Size = New System.Drawing.Size(747, 225)
        Me.dgvDanhSachSuaXe.TabIndex = 31
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(362, 461)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 29)
        Me.btXoa.TabIndex = 32
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btDong
        '
        Me.btDong.Location = New System.Drawing.Point(544, 461)
        Me.btDong.Name = "btDong"
        Me.btDong.Size = New System.Drawing.Size(75, 29)
        Me.btDong.TabIndex = 33
        Me.btDong.Text = "Đóng"
        Me.btDong.UseVisualStyleBackColor = True
        '
        'dtpNgayTiepNhan
        '
        Me.dtpNgayTiepNhan.Location = New System.Drawing.Point(281, 435)
        Me.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan"
        Me.dtpNgayTiepNhan.Size = New System.Drawing.Size(195, 20)
        Me.dtpNgayTiepNhan.TabIndex = 34
        '
        'txtTenChuXe
        '
        Me.txtTenChuXe.Location = New System.Drawing.Point(281, 325)
        Me.txtTenChuXe.Name = "txtTenChuXe"
        Me.txtTenChuXe.ReadOnly = True
        Me.txtTenChuXe.Size = New System.Drawing.Size(195, 20)
        Me.txtTenChuXe.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(122, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Tên Chủ Xe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(122, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Địa Chỉ"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(281, 358)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(195, 20)
        Me.txtDiaChi.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(122, 416)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Điện Thoại"
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(281, 409)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.ReadOnly = True
        Me.txtDienThoai.Size = New System.Drawing.Size(195, 20)
        Me.txtDienThoai.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(122, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(281, 383)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(195, 20)
        Me.txtEmail.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(122, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Hiệu Xe"
        '
        'txtHieuXe
        '
        Me.txtHieuXe.Location = New System.Drawing.Point(281, 297)
        Me.txtHieuXe.Name = "txtHieuXe"
        Me.txtHieuXe.ReadOnly = True
        Me.txtHieuXe.Size = New System.Drawing.Size(195, 20)
        Me.txtHieuXe.TabIndex = 44
        '
        'frmQuanLySuaXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 502)
        Me.Controls.Add(Me.txtHieuXe)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTenChuXe)
        Me.Controls.Add(Me.dtpNgayTiepNhan)
        Me.Controls.Add(Me.btDong)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.dgvDanhSachSuaXe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbMaXe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btCapNhat)
        Me.Controls.Add(Me.txbMaSuaXe)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuanLySuaXe"
        Me.Text = "Quản Lý Sửa Xe"
        CType(Me.dgvDanhSachSuaXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbMaSuaXe As TextBox
    Friend WithEvents btCapNhat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbMaXe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvDanhSachSuaXe As DataGridView
    Friend WithEvents btXoa As Button
    Friend WithEvents btDong As Button
    Friend WithEvents dtpNgayTiepNhan As DateTimePicker
    Friend WithEvents txtTenChuXe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHieuXe As TextBox
End Class
