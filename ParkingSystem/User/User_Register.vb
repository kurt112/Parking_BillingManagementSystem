Imports Bunifu.Framework.UI
Imports ParkingSystem

Public Class User_Register
    Private ReadOnly database As Server = New Server
    Dim text__ As String
    Private user As User = New User("", "", "", "", "", "")
    Private Shadows update As Boolean = False
    Private id As String = ""
    Private look As Boolean = False
    Public Property Table1 As BunifuCustomDataGrid = New BunifuCustomDataGrid

    Public Property Text1 As String
        Get
            Return text__
        End Get
        Set(value As String)
            text__ = value
        End Set
    End Property

    Public Property Update1 As Boolean
        Get
            Return update
        End Get
        Set(value As Boolean)
            update = value
        End Set
    End Property

    Public Property User1 As User
        Get
            Return user
        End Get
        Set(value As User)
            user = value
        End Set
    End Property

    Public Property Look1 As Boolean
        Get
            Return look
        End Get
        Set(value As Boolean)
            look = value
        End Set
    End Property

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.MouseClick
        Me.Close()

    End Sub

    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.MouseClick

        If (Validate_input() = True) Then

            If (Register_Button.Text.Equals("Update")) Then
                If (database.Upate_user(id, New User(User_id.Text, first_name.Text, last_name.Text, email_address.Text, username.Text, password.Text)) = True) Then
                    database.User_Table(Table1, Text)
                End If
            ElseIf (Register_Button.Text.Equals("OK")) Then

                Me.Close()

            Else
                If (database.Register_User(New User(User_id.Text, first_name.Text, last_name.Text, email_address.Text, username.Text, password.Text)) = True) Then

                    User_id.Text = ""
                    first_name.Text = ""
                    last_name.Text = ""
                    email_address.Text = ""
                    password.Text = ""
                    password_repeat.Text = ""
                    username.Text = ""
                    database.User_Table(Table1, Text)

                End If
            End If
        End If

    End Sub

    Private Function Validate_input() As Boolean

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

                                        Return True

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

        Return False
    End Function

    Private Sub Check_vlaue(ByVal form As Bunifu.Framework.UI.BunifuMaterialTextbox)

        If (form.Text.Equals("")) Then

            Throw New Exception

        End If

    End Sub

    Private Sub Password_repeat_OnValueChanged(sender As Object, e As EventArgs)

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
        If Not (Register_Button.Text.Equals("Update")) Then
            If (User_id.Text = "") Then
                userfield_error.Visible = True
                userfield_error.Text = "Username is empty"
            ElseIf (database.Check_userid(User_id.Text) = True) Then
                userfield_error.Visible = True
                userfield_error.Text = "Id " + User_id.Text + " is already taken"
            Else
                userfield_error.Visible = False
                userfield_error.Text = ""
            End If
        End If

    End Sub

    ' for user id text Field --------------------------------------------------------------------

    Private Sub First_name_OnValueChanged(sender As Object, e As EventArgs) Handles first_name.OnValueChanged
        Error_Detection(first_name.Text, firstname_error, "First Name is empty")
    End Sub

    Private Sub Last_name_OnValueChanged(sender As Object, e As EventArgs) Handles last_name.OnValueChanged
        Error_Detection(last_name.Text, lastname_error, "Last Name is empty")
    End Sub

    Private Sub Email_address_OnValueChanged(sender As Object, e As EventArgs) Handles email_address.OnValueChanged

        Try
            Error_Detection(email_address.Text, email_error, "Email is empty")

            If Not (email_address.Text.Contains("@")) Then
                Throw New Exception
            Else

                If Not (Register_Button.Text.Equals("Update")) Then
                    If (database.Check_email(email_address.Text) = True) Then
                        email_error.Text = "Email Already use"
                        email_error.Visible = True
                    Else
                        email_error.Visible = False
                        email_error.Text = ""
                    End If

                End If

            End If
        Catch ex As Exception
            email_error.Text = "Not a valid email"
            email_error.Visible = True
        End Try
    End Sub

    Private Sub Password_OnValueChanged(sender As Object, e As EventArgs) Handles password.OnValueChanged
        Error_Detection(password.Text, password_error, "Password is empty")


    End Sub

    Private Sub Password_repeat_OnValueChanged_1(sender As Object, e As EventArgs) Handles password_repeat.OnValueChanged
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

    Private Sub Username_OnValueChanged(sender As Object, e As EventArgs) Handles username.OnValueChanged
        If Not (Register_Button.Text.Equals("Update")) Then
            If (username.Text.Equals("")) Then

                username__.Visible = False
                username__.Text = "Empty username"
            Else
                If (database.Check_username(username.Text) = True) Then
                    username__.Visible = True
                    username__.Text = username.Text + " is already taken"
                Else
                    username__.Visible = False
                    username__.Text = ""
                End If
            End If
        End If


    End Sub

    Private Sub User_Register_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (Update1 = True) Then

            If (look = True) Then
                Register_Button.Text = "OK"
            Else

                Register_Button.Text = "Update"

            End If
            User_id.Text = User1.Id1
            first_name.Text = User1.First_name1
            last_name.Text = User1.Last_name1
            password.Text = User1.Password1
            password_repeat.Text = User1.Password1
            email_address.Text = User1.Email1
            username.Text = User1.Username1
            id = User1.Id1
        End If
    End Sub
End Class