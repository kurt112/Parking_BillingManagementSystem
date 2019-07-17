Public Class Member_Register
    Private user As String

    Public Property User1 As String
        Get
            Return user
        End Get
        Set(value As String)
            user = value
        End Set
    End Property

    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.Click
        Dim database As Server = New Server
        '   Dim number As Integer = CInt(member_id.Text)
        Dim number As Integer = 1

        Dim member As Membership = New Membership(123123123, "dsfasd", "dsfasd", "dsfasd", "dsfasd", "dsfasd", "dsfasd", "dsfasd", "dsfasd",
                                                  "dsfasd", "dsfasd", "dsfasd", "dsfasd", "dsfasd", "dsfasd", "")
        database.Membership_Register(member)
        ' database.Membership_Register(New Membership(number, first_name.Text, last_name.Text, email_address.Text,
        'cellphone_number.Text, Telephone_Number.Text, date_of_birth.Value.ToString, Place_of_Birth.Text,
        'person_to_contact.Text, Person_to_contact_number.Text, "", initial_amount.Text, "0", "0", "Nan", "Nan", user, Date.Now.ToString("MM/dd/yyyy"), initial_amount.Text))



    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub member_id_TextChanged(sender As Object, e As EventArgs) Handles member_id.TextChanged
        If (member_id.Text = "") Then
            label_show(member_id_alert)
        Else
            label_hide(member_id_alert)
        End If
    End Sub

    Private Sub first_name_TextChanged(sender As Object, e As EventArgs) Handles first_name.TextChanged
        If (first_name.Text = "") Then
            label_show(first_name_alert)
        Else
            label_hide(first_name_alert)
        End If
    End Sub

    Private Sub last_name_TextChanged(sender As Object, e As EventArgs) Handles last_name.TextChanged
        If (last_name.Text = "") Then
            label_show(last_name_alert)
        Else
            label_hide(last_name_alert)
        End If
    End Sub

    Private Sub cellphone_number_TextChanged(sender As Object, e As EventArgs) Handles cellphone_number.TextChanged
        If (cellphone_number.Text = "") Then
            label_show(cellphone_number_empty)
        Else
            label_hide(cellphone_number_empty)
        End If
    End Sub


    Private Sub person_to_contact_TextChanged(sender As Object, e As EventArgs) Handles person_to_contact.TextChanged
        If (Person_to_contact_number.Text = "") Then
            label_show(person_contact_empty)
        Else
            label_hide(person_contact_empty)
        End If
    End Sub

    Private Sub email_address_TextChanged(sender As Object, e As EventArgs) Handles email_address.TextChanged
        If (email_address.Text = "") Then
            label_show(emailaddress_alert)
        Else
            label_hide(emailaddress_alert)
        End If
    End Sub

    Private Sub Telephone_Number_TextChanged(sender As Object, e As EventArgs) Handles Telephone_Number.TextChanged
        If (Telephone_Number.Text = "") Then
            label_show(telephonenumber_alert)
        Else
            label_hide(telephonenumber_alert)
        End If
    End Sub

    Private Sub Place_of_Birth_TextChanged(sender As Object, e As EventArgs) Handles Place_of_Birth.TextChanged
        If (Place_of_Birth.Text = "") Then
            label_show(place_of_birth_alert)
        Else
            label_hide(place_of_birth_alert)
        End If
    End Sub

    Private Sub Person_to_contact_number_TextChanged(sender As Object, e As EventArgs) Handles Person_to_contact_number.TextChanged
        If (Person_to_contact_number.Text = "") Then
            label_show(person_to_contact_number_alert)
        Else
            label_hide(person_to_contact_number_alert)
        End If
    End Sub

    Private Sub label_show(ByVal text As Label)
        text.Visible = True
    End Sub
    Private Sub label_hide(ByVal text As Label)
        text.Visible = False
    End Sub

End Class