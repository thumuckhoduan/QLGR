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
        Me.dgvPhieuSuaChua = New System.Windows.Forms.DataGridView()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.txtMaXe = New System.Windows.Forms.TextBox()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.txtMaPhieuSuaChua = New System.Windows.Forms.TextBox()
        Me.txtNoiDung = New System.Windows.Forms.TextBox()
        Me.dtpNgaySuaChua = New System.Windows.Forms.DateTimePicker()
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
        Me.btCapNhat.Location = New System.Drawing.Point(197, 249)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhat.TabIndex = 1
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(362, 249)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 23)
        Me.btXoa.TabIndex = 2
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(524, 249)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 23)
        Me.btThoat.TabIndex = 3
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'txtMaXe
        '
        Me.txtMaXe.Location = New System.Drawing.Point(319, 302)
        Me.txtMaXe.Name = "txtMaXe"
        Me.txtMaXe.Size = New System.Drawing.Size(100, 20)
        Me.txtMaXe.TabIndex = 4
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(440, 302)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(100, 20)
        Me.txtThanhTien.TabIndex = 5
        '
        'txtMaPhieuSuaChua
        '
        Me.txtMaPhieuSuaChua.Location = New System.Drawing.Point(84, 302)
        Me.txtMaPhieuSuaChua.Name = "txtMaPhieuSuaChua"
        Me.txtMaPhieuSuaChua.Size = New System.Drawing.Size(100, 20)
        Me.txtMaPhieuSuaChua.TabIndex = 4
        '
        'txtNoiDung
        '
        Me.txtNoiDung.Location = New System.Drawing.Point(197, 302)
        Me.txtNoiDung.Name = "txtNoiDung"
        Me.txtNoiDung.Size = New System.Drawing.Size(100, 20)
        Me.txtNoiDung.TabIndex = 5
        '
        'dtpNgaySuaChua
        '
        Me.dtpNgaySuaChua.Location = New System.Drawing.Point(561, 302)
        Me.dtpNgaySuaChua.Name = "dtpNgaySuaChua"
        Me.dtpNgaySuaChua.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgaySuaChua.TabIndex = 6
        '
        'frmQuanLyPhieuSuaChua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtpNgaySuaChua)
        Me.Controls.Add(Me.txtNoiDung)
        Me.Controls.Add(Me.txtMaPhieuSuaChua)
        Me.Controls.Add(Me.txtThanhTien)
        Me.Controls.Add(Me.txtMaXe)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btCapNhat)
        Me.Controls.Add(Me.dgvPhieuSuaChua)
        Me.Name = "frmQuanLyPhieuSuaChua"
        Me.Text = "QuanLyPhieuSuaXe"
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
End Class
