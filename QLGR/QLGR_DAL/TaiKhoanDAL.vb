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

    Public Function get_quyen(ByRef taikhoanDTO As TaiKhoanDTO) As Result

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
                    .Parameters.AddWithValue("@taikhoan", taikhoanDTO.taikhoan)
                    .Parameters.AddWithValue("@matkhau", taikhoanDTO.matkhau)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            taikhoanDTO.quyen = reader("quyen")
                        End While
                    Else
                        taikhoanDTO.quyen = ""
                    End If
                Catch ex As Exception
                    conn.Close()
                    taikhoanDTO.quyen = ""
                    Return New Result(False, "EEROR", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function kiemtra(taikhoanDTO As TaiKhoanDTO, ByRef test As Boolean) As Result
        Dim query As String = String.Empty
        query &= "SELECT count(*) As [count] "
        query &= "FROM [tblTaiKhoan] "
        query &= "WHERE [taikhoan]=@taikhoan "
        query &= "AND [matkhau]=@matkhau"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@taikhoan", taikhoanDTO.taikhoan)
                    .Parameters.AddWithValue("@matkhau", taikhoanDTO.matkhau)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Dim x = reader("count")
                            If (x = 0) Then
                                test = True
                            Else
                                test = False
                            End If
                        End While
                    Else
                    End If
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "EEROR", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function update_matkhau(ByRef taikhoanDTO As TaiKhoanDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblTaiKhoan] SET"
        query &= " [matkhau] = @matkhau "
        query &= "WHERE "
        query &= " [taikhoan] = @taikhoan "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@taikhoan", taikhoanDTO.taikhoan)
                    .Parameters.AddWithValue("@matkhau", taikhoanDTO.matkhau)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "EEROR", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function delete(taikhoan As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblTaiKhoan] "
        query &= " WHERE "
        query &= " [taikhoan] = @taikhoan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@taikhoan", taikhoan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Tài Khoản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listtaikhoan As List(Of TaiKhoanDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [taikhoan], [matkhau], [quyen] "
        query &= " FROM [tblTaiKhoan]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listtaikhoan.Clear()
                        While reader.Read()
                            listtaikhoan.Add(New TaiKhoanDTO(reader("taikhoan"), reader("matkhau"), reader("quyen")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả tài khoản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(ByRef taikhoanDTO As TaiKhoanDTO, taikhoan As String) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblTaiKhoan] SET"
        query &= " [taikhoan] = @newtaikhoan "
        query &= " ,[matkhau] = @newmatkhau "
        query &= " ,[quyen] = @newquyen "
        query &= "WHERE "
        query &= " [taikhoan] = @taikhoan "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@newtaikhoan", taikhoanDTO.taikhoan)
                    .Parameters.AddWithValue("@newmatkhau", taikhoanDTO.matkhau)
                    .Parameters.AddWithValue("@newquyen", taikhoanDTO.quyen)
                    .Parameters.AddWithValue("@taikhoan", taikhoan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "EEROR", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class


