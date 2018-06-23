Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class NhapPhuTungBUS
    Private NhapPhuTungDAL As NhapPhuTungDAL
    Public Sub New()
        NhapPhuTungDAL = New NhapPhuTungDAL()
    End Sub
    Public Sub New(connectionString As String)
        NhapPhuTungDAL = New NhapPhuTungDAL(connectionString)
    End Sub
    Public Function insert(s As NhapPhuTungDTO) As Result
        Return NhapPhuTungDAL.insert(s)
    End Function
    Public Function buildmanhapphutung(ByRef nextMNPT As Integer) As Result
        Return NhapPhuTungDAL.buildmanhapphutung(nextMNPT)
    End Function
    Public Function selectAll(ByRef listNhapPhuTung As List(Of NhapPhuTungDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return NhapPhuTungDAL.selectALL(listNhapPhuTung)
    End Function
    Public Function update(NhapPhuTungDTO As NhapPhuTungDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return NhapPhuTungDAL.update(NhapPhuTungDTO)
    End Function
    Public Function delete(manhapphutung As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return NhapPhuTungDAL.delete(manhapphutung)
    End Function
End Class
