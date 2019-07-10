Public Class User_List

    Private Sub User_List_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim database As Server = New Server
        database.User_Table(User_table)
    End Sub

    Private Sub Userlog_Button_Click(sender As Object, e As EventArgs) Handles Userlog_Button.Click
        CreateModal(User_Log)
    End Sub

    Public Sub CreateModal(ByVal form As Form)
        form.ShowDialog()
    End Sub

    Private Sub Add_User_Click(sender As Object, e As EventArgs) Handles Add_User.Click
        CreateModal(User_Register)
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
End Class