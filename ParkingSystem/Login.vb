Imports ParkingSystem

Public Class Login
    ReadOnly database As Server = New Server
    Dim user As User_History

    Public Property User1 As User_History
        Get
            Return user
        End Get
        Set(value As User_History)
            user = value
        End Set
    End Property

    Public Property Promo1 As Pricing = New Pricing()

    Public ReadOnly Property Dashboard1 As Parking = New Parking()

    Public Property Transactionlist1 As Transaction_List = New Transaction_List()

    Public Property Area1 As Park_List = New Park_List()

    Public Property Membership1 As Membership_List = New Membership_List()

    Public Property User_form1 As User_List = New User_List()

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        database.CreateDatabase()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()

    End Sub

    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click

        If (database.User_Login(username.Text, password.Text, Me) = True) Then
            Set_From()
            Dashboard1.Single_user = user
            Me.Hide()
            Dashboard1.Show()

        Else

            MessageBox.Show("No Account Found")

        End If



    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

#Region "Setting the form"
    Private Sub Set_From()
        Dashboard1.Transaction_form1 = Transactionlist1
        Dashboard1.Promohistory_form1 = Promo1
        Dashboard1.Area_form1 = Area1
        Dashboard1.Member_form1 = Membership1
        Dashboard1.Users_form1 = User_form1

        Dashboard1.Member_table1 = Membership1.Member_table
        Dashboard1.Location_table1 = Area1.Parking_Area_Table

    End Sub
#End Region
End Class