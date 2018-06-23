Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class BaoCaoTonDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildmabaocaoton(ByRef nextMBCT As String) As Result
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [mabaocaoton] "
        query &= "FROM [tblBaoCaoTon] "
        query &= "ORDER BY [mabaocaoton] DESC "

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
                            idOnDB = reader("mabaocaoton")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMBCT = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMBCT = 1
                    Return New Result(False, "Lấy ID kế tiếp của mã báo cáo tồn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(s As BaoCaoTonDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblBaoCaoTon] ([mabaocaoton], [thang], [nam],[ngaytao])"
        query &= "VALUES (@mabaocaoton, @thang, @nam,@ngaytao)"

        'get MS
        Dim nextMBCT = 0
        buildmabaocaoton(nextMBCT)
        s.mabaocaoton = nextMBCT

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mabaocaoton", s.mabaocaoton)
                    .Parameters.AddWithValue("@thang", s.thang)
                    .Parameters.AddWithValue("@nam", s.nam)
                    .Parameters.AddWithValue("@ngaytao", s.ngaytao)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm báo cáo tồn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
