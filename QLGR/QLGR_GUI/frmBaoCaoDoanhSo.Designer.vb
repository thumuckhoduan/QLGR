﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBaoCaoDoanhSo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbThang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDoanhThu = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbTongDoanhThu = New System.Windows.Forms.Label()
        Me.btLuu = New System.Windows.Forms.Button()
        Me.btDong = New System.Windows.Forms.Button()
        Me.cbNam = New System.Windows.Forms.ComboBox()
        CType(Me.dgvDoanhThu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tháng"
        '
        'cbThang
        '
        Me.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThang.FormattingEnabled = True
        Me.cbThang.Location = New System.Drawing.Point(197, 27)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(121, 22)
        Me.cbThang.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(377, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Năm"
        '
        'dgvDoanhThu
        '
        Me.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoanhThu.Location = New System.Drawing.Point(28, 107)
        Me.dgvDoanhThu.Name = "dgvDoanhThu"
        Me.dgvDoanhThu.Size = New System.Drawing.Size(744, 286)
        Me.dgvDoanhThu.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tổng Doanh Thu"
        '
        'lbTongDoanhThu
        '
        Me.lbTongDoanhThu.AutoSize = True
        Me.lbTongDoanhThu.Location = New System.Drawing.Point(337, 89)
        Me.lbTongDoanhThu.Name = "lbTongDoanhThu"
        Me.lbTongDoanhThu.Size = New System.Drawing.Size(0, 14)
        Me.lbTongDoanhThu.TabIndex = 6
        '
        'btLuu
        '
        Me.btLuu.Location = New System.Drawing.Point(172, 421)
        Me.btLuu.Name = "btLuu"
        Me.btLuu.Size = New System.Drawing.Size(100, 25)
        Me.btLuu.TabIndex = 7
        Me.btLuu.Text = "Lập Báo Cáo"
        Me.btLuu.UseVisualStyleBackColor = True
        '
        'btDong
        '
        Me.btDong.Location = New System.Drawing.Point(474, 421)
        Me.btDong.Name = "btDong"
        Me.btDong.Size = New System.Drawing.Size(75, 25)
        Me.btDong.TabIndex = 8
        Me.btDong.Text = "Đóng"
        Me.btDong.UseVisualStyleBackColor = True
        '
        'cbNam
        '
        Me.cbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNam.FormattingEnabled = True
        Me.cbNam.Location = New System.Drawing.Point(493, 33)
        Me.cbNam.Name = "cbNam"
        Me.cbNam.Size = New System.Drawing.Size(121, 22)
        Me.cbNam.TabIndex = 9
        '
        'frmBaoCaoDoanhSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 485)
        Me.Controls.Add(Me.cbNam)
        Me.Controls.Add(Me.btDong)
        Me.Controls.Add(Me.btLuu)
        Me.Controls.Add(Me.lbTongDoanhThu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvDoanhThu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbThang)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!)
        Me.Name = "frmBaoCaoDoanhSo"
        Me.Text = "Báo Cáo Doanh Số"
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
    Friend WithEvents cbNam As ComboBox
End Class
