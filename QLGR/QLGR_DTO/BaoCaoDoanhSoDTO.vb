Public Class BaoCaoDoanhSoDTO
    Private imadoanhso As Integer
    Private ithang As Integer
    Private inam As Integer
    Private itongdoanhthu As Integer
    Private dtpngaytao As DateTime


    Public Sub New()

    End Sub

    Public Sub New(madoanhso As Integer, thang As Integer, nam As Integer, tongdoanhthu As Integer, ngaytao As DateTime)
        Me.imadoanhso = madoanhso
        Me.ithang = thang
        Me.inam = nam
        Me.itongdoanhthu = tongdoanhthu
        Me.dtpngaytao = ngaytao
    End Sub

    Public Property thang As Integer
        Get
            Return ithang
        End Get
        Set(value As Integer)
            ithang = value
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

    Public Property tongdoanhthu As Integer
        Get
            Return itongdoanhthu
        End Get
        Set(value As Integer)
            itongdoanhthu = value
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
