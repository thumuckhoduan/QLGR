Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class HieuXeDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMaHieuXe(ByRef nextMHX As String) As Result 'ex: 18222229

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [mahieuxe] "
        query &= "FROM [tblHieuXe] "
        query &= "ORDER BY [mahieuxe] DESC "

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
                            idOnDB = reader("mahieuxe")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMHX = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMHX = 1
                    Return New Result(False, "Lấy ID kế tiếp của hiệu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(s As HieuXeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblHieuXe] ([mahieuxe], [tenhieuxe])"
        query &= "VALUES (@mahieuxe,@tenhieuxe)"

        'get MSHS
        Dim nextMHX = "1"
        buildMaHieuXe(nextMHX)
        s.mahieuxe = nextMHX

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mahieuxe", s.mahieuxe)
                    .Parameters.AddWithValue("@tenhieuxe", s.tenhieuxe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm hiệu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(mahieuxe As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblHieuXe] "
        query &= " WHERE "
        query &= " [mahieuxe] = @mahieuxe "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mahieuxe", mahieuxe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Hiệu Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function selectALL(ByRef listhieuxe As List(Of HieuXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [mahieuxe], [tenhieuxe]"
        query &= " FROM [tblHieuXe]"


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
                        listhieuxe.Clear()
                        While reader.Read()
                            listhieuxe.Add(New HieuXeDTO(reader("mahieuxe"), reader("tenhieuxe")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại hiệu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(hieuxe As HieuXeDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblHieuXe] SET"
        query &= " [tenhieuxe] = @tenhieuxe "
        query &= "WHERE "
        query &= " [mahieuxe] = @mahieuxe "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mahieuxe", hieuxe.mahieuxe)
                    .Parameters.AddWithValue("@tenhieuxe", hieuxe.tenhieuxe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật hiệu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function change(hieuxe As HieuXeDTO) As Result
        Dim query As String = String.Empty
        query &= "SELECT [mahieuxe]"
        query &= "FROM [tblHieuXe]"
        query &= "WHERE"
        query &= "[tenhieuxe]=@tenhieuxe"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tenhieuxe", hieuxe.tenhieuxe)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("mahieuxe")
                        End While
                    End If
                    hieuxe.mahieuxe = idOnDB
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Lấy ID kế tiếp của hiệu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function select_byMaHieuXe(mahieuxe As Integer, ByRef hieuxeDTO As HieuXeDTO) As Result
        Dim query As String = String.Empty
        query &= " SELECT [mahieuxe], [tenhieuxe]"
        query &= " FROM [tblHieuXe]"
        query &= " WHERE [mahieuxe]=@mahieuxe"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mahieuxe", mahieuxe)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            hieuxeDTO = New HieuXeDTO(reader("mahieuxe"), reader("tenhieuxe"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy hiệu xe theo mã hiệu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function kiemtra(hieuxeDTO As HieuXeDTO) As Result
        Dim query As String = String.Empty
        query &= " SELECT count(*) As [count]"
        query &= " FROM [tblHieuXe]"
        query &= " WHERE [tenhieuxe]=@tenhieuxe"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tenhieuxe", hieuxeDTO.tenhieuxe)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Dim x = reader("count")
                            If (x > 0) Then
                            Else
                                hieuxeDTO.mahieuxe = 0
                            End If
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Kiểm Tra không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectAll_sortbytenhieuxe(ByRef listhieuxe As List(Of HieuXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [mahieuxe], [tenhieuxe]"
        query &= " FROM [tblHieuXe]"
        query &= " ORDER BY [tenhieuxe]"


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
                        listhieuxe.Clear()
                        While reader.Read()
                            listhieuxe.Add(New HieuXeDTO(reader("mahieuxe"), reader("tenhieuxe")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại hiệu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class

