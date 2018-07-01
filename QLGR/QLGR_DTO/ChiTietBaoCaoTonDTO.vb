Public Class ChiTietBaoCaoTonDTO
    Private imachitietbaocaoton As Integer
    Private imabaocaoton As Integer
    Private imaphutung As String
    Private itondau As Integer
    Private inhapthem As Integer
    Private iban As Integer
    Private itoncuoi As Integer



    Public Sub New()

    End Sub

    Public Sub New(machitietbaocaoton As Integer, mabaocaoton As Integer, maphutung As String, tondau As Integer,
                   nhapthem As Integer, ban As Integer, toncuoi As Integer)
        Me.imachitietbaocaoton = machitietbaocaoton
        Me.imabaocaoton = mabaocaoton
        Me.imaphutung = maphutung
        Me.itondau = tondau
        Me.inhapthem = nhapthem
        Me.iban = ban
        Me.itoncuoi = toncuoi
    End Sub
    Public Property machitietbaocaoton As Integer
        Get
            Return imachitietbaocaoton
        End Get
        Set(value As Integer)
            imachitietbaocaoton = value
        End Set
    End Property

    Public Property mabaocaoton As Integer
        Get
            Return imabaocaoton
        End Get
        Set(value As Integer)
            imabaocaoton = value
        End Set
    End Property

    Public Property maphutung As Integer
        Get
            Return imaphutung
        End Get
        Set(value As Integer)
            imaphutung = value
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
