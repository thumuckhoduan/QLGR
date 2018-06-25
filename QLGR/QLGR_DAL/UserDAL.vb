Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility

Public Class UserDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(s As UserDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblUser] ([username], [password], [permissions]) "
        query &= "VALUES (@username,@password,@permissions)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@username", s.username)
                    .Parameters.AddWithValue("@password", s.password)
                    .Parameters.AddWithValue("@permissions", s.permissions)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm User không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function get_permissions(ByRef s As UserDTO) As Result

        Dim query As String = String.Empty
        query &= "SELECT [permissions] "
        query &= "FROM [tblUser] "
        query &= "WHERE [username]=@username "
        query &= "AND [password]=@password"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@username", s.username)
                    .Parameters.AddWithValue("@password", s.password)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            s.permissions = reader("permissions")
                        End While
                    Else
                        s.permissions = -1
                    End If
                Catch ex As Exception
                    conn.Close()
                    s.permissions = -2
                    Return New Result(False, "EEROR", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class


