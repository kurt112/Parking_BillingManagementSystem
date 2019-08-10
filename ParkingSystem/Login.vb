Imports ParkingSystem

Public Class Login

    Dim database As Server = New Server
    Dim user As User_History
    Dim dashboard As Parking = New Parking()
    Dim promo As Pricing = New Pricing()
    Dim transactionlist As Transaction_List = New Transaction_List()
    Dim area As Park_List = New Park_List()
    Dim membership As Membership_List = New Membership_List()
    Dim user_form As User_List = New User_List()

    Public Property User1 As User_History
        Get
            Return user
        End Get
        Set(value As User_History)
            user = value
        End Set
    End Property

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        database.createDatabase()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()

    End Sub

    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click

        If (database.User_Login(username.Text, password.Text, Me) = True) Then
            set_From()
            dashboard.single_user = user
            Me.Hide()
            dashboard.Show()

        Else

            MessageBox.Show("No Account Found")

        End If



    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

#Region "Setting the form"
    Private Sub set_From()
        dashboard.Transaction_form1 = transactionlist
        dashboard.Promohistory_form1 = Pricing
        dashboard.Area_form1 = area
        dashboard.Member_form1 = membership
        dashboard.Users_form1 = user_form

        dashboard.Member_table1 = membership.Member_table
        dashboard.Location_table1 = area.Parking_Area_Table

    End Sub
#End Region
End Class