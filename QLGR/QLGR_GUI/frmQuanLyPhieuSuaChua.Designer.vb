<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuanLyPhieuSuaChua
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyPhieuSuaChua))
        Me.dgvPhieuSuaChua = New System.Windows.Forms.DataGridView()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.txtMaXe = New System.Windows.Forms.TextBox()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.txtMaPhieuSuaChua = New System.Windows.Forms.TextBox()
        Me.txtNoiDung = New System.Windows.Forms.TextBox()
        Me.dtpNgaySuaChua = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvPhieuSuaChua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPhieuSuaChua
        '
        Me.dgvPhieuSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhieuSuaChua.Location = New System.Drawing.Point(153, 53)
        Me.dgvPhieuSuaChua.Name = "dgvPhieuSuaChua"
        Me.dgvPhieuSuaChua.Size = New System.Drawing.Size(482, 150)
        Me.dgvPhieuSuaChua.TabIndex = 0
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(203, 397)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhat.TabIndex = 1
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(372, 397)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 23)
        Me.btXoa.TabIndex = 2
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(530, 397)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 23)
        Me.btThoat.TabIndex = 3
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'txtMaXe
        '
        Me.txtMaXe.Location = New System.Drawing.Point(329, 274)
        Me.txtMaXe.Name = "txtMaXe"
        Me.txtMaXe.ReadOnly = True
        Me.txtMaXe.Size = New System.Drawing.Size(200, 20)
        Me.txtMaXe.TabIndex = 4
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(329, 300)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.ReadOnly = True
        Me.txtThanhTien.Size = New System.Drawing.Size(200, 20)
        Me.txtThanhTien.TabIndex = 5
        '
        'txtMaPhieuSuaChua
        '
        Me.txtMaPhieuSuaChua.Location = New System.Drawing.Point(329, 222)
        Me.txtMaPhieuSuaChua.Name = "txtMaPhieuSuaChua"
        Me.txtMaPhieuSuaChua.ReadOnly = True
        Me.txtMaPhieuSuaChua.Size = New System.Drawing.Size(200, 20)
        Me.txtMaPhieuSuaChua.TabIndex = 4
        '
        'txtNoiDung
        '
        Me.txtNoiDung.Location = New System.Drawing.Point(329, 248)
        Me.txtNoiDung.Name = "txtNoiDung"
        Me.txtNoiDung.Size = New System.Drawing.Size(200, 20)
        Me.txtNoiDung.TabIndex = 5
        '
        'dtpNgaySuaChua
        '
        Me.dtpNgaySuaChua.Location = New System.Drawing.Point(329, 326)
        Me.dtpNgaySuaChua.Name = "dtpNgaySuaChua"
        Me.dtpNgaySuaChua.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgaySuaChua.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mã Phiếu Sửa Chữa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nội Dung"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Mã Xe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Thành Tiền"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(221, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Ngày Sửa Chữa"
        '
        'frmQuanLyPhieuSuaChua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 440)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpNgaySuaChua)
        Me.Controls.Add(Me.txtNoiDung)
        Me.Controls.Add(Me.txtMaPhieuSuaChua)
        Me.Controls.Add(Me.txtThanhTien)
        Me.Controls.Add(Me.txtMaXe)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btCapNhat)
        Me.Controls.Add(Me.dgvPhieuSuaChua)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuanLyPhieuSuaChua"
        Me.Text = "Quản Lý Phiếu Sửa  Chữa"
        CType(Me.dgvPhieuSuaChua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPhieuSuaChua As DataGridView
    Friend WithEvents btCapNhat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btThoat As Button
    Friend WithEvents txtMaXe As TextBox
    Friend WithEvents txtThanhTien As TextBox
    Friend WithEvents txtMaPhieuSuaChua As TextBox
    Friend WithEvents txtNoiDung As TextBox
    Friend WithEvents dtpNgaySuaChua As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
