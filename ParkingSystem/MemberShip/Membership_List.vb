Imports Bunifu.Framework.UI

Public Class Membership_List
    Private username As String
    Private database As Server = New Server
    Private index As Integer

    Dim Member_table_ As BunifuCustomDataGrid = Member_table

    Public Property Username1 As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Private Sub Generate_guest_Click(sender As Object, e As EventArgs) Handles generate_guest.Click
        generate_guest_function()
    End Sub

    Private Sub generate_guest_function()
        Dim input As InputBox = New InputBox
        input.User_assisgn1 = username
        input.Generate_guest1 = True
        input.table = Member_table
        input.ShowDialog()
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
        Dim Register_Form As Member_Register = New Member_Register
        Register_Form.User1 = username
        Register_Form.Table1 = Member_table
        Register_Form.Update1 = False
        Register_Form.ShowDialog()
    End Sub
    '------ ------------------------- End of Register Function -----------------------------

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim Register_Form As Member_Register = New Member_Register
        Register_Form.User1 = username
        Register_Form.Table1 = Member_table
        Register_Form.ShowDialog()
    End Sub


    '------ -------------------------For Table Function -----------------------------

    Private Sub Member_table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Member_table.CellMouseClick
        index = e.RowIndex
    End Sub

    Private Sub Member_table_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Member_table.CellMouseDoubleClick
        Check_Update()
    End Sub
    '------ -------------------------For Table Function -----------------------------


    Private Sub Update_member()
        Dim member As Member_Register = New Member_Register
        Dim Update_member As Membership = New Membership("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")


        Dim selectedRow As DataGridViewRow
        selectedRow = Member_table.Rows(index)


        If (selectedRow.Cells(1).Value.ToString.Equals("GUEST")) Then
            MessageBox.Show("GUEST CARD CANNOT BE UPDATED")
        Else

            database.Member_query(selectedRow.Cells(0).Value.ToString, Update_member)
            member.Update_member1 = Update_member
            member.Update1 = True
            member.Table1 = Member_table
            member.ShowDialog()
        End If
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
        generate_guest_function()
    End Sub

    Private Sub Refresh_ContextMenu_Click(sender As Object, e As EventArgs) Handles Refresh_ContextMenu.Click
        database.MembershipTable(Search.Text, Member_table)
    End Sub

    Private Sub DeleteContextMenu_Click(sender As Object, e As EventArgs) Handles DeleteContextMenu.Click

    End Sub

    Private Sub Update_ContextMenu_Click(sender As Object, e As EventArgs) Handles Update_ContextMenu.Click
        Check_Update()
    End Sub

    Private Sub Register_ContextMenu_Click(sender As Object, e As EventArgs) Handles Register_ContextMenu.Click
        Register_Function()
    End Sub

    Private Sub Search_OnValueChanged_1(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        database.MembershipTable(Search.Text, Member_table)
    End Sub
    '------------------------------------------------------------------------------------------------------------------------------------;
    'End of Context menu
End Class