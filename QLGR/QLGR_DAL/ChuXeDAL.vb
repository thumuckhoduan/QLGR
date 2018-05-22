Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class ChuXeDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildmachuxe(ByRef nextMSX As Integer) As Result 'ex: 18222229
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [machuxe] "
        query &= "FROM [tblChuXe] "
        query &= "ORDER BY [machuxe] DESC "

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
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("machuxe")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMSX = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMSX = 1
                    Return New Result(False, "Lấy ID kế tiếp của mã chu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(s As ChuXeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChuXe] ([machuxe], [tenchuxe], [diachi], [dienthoai], [email], [tienno])"
        query &= "VALUES (@machuxe,@tenchuxe,@diachi,@dienthoai,@email,@tienno)"

        'get MS
        Dim nextMCX = "1"
        buildmachuxe(nextMCX)
        s.machuxe = nextMCX

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machuxe", s.machuxe)
                    .Parameters.AddWithValue("@tenchuxe", s.tenchuxe)
                    .Parameters.AddWithValue("@diachi", s.diachi)
                    .Parameters.AddWithValue("@dienthoai", s.dienthoai)
                    .Parameters.AddWithValue("@email", s.email)
                    .Parameters.AddWithValue("@tienno", s.tienno)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm chu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(machuxe As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblChuXe] "
        query &= " WHERE "
        query &= " [machuxe] = @machuxe "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machuxe", machuxe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa chu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function selectALL(ByRef listsuaxe As List(Of ChuXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [machuxe], [tenchuxe], [diachi], [dienthoai], [email], [tienno]"
        query &= " FROM [tblChuXe]"


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
                        listsuaxe.Clear()
                        While reader.Read()
                            listsuaxe.Add(New ChuXeDTO(reader("machuxe"), reader("tenchuxe"), reader("diachi"), reader("dienthoai"), reader("email"), reader("tienno")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả chu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(suaxeDTO As ChuXeDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblChuXe] SET"
        query &= " [tenchuxe] = @tenchuxe "
        query &= " ,[diachi] = @diachi "
        query &= " ,[dienthoai] = @dienthoai "
        query &= " ,[email] = @email "
        query &= " ,[tienno] = @tienno "
        'cách?
        query &= "WHERE "
        query &= " [machuxe] = @machuxe"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machuxe", suaxeDTO.machuxe)
                    .Parameters.AddWithValue("@tenchuxe", suaxeDTO.tenchuxe)
                    .Parameters.AddWithValue("@diachi", suaxeDTO.diachi)
                    .Parameters.AddWithValue("@dienthoai", suaxeDTO.dienthoai)
                    .Parameters.AddWithValue("@email", suaxeDTO.email)
                    .Parameters.AddWithValue("@tienno", suaxeDTO.tienno)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Cập nhật chu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function


End Class
