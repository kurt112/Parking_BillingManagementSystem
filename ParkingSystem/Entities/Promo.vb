Public Class Promo
    Private Id As String
    Private Name As String
    Private Duration As String
    Private Description As String
    Private Ends As String
    Private Price As String
    Private Status As String

    Public Sub New(id As String, name As String, duration As String, description As String, ends As String, price As String, status As String)
        Me.Id = id
        Me.Name = name
        Me.Duration1 = duration
        Me.Description = description
        Me.Ends = ends
        Me.Price = price
        Me.Status = status
    End Sub

    Public Property Id1 As String
        Get
            Return Id
        End Get
        Set(value As String)
            Id = value
        End Set
    End Property

    Public Property Name1 As String
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property


    Public Property Description1 As String
        Get
            Return Description
        End Get
        Set(value As String)
            Description = value
        End Set
    End Property

    Public Property Ends1 As String
        Get
            Return Ends
        End Get
        Set(value As String)
            Ends = value
        End Set
    End Property

    Public Property Price1 As String
        Get
            Return Price
        End Get
        Set(value As String)
            Price = value
        End Set
    End Property

    Public Property Status1 As String
        Get
            Return Status
        End Get
        Set(value As String)
            Status = value
        End Set
    End Property

    Public Property Duration1 As String
        Get
            Return Duration
        End Get
        Set(value As String)
            Duration = value
        End Set
    End Property
End Class
