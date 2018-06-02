Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class PhuTungDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildmaphutung(ByRef nextMPT As String) As Result 'ex: 18222229

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maphutung] "
        query &= "FROM [tblPhuTung] "
        query &= "ORDER BY [maphutung] DESC "

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
                            idOnDB = reader("maphutung")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMPT = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMPT = 1
                    Return New Result(False, "Lấy ID kế tiếp của phụ tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(s As phutungDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhuTung] ([maphutung], [tenphutung],[soluongton])"
        query &= "VALUES (@maphutung,@tenphutung,@soluongton)"

        'get MSHS
        Dim nextMHX = "1"
        buildmaphutung(nextMHX)
        s.maphutung = nextMHX

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphutung", s.maphutung)
                    .Parameters.AddWithValue("@tenphutung", s.tenphutung)
                    .Parameters.AddWithValue("@soluongton", s.soluongton)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm phụ tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(maphutung As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblPhuTung] "
        query &= " WHERE "
        query &= " [maphutung] = @maphutung "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphutung", maphutung)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Phụ Tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function selectALL(ByRef listphutung As List(Of phutungDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maphutung], [tenphutung],[soluongton]"
        query &= " FROM [tblPhuTung]"


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
                        listphutung.Clear()
                        While reader.Read()
                            listphutung.Add(New phutungDTO(reader("maphutung"), reader("tenphutung"), reader("soluongton")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại phụ tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(phutung As phutungDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblPhuTung] SET"
        query &= " [tenphutung] = @tenphutung "
        query &= " ,[soluongton] = @soluongton "
        query &= "WHERE "
        query &= " [maphutung] = @maphutung "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphutung", phutung.maphutung)
                    .Parameters.AddWithValue("@tenphutung", phutung.tenphutung)
                    .Parameters.AddWithValue("@soluongton", phutung.soluongton)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật phụ tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class