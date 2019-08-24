Public Class User
    Private Id As String
    Private First_name As String
    Private Last_name As String
    Private email As String
    Private Username As String
    Private password As String
    Private status As String
    Public Sub New(id As String, first_name As String, last_name As String, email As String, username As String, password As String, status As String)
        Me.Status1 = status
        Me.Id1 = id
        Me.First_name1 = first_name
        Me.Last_name1 = last_name
        Me.Email1 = email
        Me.Username1 = username
        Me.Password1 = password
    End Sub

    Public Property Id1 As String
        Get
            Return Id
        End Get
        Set(value As String)
            Id = value
        End Set
    End Property

    Public Property First_name1 As String
        Get
            Return First_name
        End Get
        Set(value As String)
            First_name = value
        End Set
    End Property

    Public Property Last_name1 As String
        Get
            Return Last_name
        End Get
        Set(value As String)
            Last_name = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property Username1 As String
        Get
            Return Username
        End Get
        Set(value As String)
            Username = value
        End Set
    End Property

    Public Property Password1 As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property Status1 As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property
End Class
