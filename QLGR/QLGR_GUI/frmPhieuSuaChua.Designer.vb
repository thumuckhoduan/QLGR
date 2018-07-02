<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhieuSuaChua
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuSuaChua))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaPhieuSuaChua = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btLuu = New System.Windows.Forms.Button()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.cbBienSo = New System.Windows.Forms.ComboBox()
        Me.txtNoiDung = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbMaXe = New System.Windows.Forms.ComboBox()
        Me.cbMaChuXe = New System.Windows.Forms.ComboBox()
        Me.dtpNgaySuaChua = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btChiTietSuaChua = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTenChuXe = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu Sửa Chữa"
        '
        'txtMaPhieuSuaChua
        '
        Me.txtMaPhieuSuaChua.Location = New System.Drawing.Point(129, 32)
        Me.txtMaPhieuSuaChua.Name = "txtMaPhieuSuaChua"
        Me.txtMaPhieuSuaChua.ReadOnly = True
        Me.txtMaPhieuSuaChua.Size = New System.Drawing.Size(200, 20)
        Me.txtMaPhieuSuaChua.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Biển Số"
        '
        'btLuu
        '
        Me.btLuu.Location = New System.Drawing.Point(61, 190)
        Me.btLuu.Name = "btLuu"
        Me.btLuu.Size = New System.Drawing.Size(66, 29)
        Me.btLuu.TabIndex = 25
        Me.btLuu.Text = "Lưu"
        Me.btLuu.UseVisualStyleBackColor = True
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(332, 190)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(66, 29)
        Me.btThoat.TabIndex = 27
        Me.btThoat.Text = "Đóng"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'cbBienSo
        '
        Me.cbBienSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBienSo.FormattingEnabled = True
        Me.cbBienSo.Location = New System.Drawing.Point(129, 59)
        Me.cbBienSo.Name = "cbBienSo"
        Me.cbBienSo.Size = New System.Drawing.Size(200, 21)
        Me.cbBienSo.TabIndex = 30
        '
        'txtNoiDung
        '
        Me.txtNoiDung.Location = New System.Drawing.Point(129, 113)
        Me.txtNoiDung.Multiline = True
        Me.txtNoiDung.Name = "txtNoiDung"
        Me.txtNoiDung.Size = New System.Drawing.Size(200, 20)
        Me.txtNoiDung.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Nội Dung"
        '
        'cbMaXe
        '
        Me.cbMaXe.FormattingEnabled = True
        Me.cbMaXe.Location = New System.Drawing.Point(335, 59)
        Me.cbMaXe.Name = "cbMaXe"
        Me.cbMaXe.Size = New System.Drawing.Size(63, 21)
        Me.cbMaXe.TabIndex = 43
        '
        'cbMaChuXe
        '
        Me.cbMaChuXe.FormattingEnabled = True
        Me.cbMaChuXe.Location = New System.Drawing.Point(335, 86)
        Me.cbMaChuXe.Name = "cbMaChuXe"
        Me.cbMaChuXe.Size = New System.Drawing.Size(63, 21)
        Me.cbMaChuXe.TabIndex = 46
        '
        'dtpNgaySuaChua
        '
        Me.dtpNgaySuaChua.Location = New System.Drawing.Point(129, 139)
        Me.dtpNgaySuaChua.Name = "dtpNgaySuaChua"
        Me.dtpNgaySuaChua.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgaySuaChua.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Ngày Sửa Chữa"
        '
        'btChiTietSuaChua
        '
        Me.btChiTietSuaChua.Location = New System.Drawing.Point(173, 190)
        Me.btChiTietSuaChua.Name = "btChiTietSuaChua"
        Me.btChiTietSuaChua.Size = New System.Drawing.Size(111, 29)
        Me.btChiTietSuaChua.TabIndex = 65
        Me.btChiTietSuaChua.Text = "Chi Tiết Sửa Chữa"
        Me.btChiTietSuaChua.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tên Chủ Xe"
        '
        'cbTenChuXe
        '
        Me.cbTenChuXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTenChuXe.FormattingEnabled = True
        Me.cbTenChuXe.Location = New System.Drawing.Point(129, 86)
        Me.cbTenChuXe.Name = "cbTenChuXe"
        Me.cbTenChuXe.Size = New System.Drawing.Size(200, 21)
        Me.cbTenChuXe.TabIndex = 24
        '
        'frmPhieuSuaChua
        '
        Me.AcceptButton = Me.btLuu
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 231)
        Me.Controls.Add(Me.btChiTietSuaChua)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpNgaySuaChua)
        Me.Controls.Add(Me.cbMaChuXe)
        Me.Controls.Add(Me.cbMaXe)
        Me.Controls.Add(Me.txtNoiDung)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbBienSo)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btLuu)
        Me.Controls.Add(Me.cbTenChuXe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaPhieuSuaChua)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPhieuSuaChua"
        Me.Text = "Phiếu Sửa Chữa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaPhieuSuaChua As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btLuu As Button
    Friend WithEvents btThoat As Button
    Friend WithEvents cbBienSo As ComboBox
    Friend WithEvents txtNoiDung As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbMaXe As ComboBox
    Friend WithEvents cbMaChuXe As ComboBox
    Friend WithEvents dtpNgaySuaChua As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btChiTietSuaChua As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTenChuXe As ComboBox
End Class
