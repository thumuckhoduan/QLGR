Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class PhuTungBUS
    Private phutungDAL As PhuTungDAL
    Public Sub New()
        phutungDAL = New phutungDAL()
    End Sub
    Public Sub New(connectionString As String)
        phutungDAL = New phutungDAL(connectionString)
    End Sub
    Public Function insert(s As phutungDTO) As Result
        Return phutungDAL.insert(s)
    End Function
    Public Function selectAll(ByRef listphutung As List(Of phutungDTO)) As Result

        Return phutungDAL.selectALL(listphutung)
    End Function
    Public Function buildmaphutung(ByRef nextMPT As Integer) As Result
        Return phutungDAL.buildmaphutung(nextMPT)
    End Function
    Public Function delete(maphutung As Integer) As Result
        Return phutungDAL.delete(maphutung)
    End Function
    Public Function update(phutung As phutungDTO) As Result
        Return phutungDAL.update(phutung)
    End Function
End Class
