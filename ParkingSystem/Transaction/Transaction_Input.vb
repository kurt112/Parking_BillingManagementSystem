Imports System.Drawing.Printing
Imports Bunifu.Framework.UI

Public Class Transaction_Input
    Private ReadOnly database As Server = New Server
    Private ReadOnly membership As Boolean = True
    Private promo_click = False
    Dim location_table As BunifuCustomDataGrid
    Dim member_table As BunifuCustomDataGrid
    Dim transaction_table As BunifuCustomDataGrid
    Private date_today = Date.Today.ToString("dd'/'MM'/'yyyy")




    'Don't Remove the Space
    ReadOnly Date_word = " PARKING_HISTORY.DATE = "
    Private profit_total_label As Label

    Dim profit_table As BunifuCustomDataGrid

    Private Property Username As String
    ReadOnly member As Membership = New Membership(0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
    Public Property Profit_table1 As BunifuCustomDataGrid
        Get
            Return profit_table
        End Get
        Set(value As BunifuCustomDataGrid)
            profit_table = value
        End Set
    End Property
    Public Property Username1 As String
        Get
            Return Username
        End Get
        Set(value As String)
            Username = value
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


    Public Property Profit_total_label1 As Label
        Get
            Return profit_total_label
        End Get
        Set(value As Label)
            profit_total_label = value
        End Set
    End Property

    Private Sub Member_id_TextChanged(sender As Object, e As EventArgs) Handles member_id.TextChanged

        If (member_id.Text.Length >= 10) Then
            Dim new_id = Replace(member_id.Text, Space(1), Space(2))
            If (database.Member_query(new_id, member) = True) Then

                SetValue()
                database.Update_Login(member)

                If (member.Active1.Equals("ACTIVE")) Then

                    'Time out
                    database.Update_Member_Status(member.Member_id1, "INACTIVE")

                    If Not (member.Promo_activate1.Equals("Not Activate")) Then
                        parking_location.Text = database.Generate_Occupide_Area(member_id.Text)

                    Else

                        If (firstname.Text.Equals("GUEST")) Then
                            'Gues Out
                            MessageBox.Show("Out in guest")
                            database.Update_InitialAmount(member_id.Text, "0")
                            database.Set_Promo_Inactive(member_id.Text)

                        End If

                        parking_location.Text = database.Generate_Occupide_Area(member_id.Text)
                        database.Update_location(parking_location.Text, "Available")
                        database.Set_Promo_Inactive(member_id.Text)


                        '----------------------------------------------------------------'
                    End If
                    MessageBox.Show("Time Out Succesful")

                    Clear_Textbox()

                ElseIf (member.Active1.Equals("INACTIVE")) Then
                    MessageBox.Show("Time In Succesful")
                    database.Update_Member_Status(member.Member_id1, "ACTIVE")

                    If (promo_value.Text = "Not Activate") Then

                        'Time In when member
                        Promo_List.selectedIndex = 0
                        parking_location.Text = database.Generate_Location()

                    Else

                        'just updating the location 
                        '  parking_location.Text = database.location_history(member_id.Text)

                        If (database.Get_Promo_ends(member_id.Text).Equals(DateTime.Now)) Then

                            MessageBox.Show("Promo Expired")
                            database.Update_location(parking_location.Text, "Available")
                            database.Set_Promo_Inactive(member_id.Text)
                            Promo_List.selectedIndex = 0
                            promo_value.Text = Promo_List.selectedValue


                        Else

                            'Getting thep prper name of the promo
                            parking_location.Text = database.Generate_Occupide_Area(member_id.Text)

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

                            'MessageBox.Show(parking_location.Text)
                            Clear_Textbox()
                        End If
                    End If

                End If

                database.Parking_Table("", location_table)
                database.MembershipTable("", member_table)

                database.Load_Historyparking("", Transaction_table1, False, Date_word)
            Else


                Clear_Textbox()
            End If

        End If

    End Sub

    Private Sub Top_Up_Click(sender As Object, e As EventArgs) Handles Top_Up.Click
        Using value As InputBox = New InputBox

            value.Member1 = member
            value.Top_Up1 = True
            value.Value1 = initial_amount.Text
            value.Update_TextBox1 = initial_amount
            value.Total_spend1 = total_spend
            value.Points1 = points_value
            value.Total_login1 = login_times_value
            value.User_assisgn1 = Username
            value.Total_label1 = profit_total_label
            value.Profit_table1 = profit_table
            value.ShowDialog()

        End Using

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
            Dim location_amount As Integer = database.Location_price(parking_location.Text)

            If (promo_click = True) Then
                database.Parking_Table("", location_table)

                database.MembershipTable("", member_table)
            Else

                If (amount >= location_amount And location_amount >= 0) Then

                    Dim total As Object
                    Dim status_rate As String

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
                        DateTime.Now, DateTime.Now.AddHours(8), Username, "Active"))

                    'just clearing the textbox
                    database.Parking_Table("", location_table)

                    database.MembershipTable("", member_table)
                    'MessageBox.Show(database.Get_Floor(parking_location.Text))
                    database.Load_Historyparking("", Transaction_table1, False, Date_word)
                    ' Solve ko bukas
#Region "For Printing The Reciept"
                    'defaultPrinterSetting = DocumentPriter.GetDefaultPrinterSetting

                    'PrintPreviewDialog1.Document = PrintDocument1
                    PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.0
                    'PrintDialog1.ShowDialog()

                    'rintPreviewDialog1.Document = PrintDocument1

                    Dim page As New PageSetupDialog
                    With page
                        .AllowOrientation = True
                        .AllowPaper = True
                        .AllowPrinter = True
                        .ShowHelp = True
                        .ShowNetwork = True
                    End With
                    page.Document = PrintDocument1
                    PrintDocument1.PrinterSettings.PrinterName = "XP-58"
                    With PrintDocument1
                        .PrinterSettings.DefaultPageSettings.Landscape = False
                        .PrintController = New StandardPrintController()
                        .Print()
                    End With
                    'If Not myPageAlreadySetUp Then
                    'With page.Document.DefaultPageSettings
                    '.Margins.Top = 50
                    '.Margins.Left = 50
                    '.Margins.Right = 50
                    '.Margins.Bottom = 50
                    '.PaperSize.Height = 2
                    '.Landscape = False
                    'End With
                    'End If
                    'page.Sh    owDialog()


                    'PrintPreviewDialog1.Document = PrintDocument1

                    'PrintPreviewDialog1.ShowDialog()

                    'Me.Close()

#End Region

                    Clear_Textbox()
                Else

                    MessageBox.Show("Insufficient Fund")

                End If

            End If
        Else

            database.Parking_Table("", location_table)

            database.MembershipTable("", member_table)

            database.Load_Historyparking("", Transaction_table1, False, Date_word)

            Clear_Textbox()
        End If
    End Sub

    Private Sub Register_promo_button_Click(sender As Object, e As EventArgs) Handles register_promo_button.Click

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
                        DateTime.Now, DateTime.Now.AddDays(promo_ends), Username, "Active"))

                        MessageBox.Show("Succesful Registered")

                        '
                        RegisterPromo_Document.Print()
                        database.Update_location(parking_location.Text, member_id.Text)
                        promo_click = True
                        database.Load_Historyparking("", Transaction_table1, False, Date_word)
                    End If

                Else
                    MessageBox.Show("Insufficient balance")
                End If
            Else
                MessageBox.Show("Wait you're promo to Expire")
            End If

        End If
    End Sub

    Private Sub Member_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles member_id.KeyPress
        If (Asc(e.KeyChar) = 27) Then
            Clear_Textbox()
        End If
    End Sub

    Private Sub SetValue()
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

    Private Sub X_button_Click(sender As Object, e As EventArgs) Handles x_button.Click
        Me.Close()
    End Sub

    Private Sub Promo_List_onItemSelected(sender As Object, e As EventArgs) Handles Promo_List.onItemSelected
        If Not (firstname.Text.Equals("GUEST")) Then
        Else
            Promo_List.selectedIndex = 0
        End If
    End Sub
#Region "For Printing A Receipt"
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim font_name As String = "Courier New"
        Dim font_size As Integer = 9
        Dim csz As New PaperSize("Custom Paper Size", 2, 2)
        ' PrintDocument1.PrinterSettings.DefaultPageSettings.PaperSize = csz
        Dim interval As Integer = 30

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 0, interval)
        interval += 30

        e.Graphics.DrawString("Parking Billing", New Font(font_name, 11, FontStyle.Bold), Brushes.Black, 15, interval)
        interval += 30

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 0, interval)
        interval += 30

        e.Graphics.DrawString("User Assign: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(Username, New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 100, interval)
        interval += 30

        e.Graphics.DrawString("Member Name: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(member.First_name1, New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 100, interval)
        interval += 30

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 0, interval)
        interval += 30
        'For Location
        e.Graphics.DrawString("Location ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        interval += 30

        e.Graphics.DrawString("Location Name: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(parking_location.Text, New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 140, interval)
        interval += 30

        e.Graphics.DrawString("Location Floor: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(database.Get_Floor(parking_location.Text), New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 140, interval)
        interval += 30

        e.Graphics.DrawString("Location Fee: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(database.Location_price(parking_location.Text), New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 140, interval)
        interval += 30

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 0, interval)
        interval += 30

        'For Time
        e.Graphics.DrawString("Parking Status ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        interval += 30

        e.Graphics.DrawString("Time In: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(TimeOfDay.ToString("h:mm:ss tt"), New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 90, interval)
        interval += 30

        e.Graphics.DrawString("Time Out: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(TimeOfDay.AddHours(8).ToString("h:mm:ss tt"), New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 90, interval)
        interval += 30

        e.Graphics.DrawString("Date: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(Date.Today.ToString("dd'/'MM'/'yyyy"), New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 90, interval)
        interval += 30

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 0, interval)



        e.PageSettings.PaperSize = csz

        'e.Graphics.DrawString("SampleText", New Font("Arial", 70, FontStyle.Bold), Brushes.Blue, 175, 130)
    End Sub


    Private Sub RegisterPromo_Document_PrintPage(sender As Object, e As PrintPageEventArgs) Handles RegisterPromo_Document.PrintPage
        Dim promo_ends As Integer = database.Promo_ends(Promo_List.selectedValue)
        Dim promo_price As Integer = database.Promo_Price(Promo_List.selectedValue)

        Dim font_name As String = "Courier New"
        Dim font_size As Integer = 9
        Dim csz As New PaperSize("Custom Paper Size", 2, 2)

        Dim interval As Integer = 30

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 0, interval)
        interval += 30

        e.Graphics.DrawString("Parking Billing", New Font(font_name, 11, FontStyle.Bold), Brushes.Black, 15, interval)
        interval += 30

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 0, interval)
        interval += 30

        e.Graphics.DrawString("User Assign: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(Username, New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 100, interval)
        interval += 30

        e.Graphics.DrawString("Member Name: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(member.First_name1, New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 100, interval)
        interval += 30

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 0, interval)
        interval += 30
        'For Location
        e.Graphics.DrawString("Location ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        interval += 30

        e.Graphics.DrawString("Location Name: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(parking_location.Text, New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 140, interval)
        interval += 30

        e.Graphics.DrawString("Location Floor: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(database.Get_Floor(parking_location.Text), New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 140, interval)
        interval += 30

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 0, interval)
        interval += 30


        'For Time
        e.Graphics.DrawString("Promo Status", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        interval += 30

        e.Graphics.DrawString("Promo Price: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(promo_price, New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 90, interval)
        interval += 30

        e.Graphics.DrawString("Promo Name: ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        e.Graphics.DrawString(Promo_List.selectedValue, New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 90, interval)
        interval += 30

        e.Graphics.DrawString("Promo Start", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        interval += 30

        e.Graphics.DrawString("Date: ", New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 0, interval)
        e.Graphics.DrawString(date_today, New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 90, interval)
        interval += 30

        e.Graphics.DrawString("Time: ", New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 0, interval)
        e.Graphics.DrawString(TimeOfDay.ToString("h:mm:ss tt"), New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 90, interval)
        interval += 30


        e.Graphics.DrawString("Promo End ", New Font(font_name, font_size, FontStyle.Bold), Brushes.Black, 0, interval)
        interval += 30

        e.Graphics.DrawString("Date: ", New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 0, interval)
        e.Graphics.DrawString(DateTime.Now.AddDays(promo_ends).ToString("dd'/'MM'/'yyyy"), New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 90, interval)
        interval += 30

        e.Graphics.DrawString("Time: ", New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 0, interval)
        e.Graphics.DrawString(TimeOfDay.ToString("h:mm:ss tt"), New Font(font_name, font_size, FontStyle.Regular), Brushes.Black, 90, interval)
        interval += 30

        e.Graphics.DrawString("_______________________________________________ ", New Font(font_name, 11, FontStyle.Regular), Brushes.Black, 0, interval)



        e.PageSettings.PaperSize = csz
    End Sub
#End Region
End Class