Public Class Membership_List
    Private username As String
    Private database As Server = New Server
    Public Property Username1 As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Private Sub Membership_List_Load(sender As Object, e As EventArgs) Handles Me.Load
        database.MembershipTable(Member_table)
    End Sub

    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.Click
        Dim Register_Form As Member_Register = New Member_Register
        Register_Form.User1 = username
        Register_Form.ShowDialog()
    End Sub
End Class