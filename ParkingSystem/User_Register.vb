Public Class User_Register

    Dim database As Server = New Server

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()

    End Sub

    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.Click

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

    Private Sub password_repeat_OnValueChanged(sender As Object, e As EventArgs) Handles password_repeat.OnValueChanged

        If Not (password.Text = password_repeat.Text) Then

            password_repeat.LineIdleColor = Color.Red
            password_mismatch.Visible = True
        Else

            password_repeat.LineIdleColor = Color.White
            password_mismatch.Visible = False

        End If

    End Sub

End Class