Public Class dgvChiTietSuaChua
    Private imachitietsuachua As Integer
    Private imaphieusuachua As Integer
    Private imaphutung As Integer
    Private strtenphutung As String
    Private isoluong As Integer
    Private idongia As Integer
    Private itiencong As Integer
    Public Sub New()

    End Sub

    Public Sub New(machitietsuachua As Integer, maphieusuachua As Integer, maphutung As Integer, tenphutung As String, soluong As Integer, dongia As Integer, tiencong As Integer)
        Me.imachitietsuachua = machitietsuachua
        Me.imaphieusuachua = maphieusuachua
        Me.imaphutung = maphutung
        Me.strtenphutung = tenphutung
        Me.isoluong = soluong
        Me.idongia = dongia
        Me.itiencong = tiencong
    End Sub



    Public Property maphutung As Integer
        Get
            Return imaphutung
        End Get
        Set(value As Integer)
            imaphutung = value
        End Set
    End Property

    Public Property soluong As Integer
        Get
            Return isoluong
        End Get
        Set(value As Integer)
            isoluong = value
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

    Public Property tiencong As Integer
        Get
            Return itiencong
        End Get
        Set(value As Integer)
            itiencong = value
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

    Public Property maphieusuachua As Integer
        Get
            Return imaphieusuachua
        End Get
        Set(value As Integer)
            imaphieusuachua = value
        End Set
    End Property

    Public Property machitietsuachua As Integer
        Get
            Return imachitietsuachua
        End Get
        Set(value As Integer)
            imachitietsuachua = value
        End Set
    End Property
End Class
