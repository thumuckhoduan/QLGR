Public Class HieuXeDTO
    Private imahieuxe As Integer
    Private strtenhieuxe As String
    Public Sub New()
    End Sub

    Public Sub New(mahieuxe As Integer, tenhieuxe As String)
        Me.imahieuxe = mahieuxe
        Me.strtenhieuxe = tenhieuxe
    End Sub
    Property mahieuxe() As Integer
        Get
            Return imahieuxe
        End Get
        Set(ByVal Value As Integer)
            imahieuxe = Value
        End Set
    End Property
    Property tenhieuxe() As String
        Get
            Return strtenhieuxe
        End Get
        Set(ByVal Value As String)
            strtenhieuxe = Value
        End Set
    End Property
End Class
