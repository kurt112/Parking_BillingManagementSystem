Imports Bunifu.Framework.UI

Public Class Transaction_List
    Private Property username As String

    Private database As Server = New Server

    Dim Member_table As BunifuCustomDataGrid
    Dim location_table As BunifuCustomDataGrid

    Public Property Username1 As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property Member_table1 As BunifuCustomDataGrid
        Get
            Return Member_table
        End Get
        Set(value As BunifuCustomDataGrid)
            Member_table = value
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
        Dim transaction As Transaction_Input = New Transaction_Input
        transaction.Username1 = username
        transaction.Member_table1 = Member_table
        transaction.Location_table1 = location_table
        transaction.Transaction_table1 = Transaction_Table
        transaction.ShowDialog()
    End Sub

    Private Sub Goto_Transaction_logs()
        Dim transaction_history = New Transaction_Histroy_List
        transaction_history.ShowDialog()
    End Sub

    Private Sub Search_OnValueChanged(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        database.Load_Historyparking(Search.Text, Transaction_Table)
    End Sub

    '--------------------------------- Context Menu -----------------------------------------------------------'
    Private Sub Viewuser_ContextMenu_Click(sender As Object, e As EventArgs) Handles Viewuser_ContextMenu.Click

    End Sub

    Private Sub ViewPromo_ContextMenu_Click(sender As Object, e As EventArgs) Handles ViewPromo_ContextMenu.Click

    End Sub

    Private Sub Viewlocation_contextMenu_Click(sender As Object, e As EventArgs) Handles viewlocation_contextMenu.Click

    End Sub

    Private Sub Viewmember_ContextMenu_Click(sender As Object, e As EventArgs) Handles Viewmember_ContextMenu.Click

    End Sub

    Private Sub Transaction_ContextMenu_Click(sender As Object, e As EventArgs) Handles Transaction_ContextMenu.Click
        Goto_Transactioninput()
    End Sub

    Private Sub Contextmenu_refresh_Click(sender As Object, e As EventArgs) Handles contextmenu_refresh.Click
        database.Load_Historyparking(Search.Text, Transaction_Table)
    End Sub

    '--------------------------------- End Context Menu -----------------------------------------------------------'
End Class