﻿Public Class NhapPhuTungDTO

    Private imanhapphutung As Integer
    Private imaphutung As Integer
    Private isoluong As Integer
    Private dtpngaytiepnhan As DateTime


    Public Sub New()

    End Sub

    Public Sub New(manhapphutung As Integer, maphutung As Integer, soluong As Integer, ngaytiepnhan As DateTime)
        Me.imanhapphutung = manhapphutung
        Me.imaphutung = maphutung
        Me.isoluong = soluong
        Me.dtpngaytiepnhan = ngaytiepnhan
    End Sub

    Public Property manhapphutung As Integer
        Get
            Return imanhapphutung
        End Get
        Set(value As Integer)
            imanhapphutung = value
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

    Public Property ngaytiepnhan As DateTime
        Get
            Return dtpngaytiepnhan
        End Get
        Set(value As DateTime)
            dtpngaytiepnhan = value
        End Set
    End Property

    Public Property maphutung As Integer
        Get
            Return imaphutung
        End Get
        Set(value As Integer)
            imaphutung = value
        End Set
    End Property
End Class