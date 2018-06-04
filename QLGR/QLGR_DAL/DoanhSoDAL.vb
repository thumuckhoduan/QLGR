Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class DoanhSoDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildmadoanhso(ByRef nextMDS As String) As Result 'ex: 18222229
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [madoanhso] "
        query &= "FROM [tblDoanhSo] "
        query &= "ORDER BY [madoanhso] DESC "

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
                            idOnDB = reader("madoanhso")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMDS = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMDS = 1
                    Return New Result(False, "Lấy ID kế tiếp của mã doanh số không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(s As DoanhSoDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblDoanhSo] ([madoanhso], [thang], [nam], [tongdoanhthu])"
        query &= "VALUES (@madoanhso, @thang, @nam, @tongdoanhthu)"

        'get MS
        Dim nextMDS = "1"
        buildmadoanhso(nextMDS)
        s.madoanhso = nextMDS

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madoanhso", s.madoanhso)
                    .Parameters.AddWithValue("@thang", s.thang)
                    .Parameters.AddWithValue("@nam", s.nam)
                    .Parameters.AddWithValue("@tongdoanhthu", s.tongdoanhthu)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm doanh số không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
