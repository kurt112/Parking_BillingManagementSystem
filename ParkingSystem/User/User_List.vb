Public Class User_List
    Private ReadOnly database As Server = New Server
    Dim index As Integer
    Private ReadOnly user As User = New User("", "", "", "", "", "")
    Private Sub User_List_Load(sender As Object, e As EventArgs) Handles Me.Load
        User_table.ContextMenuStrip = User_ContextMenu
        database.User_Table(User_table, Search.Text)
    End Sub

    Private Sub Update_function()
        Dim selectedRow As DataGridViewRow
        selectedRow = User_table.Rows(index)
        database.User_Query(selectedRow.Cells(0).Value.ToString, user)
        Using Register_User As User_Register = New User_Register
            Register_User.User1 = user
            Register_User.Table1 = Me.User_table
            Register_User.Update1 = True
            Register_User.ShowDialog()
        End Using
    End Sub

    Public Sub CreateModal(ByVal form As Form)
        form.ShowDialog()
    End Sub

    Private Sub Add_User_Click()
        Using Register_User As User_Register = New User_Register
            Register_User.Table1 = Me.User_table
            Register_User.Text1 = Search.Text
            Register_User.ShowDialog()
        End Using
    End Sub

    Private Sub User_table_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles User_table.CellClick
        Index = e.RowIndex

    End Sub

    Private Sub Search_OnValueChanged(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        database.User_Table(User_table, Search.Text)
    End Sub

    Private Sub User_logs_Button_Click(sender As Object, e As EventArgs) Handles User_logs_Button.Click
        CreateModal(User_Log)
    End Sub

    Private Sub User_log_logo_Click(sender As Object, e As EventArgs) Handles User_log_logo.Click
        CreateModal(User_Log)
    End Sub

    Private Sub Add_User_Click_1(sender As Object, e As EventArgs) Handles Add_User.Click
        Add_User_Click()
    End Sub

    Private Sub Add_User_logo_Click(sender As Object, e As EventArgs) Handles Add_User_logo.Click
        Add_User_Click()
    End Sub

    Private Sub User_table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles User_table.CellDoubleClick
        Update_function()
    End Sub


    '********************************************** Context Menu *****************************************************
    Private Sub Register_ContextMenu_Click(sender As Object, e As EventArgs) Handles Register_ContextMenu.Click
        Add_User_Click()
    End Sub

    Private Sub Update_ContextMenu_Click(sender As Object, e As EventArgs) Handles Update_ContextMenu.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to Update this User",
                                      "Update Confirmation",
                                      MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Update_function()
        End If
    End Sub

    Private Sub DeleteContextMenu_Click(sender As Object, e As EventArgs) Handles DeleteContextMenu.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to Delete this User",
                                      "Delete Confirmation",
                                      MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Dim selectedRow As DataGridViewRow
            selectedRow = User_table.Rows(index)
            database.Delete_user(selectedRow.Cells(0).Value.ToString)
            database.User_Table(User_table, Search.Text)
        End If
    End Sub

    Private Sub Refresh_ContextMenu_Click(sender As Object, e As EventArgs) Handles Refresh_ContextMenu.Click
        database.User_Table(User_table, Search.Text)
    End Sub

    Private Sub Userlogs_ContextMenu_Click(sender As Object, e As EventArgs) Handles Userlogs_ContextMenu.Click
        CreateModal(User_Log)
    End Sub


    '********************************************** End Context Menu *****************************************************
End Class