Imports QLGR_DTO

Public Class dgvbaocaodoanhso
    Private imahieuxe As Integer
    Private strtenhieuxe As String
    Private isoluotsua As Integer
    Private ithanhtien As Integer
    Private stile As Single
    Public Sub New()

    End Sub

    Public Sub New(mahieuxe As Integer, tenhieuxe As String, soluotsua As Integer, thanhtien As Integer, tile As Single)
        Me.strtenhieuxe = tenhieuxe
        Me.isoluotsua = soluotsua
        Me.ithanhtien = thanhtien
        Me.stile = tile
        Me.imahieuxe = mahieuxe
    End Sub
    Public Property tenhieuxe As String
        Get
            Return strtenhieuxe
        End Get
        Set(value As String)
            strtenhieuxe = value
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

    Public Property mahieuxe As Integer
        Get
            Return imahieuxe
        End Get
        Set(value As Integer)
            imahieuxe = value
        End Set
    End Property
End Class
