Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class PhieuSuaChuaDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildmaphieusuachua(ByRef nextMPSC As Integer) As Result 'ex: 18222229
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maphieusuachua] "
        query &= "FROM [tblPhieuSuaChua] "
        query &= "ORDER BY [maphieusuachua] DESC "

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
                            idOnDB = reader("maphieusuachua")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMPSC = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMPSC = 1
                    Return New Result(False, "Lấy ID kế tiếp của mã phieu sua chua không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(s As PhieuSuaChuaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuSuaChua] ([maphieusuachua], [noidung], [maxe], [thanhtien])"
        query &= "VALUES (@maphieusuachua,@noidung,@maxe,@thanhtien)"

        'get MS
        Dim nextMPSC = "1"
        buildmaphieusuachua(nextMPSC)
        s.maphieusuachua = nextMPSC

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieusuachua", s.maphieusuachua)
                    .Parameters.AddWithValue("@noidung", s.noidung)
                    .Parameters.AddWithValue("@maxe", s.maxe)
                    .Parameters.AddWithValue("@thanhtien", s.thanhtien)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm phiếu sửa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(maphieusuachua As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblPhieuSuaChua] "
        query &= " WHERE "
        query &= " [maphieusuachua] = @maphieusuachua "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieusuachua", maphieusuachua)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa phiếu sửa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function selectALL(ByRef listchuxe As List(Of PhieuSuaChuaDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maphieusuachua], [noidung], [maxe], [thanhtien]"
        query &= " FROM [tblPhieuSuaChua]"


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
                            listchuxe.Add(New PhieuSuaChuaDTO(reader("maphieusuachua"), reader("noidung"), reader("maxe"), reader("thanhtien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả phiếu sửa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(phieusuachuaDTO As PhieuSuaChuaDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblPhieuSuaChua] SET"
        query &= " [noidung] = @noidung "
        query &= " ,[maxe] = @maxe "
        query &= " ,[thanhtien] = @thanhtien "

        'cách?
        query &= "WHERE "
        query &= " [maphieusuachua] = @maphieusuachua"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieusuachua", phieusuachuaDTO.maphieusuachua)
                    .Parameters.AddWithValue("@noidung", phieusuachuaDTO.noidung)
                    .Parameters.AddWithValue("@maxe", phieusuachuaDTO.maxe)
                    .Parameters.AddWithValue("@thanhtien", phieusuachuaDTO.thanhtien)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Cập nhật phiếu sửa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
