Imports ParkingSystem
Imports Bunifu.Framework.UI
Public Class InputBox

    Private My_table As Bunifu.Framework.UI.BunifuCustomDataGrid
    Private button As Bunifu.Framework.UI.BunifuFlatButton
    Private Database As Server = New Server

    'For Top up'
    Private Top_Up As Boolean = False
    Private member As Membership
    Private value As String
    Private Update_TextBox As TextBox
    Private Points As Label
    Private total_spend As Label
    Private total_login As Label
    Private register As Boolean = False
    'End of Top up'

    'For generate Guesst
    Private generate_guest As Boolean = False
    Private user_assisgn As String = ""
    'End of generate guest


    'For Parking area add
    Private parking_add As Boolean = False
    Private drop_down As BunifuDropdown
    'For Parking area add

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

    Public Property Register1 As Boolean
        Get
            Return register
        End Get
        Set(value As Boolean)
            register = value
        End Set
    End Property

    Public Property User_assisgn1 As String
        Get
            Return user_assisgn
        End Get
        Set(value As String)
            user_assisgn = value
        End Set
    End Property

    Public Property Generate_guest1 As Boolean
        Get
            Return generate_guest
        End Get
        Set(value As Boolean)
            generate_guest = value
        End Set
    End Property



    Public Property Parking_add1 As Boolean
        Get
            Return parking_add
        End Get
        Set(value As Boolean)
            parking_add = value
        End Set
    End Property

    Public Property Drop_down1 As BunifuDropdown
        Get
            Return drop_down
        End Get
        Set(value As BunifuDropdown)
            drop_down = value
        End Set
    End Property

    Private Sub Cancel_button_Click(sender As Object, e As EventArgs) Handles Cancel_button.Click
        If (parking_add = True) Then
            drop_down.selectedIndex = 0
            drop_down.Select()

        End If
        Me.Close()
    End Sub

    Private Sub Ok_button_Click(sender As Object, e As EventArgs) Handles Ok_button.Click
        If (Top_Up = True) Then
            Try
                Dim total As Integer = CInt(value) + CInt(value_text.Text)
                If (CInt(total) < 0) Then

                    Throw New Exception
                Else
                    Database.Update_Amount(value_text, member, Update_TextBox, Points, total_spend)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        ElseIf (Register1 = True) Then
            Try
                If (CInt(value_text.Text) < 0) Then
                    Throw New Exception
                Else
                    Update_TextBox.Text = value_text.Text
                    MessageBox.Show("Value added succesful")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        ElseIf (Generate_guest1 = True) Then
            Database.Membership_Register(New Membership(value_text.Text, "GUEST", "GUEST", "GUEST",
                                                   "GUEST", "GUEST", Date.Now.ToString("MM/dd/yyyy"), "0",
                                                    "0", "0", "", "", user_assisgn, Date.Now.ToString("MM/dd/yyyy"), "0", "Not Activate", "GUEST",
                                                    "GUEST", "GUEST", "", "INACTIVE"))
            Database.MembershipTable("", table)

        ElseIf (Parking_add1 = True) Then
            drop_down.AddItem(value_text.Text)


        Else
            table.Rows.Add(value_text.Text)
            button.Text = value_text.Text
            MessageBox.Show(value_text.Text + " has Added")
            Me.Close()
        End If

        Me.Close()

    End Sub
End Class