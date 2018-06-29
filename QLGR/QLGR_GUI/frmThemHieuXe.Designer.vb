<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemHieuXe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemHieuXe))
        Me.txbMaHieuXe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btLuu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbTenHieuXe = New System.Windows.Forms.TextBox()
        Me.btDong = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txbMaHieuXe
        '
        Me.txbMaHieuXe.Location = New System.Drawing.Point(121, 22)
        Me.txbMaHieuXe.Name = "txbMaHieuXe"
        Me.txbMaHieuXe.ReadOnly = True
        Me.txbMaHieuXe.Size = New System.Drawing.Size(174, 20)
        Me.txbMaHieuXe.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Hiệu Xe"
        '
        'btLuu
        '
        Me.btLuu.Location = New System.Drawing.Point(28, 109)
        Me.btLuu.Name = "btLuu"
        Me.btLuu.Size = New System.Drawing.Size(75, 23)
        Me.btLuu.TabIndex = 2
        Me.btLuu.Text = "Lưu"
        Me.btLuu.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên Hiệu Xe"
        '
        'txbTenHieuXe
        '
        Me.txbTenHieuXe.Location = New System.Drawing.Point(121, 64)
        Me.txbTenHieuXe.Name = "txbTenHieuXe"
        Me.txbTenHieuXe.Size = New System.Drawing.Size(174, 20)
        Me.txbTenHieuXe.TabIndex = 4
        '
        'btDong
        '
        Me.btDong.Location = New System.Drawing.Point(254, 109)
        Me.btDong.Name = "btDong"
        Me.btDong.Size = New System.Drawing.Size(75, 23)
        Me.btDong.TabIndex = 5
        Me.btDong.Text = "Đóng"
        Me.btDong.UseVisualStyleBackColor = True
        '
        'frmThemHieuXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 153)
        Me.Controls.Add(Me.btDong)
        Me.Controls.Add(Me.txbTenHieuXe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btLuu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbMaHieuXe)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThemHieuXe"
        Me.Text = "Thêm Hiệu Xe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbMaHieuXe As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btLuu As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txbTenHieuXe As TextBox
    Friend WithEvents btDong As Button
End Class
