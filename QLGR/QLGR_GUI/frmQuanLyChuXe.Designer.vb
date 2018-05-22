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
        Me.dgvDanhSachSuaXe = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDanhSachSuaXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDanhSachSuaXe
        '
        Me.dgvDanhSachSuaXe.AllowUserToAddRows = False
        Me.dgvDanhSachSuaXe.AllowUserToDeleteRows = False
        Me.dgvDanhSachSuaXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachSuaXe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachSuaXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachSuaXe.Location = New System.Drawing.Point(24, 12)
        Me.dgvDanhSachSuaXe.MultiSelect = False
        Me.dgvDanhSachSuaXe.Name = "dgvDanhSachSuaXe"
        Me.dgvDanhSachSuaXe.ReadOnly = True
        Me.dgvDanhSachSuaXe.RowHeadersVisible = False
        Me.dgvDanhSachSuaXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachSuaXe.Size = New System.Drawing.Size(747, 225)
        Me.dgvDanhSachSuaXe.TabIndex = 32
        '
        'frmQuanLyChuXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvDanhSachSuaXe)
        Me.Name = "frmQuanLyChuXe"
        Me.Text = "Quản Lý Chủ Xe"
        CType(Me.dgvDanhSachSuaXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDanhSachSuaXe As DataGridView
End Class
