Public Class PhieuSuaChuaDTO
    Private imaphieusuachua As Integer
    Private imasuaxe As Integer
    Private strnoidung As String
    Private ithanhtien As Integer

    Public Sub New()

    End Sub

    Public Sub New(maphieusuachua As Integer, noidung As String, masuaxe As Integer, thanhtien As Integer)
        Me.imaphieusuachua = maphieusuachua
        Me.strnoidung = noidung
        Me.imasuaxe = masuaxe
        Me.ithanhtien = thanhtien

    End Sub

    Public Property maphieusuachua As Integer
        Get
            Return imaphieusuachua
        End Get
        Set(value As Integer)
            imaphieusuachua = value
        End Set
    End Property

    Public Property masuaxe As Integer
        Get
            Return imasuaxe
        End Get
        Set(value As Integer)
            imasuaxe = value
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

    Public Property noidung As String
        Get
            Return strnoidung
        End Get
        Set(value As String)
            strnoidung = value
        End Set
    End Property
End Class
