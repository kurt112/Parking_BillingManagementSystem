Public Class InputBox

    Private My_table As Bunifu.Framework.UI.BunifuCustomDataGrid
    Private button As Bunifu.Framework.UI.BunifuFlatButton
    Public Property table As Bunifu.Framework.UI.BunifuCustomDataGrid
        Get
            Return My_table
        End Get

        Set(ByVal this_table As Bunifu.Framework.UI.BunifuCustomDataGrid)
            My_table = this_table
        End Set
    End Property

    Public Property my_button As Bunifu.Framework.UI.BunifuFlatButton
        Get
            Return button
        End Get
        Set(this_button As Bunifu.Framework.UI.BunifuFlatButton)
            button = this_button
        End Set
    End Property


    Private Sub Cancel_button_Click(sender As Object, e As EventArgs) Handles Cancel_button.Click
        Me.Close()
    End Sub

    Private Sub Ok_button_Click(sender As Object, e As EventArgs) Handles Ok_button.Click
        table.Rows.Add(value_text.Text)
        button.Text = value_text.Text
        MessageBox.Show(value_text.Text + " has Added")
        Me.Close
    End Sub
End Class