Imports Bunifu.Framework.UI

Public Class Park_List
    ReadOnly Update_member As Membership = New Membership("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
    ReadOnly database As Server = New Server
    Dim Index As Integer


    'When Parking Click
    Private Sub Register_ParkingArea()
        Using form As Parking_Add = New Parking_Add()
            form.My_Table = Parking_Area_Table
            form.ShowDialog()
        End Using
    End Sub
    Private Sub Add_Parking_Click(sender As Object, e As EventArgs) Handles Add_Parking_Button.MouseClick
        Register_ParkingArea()
    End Sub

    'When the Focus is lose to the button the panel will close

    Private Sub Set_Parkingtable()

        database.Parking_Table(Search.Text, Parking_Area_Table)

    End Sub

    'Simpy set the nod
    Private Sub Parking_List_Load(sender As Object, e As EventArgs) Handles Me.Load

        Set_Parkingtable()
        Parking_Area_Table.ContextMenuStrip = Parking_TableContextMenu

    End Sub

    Private Sub Goto_parking_area()
        Using parking_add_ As Parking_Add = New Parking_Add
            parking_add_.My_Table = Parking_Area_Table
            parking_add_.ShowDialog()
        End Using

    End Sub

    Private Sub Add_Parking_Button_Click(sender As Object, e As EventArgs) Handles Add_Parking_Button.Click
        Goto_parking_area()
    End Sub

    Private Sub Add_Parking_Logo_Click(sender As Object, e As EventArgs) Handles Add_Parking_Logo.Click
        Goto_parking_area()
    End Sub

    Private Sub Search_OnValueChanged(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        Set_Parkingtable()
    End Sub

    Private Sub Parking_Area_Table_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Parking_Area_Table.CellMouseDoubleClick
        ' MessageBox.Show("Im clicked")
        Check_Update()
    End Sub
    Private Sub Parking_Area_Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Parking_Area_Table.CellMouseClick
        Index = e.RowIndex
    End Sub

    Private Sub Update_Area()

        Using parking_add As Parking_Add = New Parking_Add
            Dim parking_area As Parking_Area = New Parking_Area(0, "", "", "", "")
            Dim selectedRow As DataGridViewRow
            Try
                selectedRow = Parking_Area_Table.Rows(Index)


                database.Parking_Query(selectedRow.Cells(0).Value.ToString, parking_area)

                parking_add.Parking_area1 = parking_area
                parking_add.Update1 = True
                parking_add.My_Table = Parking_Area_Table
                parking_add.ShowDialog()

            Catch ex As Exception
                MessageBox.Show("No Area found")
            End Try
        End Using
    End Sub

    Private Sub Check_Update()

        Update_Area()

    End Sub

    '******************************************* CONTEXT MENU FUNCTION ******************************************************
    Private Sub Register_ContextMenu_Click(sender As Object, e As EventArgs) Handles Register_ContextMenu.Click
        Register_ParkingArea()
    End Sub

    Private Sub Update_ContextMenu_Click(sender As Object, e As EventArgs) Handles Update_ContextMenu.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to Update this location?",
                                      "Update Confirmation",
                                      MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Update_Area()
        End If

    End Sub

    Private Sub DeleteContextMenu_Click(sender As Object, e As EventArgs) Handles DeleteContextMenu.Click

        Dim result As DialogResult = MessageBox.Show("Do you want to delete this item",
                                      "Delete Confirmation",
                                      MessageBoxButtons.YesNo)

        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = Parking_Area_Table.Rows(Index)

            If (result = DialogResult.Yes) Then

                database.Update_location(selectedRow.Cells(1).Value.ToString, "DISABLED")
                Set_Parkingtable()

            End If

        Catch ex As Exception

            MessageBox.Show("No Area found")
        End Try

    End Sub

    Private Sub Refresh_ContextMenu_Click(sender As Object, e As EventArgs) Handles Refresh_ContextMenu.Click
        Set_Parkingtable()
    End Sub

    Private Sub Viewmember_ContextMenu_Click(sender As Object, e As EventArgs) Handles Viewmember_ContextMenu.Click
        Try
            Dim selectedRow As DataGridViewRow

            selectedRow = Parking_Area_Table.Rows(Index)

            If Not (selectedRow.Cells(4).Value.ToString.Equals("Available") Or selectedRow.Cells(4).Value.ToString.Equals("DISABLED")) Then
                database.Member_query(selectedRow.Cells(4).Value.ToString, Update_member)
                Using member_register As Member_Register = New Member_Register
                    member_register.Update_member1 = Update_member
                    member_register.Update1 = True
                    member_register.Park_list1 = True
                    member_register.ShowDialog()
                   End Using
                    Else
                MessageBox.Show("No Member to show")
            End If
        Catch ex As Exception
            MessageBox.Show("Member not Found")
        End Try
    End Sub

    Private Sub Add_Parking_Click(sender As Object, e As MouseEventArgs) Handles Add_Parking_Button.MouseClick

    End Sub

    '******************************************* END CONTEXT MENU FUNCTION ******************************************************
End Class