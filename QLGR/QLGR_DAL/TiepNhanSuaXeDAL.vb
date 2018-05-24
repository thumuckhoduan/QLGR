Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class TiepNhanSuaXeDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMaSuaXe(ByRef nextMSX As String) As Result 'ex: 18222229
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [masuaxe] "
        query &= "FROM [tblTiepNhanSuaXe] "
        query &= "ORDER BY [masuaxe] DESC "

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
                            idOnDB = reader("masuaxe")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMSX = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMSX = 1
                    Return New Result(False, "Lấy ID kế tiếp của mã sữa xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(s As TiepNhanSuaXeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblTiepNhanSuaXe] ([masuaxe], [maxe], [ngaytiepnhan])"
        query &= "VALUES (@masuaxe,@maxe,@ngaytiepnhan)"

        'get MS
        Dim nextMSX = "1"
        buildMaSuaXe(nextMSX)
        s.masuaxe = nextMSX

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masuaxe", s.masuaxe)
                    .Parameters.AddWithValue("@maxe", s.maxe)
                    .Parameters.AddWithValue("@ngaytiepnhan", s.ngaytiepnhan)
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

    Public Function selectALL(ByRef listsuaxe As List(Of TiepNhanSuaXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [masuaxe],[maxe],[ngaytiepnhan]"
        query &= " FROM [tblTiepNhanSuaXe]"


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
                            listsuaxe.Add(New TiepNhanSuaXeDTO(reader("masuaxe"), reader("maxe"), reader("ngaytiepnhan")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả đơn sữa xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(suaxeDTO As TiepNhanSuaXeDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblTiepNhanSuaXe] SET"
        query &= " [ngaytiepnhan] = @ngaytiepnhan "
        'cách?
        query &= "WHERE "
        query &= " [masuaxe] = @masuaxe"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masuaxe", suaxeDTO.masuaxe)
                    .Parameters.AddWithValue("@ngaytiepnhan", suaxeDTO.ngaytiepnhan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Cập nhật sữa xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) 
    End Function
    Public Function delete(masuaxe As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblTiepNhanSuaXe] "
        query &= " WHERE "
        query &= " [masuaxe] = @masuaxe "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masuaxe", masuaxe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa đơn sữa xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function demdonsuaxe(ngaytiepnhan As Date, ByRef dem As Integer) As Result
        Dim query As String = String.Empty
        query &= "SELECT COUNT(*) AS [count]"
        query &= " FROM [tblTiepNhanSuaXe] "
        query &= " WHERE "
        query &= " Year([ngaytiepnhan]) =@nam "
        query &= "AND Month([ngaytiepnhan])=@thang "
        query &= "AND Day([ngaytiepnhan])=@ngay "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@nam", ngaytiepnhan.Year)
                    .Parameters.AddWithValue("@thang", ngaytiepnhan.Month)
                    .Parameters.AddWithValue("@ngay", ngaytiepnhan.Day)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("count")
                        End While
                    End If
                    dem = idOnDB
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Đã Full", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
