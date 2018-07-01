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
    Public Function kiemtra(maphutung As Integer, ByRef test As Boolean) As Result
        Return phutungDAL.kiemtra(maphutung, test)
    End Function
    Public Function selectAll_sorttenphutung(ByRef listphutung As List(Of PhuTungDTO)) As Result
        Return phutungDAL.selectAll_sorttenphutung(listphutung)
    End Function
    Public Function select_bymaphutung(maphutung As String, ByRef phutung As PhuTungDTO) As Result

        Return phutungDAL.select_bymaphutung(maphutung, phutung)
    End Function
    Public Function select_bytenphutung(tenphutung As String, ByRef phutung As PhuTungDTO) As Result

        Return phutungDAL.select_bytenphutung(tenphutung, phutung)
    End Function
End Class
