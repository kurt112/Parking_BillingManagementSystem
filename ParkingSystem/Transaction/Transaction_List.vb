Imports Bunifu.Framework.UI

Public Class Transaction_List
    Private Property Username As String

    Private ReadOnly database As Server = New Server
    Dim location_table As BunifuCustomDataGrid
    ReadOnly User_ As User = New User("", "", "", "", "", "")
    ReadOnly Member As Membership = New Membership("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
    Shadows ReadOnly Location As Parking_Area = New Parking_Area("", "", "", "", "")
    Dim index As Integer = 0
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
        Transaction_Table.ContextMenuStrip = ContextMenuStrip1
        database.Load_Historyparking("", Transaction_Table)

    End Sub

    Private Sub Transaction_Click(sender As Object, e As EventArgs) Handles Transaction.Click
        Goto_Transactioninput()
    End Sub

    Private Sub Transaction_logs_button_Click(sender As Object, e As EventArgs) Handles Transaction_logs_button.Click
        Goto_Transaction_logs()
    End Sub

    Private Sub Logo_transactionlogs_Click(sender As Object, e As EventArgs) Handles logo_transactionlogs.Click
        Goto_Transaction_logs()
    End Sub

    Private Sub Transaction_logo_Click(sender As Object, e As EventArgs) Handles Transaction_logo.Click
        Goto_Transactioninput()
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

    Private Sub Goto_Transaction_logs()
        Using transaction_history = New Transaction_Histroy_List
            transaction_history.ShowDialog()
        End Using
    End Sub

    Private Sub Search_OnValueChanged(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        database.Load_Historyparking(Search.Text, Transaction_Table)
    End Sub

    Private Sub Transaction_Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Transaction_Table.CellMouseClick
        index = e.RowIndex
    End Sub

    Private Sub Transaction_Table_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Transaction_Table.CellMouseDoubleClick


    End Sub

    '--------------------------------- Context Menu -----------------------------------------------------------'
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
        database.Load_Historyparking(Search.Text, Transaction_Table)
    End Sub

    '--------------------------------- End Context Menu -----------------------------------------------------------'
End Class