Imports Bunifu.Framework.UI

Public Class User_Register
    Dim table As Bunifu.Framework.UI.BunifuCustomDataGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid
    Dim database As Server = New Server
    Dim text__ As String

    Public Property Table1 As BunifuCustomDataGrid
        Get
            Return table
        End Get
        Set(value As BunifuCustomDataGrid)
            table = value
        End Set
    End Property

    Public Property Text1 As String
        Get
            Return text__
        End Get
        Set(value As String)
            text__ = value
        End Set
    End Property

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.MouseClick
        Me.Close()

    End Sub

    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.MouseClick

        Try

            Check_vlaue(User_id)

            Try

                Check_vlaue(first_name)

                Try

                    Check_vlaue(last_name)

                    Try

                        Check_vlaue(username)

                        Try

                            Check_vlaue(email_address)

                            Try

                                Check_vlaue(password)

                                Try

                                    Check_vlaue(password_repeat)

                                    If Not (password.Text = password_repeat.Text Or password_repeat.Text = password.Text) Then
                                        MessageBox.Show("Password Mismatch")
                                    Else

                                        If (database.Register_User(User_id.Text, first_name.Text, last_name.Text, username.Text, email_address.Text, password.Text, "Febraury 14, 2109", "Active") = True) Then

                                            User_id.Text = ""
                                            first_name.Text = ""
                                            last_name.Text = ""
                                            email_address.Text = ""
                                            password.Text = ""
                                            password_repeat.Text = ""
                                            username.Text = ""
                                            database.User_Table(table, Text)

                                        End If

                                    End If
                                Catch ex As Exception
                                    MessageBox.Show("Fill Re-type password")
                                End Try
                            Catch ex As Exception
                                MessageBox.Show("Fill Password")
                            End Try

                        Catch ex As Exception
                            MessageBox.Show("Fill Email Address")
                        End Try

                    Catch ex As Exception
                        MessageBox.Show("Fill Username")
                    End Try

                Catch ex As Exception
                    MessageBox.Show("Fill LastName")
                End Try
            Catch ex As Exception

                MessageBox.Show("Fill First name")

            End Try


        Catch ex As Exception

            MessageBox.Show("User id is empty")

        End Try



    End Sub

    Private Sub Check_vlaue(ByVal form As Bunifu.Framework.UI.BunifuMaterialTextbox)

        If (form.Text.Equals("")) Then

            Throw New Exception

        End If

    End Sub

    Private Sub password_repeat_OnValueChanged(sender As Object, e As EventArgs)

        If Not (password.Text = password_repeat.Text) Then

            password_repeat.LineIdleColor = Color.Red
            password_mismatch.Visible = True
        Else

            password_repeat.LineIdleColor = Color.White
            password_mismatch.Visible = False

        End If

    End Sub

    ' for user id text Field --------------------------------------------------------------------
    Private Sub User_id_OnValueChanged(sender As Object, e As EventArgs) Handles User_id.OnValueChanged
        If (User_id.Text = "") Then
            userfield_error.Visible = True
            userfield_error.Text = "Username is empty"
        ElseIf (database.check_userid(User_id.Text) = True)
            userfield_error.Visible = True
            userfield_error.Text = "Id " + User_id.Text + " is already taken"
        Else
            userfield_error.Visible = False
            userfield_error.Text = ""
        End If

    End Sub

    ' for user id text Field --------------------------------------------------------------------

    Private Sub first_name_OnValueChanged(sender As Object, e As EventArgs) Handles first_name.OnValueChanged
        Error_Detection(first_name.Text, firstname_error, "First Name is empty")
    End Sub

    Private Sub last_name_OnValueChanged(sender As Object, e As EventArgs) Handles last_name.OnValueChanged
        Error_Detection(last_name.Text, lastname_error, "Last Name is empty")
    End Sub

    Private Sub email_address_OnValueChanged(sender As Object, e As EventArgs) Handles email_address.OnValueChanged


        Try
            Error_Detection(email_address.Text, email_error, "Email is empty")

            If Not (email_address.Text.Contains("@")) Then
                Throw New Exception
            Else

                If (database.check_email(email_address.Text) = True) Then
                    email_error.Text = "Email Already use"
                    email_error.Visible = True
                Else
                    email_error.Visible = False
                    email_error.Text = ""
                End If

            End If
        Catch ex As Exception
            email_error.Text = "Not a valid email"
            email_error.Visible = True
        End Try




    End Sub



    Private Sub password_OnValueChanged(sender As Object, e As EventArgs) Handles password.OnValueChanged
        Error_Detection(password.Text, password_error, "Password is empty")


    End Sub

    Private Sub password_repeat_OnValueChanged_1(sender As Object, e As EventArgs) Handles password_repeat.OnValueChanged
        Error_Detection(password_repeat.Text, password_mismatch, "Re type password Empty")
    End Sub

    ' Param 1 for the textfield you want to validate
    ' Param 2 the error lable
    ' Param 3 the value of the error value
    Private Sub Error_Detection(Text As String, lable As Label, value As String)

        If (Text.Equals("")) Then
            lable.Visible = True
            lable.Text = value
        Else
            lable.Text = ""
            lable.Visible = False
        End If
    End Sub

    Private Sub username_OnValueChanged(sender As Object, e As EventArgs) Handles username.OnValueChanged
        If (username.Text.Equals("")) Then

            username__.Visible = False
            username__.Text = "Empty username"
        Else
            If (database.check_username(username.Text) = True) Then
                username__.Visible = True
                username__.Text = username.Text + " is already taken"
            Else
                username__.Visible = False
                username__.Text = ""
            End If
        End If




    End Sub
End Class