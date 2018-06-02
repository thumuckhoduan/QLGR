Public Class PhieuThuTienDTO
    Private imaphieuthu As Integer
    Private imaxe As Integer
    Private dtpngaythu As DateTime
    Private strsotienthu As String

    Public Sub New()

    End Sub

    Public Sub New(maphieuthu As Integer, maxe As Integer, ngaythu As DateTime, sotienthu As String)
        Me.imaphieuthu = maphieuthu
        Me.imaxe = maxe
        Me.dtpngaythu = ngaythu
        Me.strsotienthu = sotienthu
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

    Public Property ngaythu As DateTime
        Get
            Return dtpngaythu
        End Get
        Set(value As DateTime)
            dtpngaythu = value
        End Set
    End Property

    Public Property sotienthu As String
        Get
            Return strsotienthu
        End Get
        Set(value As String)
            strsotienthu = value
        End Set
    End Property
End Class
