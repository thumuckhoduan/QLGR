<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhieuThuTien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuThuTien))
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTenChuXe = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSoTienThu = New System.Windows.Forms.TextBox()
        Me.dtpNgayThuTien = New System.Windows.Forms.DateTimePicker()
        Me.btLuu = New System.Windows.Forms.Button()
        Me.btDong = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbMaChuXe = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMaPhieuThuTien = New System.Windows.Forms.TextBox()
        Me.cbDiaChi = New System.Windows.Forms.ComboBox()
        Me.cbEmail = New System.Windows.Forms.ComboBox()
        Me.cbDienThoai = New System.Windows.Forms.ComboBox()
        Me.cbBienSo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.cbMaXe = New System.Windows.Forms.ComboBox()
        Me.cbTienNo = New System.Windows.Forms.ComboBox()
        Me.txtSoTienNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(201, 176)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.ReadOnly = True
        Me.txtDienThoai.Size = New System.Drawing.Size(187, 20)
        Me.txtDienThoai.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Họ và Tên"
        '
        'cbTenChuXe
        '
        Me.cbTenChuXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTenChuXe.FormattingEnabled = True
        Me.cbTenChuXe.Location = New System.Drawing.Point(201, 70)
        Me.cbTenChuXe.Name = "cbTenChuXe"
        Me.cbTenChuXe.Size = New System.Drawing.Size(187, 21)
        Me.cbTenChuXe.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Biển Số"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Điện Thoại"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(201, 124)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(187, 20)
        Me.txtEmail.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Số Tiền Thu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Ngày Thu Tiền"
        '
        'txtSoTienThu
        '
        Me.txtSoTienThu.Location = New System.Drawing.Point(201, 228)
        Me.txtSoTienThu.Name = "txtSoTienThu"
        Me.txtSoTienThu.Size = New System.Drawing.Size(187, 20)
        Me.txtSoTienThu.TabIndex = 10
        '
        'dtpNgayThuTien
        '
        Me.dtpNgayThuTien.Location = New System.Drawing.Point(201, 254)
        Me.dtpNgayThuTien.Name = "dtpNgayThuTien"
        Me.dtpNgayThuTien.Size = New System.Drawing.Size(187, 20)
        Me.dtpNgayThuTien.TabIndex = 11
        '
        'btLuu
        '
        Me.btLuu.Location = New System.Drawing.Point(120, 303)
        Me.btLuu.Name = "btLuu"
        Me.btLuu.Size = New System.Drawing.Size(75, 23)
        Me.btLuu.TabIndex = 12
        Me.btLuu.Text = "Lưu"
        Me.btLuu.UseVisualStyleBackColor = True
        '
        'btDong
        '
        Me.btDong.Location = New System.Drawing.Point(394, 302)
        Me.btDong.Name = "btDong"
        Me.btDong.Size = New System.Drawing.Size(75, 23)
        Me.btDong.TabIndex = 13
        Me.btDong.Text = "Đóng"
        Me.btDong.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(105, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Mã Chủ Xe"
        '
        'cbMaChuXe
        '
        Me.cbMaChuXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaChuXe.FormattingEnabled = True
        Me.cbMaChuXe.Location = New System.Drawing.Point(201, 43)
        Me.cbMaChuXe.Name = "cbMaChuXe"
        Me.cbMaChuXe.Size = New System.Drawing.Size(187, 21)
        Me.cbMaChuXe.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(105, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Mã Phiếu Thu"
        '
        'txtMaPhieuThuTien
        '
        Me.txtMaPhieuThuTien.Location = New System.Drawing.Point(201, 17)
        Me.txtMaPhieuThuTien.Name = "txtMaPhieuThuTien"
        Me.txtMaPhieuThuTien.ReadOnly = True
        Me.txtMaPhieuThuTien.Size = New System.Drawing.Size(187, 20)
        Me.txtMaPhieuThuTien.TabIndex = 17
        '
        'cbDiaChi
        '
        Me.cbDiaChi.FormattingEnabled = True
        Me.cbDiaChi.Location = New System.Drawing.Point(401, 150)
        Me.cbDiaChi.Name = "cbDiaChi"
        Me.cbDiaChi.Size = New System.Drawing.Size(68, 21)
        Me.cbDiaChi.TabIndex = 19
        '
        'cbEmail
        '
        Me.cbEmail.FormattingEnabled = True
        Me.cbEmail.Location = New System.Drawing.Point(401, 124)
        Me.cbEmail.Name = "cbEmail"
        Me.cbEmail.Size = New System.Drawing.Size(68, 21)
        Me.cbEmail.TabIndex = 20
        '
        'cbDienThoai
        '
        Me.cbDienThoai.FormattingEnabled = True
        Me.cbDienThoai.Location = New System.Drawing.Point(401, 176)
        Me.cbDienThoai.Name = "cbDienThoai"
        Me.cbDienThoai.Size = New System.Drawing.Size(68, 21)
        Me.cbDienThoai.TabIndex = 21
        '
        'cbBienSo
        '
        Me.cbBienSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBienSo.FormattingEnabled = True
        Me.cbBienSo.Location = New System.Drawing.Point(201, 97)
        Me.cbBienSo.Name = "cbBienSo"
        Me.cbBienSo.Size = New System.Drawing.Size(187, 21)
        Me.cbBienSo.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(105, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Địa Chỉ"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(201, 150)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(187, 20)
        Me.txtDiaChi.TabIndex = 23
        '
        'cbMaXe
        '
        Me.cbMaXe.FormattingEnabled = True
        Me.cbMaXe.Location = New System.Drawing.Point(401, 97)
        Me.cbMaXe.Name = "cbMaXe"
        Me.cbMaXe.Size = New System.Drawing.Size(68, 21)
        Me.cbMaXe.TabIndex = 25
        '
        'cbTienNo
        '
        Me.cbTienNo.FormattingEnabled = True
        Me.cbTienNo.Location = New System.Drawing.Point(401, 201)
        Me.cbTienNo.Name = "cbTienNo"
        Me.cbTienNo.Size = New System.Drawing.Size(68, 21)
        Me.cbTienNo.TabIndex = 26
        '
        'txtSoTienNo
        '
        Me.txtSoTienNo.Location = New System.Drawing.Point(201, 202)
        Me.txtSoTienNo.Name = "txtSoTienNo"
        Me.txtSoTienNo.ReadOnly = True
        Me.txtSoTienNo.Size = New System.Drawing.Size(187, 20)
        Me.txtSoTienNo.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(105, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Số Tiền Nợ"
        '
        'frmPhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 345)
        Me.Controls.Add(Me.txtSoTienNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbTienNo)
        Me.Controls.Add(Me.cbMaXe)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.cbBienSo)
        Me.Controls.Add(Me.cbDienThoai)
        Me.Controls.Add(Me.cbEmail)
        Me.Controls.Add(Me.cbDiaChi)
        Me.Controls.Add(Me.txtMaPhieuThuTien)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbMaChuXe)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btDong)
        Me.Controls.Add(Me.btLuu)
        Me.Controls.Add(Me.dtpNgayThuTien)
        Me.Controls.Add(Me.txtSoTienThu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTenChuXe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPhieuThuTien"
        Me.Text = "Phiếu Thu Tiền"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbTenChuXe As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSoTienThu As TextBox
    Friend WithEvents dtpNgayThuTien As DateTimePicker
    Friend WithEvents btLuu As Button
    Friend WithEvents btDong As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cbMaChuXe As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMaPhieuThuTien As TextBox
    Friend WithEvents cbDiaChi As ComboBox
    Friend WithEvents cbEmail As ComboBox
    Friend WithEvents cbDienThoai As ComboBox
    Friend WithEvents cbBienSo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents cbMaXe As ComboBox
    Friend WithEvents cbTienNo As ComboBox
    Friend WithEvents txtSoTienNo As TextBox
    Friend WithEvents Label10 As Label
End Class
