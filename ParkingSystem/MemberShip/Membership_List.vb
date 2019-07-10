Public Class Membership_List
    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.Click
        Dim Register_Form As Member_Register = New Member_Register
        Register_Form.ShowDialog()
    End Sub
End Class