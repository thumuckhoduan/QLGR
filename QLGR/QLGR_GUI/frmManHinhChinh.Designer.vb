<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManHinhChinh
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiếpNhậnSữaXeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýSữaXeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýXeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HiệuXeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmHiệuXeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýHiệuXeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýSửaXeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XeToolStripMenuItem, Me.HiệuXeToolStripMenuItem, Me.QuảnLýSửaXeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'XeToolStripMenuItem
        '
        Me.XeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiếpNhậnSữaXeToolStripMenuItem, Me.QuảnLýSữaXeToolStripMenuItem, Me.QuảnLýXeToolStripMenuItem})
        Me.XeToolStripMenuItem.Name = "XeToolStripMenuItem"
        Me.XeToolStripMenuItem.Size = New System.Drawing.Size(32, 20)
        Me.XeToolStripMenuItem.Text = "Xe"
        '
        'TiếpNhậnSữaXeToolStripMenuItem
        '
        Me.TiếpNhậnSữaXeToolStripMenuItem.Name = "TiếpNhậnSữaXeToolStripMenuItem"
        Me.TiếpNhậnSữaXeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TiếpNhậnSữaXeToolStripMenuItem.Text = "Tiếp Nhận Sữa Xe"
        '
        'QuảnLýSữaXeToolStripMenuItem
        '
        Me.QuảnLýSữaXeToolStripMenuItem.Name = "QuảnLýSữaXeToolStripMenuItem"
        Me.QuảnLýSữaXeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuảnLýSữaXeToolStripMenuItem.Text = "Quản Lý Sữa Xe"
        '
        'QuảnLýXeToolStripMenuItem
        '
        Me.QuảnLýXeToolStripMenuItem.Name = "QuảnLýXeToolStripMenuItem"
        Me.QuảnLýXeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuảnLýXeToolStripMenuItem.Text = "Quản Lý Xe"
        '
        'HiệuXeToolStripMenuItem
        '
        Me.HiệuXeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmHiệuXeToolStripMenuItem, Me.QuảnLýHiệuXeToolStripMenuItem})
        Me.HiệuXeToolStripMenuItem.Name = "HiệuXeToolStripMenuItem"
        Me.HiệuXeToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.HiệuXeToolStripMenuItem.Text = "Hiệu Xe"
        '
        'ThêmHiệuXeToolStripMenuItem
        '
        Me.ThêmHiệuXeToolStripMenuItem.Name = "ThêmHiệuXeToolStripMenuItem"
        Me.ThêmHiệuXeToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ThêmHiệuXeToolStripMenuItem.Text = "Thêm Hiệu Xe"
        '
        'QuảnLýHiệuXeToolStripMenuItem
        '
        Me.QuảnLýHiệuXeToolStripMenuItem.Name = "QuảnLýHiệuXeToolStripMenuItem"
        Me.QuảnLýHiệuXeToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.QuảnLýHiệuXeToolStripMenuItem.Text = "Quản Lý Hiệu Xe"
        '
        'QuảnLýSửaXeToolStripMenuItem
        '
        Me.QuảnLýSửaXeToolStripMenuItem.Name = "QuảnLýSửaXeToolStripMenuItem"
        Me.QuảnLýSửaXeToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.QuảnLýSửaXeToolStripMenuItem.Text = "Quản Lý Sửa Xe"
        '
        'frmManHinhChinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmManHinhChinh"
        Me.Text = "Quản Lý Gara"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents XeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HiệuXeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmHiệuXeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiếpNhậnSữaXeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýHiệuXeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýSữaXeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýXeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýSửaXeToolStripMenuItem As ToolStripMenuItem
End Class
