Public Class Profit_Entities

#Region "Variable"
    Private Id As String
    Private Asign_User As String
    Private Profit_date As String
    Private Profit_amount As String
    Private Member_name As String
#End Region

#Region "Constructor"
    Public Sub New(id As String, asign_User As String, profit_date As String, Member_name As String, profit_amount As String)
        Me.Member_name = Member_name
        Me.Id = id
        Me.Asign_User = asign_User
        Me.Profit_date = profit_date
        Me.Profit_amount = profit_amount
    End Sub

#End Region

#Region "Getter And Setter"
    Public Property Id1 As String
        Get
            Return Id
        End Get
        Set(value As String)
            Id = value
        End Set
    End Property

    Public Property Asign_User1 As String
        Get
            Return Asign_User
        End Get
        Set(value As String)
            Asign_User = value
        End Set
    End Property

    Public Property Profit_date1 As String
        Get
            Return Profit_date
        End Get
        Set(value As String)
            Profit_date = value
        End Set
    End Property

    Public Property Profit_amount1 As String
        Get
            Return Profit_amount
        End Get
        Set(value As String)
            Profit_amount = value
        End Set
    End Property

    Public Property Member_name1 As String
        Get
            Return Member_name
        End Get
        Set(value As String)
            Member_name = value
        End Set
    End Property
#End Region
End Class
