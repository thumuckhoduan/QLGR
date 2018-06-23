Public Class BaoCaoTonDTO
    Private imabaocaoton As Integer
    Private ithang As Integer
    Private inam As Integer
    Private dtpngaytao As DateTime
    Public Sub New()

    End Sub
    Public Sub New(mabaocaoton As Integer, thang As Integer, nam As Integer, ngaytao As DateTime)
        Me.imabaocaoton = mabaocaoton
        Me.ithang = thang
        Me.inam = nam
        Me.dtpngaytao = ngaytao
    End Sub
    Public Property mabaocaoton As Integer
        Get
            Return imabaocaoton
        End Get
        Set(value As Integer)
            imabaocaoton = value
        End Set
    End Property

    Public Property thang As Integer
        Get
            Return ithang
        End Get
        Set(value As Integer)
            ithang = value
        End Set
    End Property

    Public Property nam As Integer
        Get
            Return inam
        End Get
        Set(value As Integer)
            inam = value
        End Set
    End Property

    Public Property ngaytao As Date
        Get
            Return dtpngaytao
        End Get
        Set(value As Date)
            dtpngaytao = value
        End Set
    End Property
End Class
