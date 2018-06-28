Public Class TaiKhoanDTO
    Private strtaikhoan As String
    Private strmatkhau As String
    Private iquyen As String
    Public Sub New()

    End Sub

    Public Sub New(taikhoan As Integer, matkhau As Integer, quyen As String)
        Me.strtaikhoan = taikhoan
        Me.strmatkhau = matkhau
        Me.iquyen = quyen
    End Sub

    Public Property taikhoan As String
        Get
            Return strtaikhoan
        End Get
        Set(value As String)
            strtaikhoan = value
        End Set
    End Property

    Public Property matkhau As String
        Get
            Return strmatkhau
        End Get
        Set(value As String)
            strmatkhau = value
        End Set
    End Property

    Public Property quyen As String
        Get
            Return iquyen
        End Get
        Set(value As String)
            iquyen = value
        End Set
    End Property
End Class
