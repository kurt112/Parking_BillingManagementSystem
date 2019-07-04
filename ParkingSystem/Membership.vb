Public Class Membership
    Private Sub Add_User_Click(sender As Object, e As EventArgs) Handles Register_Button.Click
        Dim form As Member_Register = New Member_Register()

        form.ShowDialog()


    End Sub
End Class