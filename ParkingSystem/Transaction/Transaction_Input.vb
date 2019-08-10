Imports Bunifu.Framework.UI

Public Class Transaction_Input
    Private database As Server = New Server
    Private membership As Boolean = True
    Private promo_click = False
    Dim location_table As BunifuCustomDataGrid
    Dim member_table As BunifuCustomDataGrid
    Dim transaction_table As BunifuCustomDataGrid

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

    Public Property Location_table1 As BunifuCustomDataGrid
        Get
            Return location_table
        End Get
        Set(value As BunifuCustomDataGrid)
            location_table = value
        End Set
    End Property

    Public Property Member_table1 As BunifuCustomDataGrid
        Get
            Return member_table
        End Get
        Set(value As BunifuCustomDataGrid)
            member_table = value
        End Set
    End Property

    Public Property Transaction_table1 As BunifuCustomDataGrid
        Get
            Return transaction_table
        End Get
        Set(value As BunifuCustomDataGrid)
            transaction_table = value
        End Set
    End Property

    Private Sub member_id_TextChanged(sender As Object, e As EventArgs) Handles member_id.TextChanged

        If (member_id.Text.Length >= 10) Then
            Dim new_id = Replace(member_id.Text, Space(1), Space(2))
            If (database.Member_query(new_id, member) = True) Then

                setValue()
                database.Update_Login(member)

                If (member.Active1.Equals("ACTIVE")) Then

                    'Time out
                    database.Update_Member_Status(member.Member_id1, "INACTIVE")

                    If Not (member.Promo_activate1.Equals("Not Activate")) Then
                        parking_location.Text = database.generate_Occupide_Area(member_id.Text)

                    Else

                        If (firstname.Text.Equals("GUEST")) Then
                            'Gues Out
                            MessageBox.Show("Out in guest")
                            database.Update_InitialAmount(member_id.Text, "0")
                            database.set_Promo_Inactive(member_id.Text)

                        End If

                        parking_location.Text = database.generate_Occupide_Area(member_id.Text)
                        database.Update_location(parking_location.Text, "Available")
                        database.set_Promo_Inactive(member_id.Text)


                        '----------------------------------------------------------------'
                    End If
                    MessageBox.Show("Time Out Succesful")

                    Clear_Textbox()

                ElseIf (member.Active1.Equals("INACTIVE")) Then

                    database.Update_Member_Status(member.Member_id1, "ACTIVE")

                    If (promo_value.Text = "Not Activate") Then

                        'Time In when member
                        Promo_List.selectedIndex = 0
                        parking_location.Text = database.generate_Location()

                    Else

                        'just updating the location 
                        '  parking_location.Text = database.location_history(member_id.Text)

                        If (database.get_Promo_ends(member_id.Text).Equals(DateTime.Now)) Then

                            MessageBox.Show("Promo Expired")
                            database.Update_location(parking_location.Text, "Available")
                            database.set_Promo_Inactive(member_id.Text)
                            Promo_List.selectedIndex = 0
                            promo_value.Text = Promo_List.selectedValue


                        Else

                            'Getting thep prper name of the promo
                            parking_location.Text = database.generate_Occupide_Area(member_id.Text)

                            Dim quit As Boolean = False
                            Dim index As Integer = 0
                            While (quit = False)
                                If (Promo_List.selectedValue.Equals(promo_value.Text)) Then
                                    quit = True
                                Else
                                    index += 1
                                    Promo_List.selectedIndex = index
                                End If
                            End While

                            MessageBox.Show(parking_location.Text)
                            Clear_Textbox()
                        End If
                    End If

                End If

                database.Parking_Table("", location_table)
                database.MembershipTable("", member_table)

                database.Load_Historyparking("", Transaction_table1)
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
            Promo_List.Visible = False
            Register_Promo.Visible = False
        Else
            database.Promo_Combobox(Promo_List)
            Promo_List.selectedIndex = 0
            Clear_Textbox()
        End If
    End Sub

    Private Sub Park_Click(sender As Object, e As EventArgs) Handles Park.Click

        If (promo_value.Text = "Not Activate") Then

            'getting the amount of the textbox
            Dim amount As Integer = CInt(initial_amount.Text)

            'just getting the amount of the location
            Dim location_amount As Integer = database.location_price(parking_location.Text)

            If (promo_click = True) Then
                database.Parking_Table("", location_table)

                database.MembershipTable("", member_table)
            Else

                If (amount > location_amount And location_amount > 0) Then

                    Dim total As Object
                    Dim status_rate = ""

                    If (firstname.Text.Equals("GUEST")) Then

                        total = amount - location_amount
                        status_rate = "GUEST RATE"

                    Else
                        total = amount - location_amount * 0.8
                        status_rate = "MEMBER RATE"
                    End If

                    initial_amount.Text = total.ToString

                    'Updating the amount
                    database.Update_InitialAmount(member_id.Text, initial_amount.Text)

                    'Updating the location
                    database.Update_location(parking_location.Text, member_id.Text)
                    MessageBox.Show("Park Succesful")

                    'Inserting data into history
                    database.Insert_Parkinghistory(New Promo_History("", member_id.Text,
                                status_rate, parking_location.Text,
                        DateTime.Now, DateTime.Now.AddHours(8), username, "Active"))

                    'just clearing the textbox
                    database.Parking_Table("", location_table)

                    database.MembershipTable("", member_table)

                    database.Load_Historyparking("", Transaction_table1)
                    Clear_Textbox()
                Else

                    MessageBox.Show("Insufficient Fund")

                End If

            End If
        Else

            database.Parking_Table("", location_table)

            database.MembershipTable("", member_table)

            database.Load_Historyparking("", Transaction_table1)
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
                    price = database.Promo_Price(Promo_List.selectedValue)
                Catch ex As Exception
                    MessageBox.Show("Select Promo First")
                End Try

                Dim amount As Integer = CInt(initial_amount.Text)

                Dim result As Integer = amount - price

                If (result >= 0) Then
                    Dim promo_ends As Integer = database.Promo_ends(Promo_List.selectedValue)

                    If Not (promo_ends = 0) Then

                        database.Update_Initital_Amount(result.ToString, member_id.Text)
                        initial_amount.Text = result
                        promo_value.Text = Promo_List.selectedValue

                        'Just updating the promo
                        database.Update_Promo(member_id.Text, Promo_List.selectedValue)

                        'inserting the data into parking history 
                        database.Insert_Parkinghistory(New Promo_History("", member_id.Text,
                               promo_value.Text, parking_location.Text,
                        DateTime.Now, DateTime.Now.AddDays(promo_ends), username, "Active"))

                        MessageBox.Show("Succesful Registered")

                        '
                        database.Update_location(parking_location.Text, member_id.Text)
                        promo_click = True
                        database.Load_Historyparking("", Transaction_table1)
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
        Promo_List.selectedIndex = 0
        member_id.Text = ""
        parking_location.Text = ""
    End Sub

    Private Sub x_button_Click(sender As Object, e As EventArgs) Handles x_button.Click
        Me.Close()
    End Sub

    Private Sub Promo_List_onItemSelected(sender As Object, e As EventArgs) Handles Promo_List.onItemSelected
        If Not (firstname.Text.Equals("GUEST")) Then
        Else
            Promo_List.selectedIndex = 0
        End If
    End Sub
End Class