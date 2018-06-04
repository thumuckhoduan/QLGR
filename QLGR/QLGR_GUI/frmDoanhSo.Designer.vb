<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoanhSo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbThang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDoanhThu = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbTongDoanhThu = New System.Windows.Forms.Label()
        Me.btLuu = New System.Windows.Forms.Button()
        Me.btDong = New System.Windows.Forms.Button()
        Me.txtNam = New System.Windows.Forms.TextBox()
        CType(Me.dgvDoanhThu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tháng"
        '
        'cbThang
        '
        Me.cbThang.FormattingEnabled = True
        Me.cbThang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbThang.Location = New System.Drawing.Point(197, 25)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(121, 21)
        Me.cbThang.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(377, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Năm"
        '
        'dgvDoanhThu
        '
        Me.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoanhThu.Location = New System.Drawing.Point(28, 99)
        Me.dgvDoanhThu.Name = "dgvDoanhThu"
        Me.dgvDoanhThu.Size = New System.Drawing.Size(744, 266)
        Me.dgvDoanhThu.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tổng Doanh Thu"
        '
        'lbTongDoanhThu
        '
        Me.lbTongDoanhThu.AutoSize = True
        Me.lbTongDoanhThu.Location = New System.Drawing.Point(337, 83)
        Me.lbTongDoanhThu.Name = "lbTongDoanhThu"
        Me.lbTongDoanhThu.Size = New System.Drawing.Size(0, 13)
        Me.lbTongDoanhThu.TabIndex = 6
        '
        'btLuu
        '
        Me.btLuu.Location = New System.Drawing.Point(172, 391)
        Me.btLuu.Name = "btLuu"
        Me.btLuu.Size = New System.Drawing.Size(75, 23)
        Me.btLuu.TabIndex = 7
        Me.btLuu.Text = "Lưu"
        Me.btLuu.UseVisualStyleBackColor = True
        '
        'btDong
        '
        Me.btDong.Location = New System.Drawing.Point(474, 391)
        Me.btDong.Name = "btDong"
        Me.btDong.Size = New System.Drawing.Size(75, 23)
        Me.btDong.TabIndex = 8
        Me.btDong.Text = "Đóng"
        Me.btDong.UseVisualStyleBackColor = True
        '
        'txtNam
        '
        Me.txtNam.Location = New System.Drawing.Point(465, 25)
        Me.txtNam.Name = "txtNam"
        Me.txtNam.Size = New System.Drawing.Size(149, 20)
        Me.txtNam.TabIndex = 9
        '
        'frmDoanhSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNam)
        Me.Controls.Add(Me.btDong)
        Me.Controls.Add(Me.btLuu)
        Me.Controls.Add(Me.lbTongDoanhThu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvDoanhThu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbThang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDoanhSo"
        Me.Text = "Doanh Số"
        CType(Me.dgvDoanhThu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbThang As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDoanhThu As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents lbTongDoanhThu As Label
    Friend WithEvents btLuu As Button
    Friend WithEvents btDong As Button
    Friend WithEvents txtNam As TextBox
End Class
