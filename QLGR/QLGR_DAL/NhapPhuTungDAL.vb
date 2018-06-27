Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class NhapPhuTungDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildmanhapphutung(ByRef nextMSX As Integer) As Result 'ex: 18222229
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [manhapphutung] "
        query &= "FROM [tblNhapPhuTung] "
        query &= "ORDER BY [manhapphutung] DESC "

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
                            idOnDB = reader("manhapphutung")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMSX = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMSX = 1
                    Return New Result(False, "Lấy ID kế tiếp của mã nhap phu tung không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(s As NhapPhuTungDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblNhapPhuTung] ([manhapphutung], [maphutung], [soluong], [ngaytiepnhan])"
        query &= "VALUES (@manhapphutung,@maphutung,@soluong,@ngaytiepnhan)"

        'get MS
        Dim nextMNPT = "1"
        buildmanhapphutung(nextMNPT)
        s.manhapphutung = nextMNPT

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhapphutung", s.manhapphutung)
                    .Parameters.AddWithValue("@maphutung", s.maphutung)
                    .Parameters.AddWithValue("@soluong", s.soluong)
                    .Parameters.AddWithValue("@ngaytiepnhan", s.ngaytiepnhan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm nhap phu tung không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(manhapphutung As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblNhapPhuTung] "
        query &= " WHERE "
        query &= " [manhapphutung] = @manhapphutung "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhapphutung", manhapphutung)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa nhap phu tung không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function selectALL(ByRef listnhapphutung As List(Of NhapPhuTungDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [manhapphutung], [maphutung], [soluong], [ngaytiepnhan]"
        query &= " FROM [tblNhapPhuTung]"


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
                        listnhapphutung.Clear()
                        While reader.Read()
                            listnhapphutung.Add(New NhapPhuTungDTO(reader("manhapphutung"), reader("maphutung"), reader("soluong"), reader("ngaytiepnhan"), reader("dongia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả nhap phu tung không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(NhapPhuTungDTO As NhapPhuTungDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblNhapPhuTung] SET"
        query &= " [maphutung] = @maphutung "
        query &= " ,[soluong] = @soluong "
        query &= " ,[ngaytiepnhan] = @ngaytiepnhan "
        'cách?
        query &= "WHERE "
        query &= " [manhapphutung] = @manhapphutung"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhapphutung", NhapPhuTungDTO.manhapphutung)
                    .Parameters.AddWithValue("@maphutung", NhapPhuTungDTO.maphutung)
                    .Parameters.AddWithValue("@soluong", NhapPhuTungDTO.soluong)
                    .Parameters.AddWithValue("@ngaytiepnhan", NhapPhuTungDTO.ngaytiepnhan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Cập nhật nhap phu tung không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function nhapthem(thang As Integer, nam As Integer, ByRef list As List(Of dgvBaoCaoTonDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [maphutung],SUM([soluong]) AS [nhapthem] "
        query &= "FROM [tblNhapPhuTung] "
        query &= "WHERE "
        query &= "Year([ngaytiepnhan]) = @nam "
        query &= "AND Month([ngaytiepnhan]) = @thang "
        query &= "GROUP BY [maphutung] "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@thang", thang)
                    .Parameters.AddWithValue("@nam", nam)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Dim baocao = New dgvBaoCaoTonDTO()
                            baocao.maphutung = reader("maphutung")
                            baocao.nhapthem = reader("nhapthem")
                            For Each item In list
                                If (baocao.maphutung = item.maphutung) Then
                                    item.nhapthem = baocao.nhapthem
                                    item.tondau = item.tondau - baocao.nhapthem
                                End If
                            Next
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "TÍnh số phụ tùng nhập thêm không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function tinhlist(ByRef list As List(Of Integer)) As Result

        Dim query As String = String.Empty
        query &= "SELECT MIN(Year([ngaytiepnhan])) As [min] "
        query &= "FROM [tblNhapPhuTung] "


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
                        While reader.Read()
                            list.Clear()
                            Dim min = reader("min")
                            For i = min To Now.Year
                                list.Add(i)
                            Next
                        End While
                    End If
                Catch ex As Exception
                    list.Add(Now.Year)
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(True)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
