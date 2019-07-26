Imports ParkingSystem

Public Class Login

    Dim database As Server = New Server
    Dim user As User_History

    Public Property User1 As User_History
        Get
            Return user
        End Get
        Set(value As User_History)
            user = value
        End Set
    End Property

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()

    End Sub

    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click

        If (database.User_Login(username.Text, password.Text, Me) = True) Then
            Dim dashboard As Parking = New Parking()
            dashboard.single_user = user
            'Me.Opacity = 0
            Me.Hide()
            dashboard.Show()

        Else

            MessageBox.Show("No Account Found")

        End If



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
End Class