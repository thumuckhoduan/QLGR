Public Class dgvBaoCaoTonDTO
    Private imaphutung As String
    Private strtenphutung As String
    Private itondau As Integer
    Private inhapthem As Integer
    Private iban As Integer
    Private itoncuoi As Integer



    Public Sub New()

    End Sub

    Public Sub New(maphutung As String, tenphutung As String, tondau As Integer, nhapthem As Integer, ban As Integer, toncuoi As Integer)
        Me.imaphutung = maphutung
        Me.strtenphutung = tenphutung
        Me.itondau = tondau
        Me.inhapthem = nhapthem
        Me.iban = ban
        Me.itoncuoi = toncuoi
    End Sub

    Public Property maphutung As String
        Get
            Return imaphutung
        End Get
        Set(value As String)
            imaphutung = value
        End Set
    End Property

    Public Property tenphutung As String
        Get
            Return strtenphutung
        End Get
        Set(value As String)
            strtenphutung = value
        End Set
    End Property

    Public Property tondau As Integer
        Get
            Return itondau
        End Get
        Set(value As Integer)
            itondau = value
        End Set
    End Property

    Public Property nhapthem As Integer
        Get
            Return inhapthem
        End Get
        Set(value As Integer)
            inhapthem = value
        End Set
    End Property

    Public Property ban As Integer
        Get
            Return iban
        End Get
        Set(value As Integer)
            iban = value
        End Set
    End Property

    Public Property toncuoi As Integer
        Get
            Return itoncuoi
        End Get
        Set(value As Integer)
            itoncuoi = value
        End Set
    End Property

End Class
