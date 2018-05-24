<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiem
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
        Me.txtChuXe = New System.Windows.Forms.TextBox()
        Me.cbHieuXe = New System.Windows.Forms.ComboBox()
        Me.dgvTimKiem = New System.Windows.Forms.DataGridView()
        Me.LaBel2 = New System.Windows.Forms.Label()
        Me.btTimKiem = New System.Windows.Forms.Button()
        Me.btDong = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTienNoMin = New System.Windows.Forms.TextBox()
        Me.txtTienNoMax = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBienSo = New System.Windows.Forms.TextBox()
        CType(Me.dgvTimKiem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(372, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hiệu Xe"
        '
        'txtChuXe
        '
        Me.txtChuXe.Location = New System.Drawing.Point(267, 20)
        Me.txtChuXe.Name = "txtChuXe"
        Me.txtChuXe.Size = New System.Drawing.Size(220, 20)
        Me.txtChuXe.TabIndex = 1
        '
        'cbHieuXe
        '
        Me.cbHieuXe.FormattingEnabled = True
        Me.cbHieuXe.Location = New System.Drawing.Point(497, 54)
        Me.cbHieuXe.Name = "cbHieuXe"
        Me.cbHieuXe.Size = New System.Drawing.Size(163, 21)
        Me.cbHieuXe.TabIndex = 2
        '
        'dgvTimKiem
        '
        Me.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTimKiem.Location = New System.Drawing.Point(12, 128)
        Me.dgvTimKiem.Name = "dgvTimKiem"
        Me.dgvTimKiem.Size = New System.Drawing.Size(760, 253)
        Me.dgvTimKiem.TabIndex = 3
        '
        'LaBel2
        '
        Me.LaBel2.AutoSize = True
        Me.LaBel2.Location = New System.Drawing.Point(175, 20)
        Me.LaBel2.Name = "LaBel2"
        Me.LaBel2.Size = New System.Drawing.Size(42, 13)
        Me.LaBel2.TabIndex = 4
        Me.LaBel2.Text = "Chủ Xe"
        '
        'btTimKiem
        '
        Me.btTimKiem.Location = New System.Drawing.Point(155, 415)
        Me.btTimKiem.Name = "btTimKiem"
        Me.btTimKiem.Size = New System.Drawing.Size(75, 23)
        Me.btTimKiem.TabIndex = 5
        Me.btTimKiem.Text = "Tìm Kiếm"
        Me.btTimKiem.UseVisualStyleBackColor = True
        '
        'btDong
        '
        Me.btDong.Location = New System.Drawing.Point(437, 415)
        Me.btDong.Name = "btDong"
        Me.btDong.Size = New System.Drawing.Size(75, 23)
        Me.btDong.TabIndex = 6
        Me.btDong.Text = "Đóng"
        Me.btDong.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Biển Số"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tiền Nợ"
        '
        'txtTienNoMin
        '
        Me.txtTienNoMin.Location = New System.Drawing.Point(155, 95)
        Me.txtTienNoMin.Name = "txtTienNoMin"
        Me.txtTienNoMin.Size = New System.Drawing.Size(157, 20)
        Me.txtTienNoMin.TabIndex = 9
        '
        'txtTienNoMax
        '
        Me.txtTienNoMax.Location = New System.Drawing.Point(497, 95)
        Me.txtTienNoMax.Name = "txtTienNoMax"
        Me.txtTienNoMax.Size = New System.Drawing.Size(163, 20)
        Me.txtTienNoMax.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "từ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(372, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "đến"
        '
        'txtBienSo
        '
        Me.txtBienSo.Location = New System.Drawing.Point(155, 55)
        Me.txtBienSo.Name = "txtBienSo"
        Me.txtBienSo.Size = New System.Drawing.Size(157, 20)
        Me.txtBienSo.TabIndex = 15
        '
        'frmTimKiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtBienSo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTienNoMax)
        Me.Controls.Add(Me.txtTienNoMin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btDong)
        Me.Controls.Add(Me.btTimKiem)
        Me.Controls.Add(Me.LaBel2)
        Me.Controls.Add(Me.dgvTimKiem)
        Me.Controls.Add(Me.cbHieuXe)
        Me.Controls.Add(Me.txtChuXe)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTimKiem"
        Me.Text = "Tìm Kiếm"
        CType(Me.dgvTimKiem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtChuXe As TextBox
    Friend WithEvents cbHieuXe As ComboBox
    Friend WithEvents dgvTimKiem As DataGridView
    Friend WithEvents LaBel2 As Label
    Friend WithEvents btTimKiem As Button
    Friend WithEvents btDong As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTienNoMin As TextBox
    Friend WithEvents txtTienNoMax As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBienSo As TextBox
End Class
