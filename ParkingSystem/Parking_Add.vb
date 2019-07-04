Public Class Parking_Add

    Private database As Server = New Server

    Private item_price As List(Of String) = New List(Of String)
    Private item_level As List(Of String) = New List(Of String)

    Private combobox_level As Combobox = New Combobox
    Private combobox_fee As Combobox = New Combobox
    Private level_showing As Boolean = False
    Private fee_showing As Boolean = False

    Public Property button_level As Bunifu.Framework.UI.BunifuFlatButton
        Get
            Return parking_level_button
        End Get

        Set(ByVal my_button As Bunifu.Framework.UI.BunifuFlatButton)
            parking_level_button = my_button
        End Set
    End Property

    Public Property button_fee As Bunifu.Framework.UI.BunifuFlatButton
        Get
            Return parking_fee_button
        End Get

        Set(ByVal my_button As Bunifu.Framework.UI.BunifuFlatButton)
            parking_fee_button = my_button
        End Set
    End Property

    Sub switchPanel(ByVal panel As Combobox, ByVal Main_Panel As Panel)

        Main_Panel.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Main_Panel.Controls.Add(panel)
        Main_Panel.BackColor = Color.Transparent
        panel.Show()

    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub List_to_Combobox(ByVal combobox As Bunifu.Framework.UI.BunifuCustomDataGrid, ByVal list As List(Of String))

        For i As Integer = 0 To list.Count

            For j As Integer = i + 1 To list.Count - 1

                If (list(i).Equals(list(j))) Then

                    list(j) = "0"

                End If

            Next

        Next

        For i As Integer = 0 To item_level.Count - 1
            If Not (list(i).Equals("0")) Then
                combobox.Rows.Add(list(i))
            End If

        Next
    End Sub

    Private Sub dropdown_add()

        database.Add_Parking_Level_Combobox(item_level)
        database.Add_Parking_Price_Combobox(item_price)

        List_to_Combobox(combobox_fee.table, item_price)
        List_to_Combobox(combobox_level.table, item_level)



    End Sub

    Private Sub Exit_Button_Click_1(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()

    End Sub

    Private Sub parking_level_button_Click(sender As Object, e As EventArgs) Handles parking_level_button.Click

        If (level_showing = False) Then

            parking_level.Show()

            switchPanel(combobox_level, parking_level)
            level_showing = True
        Else
            parking_level.Hide()

            level_showing = False
        End If
    End Sub
    Private Sub parking_level_button_LostFocus(sender As Object, e As EventArgs) Handles parking_level_button.LostFocus
        fee_showing = False
        level_showing = False
        parking_level.Hide()

    End Sub
    Private Sub parking_fee_button_Click(sender As Object, e As EventArgs) Handles parking_fee_button.Click

        If (fee_showing = False) Then
            parking_fee.Show()
            switchPanel(combobox_fee, parking_fee)
            fee_showing = True
        Else
            fee_showing = False
            parking_fee.Hide()
        End If
    End Sub
    Private Sub parking_fee_button_LostFocus(sender As Object, e As EventArgs) Handles parking_fee_button.LostFocus
        fee_showing = False
        level_showing = False
        parking_fee.Hide()

    End Sub
    Private Sub Parking_Add_Load(sender As Object, e As EventArgs) Handles Me.Load
        combobox_fee.form = Me
        combobox_level.form = Me
        combobox_fee.button_flat = parking_fee_button
        combobox_level.button_flat = parking_level_button
        combobox_level.my_panel = parking_level
        combobox_fee.my_panel = parking_fee
        combobox_fee.showing = fee_showing
        combobox_level.showing = level_showing

        dropdown_add()
    End Sub

    Private Sub Register_Button_MouseClick(sender As Object, e As MouseEventArgs) Handles Register_Button.MouseClick
        Try

            If (button_fee.Text = "Parking Fee") Then
                Throw New Exception
            Else
                Try

                    If (button_level.Text = "Parking Level") Then
                        Throw New Exception
                    Else
                        '  Dim parking As Parking_Area =
                        database.Add_ParkingArea(New Parking_Area("12312", Parking_name.Text, button_level.Text, button_fee.Text, "Available"))
                    End If
                Catch ex As Exception
                    MessageBox.Show("Invalid Value")
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Value")
        End Try

    End Sub
End Class