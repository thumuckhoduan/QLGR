Public Class PhieuThuTienDTO
    Private imaphieuthu As Integer
    Private imaxe As Integer
    Private dtpngaythu As DateTime
    Private itienthu As String

    Public Sub New()

    End Sub

    Public Sub New(maphieuthu As Integer, maxe As Integer, ngaythu As String, tienthu As String)
        Me.imaphieuthu = maphieuthu
        Me.imaxe = maxe
        Me.dtpngaythu = ngaythu
        Me.itienthu = tienthu
    End Sub

    Public Property maphieuthu As Integer
        Get
            Return imaphieuthu
        End Get
        Set(value As Integer)
            imaphieuthu = value
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

    Public Property ngaythu As Date
        Get
            Return dtpngaythu
        End Get
        Set(value As Date)
            dtpngaythu = value
        End Set
    End Property

    Public Property tienthu As String
        Get
            Return itienthu
        End Get
        Set(value As String)
            itienthu = value
        End Set
    End Property
End Class
