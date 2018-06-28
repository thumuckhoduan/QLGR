Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility

Public Class TaiKhoanDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(s As TaiKhoanDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblTaiKhoan] ([taikhoan], [matkhau], [quyen]) "
        query &= "VALUES (@taikhoan,@matkhau,@quyen)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@taikhoan", s.taikhoan)
                    .Parameters.AddWithValue("@matkhau", s.matkhau)
                    .Parameters.AddWithValue("@quyen", s.quyen)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Tài khoản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function get_maquyen(ByRef s As TaiKhoanDTO) As Result

        Dim query As String = String.Empty
        query &= "SELECT [quyen] "
        query &= "FROM [tblTaiKhoan] "
        query &= "WHERE [taikhoan]=@taikhoan "
        query &= "AND [matkhau]=@matkhau"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@taikhoan", s.taikhoan)
                    .Parameters.AddWithValue("@matkhau", s.matkhau)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            s.quyen = reader("quyen")
                        End While
                    Else
                        s.quyen = ""
                    End If
                Catch ex As Exception
                    conn.Close()
                    s.quyen = ""
                    Return New Result(False, "EEROR", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class


