Public Class dgvChiTietSuaChua
    Private imachitietsuachua As Integer
    Private imaphieusuachua As Integer
    Private imaphutung As String
    Private strtenphutung As String
    Private isoluong As Integer
    Private idongia As Integer
    Private itiencong As Integer
    Public Sub New()

    End Sub

    Public Sub New(machitietsuachua As Integer, maphieusuachua As Integer, maphutung As String, tenphutung As String, soluong As Integer, dongia As Integer, tiencong As Integer)
        Me.imachitietsuachua = machitietsuachua
        Me.imaphieusuachua = maphieusuachua
        Me.imaphutung = maphutung
        Me.strtenphutung = tenphutung
        Me.isoluong = soluong
        Me.idongia = dongia
        Me.itiencong = tiencong
    End Sub



    Public Property maphutung As String
        Get
            Return imaphutung
        End Get
        Set(value As String)
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
