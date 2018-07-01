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
    Public Function buildMaChuXe(ByRef nextMNPT As Integer) As Result
        Return ChuXeDAL.buildmachuxe(nextMNPT)
    End Function
    Public Function selectAll(ByRef listChuXe As List(Of ChuXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChuXeDAL.selectALL(listChuXe)
    End Function
    Public Function select_byMaChuXe(machuxe As Integer, ByRef chuxeDTO As ChuXeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChuXeDAL.select_byMaChuXe(machuxe, chuxeDTO)
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
    Public Function selectAll_bybienso_sortbyTenChuXe(bienso As String, ByRef listChuXe As List(Of ChuXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChuXeDAL.selectAll_bybienso_sortbyTenChuXe(bienso, listChuXe)
    End Function
    Public Function kiemtra(ChuXeDTO As ChuXeDTO, ByRef test As Boolean) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChuXeDAL.kiemtra(ChuXeDTO, test)
    End Function
End Class
