﻿Imports Bunifu.Framework.UI

Public Class Membership_List
    Private username As String
    Private ReadOnly database As Server = New Server
    Private index As Integer
    ReadOnly promo_object As Promo = New Promo("", "", "", "", "", "", "")

    'For updating the Profit
    Private profit_table As BunifuCustomDataGrid
    Private total_label As Label

    Public Property Username1 As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
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

    Public Property Total_label1 As Label
        Get
            Return total_label
        End Get
        Set(value As Label)
            total_label = value
        End Set
    End Property

    Private Sub Generate_guest_Click(sender As Object, e As EventArgs) Handles generate_guest.Click
        Generate_guest_function()
    End Sub

    Private Sub Generate_guest_function()
        Using input As InputBox = New InputBox
            input.User_assisgn1 = username
            input.Generate_guest1 = True
            input.Table = Member_table
            input.ShowDialog()
        End Using
    End Sub


    Private Sub Membership_List_Load(sender As Object, e As EventArgs) Handles Me.Load
        database.MembershipTable("", Member_table)
        Member_table.ContextMenuStrip = MemberTable_Menu
        MemberTable_Menu.Visible = True
    End Sub

    '------------------------------- For Register Function -----------------------------
    Private Sub Register_Click(sender As Object, e As EventArgs) Handles register.Click
        Register_Function()
    End Sub

    Private Sub Register_Function()
        Using Register_Form As Member_Register = New Member_Register
            Register_Form.User1 = username
            Register_Form.Table1 = Member_table
            Register_Form.Total_label1 = total_label
            Register_Form.Profit_table1 = Profit_table1
            Register_Form.ShowDialog()
        End Using
    End Sub
    '------ ------------------------- End of Register Function -----------------------------

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Using Register_Form As Member_Register = New Member_Register
            Register_Form.User1 = username
            Register_Form.Table1 = Member_table
            Register_Form.ShowDialog()
        End Using
    End Sub

    '------ -------------------------For Table Function -----------------------------

    Private Sub Member_table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Member_table.CellMouseClick
        index = e.RowIndex
    End Sub

    Private Sub Member_table_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Member_table.CellMouseDoubleClick
        Dim result As DialogResult = MessageBox.Show("Do you want to update this member ",
                                      "Update Confirmation",
                                      MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Check_Update()
        End If
    End Sub
    '------ -------------------------For Table Function -----------------------------


    Private Sub Update_member()

        Using member As Member_Register = New Member_Register
            Dim Update_member As Membership = New Membership("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")

            Dim selectedRow As DataGridViewRow
            selectedRow = Member_table.Rows(index)

            Try

                If (selectedRow.Cells(1).Value.ToString.Equals("GUEST")) Then
                    MessageBox.Show("GUEST CARD CANNOT BE UPDATED")
                Else

                    database.Member_query(selectedRow.Cells(0).Value.ToString, Update_member)
                    member.User1 = username
                    member.Update_member1 = Update_member
                    member.Update1 = True
                    member.Table1 = Member_table
                    member.Profit_table1 = profit_table
                    member.Total_label1 = total_label
                    member.ShowDialog()


                End If
            Catch ex As Exception
                MessageBox.Show("No Member Found")
            End Try
        End Using

    End Sub

    Private Sub Check_Update()
        Try
            Update_member()
        Catch ex As Exception
            MessageBox.Show("Please select a member first")
        End Try
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------;
    'Context menu
    Private Sub Generateguest_ContextMenu_Click(sender As Object, e As EventArgs) Handles Generateguest_ContextMenu.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to generate guest card ",
                                      "Confirmation",
                                      MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Generate_guest_function()
        End If
    End Sub

    Private Sub Refresh_ContextMenu_Click(sender As Object, e As EventArgs) Handles Refresh_ContextMenu.Click
        database.MembershipTable(Search.Text, Member_table)
    End Sub

    Private Sub DeleteContextMenu_Click(sender As Object, e As EventArgs) Handles DeleteContextMenu.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to delete this member?",
                                     "Delete Confirmation",
                                     MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Dim selectedRow As DataGridViewRow
            selectedRow = Member_table.Rows(index)

            database.Update_Member_Status(selectedRow.Cells(0).Value.ToString, "DISABLED")
            database.MembershipTable(Search.Text, Member_table)
        End If
    End Sub

    Private Sub Update_ContextMenu_Click(sender As Object, e As EventArgs) Handles Update_ContextMenu.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to update this member ",
                                      "Update Confirmation",
                                      MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Check_Update()
        End If
    End Sub

    Private Sub Register_ContextMenu_Click(sender As Object, e As EventArgs) Handles Register_ContextMenu.Click
        Register_Function()
    End Sub

    Private Sub Search_OnValueChanged_1(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        database.MembershipTable(Search.Text, Member_table)
    End Sub

    Private Sub Generate_picture_Click(sender As Object, e As EventArgs) Handles generate_picture.Click
        Generate_guest_function()
    End Sub


    '------------------------------------------------------------------------------------------------------------------------------------;
    'End of Context menu
End Class