Public Class User_History
    Private Id As String
    Private First_name As String
    Private Last_name As String
    Private Username As String
    Private Time_in As String
    Private Time_out As String
    Private Session As String
    Private date_ As String


    Public Sub New(id As String, first_name As String, last_name As String, username As String, time_in As String, time_out As String, session As String, date_ As String)
        Me.Id = id
        Me.First_name = first_name
        Me.Last_name = last_name
        Me.Username = username
        Me.Time_in = time_in
        Me.Time_out = time_out
        Me.Session = session
        Me.date_ = date_
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

    Public Property Username1 As String
        Get
            Return Username
        End Get
        Set(value As String)
            Username = value
        End Set
    End Property

    Public Property Time_in1 As String
        Get
            Return Time_in
        End Get
        Set(value As String)
            Time_in = value
        End Set
    End Property

    Public Property Time_out1 As String
        Get
            Return Time_out
        End Get
        Set(value As String)
            Time_out = value
        End Set
    End Property

    Public Property Session1 As String
        Get
            Return Session
        End Get
        Set(value As String)
            Session = value
        End Set
    End Property

    Public Property Date_1 As String
        Get
            Return date_
        End Get
        Set(value As String)
            date_ = value
        End Set
    End Property
End Class
