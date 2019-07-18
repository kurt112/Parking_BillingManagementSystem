﻿Public Class Register2
    Private database As Server = New Server
    Private membership As Boolean = True

    Dim member As Membership = New Membership(0, "", "", "", "", "", "", "", "", "", "", "",
                                               "", "", "", "")


    Private Sub member_id_TextChanged(sender As Object, e As EventArgs) Handles member_id.TextChanged
        If (member_id.Text.Length >= 2) Then
            If (database.Member_query(member_id.Text, member) = True) Then
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
                If (promo_value.Text = "Not Activate") Then
                    Promo.selectedIndex = 0
                    parking_location.Text = database.generate_Location()
                Else
                    Dim quit As Boolean = False
                    Dim index As Integer = 0
                    While (quit = False)
                        MessageBox.Show(Promo.selectedValue)

                        

                        MessageBox.Show(index)
                        If (Promo.selectedValue.Equals(promo_value)) Then
                            quit = True
                        Else
                            index += 1
                        End If
                    End While
                    parking_location.Text = database.location_history(member_id.Text)
                End If
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
        End If
    End Sub

    Private Sub Park_Click(sender As Object, e As EventArgs) Handles Park.Click

        If (promo_value.Text = "Not Activate") Then

            Dim amount As Integer = CInt(initial_amount.Text)
            Dim location_amount As Integer = database.location_price(parking_location.Text)

            If (amount > location_amount) Then
                Dim total As Integer = amount - location_amount

                database.Update_InitialAmount(member_id.Text, total.ToString)
            Else
                MessageBox.Show("Insufficient Fund")

            End If
        Else
        End If

    End Sub



    Private Sub register_promo_button_Click(sender As Object, e As EventArgs) Handles register_promo_button.Click

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
                database.Update_Initital_Amount(result.ToString, member_id.Text)
                initial_amount.Text = result
                promo_value.Text = Promo.selectedValue
                database.Update_Promo(member_id.Text, Promo.selectedValue)
                database.Insert_History_Promo(New Promo_History("", member_id.Text, promo_value.Text,
                                                                parking_location.Text,
               Date.Today.ToString("dd'/'MM'/'yyyy"), Date.Today.AddDays(promo_ends).ToString("dd'/'MM'/'yyyy"), "Active"))
                MessageBox.Show("Succesful Registered")
                database.Update_location_Available(parking_location.Text, "Not Available")
            Else
                MessageBox.Show("Insufficient balance")
            End If


        Else
            MessageBox.Show("Wait you're promo to Expire")
        End If

    End Sub

    Private Sub member_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles member_id.KeyPress
        If (Asc(e.KeyChar) = 27) Then
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
        End If
    End Sub
End Class