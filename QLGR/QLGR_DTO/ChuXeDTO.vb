Public Class ChuXeDTO

    Private imachuxe As Integer
    Private strtenchuxe As String
    Private strdienthoai As String
    Private strdiachi As String
    Private stremail As String
    Private itienno As String

    Public Sub New()

    End Sub

    Public Sub New(machuxe As Integer, tenchuxe As String, dienthoai As String, diachi As String, email As String, tienno As String)
        Me.imachuxe = machuxe
        Me.strtenchuxe = tenchuxe
        Me.strdiachi = diachi
        Me.strdienthoai = dienthoai
        Me.stremail = email
        Me.itienno = tienno
    End Sub

    Public Property machuxe As Integer
        Get
            Return imachuxe
        End Get
        Set(value As Integer)
            imachuxe = value
        End Set
    End Property

    Public Property tenchuxe As String
        Get
            Return strtenchuxe
        End Get
        Set(value As String)
            strtenchuxe = value
        End Set
    End Property

    Public Property dienthoai As String
        Get
            Return strdienthoai
        End Get
        Set(value As String)
            strdienthoai = value
        End Set
    End Property

    Public Property diachi As String
        Get
            Return strdiachi
        End Get
        Set(value As String)
            strdiachi = value
        End Set
    End Property

    Public Property email As String
        Get
            Return stremail
        End Get
        Set(value As String)
            stremail = value
        End Set
    End Property

    Public Property tienno As String
        Get
            Return itienno
        End Get
        Set(value As String)
            itienno = value
        End Set
    End Property
End Class
