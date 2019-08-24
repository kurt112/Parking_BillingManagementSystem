Imports Bunifu.Framework.UI
Imports ParkingSystem

Public Class Member_Register

#Region "Object And Variable"
    Private user As String
    Private is_Update As Boolean = False

    Private ReadOnly database As Server = New Server
    Dim strFileName As String = ""
    Private park_list As Boolean = False
    Private Update_member As Membership = New Membership("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")

    Dim id As String

    Private profit_table As BunifuCustomDataGrid
    Private total_label As Label
#End Region

#Region "On Load"
    Private Sub Member_Register_Load(sender As Object, e As EventArgs) Handles Me.Load
        '  MessageBox.Show(user)
        If (Update1 = True) Then


            If (park_list = True) Then
                Register_Button.Text = "OK"
            Else
                Register_Button.Text = "Update"
            End If

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
            id = Update_member.Member_id1
        End If
        Me.Width = 1225
    End Sub
#End Region

#Region "Getter and Setter"

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
            Return Table2
        End Get
        Set(value As BunifuCustomDataGrid)
            Table2 = value
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

    Public Property Park_list1 As Boolean
        Get
            Return park_list
        End Get
        Set(value As Boolean)
            park_list = value
        End Set
    End Property

    Public Property Table2 As BunifuCustomDataGrid = New BunifuCustomDataGrid

    Public Property Total_label1 As Label
        Get
            Return total_label
        End Get
        Set(value As Label)
            total_label = value
        End Set
    End Property

    Public Property Profit_table1 As BunifuCustomDataGrid
        Get
            Return profit_table
        End Get
        Set(value As BunifuCustomDataGrid)
            profit_table = value
        End Set
    End Property
#End Region

    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.Click

        If (park_list = True) Then
            Me.Close()
        Else
            If (is_Update = False) Then
                If (Validate_input() = True) Then

                    Try
                        Dim points As Integer = CInt(initial_amount.Text) / 50

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
                End If
            Else
                If (Validate_input() = True) Then

                    If (database.Update_Member(id, New Membership(member_id.Text, first_name.Text, last_name.Text, email_address.Text,
                                                            cellphone_number.Text, Telephone_Number.Text, date_of_birth.Value.ToString("dd'/'MM'/'yyyy"), initial_amount.Text,
                                                            "0", points_value.Text, "", "", user, Date.Now.ToString("dd'/'MM'/'yyyy"), total_spend.Text, "Not Activate", Place_of_Birth.Text,
                                                            person_to_contact.Text, Person_to_contact_number.Text, strFileName, "INACTIVE")) = True) Then
                        Refresh_fields()
                    End If
                Else
                    '   MessageBox.Show("Im in update")
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

    Private Sub Member_id_TextChanged(sender As Object, e As EventArgs) Handles member_id.TextChanged
        If (member_id.Text = "") Then
            Label_show(member_id_alert)
        Else
            Label_hide(member_id_alert)
        End If
    End Sub

    Private Sub First_name_TextChanged(sender As Object, e As EventArgs) Handles first_name.TextChanged
        If (first_name.Text = "") Then
            Label_show(first_name_alert)
        Else
            Label_hide(first_name_alert)
        End If
    End Sub

    Private Sub Last_name_TextChanged(sender As Object, e As EventArgs) Handles last_name.TextChanged
        If (last_name.Text = "") Then
            Label_show(last_name_alert)
        Else
            Label_hide(last_name_alert)
        End If
    End Sub

    Private Sub Cellphone_number_TextChanged(sender As Object, e As EventArgs) Handles cellphone_number.TextChanged
        If (cellphone_number.Text = "") Then
            Label_show(cellphone_number_empty)
        Else
            Label_hide(cellphone_number_empty)
        End If
    End Sub


    Private Sub Person_to_contact_TextChanged(sender As Object, e As EventArgs) Handles person_to_contact.TextChanged
        If (person_to_contact.Text = "") Then
            Label_show(person_contact_empty)
        Else
            Label_hide(person_contact_empty)
        End If
    End Sub

    Private Sub Email_address_TextChanged(sender As Object, e As EventArgs) Handles email_address.TextChanged
        If (email_address.Text = "") Then
            Label_show(emailaddress_alert)
        Else
            Label_hide(emailaddress_alert)
        End If
    End Sub

    Private Sub Telephone_Number_TextChanged(sender As Object, e As EventArgs) Handles Telephone_Number.TextChanged
        If (Telephone_Number.Text = "") Then
            Label_show(telephonenumber_alert)
        Else
            Label_hide(telephonenumber_alert)
        End If
    End Sub

    Private Sub Place_of_Birth_TextChanged(sender As Object, e As EventArgs) Handles Place_of_Birth.TextChanged
        If (Place_of_Birth.Text = "") Then
            Label_show(place_of_birth_alert)
        Else
            Label_hide(place_of_birth_alert)
        End If
    End Sub

    Private Sub Person_to_contact_number_TextChanged(sender As Object, e As EventArgs) Handles Person_to_contact_number.TextChanged
        If (Person_to_contact_number.Text = "") Then
            Label_show(person_to_contact_number_alert)
        Else
            Label_hide(person_to_contact_number_alert)
        End If
    End Sub

    Private Sub Label_show(ByVal text As Label)
        text.Visible = True
    End Sub
    Private Sub Label_hide(ByVal text As Label)
        text.Visible = False
    End Sub

    Private Sub Upload_Button_Click(sender As Object, e As EventArgs) Handles Upload_Button.Click
        Using fd As OpenFileDialog = New OpenFileDialog()

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
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Top_Up_Click(sender As Object, e As EventArgs) Handles Top_Up.Click
        Using value As InputBox = New InputBox
            value.User_assisgn1 = user
            If (Register_Button.Text = "Update") Then

                value.Top_Up1 = True
                value.Points1 = points_value
                value.Member1 = Update_member
                value.Total_spend1 = total_spend

            Else
                value.Register1 = True

            End If
            value.Profit_table1 = profit_table
            value.Total_label1 = total_label
            value.Update_TextBox1 = initial_amount
            value.ShowDialog()
        End Using
    End Sub
End Class