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
                    Dim idOnDB As String
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("maphutung")
                        End While
                    End If
                    nextMPT = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    nextMPT = 1
                    Return New Result(False, "Lấy ID kế tiếp của phụ tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(s As phutungDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhuTung] ([maphutung], [tenphutung],[soluongton],[dongia])"
        query &= "VALUES (@maphutung,@tenphutung,@soluongton,@dongia)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphutung", s.maphutung)
                    .Parameters.AddWithValue("@tenphutung", s.tenphutung)
                    .Parameters.AddWithValue("@soluongton", s.soluongton)
                    .Parameters.AddWithValue("@dongia", s.dongia)
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
    Public Function delete(maphutung As String) As Result

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
        query &= " SELECT [maphutung], [tenphutung],[soluongton],[dongia]"
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
                            listphutung.Add(New PhuTungDTO(reader("maphutung"), reader("tenphutung"), reader("soluongton"), reader("dongia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả phụ tùng không thành công", ex.StackTrace)
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
        query &= " ,[dongia] = @dongia "
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
                    .Parameters.AddWithValue("@dongia", phutung.dongia)
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

    Public Function kiemtra(maphutung As String, ByRef test As Boolean) As Result
        Dim query As String = String.Empty
        query &= " SELECT count(*) As [count]"
        query &= " FROM [tblPhuTung]"
        query &= " WHERE [maphutung]=@maphutung"


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
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Dim x = reader("count")
                            If (x > 0) Then
                            Else
                                test = False
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

    Public Function selectAll_sorttenphutung(ByRef listphutung As List(Of PhuTungDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maphutung], [tenphutung],[soluongton],[dongia]"
        query &= " FROM [tblPhuTung]"
        query &= " ORDER by [tenphutung]"


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
                            listphutung.Add(New PhuTungDTO(reader("maphutung"), reader("tenphutung"), reader("soluongton"), reader("dongia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả phụ tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function select_bymaphutung(maphutung As String, ByRef phutung As PhuTungDTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maphutung], [tenphutung],[soluongton],[dongia]"
        query &= " FROM [tblPhuTung]"
        query &= " WHERE [maphutung]=@maphutung"


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
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            phutung = New PhuTungDTO(reader("maphutung"), reader("tenphutung"), reader("soluongton"), reader("dongia"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả phụ tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function select_bytenphutung(tenphutung As String, ByRef phutung As PhuTungDTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maphutung], [tenphutung],[soluongton],[dongia]"
        query &= " FROM [tblPhuTung]"
        query &= " WHERE [tenphutung]=@tenphutung"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tenphutung", tenphutung)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            phutung = New PhuTungDTO(reader("maphutung"), reader("tenphutung"), reader("soluongton"), reader("dongia"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả phụ tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class