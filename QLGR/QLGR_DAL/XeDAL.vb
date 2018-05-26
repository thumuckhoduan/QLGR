﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class XeDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMaXe(ByRef nextMX As String) As Result 'ex: 18222229
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maxe] "
        query &= "FROM [tblXe] "
        query &= "ORDER BY [maxe] DESC "

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
                            idOnDB = reader("maxe")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMX = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMX = 1
                    Return New Result(False, "Lấy ID kế tiếp của xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function insert(s As XeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblXe] ([maxe], [mahieuxe], [machuxe],[bienso])"
        query &= "VALUES (@maxe,@mahieuxe,@machuxe,@bienso)"

        Dim nextMX = "1"
        buildMaXe(nextMX)
        s.maxe = nextMX

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maxe", s.maxe)
                    .Parameters.AddWithValue("@mahieuxe", s.mahieuxe)
                    .Parameters.AddWithValue("@machuxe", s.machuxe)
                    .Parameters.AddWithValue("@bienso", s.bienso)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectALL(ByRef listXe As List(Of XeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maxe], [mahieuxe], [machuxe], [bienso]"
        query &= " FROM [tblXe]"


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
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New XeDTO(reader("maxe"), reader("mahieuxe"), reader("machuxe"), reader("bienso")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(xeDTO As XeDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblXe] SET"
        query &= " [mahieuxe] = @mahieuxe "
        query &= " ,[bienso] = @bienso "
        query &= " ,[machuxe] = @machuxe "
        query &= "WHERE "
        query &= " [maxe] = @maxe "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maxe", xeDTO.maxe)
                    .Parameters.AddWithValue("@mahieuxe", xeDTO.mahieuxe)
                    .Parameters.AddWithValue("@machuxe", xeDTO.machuxe)
                    .Parameters.AddWithValue("@bienso", xeDTO.bienso)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(iMaXe As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblXe] "
        query &= " WHERE "
        query &= " [maxe] = @maxe "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maxe", iMaXe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaChuXe(iMaChuXe As Integer, ByRef listXe As List(Of XeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maxe], [mahieuxe], [machuxe], [bienso] "
        query &= " FROM [tblXe] "
        query &= "     ,[tblChuXe] "
        query &= " WHERE "
        query &= "     [tblXe].[machuxe] = [tblChuXe].[machuxe]"
        query &= "     AND [tblChuXe].[machuxe] = @machuxe"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machuxe", iMaChuXe)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New XeDTO(reader("maxe"), reader("mahieuxe"), reader("machuxe"), reader("bienso")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả xe theo chủ xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function tracuu(chuxe As String, hieuxe As String, bienso As String, tiennomin As Integer, tiennomax As Integer, ByRef listtimkiem As List(Of TimKiemDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [tenchuxe], [tenhieuxe], [bienso], [tienno]"
        query &= " FROM [tblXe],[tblHieuXe],[tblChuXe]"
        query &= " WHERE [tblXe.mahieuxe]=[tblHieuXe.mahieuxe] "
        query &= " AND [tblChuXe.machuxe]=[tblXe.machuxe] "
        query &= " AND [tblChuXe.tenchuxe] LIKE @tenchuxe "
        query &= " AND [tblHieuXe.tenhieuxe] LIKE @tenhieuxe "
        query &= " AND [tblXe.bienso] LIKE @bienso "
        query &= " AND [tblXe.tiennomin] BETWEEN @tiennomin AND @tiennomax "



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tenchuxe", chuxe)
                    .Parameters.AddWithValue("@tenhieuxe", hieuxe)
                    .Parameters.AddWithValue("@bienso", bienso)
                    .Parameters.AddWithValue("@tiennomin", tiennomin)
                    .Parameters.AddWithValue("@tiennomax", tiennomax)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listtimkiem.Clear()
                        While reader.Read()
                            listtimkiem.Add(New TimKiemDTO(reader("tenchuxe"), reader("tenhieuxe"), reader("bienso"), reader("tienno")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Tra C?u không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
