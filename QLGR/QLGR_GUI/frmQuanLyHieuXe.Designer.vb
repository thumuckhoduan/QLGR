<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyHieuXe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyHieuXe))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbTenHieuXe = New System.Windows.Forms.TextBox()
        Me.txbMaHieuXe = New System.Windows.Forms.TextBox()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.dgvDanhSachHieuXe = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btDong = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSachHieuXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Hiệu Xe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Hiệu Xe"
        '
        'txbTenHieuXe
        '
        Me.txbTenHieuXe.Location = New System.Drawing.Point(261, 287)
        Me.txbTenHieuXe.Name = "txbTenHieuXe"
        Me.txbTenHieuXe.Size = New System.Drawing.Size(266, 20)
        Me.txbTenHieuXe.TabIndex = 2
        '
        'txbMaHieuXe
        '
        Me.txbMaHieuXe.Location = New System.Drawing.Point(261, 255)
        Me.txbMaHieuXe.Name = "txbMaHieuXe"
        Me.txbMaHieuXe.ReadOnly = True
        Me.txbMaHieuXe.Size = New System.Drawing.Size(266, 20)
        Me.txbMaHieuXe.TabIndex = 3
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(106, 333)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhat.TabIndex = 4
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(295, 333)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 23)
        Me.btXoa.TabIndex = 5
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'dgvDanhSachHieuXe
        '
        Me.dgvDanhSachHieuXe.AllowUserToAddRows = False
        Me.dgvDanhSachHieuXe.AllowUserToDeleteRows = False
        Me.dgvDanhSachHieuXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachHieuXe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachHieuXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachHieuXe.Location = New System.Drawing.Point(154, 34)
        Me.dgvDanhSachHieuXe.MultiSelect = False
        Me.dgvDanhSachHieuXe.Name = "dgvDanhSachHieuXe"
        Me.dgvDanhSachHieuXe.ReadOnly = True
        Me.dgvDanhSachHieuXe.RowHeadersVisible = False
        Me.dgvDanhSachHieuXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachHieuXe.Size = New System.Drawing.Size(373, 197)
        Me.dgvDanhSachHieuXe.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Danh Sách Hiệu Xe"
        '
        'btDong
        '
        Me.btDong.Location = New System.Drawing.Point(485, 333)
        Me.btDong.Name = "btDong"
        Me.btDong.Size = New System.Drawing.Size(75, 23)
        Me.btDong.TabIndex = 8
        Me.btDong.Text = "Đóng"
        Me.btDong.UseVisualStyleBackColor = True
        '
        'frmQuanLyHieuXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 376)
        Me.Controls.Add(Me.btDong)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvDanhSachHieuXe)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btCapNhat)
        Me.Controls.Add(Me.txbMaHieuXe)
        Me.Controls.Add(Me.txbTenHieuXe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuanLyHieuXe"
        Me.Text = "Quản Lý Hiệu Xe"
        CType(Me.dgvDanhSachHieuXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbTenHieuXe As TextBox
    Friend WithEvents txbMaHieuXe As TextBox
    Friend WithEvents btCapNhat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents dgvDanhSachHieuXe As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btDong As Button
End Class
