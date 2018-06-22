Public Class ChiTietDoanhSoDTO
    Private imachitiet As Integer
    Private imadoanhso As Integer
    Private imahieuxe As Integer
    Private isoluotsua As Integer
    Private ithanhtien As Integer
    Private itile As Single


    Public Sub New()

    End Sub

    Public Sub New(machitiet As Integer, madoanhso As Integer, mahieuxe As Integer, soluotsua As Integer, thanhtien As Integer, tongdoanhthu As Single)
        Me.machitiet = machitiet
        Me.madoanhso = madoanhso
        Me.mahieuxe = mahieuxe
        Me.soluotsua = soluotsua
        Me.thanhtien = thanhtien
        Me.tile = tile
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
            Return itile
        End Get
        Set(value As Single)
            itile = value
        End Set
    End Property
End Class
