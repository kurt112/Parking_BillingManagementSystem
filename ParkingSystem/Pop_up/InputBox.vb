Imports ParkingSystem
Imports Bunifu.Framework.UI
Public Class InputBox
#Region "Variables And Object"

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
    Private user_assisgn As String
    'End of generate guest


    'For Parking area add
    Private parking_add As Boolean = False
    Private drop_down As BunifuDropdown
    'For Parking area add

    'For Autoselecting the combobox
    Dim index As Integer = 1

    'For Reloading The pro fit
    Dim profit_table As BunifuCustomDataGrid
    Dim total_label As Label
#End Region

#Region "Properties"
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

    Public Property Profit_table1 As BunifuCustomDataGrid
        Get
            Return profit_table
        End Get
        Set(value As BunifuCustomDataGrid)
            profit_table = value
        End Set
    End Property

    Public Property Total1 As Label
        Get
            Return total_label
        End Get
        Set(value As Label)
            total_label = value
        End Set
    End Property

    Public Property Total_label1 As Label
        Get
            Return total_label
        End Get
        Set(value As Label)
            total_label = value
        End Set
    End Property
#End Region

    Private Sub Cancel_button_Click(sender As Object, e As EventArgs) Handles Cancel_button.Click
        If (parking_add = True) Then
            drop_down.selectedIndex = 0
            drop_down.Select()

        End If
        Me.Close()
    End Sub

    Private Sub Ok_button_Click(sender As Object, e As EventArgs) Handles Ok_button.Click
        Try

            Dim date_today As String = Date.Today.ToString("dd'/'MM'/'yyyy")

            Dim text_value As Long = CLng(value_text.Text)

            If (text_value < 0) Then

                Throw New Exception

            Else

                If (Top_Up = True) Then
                    Try

                        Dim total As Integer = CInt(value) + text_value

                        If (CInt(total) < 0) Then

                            Throw New Exception

                        Else
                            '                 MessageBox.Show("I'm on Transaction input")
                            Database.Update_Amount(value_text, member, Update_TextBox, Points, total_spend)
                            Database.Insert_Profit(New Profit_Entities("", user_assisgn, date_today, member.First_name1, text_value))
                            Database.Profit_Table("", profit_table, total_label, " PROFIT_DATE = ")

                        End If

                    Catch ex As Exception

                        MessageBox.Show("Top up Failed")

                    End Try

                    'First registration of the Member

                ElseIf (Register1 = True) Then

                    Update_TextBox.Text = text_value + CInt(Update_TextBox.Text)
                    Database.Insert_Profit(New Profit_Entities("", user_assisgn, date_today, "First Top Up", text_value))
                    Database.Profit_Table("", profit_table, total_label, " PROFIT_DATE = ")
                ElseIf (Generate_guest1 = True) Then

                    Database.Membership_Register(New Membership(value_text.Text, "GUEST", "GUEST", "GUEST",
                                                   "GUEST", "GUEST", date_today, "0",
                                                    "0", "0", "", "", user_assisgn, date_today, "0", "Not Activate", "GUEST",
                                                    "GUEST", "GUEST", "", "INACTIVE"))

                    Database.MembershipTable("", Table)

                ElseIf (Parking_add1 = True) Then

                    drop_down.AddItem(text_value)
                    drop_down.selectedIndex = drop_down.Items.Count - 1
                    drop_down.selectedIndex += index
                    index += 1

                End If

                Me.Close()

            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Value")
        End Try
    End Sub

    Private Sub InputBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' MessageBox.Show(user_assisgn)
    End Sub
End Class