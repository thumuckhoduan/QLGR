Public Class TiepNhanSuaXeDTO
    Private imasuaxe As Integer
    Private imaxe As Integer
    Private dtpngaytiepnhan As DateTime

    Public Sub New()

    End Sub

    Public Sub New(masuaxe As Integer, maxe As Integer, ngaytiepnhan As DateTime)
        Me.imasuaxe = masuaxe
        Me.imaxe = maxe
        Me.dtpngaytiepnhan = ngaytiepnhan
    End Sub



    Public Property ngaytiepnhan As DateTime
        Get
            Return dtpngaytiepnhan
        End Get
        Set(value As DateTime)
            dtpngaytiepnhan = value
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

    Public Property maxe As Integer
        Get
            Return imaxe
        End Get
        Set(value As Integer)
            imaxe = value
        End Set
    End Property
End Class
