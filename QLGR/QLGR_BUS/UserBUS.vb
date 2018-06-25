Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class UserBUS
    Private userDAL As UserDAL

    Public Sub New()
        userDAL = New UserDAL()
    End Sub

    Public Sub New(connectionString As String)
        userDAL = New UserDAL(connectionString)
    End Sub

    Public Function insert(userDTO As UserDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return userDAL.insert(userDTO)
    End Function

    Public Function get_permissions(ByRef userDTO As UserDTO) As Result
        Return userDAL.get_permissions(userDTO)
    End Function
End Class
