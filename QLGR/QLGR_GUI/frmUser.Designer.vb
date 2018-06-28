<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ĐăngXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btTiepNhanSuaXe = New System.Windows.Forms.Button()
        Me.btPhieuSuaChua = New System.Windows.Forms.Button()
        Me.btQuanLySuaXe = New System.Windows.Forms.Button()
        Me.btQuanLyPhieuSuaChua = New System.Windows.Forms.Button()
        Me.btChiTietSuaChua = New System.Windows.Forms.Button()
        Me.btThemHieuXe = New System.Windows.Forms.Button()
        Me.btQuanLyChuXe = New System.Windows.Forms.Button()
        Me.btQuanLyXe = New System.Windows.Forms.Button()
        Me.btQuanLyHieuXe = New System.Windows.Forms.Button()
        Me.btTimKiem = New System.Windows.Forms.Button()
        Me.btBaoCaoTon = New System.Windows.Forms.Button()
        Me.btQuanLyPhuTung = New System.Windows.Forms.Button()
        Me.btThemPhuTung = New System.Windows.Forms.Button()
        Me.btPhieuThuTien = New System.Windows.Forms.Button()
        Me.btBaoCaoDoanhsSo = New System.Windows.Forms.Button()
        Me.btNhapPhuTung = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐăngXuấtToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1098, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ĐăngXuấtToolStripMenuItem
        '
        Me.ĐăngXuấtToolStripMenuItem.Name = "ĐăngXuấtToolStripMenuItem"
        Me.ĐăngXuấtToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ĐăngXuấtToolStripMenuItem.Text = "Đăng Xuất"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btTiepNhanSuaXe
        '
        Me.btTiepNhanSuaXe.Location = New System.Drawing.Point(96, 151)
        Me.btTiepNhanSuaXe.Name = "btTiepNhanSuaXe"
        Me.btTiepNhanSuaXe.Size = New System.Drawing.Size(115, 23)
        Me.btTiepNhanSuaXe.TabIndex = 1
        Me.btTiepNhanSuaXe.Text = "Tiếp Nhận Sữa Xe"
        Me.btTiepNhanSuaXe.UseVisualStyleBackColor = True
        '
        'btPhieuSuaChua
        '
        Me.btPhieuSuaChua.Location = New System.Drawing.Point(96, 222)
        Me.btPhieuSuaChua.Name = "btPhieuSuaChua"
        Me.btPhieuSuaChua.Size = New System.Drawing.Size(115, 23)
        Me.btPhieuSuaChua.TabIndex = 2
        Me.btPhieuSuaChua.Text = "Phiếu Sữa Chữa"
        Me.btPhieuSuaChua.UseVisualStyleBackColor = True
        '
        'btQuanLySuaXe
        '
        Me.btQuanLySuaXe.Location = New System.Drawing.Point(306, 151)
        Me.btQuanLySuaXe.Name = "btQuanLySuaXe"
        Me.btQuanLySuaXe.Size = New System.Drawing.Size(141, 23)
        Me.btQuanLySuaXe.TabIndex = 3
        Me.btQuanLySuaXe.Text = "Quản Lý Sữa Xe"
        Me.btQuanLySuaXe.UseVisualStyleBackColor = True
        '
        'btQuanLyPhieuSuaChua
        '
        Me.btQuanLyPhieuSuaChua.Location = New System.Drawing.Point(306, 222)
        Me.btQuanLyPhieuSuaChua.Name = "btQuanLyPhieuSuaChua"
        Me.btQuanLyPhieuSuaChua.Size = New System.Drawing.Size(141, 23)
        Me.btQuanLyPhieuSuaChua.TabIndex = 4
        Me.btQuanLyPhieuSuaChua.Text = "Quản Lý Phiếu Sữa Chữa"
        Me.btQuanLyPhieuSuaChua.UseVisualStyleBackColor = True
        '
        'btChiTietSuaChua
        '
        Me.btChiTietSuaChua.Location = New System.Drawing.Point(96, 285)
        Me.btChiTietSuaChua.Name = "btChiTietSuaChua"
        Me.btChiTietSuaChua.Size = New System.Drawing.Size(115, 23)
        Me.btChiTietSuaChua.TabIndex = 5
        Me.btChiTietSuaChua.Text = "Chi Tiết Sữa Chữa"
        Me.btChiTietSuaChua.UseVisualStyleBackColor = True
        '
        'btThemHieuXe
        '
        Me.btThemHieuXe.Location = New System.Drawing.Point(518, 222)
        Me.btThemHieuXe.Name = "btThemHieuXe"
        Me.btThemHieuXe.Size = New System.Drawing.Size(125, 23)
        Me.btThemHieuXe.TabIndex = 6
        Me.btThemHieuXe.Text = "Thêm Hiệu Xe"
        Me.btThemHieuXe.UseVisualStyleBackColor = True
        '
        'btQuanLyChuXe
        '
        Me.btQuanLyChuXe.Location = New System.Drawing.Point(518, 151)
        Me.btQuanLyChuXe.Name = "btQuanLyChuXe"
        Me.btQuanLyChuXe.Size = New System.Drawing.Size(125, 23)
        Me.btQuanLyChuXe.TabIndex = 7
        Me.btQuanLyChuXe.Text = "Quản Lý Chủ Xe"
        Me.btQuanLyChuXe.UseVisualStyleBackColor = True
        '
        'btQuanLyXe
        '
        Me.btQuanLyXe.Location = New System.Drawing.Point(306, 285)
        Me.btQuanLyXe.Name = "btQuanLyXe"
        Me.btQuanLyXe.Size = New System.Drawing.Size(141, 23)
        Me.btQuanLyXe.TabIndex = 8
        Me.btQuanLyXe.Text = "Quản Lý Xe"
        Me.btQuanLyXe.UseVisualStyleBackColor = True
        '
        'btQuanLyHieuXe
        '
        Me.btQuanLyHieuXe.Location = New System.Drawing.Point(700, 151)
        Me.btQuanLyHieuXe.Name = "btQuanLyHieuXe"
        Me.btQuanLyHieuXe.Size = New System.Drawing.Size(129, 23)
        Me.btQuanLyHieuXe.TabIndex = 9
        Me.btQuanLyHieuXe.Text = "Quản Lý Hiệu Xe"
        Me.btQuanLyHieuXe.UseVisualStyleBackColor = True
        '
        'btTimKiem
        '
        Me.btTimKiem.Location = New System.Drawing.Point(518, 285)
        Me.btTimKiem.Name = "btTimKiem"
        Me.btTimKiem.Size = New System.Drawing.Size(125, 23)
        Me.btTimKiem.TabIndex = 10
        Me.btTimKiem.Text = "Tìm Kiếm"
        Me.btTimKiem.UseVisualStyleBackColor = True
        '
        'btBaoCaoTon
        '
        Me.btBaoCaoTon.Location = New System.Drawing.Point(372, 361)
        Me.btBaoCaoTon.Name = "btBaoCaoTon"
        Me.btBaoCaoTon.Size = New System.Drawing.Size(116, 23)
        Me.btBaoCaoTon.TabIndex = 11
        Me.btBaoCaoTon.Text = "Báo Cáo Tồn"
        Me.btBaoCaoTon.UseVisualStyleBackColor = True
        '
        'btQuanLyPhuTung
        '
        Me.btQuanLyPhuTung.Location = New System.Drawing.Point(873, 151)
        Me.btQuanLyPhuTung.Name = "btQuanLyPhuTung"
        Me.btQuanLyPhuTung.Size = New System.Drawing.Size(135, 23)
        Me.btQuanLyPhuTung.TabIndex = 12
        Me.btQuanLyPhuTung.Text = "Quản Lý Phụ Tùng"
        Me.btQuanLyPhuTung.UseVisualStyleBackColor = True
        '
        'btThemPhuTung
        '
        Me.btThemPhuTung.Location = New System.Drawing.Point(700, 285)
        Me.btThemPhuTung.Name = "btThemPhuTung"
        Me.btThemPhuTung.Size = New System.Drawing.Size(129, 23)
        Me.btThemPhuTung.TabIndex = 13
        Me.btThemPhuTung.Text = "Thêm Phụ Tùng"
        Me.btThemPhuTung.UseVisualStyleBackColor = True
        '
        'btPhieuThuTien
        '
        Me.btPhieuThuTien.Location = New System.Drawing.Point(700, 222)
        Me.btPhieuThuTien.Name = "btPhieuThuTien"
        Me.btPhieuThuTien.Size = New System.Drawing.Size(129, 23)
        Me.btPhieuThuTien.TabIndex = 14
        Me.btPhieuThuTien.Text = "Phiếu Thu Tiền"
        Me.btPhieuThuTien.UseVisualStyleBackColor = True
        '
        'btBaoCaoDoanhsSo
        '
        Me.btBaoCaoDoanhsSo.Location = New System.Drawing.Point(647, 361)
        Me.btBaoCaoDoanhsSo.Name = "btBaoCaoDoanhsSo"
        Me.btBaoCaoDoanhsSo.Size = New System.Drawing.Size(135, 23)
        Me.btBaoCaoDoanhsSo.TabIndex = 16
        Me.btBaoCaoDoanhsSo.Text = "Báo Cáo Doanh Số"
        Me.btBaoCaoDoanhsSo.UseVisualStyleBackColor = True
        '
        'btNhapPhuTung
        '
        Me.btNhapPhuTung.Location = New System.Drawing.Point(873, 222)
        Me.btNhapPhuTung.Name = "btNhapPhuTung"
        Me.btNhapPhuTung.Size = New System.Drawing.Size(135, 23)
        Me.btNhapPhuTung.TabIndex = 17
        Me.btNhapPhuTung.Text = "Nhập Phụ Tùng"
        Me.btNhapPhuTung.UseVisualStyleBackColor = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 554)
        Me.Controls.Add(Me.btNhapPhuTung)
        Me.Controls.Add(Me.btBaoCaoDoanhsSo)
        Me.Controls.Add(Me.btPhieuThuTien)
        Me.Controls.Add(Me.btThemPhuTung)
        Me.Controls.Add(Me.btQuanLyPhuTung)
        Me.Controls.Add(Me.btBaoCaoTon)
        Me.Controls.Add(Me.btTimKiem)
        Me.Controls.Add(Me.btQuanLyHieuXe)
        Me.Controls.Add(Me.btQuanLyXe)
        Me.Controls.Add(Me.btQuanLyChuXe)
        Me.Controls.Add(Me.btThemHieuXe)
        Me.Controls.Add(Me.btChiTietSuaChua)
        Me.Controls.Add(Me.btQuanLyPhieuSuaChua)
        Me.Controls.Add(Me.btQuanLySuaXe)
        Me.Controls.Add(Me.btPhieuSuaChua)
        Me.Controls.Add(Me.btTiepNhanSuaXe)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUser"
        Me.Text = "Car"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btTiepNhanSuaXe As Button
    Friend WithEvents btPhieuSuaChua As Button
    Friend WithEvents btQuanLySuaXe As Button
    Friend WithEvents btQuanLyPhieuSuaChua As Button
    Friend WithEvents btChiTietSuaChua As Button
    Friend WithEvents btThemHieuXe As Button
    Friend WithEvents btQuanLyChuXe As Button
    Friend WithEvents btQuanLyXe As Button
    Friend WithEvents btQuanLyHieuXe As Button
    Friend WithEvents btTimKiem As Button
    Friend WithEvents btBaoCaoTon As Button
    Friend WithEvents btQuanLyPhuTung As Button
    Friend WithEvents btThemPhuTung As Button
    Friend WithEvents btPhieuThuTien As Button
    Friend WithEvents btBaoCaoDoanhsSo As Button
    Friend WithEvents btNhapPhuTung As Button
    Friend WithEvents ĐăngXuấtToolStripMenuItem As ToolStripMenuItem
End Class
