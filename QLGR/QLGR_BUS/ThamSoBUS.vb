Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class ThamSoBUS
    Private thamsoDAL As ThamSoDAL
    Public Sub New()
        thamsoDAL = New ThamSoDAL()
    End Sub
    Public Sub New(connectionString As String)
        thamsoDAL = New ThamSoDAL(connectionString)
    End Sub
    Public Function selectAll(ByRef thamso As ThamSoDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return thamsoDAL.selectAll(thamso)
    End Function
    Public Function update(thamsoDTO As ThamSoDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return thamsoDAL.update(thamsoDTO)
    End Function
End Class
