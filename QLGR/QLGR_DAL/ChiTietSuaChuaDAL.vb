Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class ChiTietSuaChuaDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMachitietsuachua(ByRef nextMSX As Integer) As Result 'ex: 18222229
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [machitietsuachua] "
        query &= "FROM [tblChiTietSuaChua] "
        query &= "ORDER BY [machitietsuachua] DESC "

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
                            idOnDB = reader("machitietsuachua")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMSX = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMSX = 1
                    Return New Result(False, "Lấy ID kế tiếp của mã chi tiết sửa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(s As ChiTietSuaChuaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChiTietSuaChua] ([machitietsuachua], [maphieusuachua], [maphutung], [soluong], [dongia], [tiencong])"
        query &= "VALUES (@machitietsuachua,@maphieusuachua,@maphutung,@soluong,@dongia,@tiencong)"

        'get MS
        Dim nextMCTSC = "1"
        buildMachitietsuachua(nextMCTSC)
        s.machitietsuachua = nextMCTSC

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machitietsuachua", s.machitietsuachua)
                    .Parameters.AddWithValue("@maphieusuachua", s.maphieusuachua)
                    .Parameters.AddWithValue("@maphutung", s.maphutung)
                    .Parameters.AddWithValue("@soluong", s.soluong)
                    .Parameters.AddWithValue("@dongia", s.dongia)
                    .Parameters.AddWithValue("@tiencong", s.tiencong)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm chi tiết sửa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(machitietsuachua As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblChiTietSuaChua] "
        query &= " WHERE "
        query &= " [machitietsuachua] = @machitietsuachua "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machitietsuachua", machitietsuachua)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa chi tiết sửa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function selectALL(ByRef listchuxe As List(Of ChiTietSuaChuaDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [machitietsuachua], [maphieusuachua], [maphutung], [soluong], [dongia], [tiencong]"
        query &= " FROM [tblChiTietSuaChua]"


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
                        listchuxe.Clear()
                        While reader.Read()
                            listchuxe.Add(New ChiTietSuaChuaDTO(reader("machitietsuachua"), reader("maphieusuachua"), reader("maphutung"), reader("soluong"), reader("dongia"), reader("tiencong")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả chi tiết sửa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByMaPhieuSuaChua(iMaPhieuSuaChua As Integer, ByRef listChiTietSuaChua As List(Of ChiTietSuaChuaDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [tblChiTietSuaChua].[machitietsuachua],[tblChiTietSuaChua].[maphieusuachua] ,[tblChiTietSuaChua].[maphutung],[tblChiTietSuaChua].[soluong],[tblChiTietSuaChua].[dongia],[tblChiTietSuaChua].[tiencong] "
        query &= " FROM [tblChiTietSuaChua] "
        query &= "     ,[tblPhieuSuaChua] "
        query &= " WHERE "
        query &= "     [tblChiTietSuaChua].[maphieusuachua] = [tblPhieuSuaChua].[maphieusuachua] "
        query &= "     AND [tblChiTietSuaChua].[maphieusuachua] = @maphieusuachua "



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieusuachua", iMaPhieuSuaChua)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listChiTietSuaChua.Clear()
                        While reader.Read()
                            listChiTietSuaChua.Add(New ChiTietSuaChuaDTO(reader("machitietsuachua"), reader("maphieusuachua"), reader("maphutung"), reader("soluong"), reader("dongia"), reader("tiencong")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả chi tiết sửa chữa theo mã phiếu sửa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(ChiTietSuaChuaDTO As ChiTietSuaChuaDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblChiTietSuaChua] SET"
        query &= " [maphieusuachua] = @maphieusuachua "
        query &= " ,[maphutung] = @maphutung "
        query &= " ,[soluong] = @soluong "
        query &= " ,[dongia] = @dongia "
        query &= " ,[tiencong] = @tiencong "
        'cách?
        query &= "WHERE "
        query &= " [machitietsuachua] = @machitietsuachua"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machitietsuachua", ChiTietSuaChuaDTO.machitietsuachua)
                    .Parameters.AddWithValue("@maphieusuachua", ChiTietSuaChuaDTO.maphieusuachua)
                    .Parameters.AddWithValue("@maphutung", ChiTietSuaChuaDTO.maphutung)
                    .Parameters.AddWithValue("@soluong", ChiTietSuaChuaDTO.soluong)
                    .Parameters.AddWithValue("@dongia", ChiTietSuaChuaDTO.dongia)
                    .Parameters.AddWithValue("@tiencong", ChiTietSuaChuaDTO.tiencong)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Cập nhật chi tiết sửa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function ban(thang As Integer, nam As Integer, ByRef list As List(Of dgvBaoCaoTonDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [maphutung],SUM([soluong]) AS [ban]"
        query &= "FROM [tblChiTietSuaChua],[tblPhieuSuaChua]"
        query &= "WHERE "
        query &= "[tblPhieuSuaChua].[maphieusuachua]=[tblChiTietSuaChua].[maphieusuachua]"
        query &= "AND Year([ngaysuachua])  = @nam "
        query &= "AND Month([ngaysuachua])  = @thang "
        query &= "GROUP BY [maphutung]"

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
                            baocao.ban = reader("ban")
                            For Each item In list
                                If (baocao.maphutung = item.maphutung) Then
                                    item.ban = baocao.ban
                                    item.tondau = item.tondau + baocao.ban
                                End If
                            Next
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Tính số lượng phụ tùng bán không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
