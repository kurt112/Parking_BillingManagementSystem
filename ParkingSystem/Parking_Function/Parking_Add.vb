Imports Bunifu.Framework.UI
Imports ParkingSystem

Public Class Parking_Add

    Private ReadOnly database As Server = New Server

    Private table As BunifuCustomDataGrid
    Private parking_area As Parking_Area = New Parking_Area(0, "", "", "", "")
    Private Shadows look As Boolean = False
    Private Shadows update As Boolean = False
    Public Property My_Table As BunifuCustomDataGrid
        Get
            Return table
        End Get
        Set(value As BunifuCustomDataGrid)
            table = value
        End Set
    End Property

    Public Property Parking_area1 As Parking_Area
        Get
            Return parking_area
        End Get
        Set(value As Parking_Area)
            parking_area = value
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

    Public Property Look1 As Boolean
        Get
            Return look
        End Get
        Set(value As Boolean)
            look = value
        End Set
    End Property

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub


    Private Sub Dropdown_add()

        database.Add_Parking_Level_Combobox(Parking_Level)
        database.Add_Parking_Price_Combobox(Parking_fee)


    End Sub

    Private Sub Exit_Button_Click_1(sender As Object, e As EventArgs) Handles Exit_Button.MouseClick
        Me.Close()

    End Sub

    Private Sub Parking_Add_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dropdown_add()
        If (Update1 = True) Then

            If (Look1 = True) Then
                Register_Button.Text = "OK"
            Else
                Register_Button.Text = "Update"
            End If

            'MessageBox.Show(Parking_fee.Items.Count.ToString)

            Parking_name.Text = parking_area.Parking_name1
            Dim quit As Boolean = False
            Dim index As Integer = 0
            While (quit = False)
                Parking_Level.selectedIndex = index
                If (Parking_Level.selectedValue.Equals(parking_area.Parking_level1)) Then
                    quit = True
                Else
                    index += 1
                End If
            End While

            Dim quit1 As Boolean = False
            Dim index1 As Integer = 0
            While (quit1 = False)
                Parking_fee.selectedIndex = index1
                If (Parking_fee.selectedValue.Equals(parking_area.Parking_Rate1)) Then
                    quit1 = True
                Else
                    index1 += 1

                End If
            End While


        End If
    End Sub

    Private Sub Register_Button_MouseClick(sender As Object, e As MouseEventArgs) Handles Register_Button.MouseClick

        If (Update1 = False) Then

            If (Validate() = True) Then
                database.Add_ParkingArea(New Parking_Area("12312", Parking_name.Text, Parking_Level.selectedValue, Parking_fee.selectedValue, "Available"))
                MessageBox.Show("Add Parking Successful")
                database.Parking_Table("", table)
            End If

        Else

            If (Look1 = True) Then
                Me.Close()
            Else
                If (Validate() = True) Then
                    If (database.Update_Parkingarea(New Parking_Area(parking_area.Id1, Parking_name.Text, Parking_Level.selectedValue, Parking_fee.selectedValue, parking_area.Parking_Status1)) = True) Then
                        MessageBox.Show("Update Successful")
                        database.Parking_Table("", table)
                    End If
                End If

            End If
        End If

    End Sub

    Private Overloads Function Validate() As Boolean
        Try
            If (Parking_fee.selectedValue.Equals("Parking Fee") Or Parking_fee.selectedValue.Equals("Add New Item")) Then

                Throw New Exception
            Else
                Try
                    If (Parking_Level.selectedValue.Equals("Parking Level") Or Parking_Level.selectedValue.Equals("Add New Item")) Then
                        Throw New Exception
                    Else

                        Return True

                    End If
                Catch ex As Exception
                    MessageBox.Show("Invalid Value")
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Value")
        End Try
        Return False
    End Function

    Private Sub Parking_Level_onItemSelected(sender As Object, e As EventArgs) Handles Parking_Level.onItemSelected

        If (Parking_Level.selectedValue.Equals("Add New Item")) Then

            Using input As InputBox = New InputBox
                input.Parking_add1 = True
                input.Drop_down1 = Parking_Level
                input.ShowDialog()
            End Using

        End If
    End Sub
    Private Sub Parking_fee_onItemSelected(sender As Object, e As EventArgs) Handles Parking_fee.onItemSelected
        If (Parking_fee.selectedValue.Equals("Add New Item")) Then
            Using input As InputBox = New InputBox
                input.Parking_add1 = True
                input.Drop_down1 = Parking_fee
                input.ShowDialog()
            End Using
        End If
    End Sub
End Class