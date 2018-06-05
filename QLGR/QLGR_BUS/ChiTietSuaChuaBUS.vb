﻿Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class ChiTietSuaChuaBUS
    Private ChiTietSuaChuaDAL As ChiTietSuaChuaDAL
    Public Sub New()
        ChiTietSuaChuaDAL = New ChiTietSuaChuaDAL()
    End Sub
    Public Sub New(connectionString As String)
        ChiTietSuaChuaDAL = New ChiTietSuaChuaDAL(connectionString)
    End Sub
    Public Function insert(s As ChiTietSuaChuaDTO) As Result
        Return ChiTietSuaChuaDAL.insert(s)
    End Function
    Public Function buildMaChiTietSuaChua(ByRef nextMPSC As Integer) As Result
        Return ChiTietSuaChuaDAL.buildMachitietsuachua(nextMPSC)
    End Function
    Public Function selectAll(ByRef listchitietsuachua As List(Of ChiTietSuaChuaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChiTietSuaChuaDAL.selectALL(listchitietsuachua)
    End Function
    Public Function update(chitietsuachuaDTO As ChiTietSuaChuaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChiTietSuaChuaDAL.update(chitietsuachuaDTO)
    End Function
    Public Function delete(machitietsuachua As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ChiTietSuaChuaDAL.delete(machitietsuachua)
    End Function
End Class
