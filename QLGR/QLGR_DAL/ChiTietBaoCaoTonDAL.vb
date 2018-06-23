Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility

Public Class ChiTietBaoCaoTonDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildmachitietbaocaoton(ByRef nextMCTBCT As String) As Result 'ex: 18222229
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [machitietbaocaoton] "
        query &= "FROM [tblChiTietBaoCaoTon] "
        query &= "ORDER BY [machitietbaocaoton] DESC "

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
                            idOnDB = reader("machitietbaocaoton")
                        End While
                    End If
                    nextMCTBCT = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    nextMCTBCT = 1
                    Return New Result(False, "Lấy ID kế tiếp của mã chi tiết báo cáo tồn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function insert(s As ChiTietBaoCaoTonDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChiTietBaoCaoTon] ([machitietbaocaoton], [mabaocaoton], [maphutung], [tondau],[nhapthem],[ban],[toncuoi])"
        query &= "VALUES (@machitietbaocaoton, @mabaocaoton, @maphutung, @tondau,@nhapthem,@ban,@toncuoi)"

        Dim nextMCTBCT = 0
        buildmachitietbaocaoton(nextMCTBCT)
        s.machitietbaocaoton = nextMCTBCT

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machitietbaocaoton", s.machitietbaocaoton)
                    .Parameters.AddWithValue("@mabaocaoton", s.mabaocaoton)
                    .Parameters.AddWithValue("@maphutung", s.maphutung)
                    .Parameters.AddWithValue("@tondau", s.tondau)
                    .Parameters.AddWithValue("@nhapthem", s.nhapthem)
                    .Parameters.AddWithValue("@ban", s.ban)
                    .Parameters.AddWithValue("@toncuoi", s.toncuoi)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Chi Tiet Báo Cáo Tồn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class

