Imports Bunifu.Framework.UI
Imports ParkingSystem

Public Class Member_Register

    Private user As String = "asfa"
    Private is_Update As Boolean = False

    Private database As Server = New Server
    Dim strFileName As String = ""
    Dim Update_member As Membership = New Membership("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
    Dim table As BunifuCustomDataGrid = New BunifuCustomDataGrid
    Private Sub Member_Register_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (Update1 = True) Then

            Register_Button.Text = "Update"
            first_name.Text = Update_member1.First_name1
            last_name.Text = Update_member1.Last_name1
            member_id.Text = Update_member1.Member_id1
            email_address.Text = Update_member1.Email_address1
            Try
                photo.Image = Image.FromFile(Update_member1.Photo1)
            Catch ex As Exception

            End Try

            cellphone_number.Text = Update_member1.Cellphone_number1
            Telephone_Number.Text = Update_member1.Phone_number1
            Place_of_Birth.Text = Update_member1.Place_of_birth1
            person_to_contact.Text = Update_member1.Person_to_contact1
            Person_to_contact_number.Text = Update_member1.Phone_number1
            initial_amount.Text = Update_member1.Initital_amount1
            login_times_value.Text = Update_member1.Login_times1
            points_value.Text = Update_member1.Points1
            last_parking.Text = Update_member1.Last_parking1
            membership_level_value.Text = Update_member1.Membership_level1
            cashier_value.Text = Update_member1.Cashier_registered1
            date_registered_value.Text = Update_member1.Date_registered1
            total_spend.Text = Update_member1.Total_spend1

            date_of_birth.Value = Update_member1.Date_of_birth1

        End If
        Me.Width = 1225
    End Sub


    Public Property User1 As String
        Get
            Return user
        End Get
        Set(value As String)
            user = value
        End Set
    End Property

    Public Property Table1 As BunifuCustomDataGrid
        Get
            Return table
        End Get
        Set(value As BunifuCustomDataGrid)
            table = value
        End Set
    End Property

    Public Property Update_member1 As Membership
        Get
            Return Update_member
        End Get
        Set(value As Membership)
            Update_member = value
        End Set
    End Property

    Public Property Update1 As Boolean
        Get
            Return is_Update
        End Get
        Set(value As Boolean)
            is_Update = value
        End Set
    End Property

    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.Click
        If (is_Update = False) Then
            If (Validate_input() = True) Then
                Dim points As Integer = 0
                Try
                    points = CInt(initial_amount.Text) / 50
                    Dim new_id = Replace(member_id.Text, Space(1), Space(2))
                    database.Membership_Register(New Membership(new_id, first_name.Text, last_name.Text, email_address.Text,
                                                    cellphone_number.Text, Telephone_Number.Text, date_of_birth.Value.ToString("dd'/'MM'/'yyyy"), initial_amount.Text,
                                                    "0", points.ToString, "", "", user, Date.Now.ToString("dd'/'MM'/'yyyy"), initial_amount.Text, "Not Activate", Place_of_Birth.Text,
                                                    person_to_contact.Text, Person_to_contact_number.Text, strFileName, "INACTIVE"))
                    Refresh_fields()
                Catch ex As Exception
                    MessageBox.Show("Can't Process the input")
                End Try
            Else

                If (Validate_input() = True) Then
                    MessageBox.Show("hjask")
                    If (database.Update_Member(New Membership(member_id.Text, first_name.Text, last_name.Text, email_address.Text,
                                                        cellphone_number.Text, Telephone_Number.Text, date_of_birth.Value.ToString("dd'/'MM'/'yyyy"), initial_amount.Text,
                                                        "0", points_value.Text, "", "", user, Date.Now.ToString("dd'/'MM'/'yyyy"), total_spend.Text, "Not Activate", Place_of_Birth.Text,
                                                        person_to_contact.Text, Person_to_contact_number.Text, strFileName, "INACTIVE")) = True) Then
                        MessageBox.Show("Update Succesful")
                        Refresh_fields()
                    End If
                Else
                    MessageBox.Show("Im in update")
                End If

            End If
        End If

    End Sub

    Private Function Validate_input() As Boolean

        Try

            If (member_id.Text.Length >= 10) Then
                Try
                    If Not (first_name.Text.Length = 0) Then
                        Try
                            If Not (last_name.Text.Length = 0) Then
                                Try
                                    If (email_address.Text.Contains("@")) Then
                                        Try
                                            If (cellphone_number.Text.Length >= 10) Then
                                                Try
                                                    If (Telephone_Number.Text >= 7 Or Telephone_Number.Text = "Nan") Then
                                                        MessageBox.Show(member_id.Text)
                                                        Return True

                                                    Else
                                                        Throw New Exception
                                                    End If
                                                Catch ex As Exception
                                                    MessageBox.Show("Not a valid TelephoneNumber")
                                                End Try
                                            Else
                                                Throw New Exception
                                            End If

                                        Catch ex As Exception
                                            MessageBox.Show("Not a valid Cellphone number")
                                        End Try
                                    Else
                                        Throw New Exception
                                    End If

                                Catch ex As Exception
                                    MessageBox.Show("Not a valid Email`")
                                End Try
                            Else
                                Throw New Exception
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Last Name is empty")
                        End Try
                    Else
                        Throw New Exception
                    End If
                Catch ex As Exception
                    MessageBox.Show("First name is empty")
                End Try
            Else
                Throw New Exception
            End If

        Catch ex As Exception
            MessageBox.Show("Member id should have greater than 10 numbers")
        End Try
        Return False
    End Function

    Private Sub Refresh_fields()

        Telephone_Number.Text = ""
        member_id.Text = ""
        first_name.Text = ""
        last_name.Text = ""
        cellphone_number.Text = ""
        Telephone_Number.Text = ""
        email_address.Text = ""
        initial_amount.Text = ""
        Place_of_Birth.Text = ""
        person_to_contact.Text = ""
        Person_to_contact_number.Text = ""
        database.MembershipTable("", Table1)
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
        If (person_to_contact.Text = "") Then
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

    Private Sub Upload_Button_Click(sender As Object, e As EventArgs) Handles Upload_Button.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\Users\orioque35\Pictures"
        '"All files (*.*)|*.*|All files (*.*)|*.*"
        fd.Filter = "Pictures (*.jpg *.jpeg *.png *.gif)| *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True


        If (fd.ShowDialog = DialogResult.OK) Then
            strFileName = fd.FileName
            photo.Image = Image.FromFile(fd.FileName)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Top_Up_Click(sender As Object, e As EventArgs) Handles Top_Up.Click
        Dim value As InputBox = New InputBox

        If (Register_Button.Text = "Update") Then
            value.Top_Up1 = True
            value.Points1 = points_value
            value.Total_spend1 = total_spend
            value.Member1 = Update_member
            value.Update_TextBox1 = initial_amount
        Else
            value.Register1 = True
            value.Update_TextBox1 = initial_amount

        End If
        value.ShowDialog()
        value.Update_TextBox1 = initial_amount
    End Sub
End Class