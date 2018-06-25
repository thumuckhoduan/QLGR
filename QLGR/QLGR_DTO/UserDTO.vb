Public Class UserDTO
    Private strusername As String
    Private strpassword As String
    Private ipermissions As Integer

    Public Sub New()

    End Sub

    Public Sub New(username As Integer, password As Integer, permissions As Integer)
        Me.strusername = username
        Me.strpassword = password
        Me.ipermissions = permissions
    End Sub

    Public Property username As String
        Get
            Return strusername
        End Get
        Set(value As String)
            strusername = value
        End Set
    End Property


    Public Property password As String
        Get
            Return strpassword
        End Get
        Set(value As String)
            strpassword = value
        End Set
    End Property


    Public Property permissions As Integer
        Get
            Return ipermissions
        End Get
        Set(value As Integer)
            ipermissions = value
        End Set
    End Property
End Class
