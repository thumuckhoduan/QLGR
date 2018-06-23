Public Class ChiTietDoanhSoDTO
    Private imachitiet As Integer
    Private imadoanhso As Integer
    Private imahieuxe As Integer
    Private isoluotsua As Integer
    Private ithanhtien As Integer
    Private stile As Single


    Public Sub New()

    End Sub

    Public Sub New(machitiet As Integer, madoanhso As Integer, mahieuxe As Integer, soluotsua As Integer, thanhtien As Integer, tongdoanhthu As Single)
        Me.imachitiet = machitiet
        Me.imadoanhso = madoanhso
        Me.imahieuxe = mahieuxe
        Me.isoluotsua = soluotsua
        Me.ithanhtien = thanhtien
        Me.stile = tile
    End Sub

    Public Property machitiet As Integer
        Get
            Return imachitiet
        End Get
        Set(value As Integer)
            imachitiet = value
        End Set
    End Property

    Public Property madoanhso As Integer
        Get
            Return imadoanhso
        End Get
        Set(value As Integer)
            imadoanhso = value
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

    Public Property soluotsua As Integer
        Get
            Return isoluotsua
        End Get
        Set(value As Integer)
            isoluotsua = value
        End Set
    End Property

    Public Property thanhtien As Integer
        Get
            Return ithanhtien
        End Get
        Set(value As Integer)
            ithanhtien = value
        End Set
    End Property

    Public Property tile As Single
        Get
            Return stile
        End Get
        Set(value As Single)
            stile = value
        End Set
    End Property
End Class
