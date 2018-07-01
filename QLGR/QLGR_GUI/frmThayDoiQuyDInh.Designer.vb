<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThayDoiQuyDInh
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
        Me.txtTiepNhanToiDa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btLuu = New System.Windows.Forms.Button()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTiepNhanToiDa
        '
        Me.txtTiepNhanToiDa.Location = New System.Drawing.Point(114, 26)
        Me.txtTiepNhanToiDa.Name = "txtTiepNhanToiDa"
        Me.txtTiepNhanToiDa.Size = New System.Drawing.Size(100, 20)
        Me.txtTiepNhanToiDa.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tiếp Nhận Tối Đa"
        '
        'btLuu
        '
        Me.btLuu.Location = New System.Drawing.Point(37, 61)
        Me.btLuu.Name = "btLuu"
        Me.btLuu.Size = New System.Drawing.Size(53, 31)
        Me.btLuu.TabIndex = 2
        Me.btLuu.Text = "Lưu"
        Me.btLuu.UseVisualStyleBackColor = True
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(152, 61)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(53, 31)
        Me.btThoat.TabIndex = 3
        Me.btThoat.Text = "Đóng"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'frmThayDoiQuyDInh
        '
        Me.AcceptButton = Me.btLuu
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 96)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btLuu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTiepNhanToiDa)
        Me.Name = "frmThayDoiQuyDInh"
        Me.Text = "Thay Đổi Quy Định"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTiepNhanToiDa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btLuu As Button
    Friend WithEvents btThoat As Button
End Class
