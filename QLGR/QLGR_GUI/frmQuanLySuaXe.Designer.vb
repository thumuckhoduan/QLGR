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
        CType(Me.dgvDanhSachSuaXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbMaSuaXe
        '
        Me.txbMaSuaXe.Location = New System.Drawing.Point(281, 259)
        Me.txbMaSuaXe.Name = "txbMaSuaXe"
        Me.txbMaSuaXe.ReadOnly = True
        Me.txbMaSuaXe.Size = New System.Drawing.Size(195, 20)
        Me.txbMaSuaXe.TabIndex = 0
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(190, 412)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhat.TabIndex = 1
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã Sữa Xe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mã Xe"
        '
        'txbMaXe
        '
        Me.txbMaXe.Location = New System.Drawing.Point(281, 301)
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
        Me.Label4.Location = New System.Drawing.Point(119, 341)
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
        Me.btXoa.Location = New System.Drawing.Point(357, 412)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 29)
        Me.btXoa.TabIndex = 32
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btDong
        '
        Me.btDong.Location = New System.Drawing.Point(548, 406)
        Me.btDong.Name = "btDong"
        Me.btDong.Size = New System.Drawing.Size(75, 29)
        Me.btDong.TabIndex = 33
        Me.btDong.Text = "Đóng"
        Me.btDong.UseVisualStyleBackColor = True
        '
        'dtpNgayTiepNhan
        '
        Me.dtpNgayTiepNhan.Location = New System.Drawing.Point(281, 333)
        Me.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan"
        Me.dtpNgayTiepNhan.Size = New System.Drawing.Size(195, 20)
        Me.dtpNgayTiepNhan.TabIndex = 34
        '
        'frmQuanLySuaXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Name = "frmQuanLySuaXe"
        Me.Text = "Quản Lý Sữa Xe"
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
End Class
