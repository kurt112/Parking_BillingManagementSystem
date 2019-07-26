Public Class User_Log

    Dim database As Server = New Server
    Private Sub Search_OnValueChanged(sender As Object, e As EventArgs) Handles Search.OnValueChanged

        database.User_History_Table(UserLogs_Table, Search.Text)
    End Sub

    Private Sub User_Log_Load(sender As Object, e As EventArgs) Handles Me.Load
        database.User_History_Table(UserLogs_Table, Search.Text)
    End Sub

End Class