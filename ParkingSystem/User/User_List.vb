Public Class User_List
    Dim database As Server = New Server
    Private Sub User_List_Load(sender As Object, e As EventArgs) Handles Me.Load

        database.User_Table(User_table, Search.Text)
    End Sub



    Public Sub CreateModal(ByVal form As Form)
        form.ShowDialog()
    End Sub

    Private Sub Add_User_Click()
        Dim Register_User As User_Register = New User_Register
        Register_User.Table1 = Me.User_table
        Register_User.Text1 = Search.Text
        Register_User.ShowDialog()
    End Sub

    Private Sub User_table_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles User_table.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = User_table.Rows(index)
        MessageBox.Show(selectedRow.Cells(0).Value.ToString)
        MessageBox.Show(selectedRow.Cells(1).Value.ToString)
        MessageBox.Show(selectedRow.Cells(2).Value.ToString)
        MessageBox.Show(selectedRow.Cells(3).Value.ToString)
        MessageBox.Show(selectedRow.Cells(4).Value.ToString)
        MessageBox.Show(selectedRow.Cells(5).Value.ToString)
        MessageBox.Show(selectedRow.Cells(6).Value.ToString)
        MessageBox.Show(selectedRow.Cells(7).Value.ToString)

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

End Class