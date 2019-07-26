Public Class Transaction_List
    Private Property username As String
    Private database As Server = New Server

    Public Property Username1 As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Private Sub Transaction_List_Load(sender As Object, e As EventArgs) Handles Me.Load

        database.Load_Historyparking(Transaction_Table)


    End Sub



    Private Sub Transaction_Hitory_Click(sender As Object, e As EventArgs) Handles Transaction_Hitory.Click
        Dim transaction_history = New Transaction_Histroy_List
        transaction_history.ShowDialog()
    End Sub

    Private Sub Add_Transaction_Click(sender As Object, e As EventArgs) Handles Add_Transaction.Click
        Dim transaction As Transaction_Input = New Transaction_Input

        transaction.Username1 = username
        MessageBox.Show(Username1)
        transaction.ShowDialog()
    End Sub
End Class