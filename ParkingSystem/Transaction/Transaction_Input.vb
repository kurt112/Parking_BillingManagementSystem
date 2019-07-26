Public Class Transaction_Input
    Private database As Server = New Server
    Private membership As Boolean = True
    Private promo_click = False
    Private Property username As String
    Dim member As Membership = New Membership(0, "", "", "", "", "", "", "", "", "", "", "",
                                               "", "", "", "", "", "", "", "", "")

    Public Property Username1 As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Private Sub member_id_TextChanged(sender As Object, e As EventArgs) Handles member_id.TextChanged

        If (member_id.Text.Length >= 2) Then

            If (database.Member_query(member_id.Text, member) = True) Then

                setValue()
                database.Update_Login(member)

                If (member.Active1.Equals("ACTIVE")) Then

                    'Out when Member
                    database.Update_Member_Status(member.Member_id1, "INACTIVE")
                    If (firstname.Text.Equals("GUEST")) Then
                        'Gues Out
                        parking_location.Text = database.generate_Occupide_Area(member_id.Text)
                        MessageBox.Show("Out in guest")
                        database.Update_InitialAmount(member_id.Text, "0")
                        database.Update_location(parking_location.Text, "Available")
                    End If

                    MessageBox.Show("Time Out Succesful")

                    Clear_Textbox()

                ElseIf (member.Active1.Equals("INACTIVE")) Then

                    database.Update_Member_Status(member.Member_id1, "ACTIVE")

                    If (promo_value.Text = "Not Activate") Then
                        'Time In when member
                        Promo.selectedIndex = 0
                        parking_location.Text = database.generate_Location()
                    Else
                        'just updating the location 
                        parking_location.Text = database.location_history(member_id.Text)
                        If (database.get_Promo_ends(member_id.Text).Equals(DateTime.Now)) Then
                            MessageBox.Show("Promo Expired")
                            database.Update_location(parking_location.Text, "Available")
                            database.set_Promo_Inactive(member_id.Text)
                            Promo.selectedIndex = 0
                            promo_value.Text = Promo.selectedValue
                        Else
                            'Getting thep prper name of the promo
                            Dim quit As Boolean = False
                            Dim index As Integer = 0
                            While (quit = False)
                                If (Promo.selectedValue.Equals(promo_value.Text)) Then
                                    quit = True
                                Else
                                    index += 1
                                    Promo.selectedIndex = index
                                End If
                            End While
                        End If
                    End If

                End If
            Else
                Clear_Textbox()
            End If

        End If
    End Sub

    Private Sub Top_Up_Click(sender As Object, e As EventArgs) Handles Top_Up.Click
        Dim value As InputBox = New InputBox

        value.Member1 = member
        value.Top_Up1 = True
        value.Value1 = initial_amount.Text
        value.Update_TextBox1 = initial_amount
        value.Total_spend1 = total_spend
        value.Points1 = points_value
        value.Total_login1 = login_times_value
        value.ShowDialog()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (membership = False) Then
            Promo.Visible = False
            Register_Promo.Visible = False
        Else
            database.Promo_Combobox(Promo)
            Promo.selectedIndex = 0
            Clear_Textbox()
        End If
    End Sub

    Private Sub Park_Click(sender As Object, e As EventArgs) Handles Park.Click

        If (promo_value.Text = "Not Activate") Then

            Dim amount As Integer = CInt(initial_amount.Text)
            Dim location_amount As Integer = database.location_price(parking_location.Text)

            If (promo_click = True) Then

            Else

                If (amount > location_amount) Then
                    Dim total As Object
                    Dim status_rate = ""
                    If Not (firstname.Text.Equals("GUEST")) Then
                        total = amount - location_amount
                        status_rate = "GUEST RATE"

                    Else
                        total = amount - location_amount * 0.8
                        status_rate = "MEMBER RATE"
                    End If

                    initial_amount.Text = total.ToString
                    database.Update_InitialAmount(member_id.Text, initial_amount.Text)
                        database.Update_location(parking_location.Text, member_id.Text)
                        MessageBox.Show("Park Succesful")
                    database.Insert_Parkinghistory(New Promo_History("", member_id.Text,
                                status_rate, parking_location.Text,
                        DateTime.Now, DateTime.Now.AddHours(8), username, "Active"))
                    Clear_Textbox()
                    Else
                        MessageBox.Show("Insufficient Fund")

                End If

            End If
        Else
            MessageBox.Show("Park Succesful")
            Clear_Textbox()
        End If
    End Sub
    Private Sub register_promo_button_Click(sender As Object, e As EventArgs) Handles register_promo_button.Click

        If (firstname.Text.Equals("GUEST") Or last_name.Text.Equals("GUEST")) Then
            MessageBox.Show("Must be a member to register this promo")
        Else
            If (promo_value.Text = "Not Activate") Then
                Dim price = 0
                Try
                    price = database.Promo_Price(Promo.selectedValue)
                Catch ex As Exception
                    MessageBox.Show("Select Promo First")
                End Try

                Dim amount As Integer = CInt(initial_amount.Text)

                Dim result As Integer = amount - price

                If (result >= 0) Then
                    Dim promo_ends As Integer = database.Promo_ends(Promo.selectedValue)

                    If Not (promo_ends = 0) Then

                        database.Update_Initital_Amount(result.ToString, member_id.Text)
                        initial_amount.Text = result
                        promo_value.Text = Promo.selectedValue

                        database.Update_Promo(member_id.Text, Promo.selectedValue)

                        database.Insert_Parkinghistory(New Promo_History("", member_id.Text,
                               promo_value.Text, parking_location.Text,
                        DateTime.Now, DateTime.Now.AddDays(promo_ends), username, "Active"))

                        MessageBox.Show("Succesful Registered")
                        database.Update_location(parking_location.Text, member_id.Text)
                        promo_click = True
                    End If

                Else
                    MessageBox.Show("Insufficient balance")
                End If
            Else
                MessageBox.Show("Wait you're promo to Expire")
            End If

        End If
    End Sub

    Private Sub member_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles member_id.KeyPress
        If (Asc(e.KeyChar) = 27) Then
            Clear_Textbox()
        End If
    End Sub

    Private Sub setValue()
        firstname.Text = member.First_name1
        last_name.Text = member.Last_name1
        email.Text = member.Email_address1
        cellphone.Text = member.Cellphone_number1
        Telephone.Text = member.Phone_number1
        login_times_value.Text = member.Login_times1
        points_value.Text = member.Points1
        last_parking.Text = member.Last_parking1
        membership_level_value.Text = member.Membership_level1
        cashier_value.Text = member.Cashier_registered1
        date_registered_value.Text = member.Date_registered1
        total_spend.Text = member.Total_spend1
        initial_amount.Text = member.Initital_amount1
        promo_value.Text = member.Promo_activate1
    End Sub

    Private Sub Clear_Textbox()
        firstname.Text = ""
        last_name.Text = ""
        email.Text = ""
        cellphone.Text = ""
        Telephone.Text = ""
        login_times_value.Text = ""
        points_value.Text = ""
        last_parking.Text = ""
        membership_level_value.Text = ""
        cashier_value.Text = ""
        date_registered_value.Text = ""
        total_spend.Text = ""
        initial_amount.Text = ""
        promo_value.Text = ""
        Promo.selectedIndex = 0
        member_id.Text = ""
        parking_location.Text = ""
    End Sub

    Private Sub x_button_Click(sender As Object, e As EventArgs) Handles x_button.Click
        Me.Close()
    End Sub

    Private Sub Promo_onItemSelected(sender As Object, e As EventArgs) Handles Promo.onItemSelected
        If Not (firstname.Text.Equals("GUEST")) Then
        Else
            Promo.selectedIndex = 0
        End If
    End Sub
End Class