Imports Bunifu.Framework.UI
Public Class Transaction_Histroy_List
    Private Property Username As String

    Private ReadOnly database As Server = New Server
    Dim location_table As BunifuCustomDataGrid
    ReadOnly User_ As User = New User("", "", "", "", "", "", "")
    ReadOnly Member As Membership = New Membership("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
    Shadows ReadOnly Location As Parking_Area = New Parking_Area("", "", "", "", "")
    Dim index As Integer = 0
    Dim Date_word As String = " PARKING_HISTORY.DATE = "

    Public Property Username1 As String
        Get
            Return Username
        End Get
        Set(value As String)
            Username = value
        End Set
    End Property

    Public Property Member_table1 As BunifuCustomDataGrid

    Public Property Location_table1 As BunifuCustomDataGrid
        Get
            Return location_table
        End Get
        Set(value As BunifuCustomDataGrid)
            location_table = value
        End Set
    End Property

    Private Sub Transaction_List_Load(sender As Object, e As EventArgs) Handles Me.Load

        start_date.Value = Date.Today()
        date_end.Value = Date.Today()

        database.Load_Historyparking("", Transaction_Table, True, Date_word)

        Transaction_Table.ContextMenuStrip = ContextMenuStrip1

    End Sub

    Private Sub Goto_Transactioninput()
        Using transaction As Transaction_Input = New Transaction_Input
            transaction.Username1 = Username
            transaction.Member_table1 = Member_table1
            transaction.Location_table1 = location_table
            transaction.Transaction_table1 = Transaction_Table
            transaction.ShowDialog()
        End Using
    End Sub

    Private Sub Search_OnValueChanged(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        database.Load_Historyparking(Search.Text, Transaction_Table, True, Date_word)
    End Sub

    Private Sub Transaction_Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        index = e.RowIndex
    End Sub

    Private Sub Transaction_Table_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)


    End Sub

    '*****************************************  Context Menu *************************************************************'
    Private Sub Viewuser_ContextMenu_Click(sender As Object, e As EventArgs) Handles Viewuser_ContextMenu.Click
        Using register As User_Register = New User_Register
            Try
                Dim selectedRow As DataGridViewRow
                selectedRow = Transaction_Table.Rows(index)
                database.User_Query_Name(selectedRow.Cells(8).Value.ToString, User_)
                register.User1 = User_
                register.Update1 = True
                register.Look1 = True
                register.ShowDialog()

            Catch ex As Exception
                MessageBox.Show("No Element Found")
            End Try
        End Using
    End Sub
    Private Sub Viewlocation_contextMenu_Click(sender As Object, e As EventArgs) Handles viewlocation_contextMenu.Click
        Using location_form As Parking_Add = New Parking_Add
            Try
                Dim selectedRow As DataGridViewRow
                selectedRow = Transaction_Table.Rows(index)
                database.Parking_Query_Name(selectedRow.Cells(5).Value.ToString, Location)
                location_form.Parking_area1 = Location
                location_form.Update1 = True
                location_form.Look1 = True
                location_form.ShowDialog()

            Catch ex As Exception
                MessageBox.Show("No Element Found")
            End Try
        End Using
    End Sub

    Private Sub Viewmember_ContextMenu_Click(sender As Object, e As EventArgs) Handles Viewmember_ContextMenu.Click
        Using member_form As Member_Register = New Member_Register
            Try
                Dim selectedRow As DataGridViewRow
                selectedRow = Transaction_Table.Rows(index)
                database.Member_query(selectedRow.Cells(1).Value.ToString, Member)
                member_form.Update_member1 = Member
                member_form.Update1 = True
                member_form.Park_list1 = True
                member_form.ShowDialog()

            Catch ex As Exception
                MessageBox.Show("No Element Found")
            End Try
        End Using
    End Sub

    Private Sub Transaction_ContextMenu_Click(sender As Object, e As EventArgs) Handles Transaction_ContextMenu.Click
        Goto_Transactioninput()
    End Sub

    Private Sub Contextmenu_refresh_Click(sender As Object, e As EventArgs) Handles contextmenu_refresh.Click
        database.Load_Historyparking(Search.Text, Transaction_Table, True, Date_word)
    End Sub
    '***************************************** End  Context Menu *************************************************************'


    '********************************************* For Date ************************************************************
    Private Sub Start_date_onValueChanged(sender As Object, e As EventArgs) Handles start_date.onValueChanged

        Date_word = " PARKING_HISTORY.DATE = "

        start_date_copy.Value = start_date.Value

        If (start_date_copy.Value < date_end.Value) Then

            While Not (start_date_copy.Value = date_end.Value.AddDays(1))

                If (start_date_copy.Value.AddDays(1) = date_end.Value.AddDays(1)) Then

                    Date_word += "'" + start_date_copy.Value.ToString("dd'/'MM'/'yyyy") + "'"

                Else

                    Date_word += "'" + start_date_copy.Value.ToString("dd'/'MM'/'yyyy") + "' OR PARKING_HISTORY.DATE = "

                End If


                start_date_copy.Value = start_date_copy.Value.AddDays(1)

            End While

            database.Load_Historyparking(Search.Text, Transaction_Table, True, Date_word)

        End If

    End Sub

    Private Sub Date_end_onValueChanged(sender As Object, e As EventArgs) Handles date_end.onValueChanged
        Date_word = " PARKING_HISTORY.DATE = "

        start_date_copy.Value = start_date.Value
        If (start_date_copy.Value < date_end.Value) Then

            While Not (start_date_copy.Value = date_end.Value.AddDays(1))

                If (start_date_copy.Value.AddDays(1) = date_end.Value.AddDays(1)) Then

                    Date_word += "'" + start_date_copy.Value.ToString("dd'/'MM'/'yyyy") + "' "

                Else

                    Date_word += "'" + start_date_copy.Value.ToString("dd'/'MM'/'yyyy") + "' OR PARKING_HISTORY.DATE = "

                End If


                start_date_copy.Value = start_date_copy.Value.AddDays(1)

            End While
            database.Load_Historyparking(Search.Text, Transaction_Table, True, Date_word)

        End If
    End Sub

    '*********************************************** End Date ************************************************************
End Class