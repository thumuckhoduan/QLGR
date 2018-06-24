<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBaoCaoTon
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
        Me.dgvBaoCaoTon = New System.Windows.Forms.DataGridView()
        Me.cbThang = New System.Windows.Forms.ComboBox()
        Me.cbNam = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLapBaoCao = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        CType(Me.dgvBaoCaoTon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBaoCaoTon
        '
        Me.dgvBaoCaoTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCaoTon.Location = New System.Drawing.Point(13, 64)
        Me.dgvBaoCaoTon.Name = "dgvBaoCaoTon"
        Me.dgvBaoCaoTon.Size = New System.Drawing.Size(738, 330)
        Me.dgvBaoCaoTon.TabIndex = 0
        '
        'cbThang
        '
        Me.cbThang.FormattingEnabled = True
        Me.cbThang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbThang.Location = New System.Drawing.Point(140, 13)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(121, 21)
        Me.cbThang.TabIndex = 1
        '
        'cbNam
        '
        Me.cbNam.FormattingEnabled = True
        Me.cbNam.Location = New System.Drawing.Point(464, 13)
        Me.cbNam.Name = "cbNam"
        Me.cbNam.Size = New System.Drawing.Size(121, 21)
        Me.cbNam.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(386, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Năm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tháng"
        '
        'btnLapBaoCao
        '
        Me.btnLapBaoCao.Location = New System.Drawing.Point(173, 415)
        Me.btnLapBaoCao.Name = "btnLapBaoCao"
        Me.btnLapBaoCao.Size = New System.Drawing.Size(98, 23)
        Me.btnLapBaoCao.TabIndex = 5
        Me.btnLapBaoCao.Text = "Lập Báo Cáo"
        Me.btnLapBaoCao.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(441, 415)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 6
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'frmBaoCaoTon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 450)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnLapBaoCao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbNam)
        Me.Controls.Add(Me.cbThang)
        Me.Controls.Add(Me.dgvBaoCaoTon)
        Me.Name = "frmBaoCaoTon"
        Me.Text = "Báo Cáo Tồn"
        CType(Me.dgvBaoCaoTon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBaoCaoTon As DataGridView
    Friend WithEvents cbThang As ComboBox
    Friend WithEvents cbNam As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLapBaoCao As Button
    Friend WithEvents btnDong As Button
End Class
