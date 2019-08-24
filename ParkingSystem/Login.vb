Imports System.Drawing.Printing
Imports ParkingSystem

Public Class Login
    ReadOnly database As Server = New Server
    Public ReadOnly Property Dashboard1 As Parking = New Parking()
    Private ReadOnly myPageAlreadySetUp As Boolean = False
    Dim user As User_History
    Dim admin = False
    Private ReadOnly encrypt As Encrypt = New Encrypt
    Public Property User1 As User_History
        Get
            Return user
        End Get
        Set(value As User_History)
            user = value
        End Set
    End Property

    Public Property Admin1 As Object
        Get
            Return admin
        End Get
        Set(value As Object)
            admin = value
        End Set
    End Property

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        database.CreateDatabase()

        If (database.User_Login(username.Text, encrypt.Base64Encode(password.Text), Me) = True) Then
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
        Dashboard1.Admin1 = admin
        Dashboard1.Transaction_form1 = New Transaction_List()
        Dashboard1.Promohistory_form1 = New Pricing()
        Dashboard1.Area_form1 = New Park_List()
        Dashboard1.Member_form1 = New Membership_List()
        Dashboard1.Users_form1 = New User_List()
        Dashboard1.Profit_form1 = New Profit_List()

        Dashboard1.Member_table1 = Dashboard1.Member_form1.Member_table
        Dashboard1.Location_table1 = Dashboard1.Area_form1.Parking_Area_Table


        Dashboard1.Transaction_form1.Profit_table1 = Dashboard1.Profit_form1.Profit_table
        Dashboard1.Transaction_form1.Total_label1 = Dashboard1.Profit_form1.total_value

        Dashboard1.Member_form1.Profit_table1 = Dashboard1.Profit_form1.Profit_table
        Dashboard1.Member_form1.Total_label1 = Dashboard1.Profit_form1.total_value

    End Sub


#End Region
End Class