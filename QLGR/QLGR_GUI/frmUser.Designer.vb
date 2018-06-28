<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.btTiepNhanSuaXe = New System.Windows.Forms.Button()
        Me.btPhieuSuaChua = New System.Windows.Forms.Button()
        Me.btChiTietSuaChua = New System.Windows.Forms.Button()
        Me.btTimKiem = New System.Windows.Forms.Button()
        Me.btPhieuThuTien = New System.Windows.Forms.Button()
        Me.btNhapPhuTung = New System.Windows.Forms.Button()
        Me.btDangXuat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btTiepNhanSuaXe
        '
        Me.btTiepNhanSuaXe.Location = New System.Drawing.Point(71, 115)
        Me.btTiepNhanSuaXe.Name = "btTiepNhanSuaXe"
        Me.btTiepNhanSuaXe.Size = New System.Drawing.Size(129, 23)
        Me.btTiepNhanSuaXe.TabIndex = 1
        Me.btTiepNhanSuaXe.Text = "Tiếp Nhận Sữa Xe"
        Me.btTiepNhanSuaXe.UseVisualStyleBackColor = True
        '
        'btPhieuSuaChua
        '
        Me.btPhieuSuaChua.Location = New System.Drawing.Point(262, 115)
        Me.btPhieuSuaChua.Name = "btPhieuSuaChua"
        Me.btPhieuSuaChua.Size = New System.Drawing.Size(148, 23)
        Me.btPhieuSuaChua.TabIndex = 2
        Me.btPhieuSuaChua.Text = "Phiếu Sữa Chữa"
        Me.btPhieuSuaChua.UseVisualStyleBackColor = True
        '
        'btChiTietSuaChua
        '
        Me.btChiTietSuaChua.Location = New System.Drawing.Point(71, 51)
        Me.btChiTietSuaChua.Name = "btChiTietSuaChua"
        Me.btChiTietSuaChua.Size = New System.Drawing.Size(129, 23)
        Me.btChiTietSuaChua.TabIndex = 5
        Me.btChiTietSuaChua.Text = "Chi Tiết Sữa Chữa"
        Me.btChiTietSuaChua.UseVisualStyleBackColor = True
        '
        'btTimKiem
        '
        Me.btTimKiem.Location = New System.Drawing.Point(262, 187)
        Me.btTimKiem.Name = "btTimKiem"
        Me.btTimKiem.Size = New System.Drawing.Size(148, 23)
        Me.btTimKiem.TabIndex = 10
        Me.btTimKiem.Text = "Tìm Kiếm"
        Me.btTimKiem.UseVisualStyleBackColor = True
        '
        'btPhieuThuTien
        '
        Me.btPhieuThuTien.Location = New System.Drawing.Point(71, 187)
        Me.btPhieuThuTien.Name = "btPhieuThuTien"
        Me.btPhieuThuTien.Size = New System.Drawing.Size(129, 23)
        Me.btPhieuThuTien.TabIndex = 14
        Me.btPhieuThuTien.Text = "Phiếu Thu Tiền"
        Me.btPhieuThuTien.UseVisualStyleBackColor = True
        '
        'btNhapPhuTung
        '
        Me.btNhapPhuTung.Location = New System.Drawing.Point(262, 51)
        Me.btNhapPhuTung.Name = "btNhapPhuTung"
        Me.btNhapPhuTung.Size = New System.Drawing.Size(148, 23)
        Me.btNhapPhuTung.TabIndex = 28
        Me.btNhapPhuTung.Text = "Nhập Phụ Tùng"
        Me.btNhapPhuTung.UseVisualStyleBackColor = True
        '
        'btDangXuat
        '
        Me.btDangXuat.Location = New System.Drawing.Point(149, 230)
        Me.btDangXuat.Name = "btDangXuat"
        Me.btDangXuat.Size = New System.Drawing.Size(148, 23)
        Me.btDangXuat.TabIndex = 29
        Me.btDangXuat.Text = "Đăng Xuất"
        Me.btDangXuat.UseVisualStyleBackColor = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 279)
        Me.Controls.Add(Me.btDangXuat)
        Me.Controls.Add(Me.btNhapPhuTung)
        Me.Controls.Add(Me.btPhieuThuTien)
        Me.Controls.Add(Me.btTimKiem)
        Me.Controls.Add(Me.btChiTietSuaChua)
        Me.Controls.Add(Me.btPhieuSuaChua)
        Me.Controls.Add(Me.btTiepNhanSuaXe)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUser"
        Me.Text = "Car"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btTiepNhanSuaXe As Button
    Friend WithEvents btPhieuSuaChua As Button
    Friend WithEvents btChiTietSuaChua As Button
    Friend WithEvents btTimKiem As Button
    Friend WithEvents btPhieuThuTien As Button
    Friend WithEvents btNhapPhuTung As Button
    Friend WithEvents btDangXuat As Button
End Class
