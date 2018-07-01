Public Class PhuTungDTO
    Private strmaphutung As String
    Private strtenphutung As String
    Private isoluongton As Integer
    Private idongia As Integer
    Public Sub New()
    End Sub
    Public Sub New(maphutung As String, tenphutung As String, soluongton As Integer, dongia As Integer)
        Me.strmaphutung = maphutung
        Me.strtenphutung = tenphutung
        Me.isoluongton = soluongton
        Me.idongia = dongia
    End Sub

    Public Property maphutung As String
        Get
            Return strmaphutung
        End Get
        Set(value As String)
            strmaphutung = value
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

    Public Property soluongton As Integer
        Get
            Return isoluongton
        End Get
        Set(value As Integer)
            isoluongton = value
        End Set
    End Property

    Public Property dongia As Integer
        Get
            Return idongia
        End Get
        Set(value As Integer)
            idongia = value
        End Set
    End Property
End Class
