﻿Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class XeBUS
    Private XeDAL As XeDAL
    Public Sub New()
        XeDAL = New XeDAL()
    End Sub
    Public Sub New(connectionString As String)
        XeDAL = New XeDAL(connectionString)
    End Sub
    Public Function insert(s As XeDTO) As Result
        Return XeDAL.insert(s)
    End Function
    Public Function buildMaXe(ByRef nextMX As Integer) As Result
        Return XeDAL.buildMaXe(nextMX)
    End Function
    Public Function selectAll(ByRef listXe As List(Of XeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return XeDAL.selectALL(listXe)
    End Function
    Public Function update(xeDTO As XeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return XeDAL.update(xeDTO)
    End Function
    Public Function delete(maxe As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return XeDAL.delete(maxe)
    End Function

End Class
