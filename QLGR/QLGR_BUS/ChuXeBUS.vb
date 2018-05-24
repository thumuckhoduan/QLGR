﻿Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class ChuXeBUS
    Private ChuXeDAL As ChuXeDAL
    Public Sub New()
        ChuXeDAL = New ChuXeDAL()
    End Sub
    Public Sub New(connectionString As String)
        ChuXeDAL = New ChuXeDAL(connectionString)
    End Sub
    Public Function insert(s As ChuXeDTO) As Result
        Return ChuXeDAL.insert(s)
    End Function
    Public Function buildMaChuXe(ByRef nextMCX As Integer) As Result
        Return ChuXeDAL.buildmachuxe(nextMCX)
    End Function
    Public Function selectAll(ByRef listChuXe As List(Of ChuXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChuXeDAL.selectALL(listChuXe)
    End Function
    Public Function update(ChuXeDTO As ChuXeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChuXeDAL.update(ChuXeDTO)
    End Function
    Public Function delete(machuxe As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChuXeDAL.delete(machuxe)
    End Function
    Public Function selectallby_tienno(tiennomin As Integer, tiennomax As Integer, ByRef listChuXe As List(Of ChuXeDTO)) As Result
        Return ChuXeDAL.selectallby_tienno(tiennomin, tiennomax, listChuXe)
    End Function
    Public Function selectallby_chuxe(tenchuxe As String, ByRef listChuXe As List(Of ChuXeDTO)) As Result
        Return ChuXeDAL.selectallby_chuxe(tenchuxe, listChuXe)
    End Function
End Class
