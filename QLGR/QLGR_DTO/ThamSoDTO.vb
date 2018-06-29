Public Class ThamSoDTO
    Private itiepnhantoida As Integer

    Public Sub New()

    End Sub

    Public Sub New(tiepnhantoida As Integer)
        Me.itiepnhantoida = tiepnhantoida
    End Sub

    Public Property tiepnhantoida As Integer
        Get
            Return itiepnhantoida
        End Get
        Set(value As Integer)
            itiepnhantoida = value
        End Set
    End Property
End Class
