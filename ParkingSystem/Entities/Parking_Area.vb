Public Class Parking_Area

    Private Id As String
    Private Parking_name As String
    Private Parking_level As String
    Private Parking_Rate As String
    Private Parking_Status As String

    Public Sub New(id As String, parking_name As String, parking_level As String, parking_Rate As String, parking_status As String)
        Me.Parking_Status = parking_status
        Me.Id = id
        Me.Parking_name = parking_name
        Me.Parking_level = parking_level
        Me.Parking_Rate = parking_Rate
    End Sub



    Public Property Id1 As String
        Get
            Return Id
        End Get
        Set(value As String)
            Id = value
        End Set
    End Property

    Public Property Parking_name1 As String
        Get
            Return Parking_name
        End Get
        Set(value As String)
            Parking_name = value
        End Set
    End Property

    Public Property Parking_level1 As String
        Get
            Return Parking_level
        End Get
        Set(value As String)
            Parking_level = value
        End Set
    End Property

    Public Property Parking_Rate1 As String
        Get
            Return Parking_Rate
        End Get
        Set(value As String)
            Parking_Rate = value
        End Set
    End Property

    Public Property Parking_Status1 As String
        Get
            Return Parking_Status
        End Get
        Set(value As String)
            Parking_Status = value
        End Set
    End Property
End Class