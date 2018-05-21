Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class PhieuThuTienDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildmaphieuthu(ByRef nextMSX As String) As Result 'ex: 18222229
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maphieuthu] "
        query &= "FROM [tblChuXe] "
        query &= "ORDER BY [maphieuthu] DESC "

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
                            idOnDB = reader("maphieuthu")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMSX = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMSX = 1
                    Return New Result(False, "Lấy ID kế tiếp của mã phieu thu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(s As PhieuThuTienDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChuXe] ([maphieuthu], [maxe], [ngaythu], [sotienthu])"
        query &= "VALUES (@maphieuthu,@maxe,@ngaythu,@sotienthu)"

        'get MS
        Dim nextMPT = "1"
        buildmaphieuthu(nextMPT)
        s.maphieuthu = nextMPT

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieuthu", s.maphieuthu)
                    .Parameters.AddWithValue("@maxe", s.maxe)
                    .Parameters.AddWithValue("@ngaythu", s.ngaythu)
                    .Parameters.AddWithValue("@sotienthu", s.sotienthu)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm phieu thu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(maphieuthu As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblChuXe] "
        query &= " WHERE "
        query &= " [maphieuthu] = @maphieuthu "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieuthu", maphieuthu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa phieu thu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function selectALL(ByRef listsuaxe As List(Of PhieuThuTienDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maphieuthu], [maxe], [ngaythu], [sotienthu]"
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
                            listsuaxe.Add(New PhieuThuTienDTO(reader("maphieuthu"), reader("maxe"), reader("ngaythu"), reader("sotienthu")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả phieu thu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(suaxeDTO As PhieuThuTienDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblChuXe] SET"
        query &= " [maxe] = @maxe "
        query &= " ,[ngaythu] = @ngaythu "
        query &= " ,[sotienthu] = @sotienthu "
        'cách?
        query &= "WHERE "
        query &= " [maphieuthu] = @maphieuthu"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieuthu", suaxeDTO.maphieuthu)
                    .Parameters.AddWithValue("@maxe", suaxeDTO.maxe)
                    .Parameters.AddWithValue("@ngaythu", suaxeDTO.ngaythu)
                    .Parameters.AddWithValue("@sotienthu", suaxeDTO.sotienthu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Cập nhật phieu thu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function


End Class
