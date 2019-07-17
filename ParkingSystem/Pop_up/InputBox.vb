Imports ParkingSystem

Public Class InputBox

    Private My_table As Bunifu.Framework.UI.BunifuCustomDataGrid
    Private button As Bunifu.Framework.UI.BunifuFlatButton
    Private Database As Server = New Server

    'For Top up'
    Private Top_Up As Boolean
    Private member As Membership
    Private value As String
    Private Update_TextBox As TextBox
    Private Points As Label
    Private total_spend As Label
    Private total_login As Label
    'End of Top up'

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

    Public Property Top_Up1 As Boolean
        Get
            Return Top_Up
        End Get
        Set(value As Boolean)
            Top_Up = value
        End Set
    End Property

    Public Property Member1 As Membership
        Get
            Return member
        End Get
        Set(value As Membership)
            member = value
        End Set
    End Property

    Public Property Value1 As String
        Get
            Return value
        End Get
        Set(value As String)
            Me.value = value
        End Set
    End Property

    Public Property Update_TextBox1 As TextBox
        Get
            Return Update_TextBox
        End Get
        Set(value As TextBox)
            Update_TextBox = value
        End Set
    End Property

    Public Property Total_spend1 As Label
        Get
            Return total_spend
        End Get
        Set(value As Label)
            total_spend = value
        End Set
    End Property

    Public Property Points1 As Label
        Get
            Return Points
        End Get
        Set(value As Label)
            Points = value
        End Set
    End Property

    Public Property Total_login1 As Label
        Get
            Return total_login
        End Get
        Set(value As Label)
            total_login = value
        End Set
    End Property

    Private Sub Cancel_button_Click(sender As Object, e As EventArgs) Handles Cancel_button.Click
        Me.Close()
    End Sub

    Private Sub Ok_button_Click(sender As Object, e As EventArgs) Handles Ok_button.Click
        If (Top_Up = True) Then

            Database.Update_Amount(value_text, member, Update_TextBox, Points, total_spend)
            Me.Close()

        Else
            table.Rows.Add(value_text.Text)
            button.Text = value_text.Text
            MessageBox.Show(value_text.Text + " has Added")
        End If
    End Sub
End Class