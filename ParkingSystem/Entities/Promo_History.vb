Public Class Promo_History
#Region "Objects"
    Private Promo_id As String
    Private Member_id As String
    Private Promo_name As String
    Private Location As String
    Private Promo_registered_date As String
    Private Promo_ends As String
    Private promo_active As String

#End Region


#Region "Constructor"
    Public Sub New(promo_id As String, member_id As String, promo_name As String, location As String, promo_registered_date As String, promo_ends As String, promo_active As String)
        Me.Promo_id = promo_id
        Me.Member_id = member_id
        Me.Promo_name = promo_name
        Me.Location = location
        Me.Promo_registered_date = promo_registered_date
        Me.Promo_ends = promo_ends
        Me.promo_active = promo_active
    End Sub
#End Region
#Region "Properties"
    Public Property Promo_id1 As String
        Get
            Return Promo_id
        End Get
        Set(value As String)
            Promo_id = value
        End Set
    End Property

    Public Property Member_id1 As String
        Get
            Return Member_id
        End Get
        Set(value As String)
            Member_id = value
        End Set
    End Property

    Public Property Promo_name1 As String
        Get
            Return Promo_name
        End Get
        Set(value As String)
            Promo_name = value
        End Set
    End Property

    Public Property Location1 As String
        Get
            Return Location
        End Get
        Set(value As String)
            Location = value
        End Set
    End Property

    Public Property Promo_registered_date1 As String
        Get
            Return Promo_registered_date
        End Get
        Set(value As String)
            Promo_registered_date = value
        End Set
    End Property

    Public Property Promo_ends1 As String
        Get
            Return Promo_ends
        End Get
        Set(value As String)
            Promo_ends = value
        End Set
    End Property

    Public Property Promo_active1 As String
        Get
            Return promo_active
        End Get
        Set(value As String)
            promo_active = value
        End Set
    End Property
#End Region

End Class
