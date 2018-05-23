<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyChuXe
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
        Me.dgvDanhSachChuXe = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTenChuXe = New System.Windows.Forms.TextBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTienNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaChuXe = New System.Windows.Forms.TextBox()
        Me.btDong = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSachChuXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDanhSachChuXe
        '
        Me.dgvDanhSachChuXe.AllowUserToAddRows = False
        Me.dgvDanhSachChuXe.AllowUserToDeleteRows = False
        Me.dgvDanhSachChuXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachChuXe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachChuXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachChuXe.Location = New System.Drawing.Point(24, 12)
        Me.dgvDanhSachChuXe.MultiSelect = False
        Me.dgvDanhSachChuXe.Name = "dgvDanhSachChuXe"
        Me.dgvDanhSachChuXe.ReadOnly = True
        Me.dgvDanhSachChuXe.RowHeadersVisible = False
        Me.dgvDanhSachChuXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachChuXe.Size = New System.Drawing.Size(747, 225)
        Me.dgvDanhSachChuXe.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(201, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Mã Chủ Xe"
        '
        'txtTenChuXe
        '
        Me.txtTenChuXe.Location = New System.Drawing.Point(300, 287)
        Me.txtTenChuXe.Name = "txtTenChuXe"
        Me.txtTenChuXe.Size = New System.Drawing.Size(184, 20)
        Me.txtTenChuXe.TabIndex = 67
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(300, 341)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(184, 20)
        Me.txtDienThoai.TabIndex = 65
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(300, 313)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(184, 20)
        Me.txtDiaChi.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Điện Thoại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Địa Chỉ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Tên Chủ Xe"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(300, 367)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(184, 20)
        Me.txtEmail.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 370)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Email"
        '
        'txtTienNo
        '
        Me.txtTienNo.Location = New System.Drawing.Point(300, 393)
        Me.txtTienNo.Name = "txtTienNo"
        Me.txtTienNo.Size = New System.Drawing.Size(184, 20)
        Me.txtTienNo.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 396)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Tiền nợ"
        '
        'txtMaChuXe
        '
        Me.txtMaChuXe.Location = New System.Drawing.Point(300, 257)
        Me.txtMaChuXe.Name = "txtMaChuXe"
        Me.txtMaChuXe.Size = New System.Drawing.Size(184, 20)
        Me.txtMaChuXe.TabIndex = 74
        '
        'btDong
        '
        Me.btDong.Location = New System.Drawing.Point(578, 427)
        Me.btDong.Name = "btDong"
        Me.btDong.Size = New System.Drawing.Size(75, 23)
        Me.btDong.TabIndex = 77
        Me.btDong.Text = "Đóng"
        Me.btDong.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(334, 427)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 76
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(119, 427)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 75
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'frmQuanLyChuXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 462)
        Me.Controls.Add(Me.btDong)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtMaChuXe)
        Me.Controls.Add(Me.txtTienNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTenChuXe)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvDanhSachChuXe)
        Me.Name = "frmQuanLyChuXe"
        Me.Text = "Quản Lý Chủ Xe"
        CType(Me.dgvDanhSachChuXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDanhSachChuXe As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTenChuXe As TextBox
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTienNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaChuXe As TextBox
    Friend WithEvents btDong As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
End Class
