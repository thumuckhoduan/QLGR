Public Class TimKiemDTO
    Private strchuxe As String
    Private strhieuxe As String
    Private strbienso As String
    Private itienno As Integer
    Public Sub New(chuxe As String, hieuxe As String, bienso As String, tienno As Integer)
        Me.strchuxe = chuxe
        Me.strhieuxe = hieuxe
        Me.strbienso = bienso
        Me.itienno = tienno
    End Sub
    Public Property chuxe As String
        Get
            Return strchuxe
        End Get
        Set(value As String)
            strchuxe = value
        End Set
    End Property
    Public Property hieuxe As String
        Get
            Return strhieuxe
        End Get
        Set(value As String)
            strhieuxe = value
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
    Public Property tienno As Integer
        Get
            Return itienno
        End Get
        Set(value As Integer)
            itienno = value
        End Set
    End Property
End Class
