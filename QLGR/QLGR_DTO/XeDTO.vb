Public Class XeDTO
    Private imaxe As Integer
    Private imahieuxe As Integer
    Private strmachuxe As Integer
    Private strbienso As String


    Public Sub New()

    End Sub

    Public Sub New(maxe As Integer, mahieuxe As Integer, machuxe As Integer, bienso As String)
        Me.imaxe = maxe
        Me.imahieuxe = mahieuxe
        Me.strmachuxe = machuxe
        Me.strbienso = bienso

    End Sub

    Public Property bienso As String
        Get
            Return strbienso
        End Get
        Set(value As String)
            strbienso = value
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

    Public Property machuxe As Integer
        Get
            Return strmachuxe
        End Get
        Set(value As Integer)
            strmachuxe = value
        End Set
    End Property
End Class
