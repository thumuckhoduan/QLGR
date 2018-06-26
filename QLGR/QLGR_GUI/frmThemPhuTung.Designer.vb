<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemPhuTung
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
        Me.btThem = New System.Windows.Forms.Button()
        Me.btDong = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbMaPhuTung = New System.Windows.Forms.TextBox()
        Me.txbTenPhuTung = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btThem
        '
        Me.btThem.Location = New System.Drawing.Point(74, 162)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(75, 23)
        Me.btThem.TabIndex = 0
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = True
        '
        'btDong
        '
        Me.btDong.Location = New System.Drawing.Point(340, 162)
        Me.btDong.Name = "btDong"
        Me.btDong.Size = New System.Drawing.Size(75, 23)
        Me.btDong.TabIndex = 1
        Me.btDong.Text = "Đóng"
        Me.btDong.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã Phụ Tùng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên Phụ Tùng"
        '
        'txbMaPhuTung
        '
        Me.txbMaPhuTung.Location = New System.Drawing.Point(178, 68)
        Me.txbMaPhuTung.Name = "txbMaPhuTung"
        Me.txbMaPhuTung.ReadOnly = True
        Me.txbMaPhuTung.Size = New System.Drawing.Size(237, 20)
        Me.txbMaPhuTung.TabIndex = 4
        '
        'txbTenPhuTung
        '
        Me.txbTenPhuTung.Location = New System.Drawing.Point(178, 110)
        Me.txbTenPhuTung.Name = "txbTenPhuTung"
        Me.txbTenPhuTung.Size = New System.Drawing.Size(237, 20)
        Me.txbTenPhuTung.TabIndex = 5
        '
        'frmThemPhuTung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 245)
        Me.Controls.Add(Me.txbTenPhuTung)
        Me.Controls.Add(Me.txbMaPhuTung)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btDong)
        Me.Controls.Add(Me.btThem)
        Me.Name = "frmThemPhuTung"
        Me.Text = "Thêm Phụ Tùng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btThem As Button
    Friend WithEvents btDong As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbMaPhuTung As TextBox
    Friend WithEvents txbTenPhuTung As TextBox
End Class
