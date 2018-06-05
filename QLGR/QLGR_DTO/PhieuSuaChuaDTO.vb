Public Class PhieuSuaChuaDTO
    Private imaphieusuachua As Integer
    Private imaxe As Integer
    Private strnoidung As String
    Private ithanhtien As Integer

    Public Sub New()

    End Sub

    Public Sub New(maphieusuachua As Integer, noidung As String, maxe As Integer, thanhtien As Integer)
        Me.imaphieusuachua = maphieusuachua
        Me.strnoidung = noidung
        Me.imaxe = maxe
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

    Public Property maxe As Integer
        Get
            Return imaxe
        End Get
        Set(value As Integer)
            imaxe = value
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
