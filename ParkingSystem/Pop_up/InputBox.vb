Imports ParkingSystem
Imports Bunifu.Framework.UI
Public Class InputBox

    Private My_table As BunifuCustomDataGrid

    Private ReadOnly Database As Server = New Server

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



    Public Property Table As BunifuCustomDataGrid
        Get
            Return My_table
        End Get

        Set(ByVal this_table As BunifuCustomDataGrid)
            My_table = this_table
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

        Try
            Dim text_value As Integer = CInt(value_text.Text)

            If (text_value < 0) Then

                Throw New Exception

            Else

                If (Top_Up = True) Then
                    Try

                        Dim total As Integer = CInt(value) + text_value

                        If (CInt(total) < 0) Then

                            Throw New Exception

                        Else

                            Database.Update_Amount(value_text, member, Update_TextBox, Points, total_spend)

                        End If

                    Catch ex As Exception

                        MessageBox.Show("Top up Failed")

                    End Try

                ElseIf (Register1 = True) Then

                    Update_TextBox.Text = text_value
                    MessageBox.Show("Value added succesful")

                ElseIf (Generate_guest1 = True) Then
                    Database.Membership_Register(New Membership(value_text.Text, "GUEST", "GUEST", "GUEST",
                                                   "GUEST", "GUEST", Date.Now.ToString("MM/dd/yyyy"), "0",
                                                    "0", "0", "", "", user_assisgn, Date.Now.ToString("MM/dd/yyyy"), "0", "Not Activate", "GUEST",
                                                    "GUEST", "GUEST", "", "INACTIVE"))
                    Database.MembershipTable("", Table)

                ElseIf (Parking_add1 = True) Then

                    drop_down.AddItem(text_value)
                    drop_down.selectedIndex = drop_down.Items.Count - 1
                    drop_down.selectedIndex += 1

                End If

                Me.Close()

            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Value")
        End Try
    End Sub

End Class