﻿Public Class PhuTungDTO
    Private imaphutung As Integer
    Private strtenphutung As String
    Private isoluongton As Integer
    Private idongia As Integer
    Public Sub New()
    End Sub
    Public Sub New(maphutung As Integer, tenphutung As String, soluongton As Integer, dongia As Integer)
        Me.maphutung = maphutung
        Me.tenphutung = tenphutung
        Me.soluongton = soluongton
        Me.idongia = dongia
    End Sub

    Public Property maphutung As Integer
        Get
            Return imaphutung
        End Get
        Set(value As Integer)
            imaphutung = value
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
