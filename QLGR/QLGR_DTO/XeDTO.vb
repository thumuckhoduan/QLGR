Public Class XeDTO
    Private imaxe As Integer
    Private imahieuxe As Integer
    Private strchuxe As String
    Private strbienso As String
    Private strdiachi As String
    Private strdienthoai As String

    Public Sub New()

    End Sub

    Public Sub New(maxe As Integer, mahieuxe As Integer, chuxe As String, bienso As String, diachi As String, dienthoai As String)
        Me.imaxe = maxe
        Me.imahieuxe = mahieuxe
        Me.strchuxe = chuxe
        Me.strbienso = bienso
        Me.strdiachi = diachi
        Me.strdienthoai = dienthoai

    End Sub

    Public Property chuxe As String
        Get
            Return strchuxe
        End Get
        Set(value As String)
            strchuxe = value
        End Set
    End Property

    Public Property bienso As String
        Get
            Return strbienso
        End Get
        Set(value As String)
            strbienso = value
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

    Public Property dienthoai As String
        Get
            Return strdienthoai
        End Get
        Set(value As String)
            strdienthoai = value
        End Set
    End Property

    Public Property maxe As Integer
        Get
            Return imaxe
        End Get
        Set(value As Integer)
            imaxe = value
        End Set
    End Property

    Public Property mahieuxe As Integer
        Get
            Return imahieuxe
        End Get
        Set(value As Integer)
            imahieuxe = value
        End Set
    End Property
End Class
