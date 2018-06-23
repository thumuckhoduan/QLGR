Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class ChiTietDoanhSoDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildmachitiet(ByRef nextMCT As String) As Result 'ex: 18222229
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [machitietdoanhso] "
        query &= "FROM [tblChiTietDoanhSo] "
        query &= "ORDER BY [machitietdoanhso] DESC "

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
                            idOnDB = reader("machitietdoanhso")
                        End While
                    End If
                    nextMCT = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    nextMCT = 1
                    Return New Result(False, "Lấy ID kế tiếp của mã chi tiết doanh số không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(s As ChiTietDoanhSoDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChiTietDoanhSo] ([machitietdoanhso], [madoanhso], [mahieuxe], [soluotsua],[thanhtien],[tile])"
        query &= "VALUES (@machitietdoanhso, @madoanhso, @mahieuxe, @soluotsua,@thanhtien,@tile)"

        'get MS
        Dim nextMCT = "1"
        buildmachitiet(nextMCT)
        s.machitiet = nextMCT

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machitietdoanhso", s.machitiet)
                    .Parameters.AddWithValue("@madoanhso", s.madoanhso)
                    .Parameters.AddWithValue("@mahieuxe", s.mahieuxe)
                    .Parameters.AddWithValue("@soluotsua", s.soluotsua)
                    .Parameters.AddWithValue("@thanhtien", s.thanhtien)
                    .Parameters.AddWithValue("@tile", s.tile)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Chi Tiet Doanh Số không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function taochitietbaocao(thang As Integer, nam As Integer, ByRef list As List(Of dgvbaocaodoanhso), tongthanhtien As Integer) As Result
        Dim query As String = String.Empty


        query &= "SELECT [tblHieuXe].[mahieuxe],[tenhieuxe], count(*) AS [tongsoluot],  SUM([tblPhieuSuaChua].[thanhtien]) AS [thanhtien] "
        query &= "FROM [tblXe],[tblHieuXe],[tblPhieuSuaChua] "
        query &= "WHERE "
        query &= "[tblHieuXe].[mahieuxe] = [tblXe].[mahieuxe] "
        query &= "AND [tblXe].[maxe]  = [tblPhieuSuaChua].[maxe] "
        query &= "AND Year([ngaysuachua])  = @nam "
        query &= "AND Month([ngaysuachua])  = @thang "
        query &= "GROUP BY [tblHieuXe].[mahieuxe],[tenhieuxe]"



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
                        list.Clear()
                        While reader.Read()
                            Dim CTDS = New dgvbaocaodoanhso()
                            CTDS.mahieuxe = reader("mahieuxe")
                            CTDS.tenhieuxe = reader("tenhieuxe")
                            CTDS.soluotsua = reader("tongsoluot")
                            CTDS.thanhtien = reader("thanhtien")
                            CTDS.tile = CTDS.thanhtien / tongthanhtien * 100
                            list.Add(CTDS)
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "tạo báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
